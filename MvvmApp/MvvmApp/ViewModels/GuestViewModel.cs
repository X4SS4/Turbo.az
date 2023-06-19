using System;
using System.Collections.ObjectModel;
using System.Configuration;
using TurboAz.Entities.Announcements;
using TurboAz.Models.Messages;
using TurboAz.Models.Users.Base;
using TurboAz.Services.Base;
using TurboAz.Tools;
using TurboAz.ViewModels.Base;

namespace TurboAz.ViewModels;
public class GuestViewModel : ViewModelBase {

	private readonly IMessenger messenger;
	private MyCommand navigationCommand;
    private ObservableCollection<Announcement> announcementsGuests = new ObservableCollection<Announcement>();
    public ObservableCollection<Announcement> AnnouncementsGuests
    {
        get { return announcementsGuests; }
        set { PropertyChange(out announcementsGuests, value); }
    }

    public MyCommand NavigationCommand {
        get => navigationCommand ??= new MyCommand(() => this.messenger.Send(new NavigationMessage(typeof(ModeratorViewModel))));  /*switch window*/
        set => base.PropertyChange(out navigationCommand, value);
    }

    public GuestViewModel(IMessenger messenger) {
        this.messenger = messenger;
        var ann = new Announcement
        {
            ImageURL = "https://turbo.azstatic.com/uploads/full/2023%2F03%2F27%2F17%2F02%2F58%2Ffb5cafa4-c7dd-4a45-9082-e1933515020b%2F98123_vH-vdKbLeW-uyh8dfwHPvQ.jpg",
            Description = "Chevrolet Azermash CP Yeni model Cobalt LTZ 2023 Avtomobilde mövcuddur Elektrik şüşə qaldiranlar Kondisioner Usb Abs Yüngül lehimli diskler 195/65/R15 Nağd köçürmə və lizing vasitəsi ilə satış mövcuddur Lizing şərtləri İlkin ödəniş 4500 AZNQiymətə DYPİ qeydiyyatı daxil deyildir",
            Seller = new UserBase
            {
                Name = "Zabil",
                Email = "xas.zab.kam@gmail.com"
            },
            CarInformation = new CarInfo
            {
                Brand = "Maybach",
                Model = "Ulyotni",
                Condition = CARCONDITIONS.New,
                ManufactureDate = 2023,
                Color = "Pomidor",
                Engine = 1.5,
                Price = 1_000_000,
                AnnouncementDate = new System.DateTime(2023, 10, 14),
            }

        };
        announcementsGuests.Add(ann);
    }
}