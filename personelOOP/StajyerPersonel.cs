﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personelOOP
{
    class StajyerPersonel : Personel
    {
        private int _stajSuresi;
        public int stajSuresi
        {
            get
            {
                return _stajSuresi;
            }
            set
            {
                _stajSuresi = value;
            }
        }
    }
}
