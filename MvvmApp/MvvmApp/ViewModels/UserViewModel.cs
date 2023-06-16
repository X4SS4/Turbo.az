using TurboAz.Models.Messages;
using TurboAz.Services.Base;
using TurboAz.Tools;
using TurboAz.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.ViewModels;

public  class UserViewModel : ViewModelBase
{
    private readonly IMessenger messenger;

    private string message;
    public string Message
    {
        get => message;
        set => base.PropertyChange(out message, value);
    }

    private MyCommand navigationCommand;
    public MyCommand NavigationCommand
    {
        get => navigationCommand ??= new MyCommand(() => this.messenger.Send(new NavigationMessage(typeof(GuestViewModel))));
        set => base.PropertyChange(out navigationCommand, value);
    }

    public UserViewModel(IMessenger messenger)
    {
        this.messenger = messenger;
    }
}
