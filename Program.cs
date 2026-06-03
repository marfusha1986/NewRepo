namespace BlokSeviyesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int disBlokSayi = 10;
            { // ic blok aciliyor
                int icBlokSayi = 5;
                Console.WriteLine("Dış bloktaki degisken: {0}", disBlokSayi);
                Console.WriteLine("İç bloktaki degisken: {0}", icBlokSayi);
            } // ic blok burada bitiyor
            Console.WriteLine("Dış bloktaki degisken: {0}", disBlokSayi);
           // Console.WriteLine("İç bloktaki degisken: {0}", icBlokSayi); // hata
            Console.ReadLine();
        }
    }
}
