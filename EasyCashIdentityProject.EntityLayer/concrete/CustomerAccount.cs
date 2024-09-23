using EasyCashIdentityProject.EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashProject.EntityLayer.Concrete
{
    // Musterinin hesap bilgilerini icerecek tablo
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        public string CustomerAccountNumber { get; set; } // Musteri hesap numarasi (IBAN yerine kullanilmaktadir)
        public string CustomerAccountCurrency { get; set; } // Hesabin Döviz bilgisi
        public decimal CustomerAccountBalance { get; set; } = 0; // Hesap bakiyesi
        public string? BankBranch { get; set; }  // Banka subesi

        public int AppUserId { get; set; }
        public AppUser Appuser { get; set; }
    }
}