using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personelOOP
{
    class SozlesmeliPersonel : Personel
    {
        private DateTime _sozlesmeTarihi;

        public DateTime sozlesmeTarihi
        {
            get
            {
                return _sozlesmeTarihi;
            }
            set
            {
                _sozlesmeTarihi = value;
            }
        }

        public new int AylikHesapla()
        {

            ucret = (30 - izin) * 150;
            return ucret;

            //return maasHesabi;
        }
    }
}
