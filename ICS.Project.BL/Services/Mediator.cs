﻿using System;
using System.Collections.Generic;
using System.Linq;
using ICS.Project.BL.Messages;

namespace ICS.Project.BL.Services
{
    public class Mediator : IMediator
    {
        private static Mediator _instance;

        private readonly Dictionary<Type, List<Delegate>> registeredActions = new Dictionary<Type, List<Delegate>>();

        public static Mediator Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Mediator();

                return _instance;
            }
        }

        public void Register<TMessage>(Action<TMessage> action)
            where TMessage : IMessage
        {
            var key = typeof(TMessage);
            if (!registeredActions.TryGetValue(key, out _)) registeredActions[key] = new List<Delegate>();
            registeredActions[key].Add(action);
        }

        public void UnRegister<TMessage>(Action<TMessage> action)
            where TMessage : IMessage
        {
            var key = typeof(TMessage);

            if (registeredActions.TryGetValue(typeof(TMessage), out var actions))
            {
                var actionsList = actions.ToList();
                actionsList.Remove(action);
                registeredActions[key] = new List<Delegate>(actionsList);
            }
        }

        public void Send<TMessage>(TMessage message)
            where TMessage : IMessage
        {
            if (registeredActions.TryGetValue(typeof(TMessage), out var actions))
                foreach (var action in actions.Select(action => action as Action<TMessage>)
                    .Where(action => action != null))
                    action(message);
        }
    }
}