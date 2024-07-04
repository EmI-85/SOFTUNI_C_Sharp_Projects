using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogfoodprice = 2.50;
            int catfoodprice = 4;
            int dogfoodquantity = int.Parse(Console.ReadLine());
            int catfoodquantity = int.Parse(Console.ReadLine());
            double dogfoodbill = dogfoodprice * dogfoodquantity;
            int catfoodbill = catfoodprice * catfoodquantity;
            double finalprice = dogfoodbill + catfoodbill;
            Console.WriteLine(finalprice +" " +"lv.");
        }
    }
}
