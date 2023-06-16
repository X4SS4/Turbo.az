using TurboAz.Models.Messages;
using TurboAz.Services.Base;
using TurboAz.Tools;
using TurboAz.ViewModels.Base;

namespace TurboAz.ViewModels;
public class GuestViewModel : ViewModelBase {
	private readonly IMessenger messenger;
	private string text;

	public string Text { get => this.text; set => base.PropertyChange(out this.text, value); }
	
	private MyCommand navigationCommand;
    public MyCommand NavigationCommand {
        get => navigationCommand ??= new MyCommand(() => this.messenger.Send(new NavigationMessage(typeof(ModeratorViewModel))));
        set => base.PropertyChange(out navigationCommand, value);
    }

    public GuestViewModel(IMessenger messenger) {
		this.messenger = messenger;
	}
}