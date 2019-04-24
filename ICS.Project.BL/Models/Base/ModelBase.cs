using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ICS.Project.BL.Models.Base
{
    public class ModelBase : IModelBase//, INotifyPropertyChanged
    {
        public Guid ID { get; set; }
//        public event PropertyChangedEventHandler PropertyChanged;
//
//        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
//        {
//            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//        }
    }
}