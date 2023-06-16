namespace TurboAz.ViewModels;

using TurboAz.Models.Messages;
using TurboAz.Services.Base;
using TurboAz.Tools;
using TurboAz.ViewModels.Base;
using System.Windows.Media;

public class ModeratorViewModel : ViewModelBase {
    private readonly IMessenger messenger;

    private string message;
    public string Message {
        get => message;
        set => base.PropertyChange(out message, value);
    }

    private MyCommand navigationCommand;
    public MyCommand NavigationCommand {
        get => navigationCommand ??= new MyCommand(() => this.messenger.Send(new NavigationMessage(typeof(GuestViewModel))));
        set => base.PropertyChange(out navigationCommand, value);
    }

    public ModeratorViewModel(IMessenger messenger) {
        this.messenger = messenger;
    }
}