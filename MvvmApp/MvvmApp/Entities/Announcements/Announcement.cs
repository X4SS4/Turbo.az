using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        public UserBase seller;
        public CarInfo carInformation = new CarInfo();
        public CarInfo CarInformation
        {
            get { return carInformation; }
            set { OnPropertyChanged() }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class CarInfo : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string brand;
        public string Brand
        {
            get { return brand; }
            set
            {
                if (brand != value)
                {
                    brand = value;
                    OnPropertyChanged(brand);
                }
            }
        }
        public string ID { get; set; }
        //public string Brand { get; set; }
        public string Model { get; set; }
        public CARCONDITIONS Condition { get; set; }
        public int ManufactureDate { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Price { get; set; }
        public DateTime AnnouncementDate { get; set; }
    }
}
