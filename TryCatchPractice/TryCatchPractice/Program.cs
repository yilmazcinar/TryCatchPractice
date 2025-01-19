using System;

class Program
{
    static void Main()
    {
       
        
        while (true) // Sonsuz döngü, kullanıcı geçerli bir sayı girene kadar devam edecek.
        {
            

            try
            {
                Console.Write("\nLütfen bir sayı giriniz:\n ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\nGirdiğiniz sayını karesi : {Math.Pow(sayi ,2)}\n");

                break;

            }
            catch (Exception)
            {

                Console.WriteLine("\nGeçersiz giriş yaptınız lütfen bir sayı giriniz. \n");
            }



          
        }
    }
}
