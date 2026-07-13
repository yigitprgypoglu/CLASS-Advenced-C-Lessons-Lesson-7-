using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3
{
    internal class Program
    {
        
        static int Main(string[] args)
        {
            Kisi birincikisi=new Kisi() 
            {
                Ad="Yigit",
                Soyad="Pirgayipoglu",
                Yas=21 
            };
            /*
             * ikincil yontem
            birincikisi.Ad = "Yigit";
            birincikisi.Soyad = "Pirgayipoglu";
            birincikisi.Yas = 21;
            */

            birincikisi.Ozellikler();
            return 0;
        }
    }
}
