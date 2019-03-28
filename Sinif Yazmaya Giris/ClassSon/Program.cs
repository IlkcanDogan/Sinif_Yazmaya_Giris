using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSon
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int sonuc = 0;
            Console.Write("A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("B: ");
            b = Convert.ToInt32(Console.ReadLine());

            // Hesapla hesap = new Hesapla(a,b);
            Hesapla hesap = new Hesapla();
            
            Console.WriteLine(hesap.Cikar(a,b));


            Console.ReadLine();
        }
    }
    class Hesapla
    {

        #region
        int sonuc = 0;
        #endregion
        
        public Hesapla()
        {
           
            Console.WriteLine("İşlem Yapılıyor...");
        }
        

        public int Topla(int a, int b)
        {
            int sonuc = 0;
            sonuc = a + b;

            return sonuc;
        }

        public int Cikar(int a, int b)
        {
            sonuc = a - b;
            return sonuc;
        }
    }
}
