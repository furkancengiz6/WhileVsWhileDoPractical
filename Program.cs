using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileVsWhileDoPractical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.

            ( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )

            Örnek inputlar : 10 ve -5  */

           
            int sayac = 0;

            int limitNumber;

            Console.Write("Sayi giriniz : ");
            limitNumber = Convert.ToInt32( Console.ReadLine() );
            
            do
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                sayac++;
            }
            while (sayac <= limitNumber);

            /*
            While -> Koşul sağlandığı sürece çalışır.
            Koşulun başta kontrol edilmesi gerektiği ve döngünün hiç çalışmaması durumunda çalışmayacağı durumlar için kullanılır.



            Do While -> En az bir kere çalışır, sonra koşula bakar.
            Kod bloğu en az bir kere çalıştırılacaksa ve döngünün en az bir kere çalışmasını istiyorsak kullanılır.


            */

            /*

            while (sayac <= limitNumber)
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                sayac++;
            }
            */





        }
    }
}
