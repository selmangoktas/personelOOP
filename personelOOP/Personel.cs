using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personelOOP
{
    public class Personel : IAylik
    {
        private string _sicilNo;
        private string _ad;
        private string _soyad;
        private int _ucret;
        private int _izin;
        private int _rapor;

        public string sicilNo
        {
            get
            {
                return _sicilNo;
            }
            set
            {
                //if (sicilNo.Length == 5)
                    _sicilNo = value;
                /*else
                    _sicilNo = "20000";*/

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

        public int rapor
        {
            get
            {
                return _rapor;
            }
            set
            {
                _rapor = value;
            }
        }
        public string AdSoyadGetir()
        {
            return $"{ad} {soyad}";
        }

        public string AylikGoruntule()
        {
            return "Alacagınız Maaş: " + ucret;
        }

        public virtual int AylikHesapla()
        {

            _ucret = (30 - izin) * 150;
            return ucret;
        }


    }
}
