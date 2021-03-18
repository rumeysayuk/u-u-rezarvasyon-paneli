using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uçuş_rezarvasyon_paneli.Nesne
{
     class biletRaporNesne
    {
        private string adSoyad;
        public string AdSoyad
        {
            get
            {
                return adSoyad;
            }
            set
            {
                adSoyad = value;
            }
        }
        private string tc;
        public string Tc
        {
            get
            {
                return tc;
            }
            set
            {
                tc = value;
            }
        }
        private string phone;
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
    }
}
