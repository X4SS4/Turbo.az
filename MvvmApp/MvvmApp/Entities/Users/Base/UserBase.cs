using System;
using System.Collections.Generic;
using System.ComponentModel;
using TurboAz.Entities.Announcements;
using TurboAz.Entities.Users.States;
using TurboAz.Entities.Users.States.BaseState;

namespace TurboAz.Models.Users.Base
{
    public class UserBase : INotifyPropertyChanged
    {
        public List<Announcement>? Announcements;
        public BaseUserState state;
        public string? name;
        public string? Name
        {
            get => this.name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(name));
                }
            }
        }
        public string Login {get;set;}
        public string Password { get; set; }
        public string Email { get;set;}

        public UserBase()
        {
            this.state = new UserState(this);
        }

        public void SigIn() => this.state.SigIn();

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
