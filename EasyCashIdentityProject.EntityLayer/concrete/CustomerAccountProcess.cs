using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashProject.EntityLayer.Concrete
{
    // Musterilerin birbirlerine yaptiklari havale eft islemlerini barindiracak olan tablo
    // (SenderID ve ReceiverID => CustomerAccount tablosundaki hesaplari icerecek. Yani yalnizca CustomerAccount tablosundaki ID'leri alabilir.)
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessID { get; set; }
        public string ProcessType { get; set; } // islem turu
        public decimal Amount { get; set; } // Miktar - Ne kadar para gonderildi?
        public DateTime ProcessDate { get; set; }
        
    }
}