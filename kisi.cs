using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3
{
    internal class Kisi
    {
        //private bu class disinda baska yerden ulasilmasini engeller
        //internal olarak işaretlenen bir öğeye sadece tanımlandığı proje (assembly) içinden erişilebilir.
        public string Ad;
        public string Soyad;
        public int Yas;

        public void Ozellikler()
        {
            Console.WriteLine("{0}\n{1}\n{2}",Ad,Soyad,Yas);
        }
    }
}
