using System;

namespace assignment1
{
    class Program
    {
        static void CalculateVat()
        {
            const float VAT_RATE = 0.21F;
            Console.Write("Enter the price: ");
            string input = Console.ReadLine();
            float price = float.Parse(input);
            float vat = float.Parse(input);
            float totalPrice = float.Parse(input);
            vat = price * VAT_RATE;
            totalPrice = price + vat;
            Console.Write("price: {0}, VAT: {1}, total: {2}", price.ToString("0.00"), vat.ToString("0.00"), totalPrice.ToString("0.00"));

        }
        static void Main(string[] args)
        {
            CalculateVat();
            Console.ReadKey();
        }
    }
}
