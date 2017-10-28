using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Emlak
    {
        private string unvan;
        private string reng;
        private int otaqsayi;
        private int mertebe;
        private double sahe;

        public string UNVANI
        {
            get { return unvan; }
            set { unvan = value.ToUpper(); }
        }
        public string RENGI
        {
            get { return reng; }
            set { reng = value.ToLower(); }
        }
        public int OTAQSAYI
        {
            get { return otaqsayi; }
            set { otaqsayi = Math.Abs(value); }
        }
        public int MERTEBESI
        {
            get { return mertebe; }
            set { mertebe = Math.Abs(value); }
        }
        public double SAHESI
        {
            get { return sahe; }
            set { sahe = Math.Abs(value); }
        }
    }
}
