using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Yogurt : IExpired, INotifyPropertyChanged
    {
        public string Name { get; set; } = "";
        public int NetWeight { get; set; }
        public float Price{ get; set; }
        public DateTime ExpirationDate { get; set; }
        public int GetExpireDays() { return (ExpirationDate - DateTime.Today).Days; }

        public Yogurt(string name, int netWeight, float price, DateTime expirationDate)
        {
            Name = name;
            NetWeight = netWeight;
            Price = price;
            ExpirationDate = expirationDate;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
