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
            //class ayni isi yapan kod butunlerini toplamak icin kullanilir.
          
            //class okunulabilirligi arttirir ve egerki takim halinde is yapiyorsaniz ayri ayri class lara bolerek isi yapabilirsiniz.
            
            Sinif asd = new Sinif(); //nesnemizi olusturduk
            asd.x = 5;

            asd.Yazdir(asd.x.ToString());// asd.x bir int oldugu icin ve bizde yazdir fonksiyonumuzda string bi degisken kullandigimiz icin tostring kullanip gelen int degiskeni stringe dondurmek zorunda kaldik
            
            Console.ReadLine();
            return 0;
        }
        class Sinif
        {
            public int x; // x e her yerden ulasabilmek icin public verdik.

            public void Yazdir(string text)
            {
                Console.WriteLine(text);
            }

        }
    }
}
