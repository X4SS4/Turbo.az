using System.Windows;
using TurboAz.Services;
using TurboAz.Services.Base;
using TurboAz.ViewModels;
using TurboAz.ViewModels.Base;
using SimpleInjector;

namespace TurboAz {
    public partial class App : Application {
        public static Container ServiceContainer { get; set; } = new Container();

        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);

            ConfigureContainer();

            StartWindow<GuestViewModel>();
        }

        private void StartWindow<T>() where T : ViewModelBase {
            var startView = new MainWindow();

            var startViewModel = ServiceContainer.GetInstance<MainViewModel>();
            startViewModel.ActiveViewModel = ServiceContainer.GetInstance<T>();
            startView.DataContext = startViewModel;

            startView.ShowDialog();
        }

        private void ConfigureContainer() {
            ServiceContainer.RegisterSingleton<IMessenger, Messenger>();

            ServiceContainer.RegisterSingleton<UserViewModel>();
            ServiceContainer.RegisterSingleton<AdminViewModel>();
            ServiceContainer.RegisterSingleton<GuestViewModel>();
            ServiceContainer.RegisterSingleton<MainViewModel>();
            ServiceContainer.RegisterSingleton<ModeratorViewModel>();

            ServiceContainer.Verify();
        }
    }
}