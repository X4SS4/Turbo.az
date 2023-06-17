namespace TurboAz.ViewModels;

using TurboAz.Models.Messages;
using TurboAz.Services.Base;
using TurboAz.ViewModels.Base;
using System.Threading;
using System.Collections.ObjectModel;
using TurboAz.Entities.Announcements;

public class MainViewModel : ViewModelBase {

	private ViewModelBase activeViewModel;
	private readonly IMessenger messenger;


	public ViewModelBase ActiveViewModel {
		get { return activeViewModel; }
		set { base.PropertyChange(out this.activeViewModel, value); }
	}

	public MainViewModel(IMessenger messenger) {
		this.messenger = messenger;

		this.messenger.Subscribe<NavigationMessage>((message) => {
			if (message is NavigationMessage navigationMessage) {
				var viewModelObj = App.ServiceContainer.GetInstance(navigationMessage.DestinationViewModelType);
				if (viewModelObj is ViewModelBase viewModel) {
					this.ActiveViewModel = viewModel;
				}
			}
		});
    }
}