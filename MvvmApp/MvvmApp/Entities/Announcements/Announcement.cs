using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TurboAz.Models.Users.Base;

namespace TurboAz.Entities.Announcements
{
    public enum CARCONDITIONS { New = 1, Used, Crushed }
    public class Announcement : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string? Description { get; set; }

        private UserBase seller = new UserBase();
        public UserBase Seller
        {
            get { return seller; }
            set { PropertyChange(out this.seller, value); }
        }

        private CarInfo carInformation = new CarInfo();
        public CarInfo CarInformation
        {
            get { return carInformation; }
            set { PropertyChange(out carInformation, value); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void PropertyChange<T>(out T field, T value, [CallerMemberName] string propName = "")
        {
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }

    public class CarInfo {        
        public string ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public CARCONDITIONS Condition { get; set; }
        public int ManufactureDate { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Price { get; set; }
        public DateTime AnnouncementDate { get; set; }
    }
}
