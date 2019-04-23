using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ICS.Project.BL.Annotations;
using ICS.Project.BL.Models.Base;

namespace ICS.Project.BL.Models
{
    public class TeamModel : ModelBase, INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }


        public string Description { get; set; }
        


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}