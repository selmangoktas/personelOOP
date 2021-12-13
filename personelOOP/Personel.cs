using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personelOOP
{
    public class Personel
    {
        private string _sicilNo;
        private string _ad;
        private string _soyad;
        private int _ucret;
        private int _izin;

        public string sicilNo
        {
            get
            {
                return _sicilNo;
            }
            set
            {
                if (_ad.Length == 5)
                    _sicilNo = value;

            }
        }
        public string ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public string soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }


        public int ucret
        {
            get { return _ucret; }
            set { _ucret = value; }
        }

        public int izin
        {
            get { return _izin; }
            set { _izin = value; }
        }
        public string AdSoyadGetir()
        {
            return $"{ad} {soyad}";
        }

        public virtual void AylikHesapla()
        {

             _ucret = (30 - izin) * 150;
            //return maasHesabi;
        }


    }
}
