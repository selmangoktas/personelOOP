using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personelOOP
{
    public class KadroluPersonel : Personel
    {
        private string _KadroUnvani;

        public string KadroUnvani
        {
            get
            {
                return _KadroUnvani;
            }
            set
            {
                _KadroUnvani = value;

            }
        }

        public new int AylikHesapla()
        {


            if (rapor <= 5)
                return ucret;
            else
                return ucret - (ucret / 30) * rapor;


            //return maasHesabi;
        }
    }
}
