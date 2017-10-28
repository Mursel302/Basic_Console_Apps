using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetMethod
{
    class Telebe
    {
        private string ad;
        private string soyad;
        private int yas;
        private string ixtisas;


        public string ADI
        {
            get { return ad; }
            set { ad = value; }
        }
        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public int YASI
        {
            get { return yas; }
            set {
                if (value<18)
                {
                    yas = 18;
                }
                else
                {
                    yas = value;
                }
            }
        }
        public string IXTISASI
        {
            get { return ixtisas; }
            set { ixtisas = value; }
        }
    }
}
