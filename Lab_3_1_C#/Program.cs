using System;

namespace DietApp.Tests
{
    public class Foodstuff
    {
        public double Price { get; private set; }
        public int Caloricity { get; private set; }

        public void Init(double price, int caloricity)
        {
            Price = price;
            Caloricity = caloricity;
        }

        public Foodstuff()
        {
        }

        public Foodstuff(double price, int caloricity)
        {
            Price = price;
            Caloricity = caloricity;
        }

        public double ProductValue()
        {
            return Price / Caloricity;
        }

        public void Read()
        {
            Console.Write("Стоимость (100 гр.):  ");
            Price = double.Parse(Console.ReadLine());

            Console.Write("Калорийность (100 гр.): ");
            Caloricity = int.Parse(Console.ReadLine());
        }
    }

    public class Dieta : Foodstuff
    {
        public int BreadUnits { get; set; }

        public Dieta(double price, int caloricity, int breadUnits) : base(price, caloricity)
        {
            BreadUnits = breadUnits;
        }

        public Dieta()
        {
        }

        public double ProductValue()
        {
            return Price / (Caloricity + (BreadUnits * 2));
        }

    }

    public class Diet
    {
        private Foodstuff Foodstuff { get; set; }
        private Dieta Dieta { get; set; }

        public Diet(Foodstuff foodstuff, Dieta dieta)
        {
            Foodstuff = foodstuff;
            Dieta = dieta;
        }

        public void Read()
        {
            Console.WriteLine("Нормальная ценность:");
            Foodstuff.Read();

            Console.WriteLine("С хлебными единицами:");
            Dieta.Read();
        }

        public double TotalValue()
        {
            return Dieta.ProductValue() + Foodstuff.ProductValue();
        }
    }

    public class Program
    {
        public static void Main()
        {
            Foodstuff foodstuff = new Foodstuff();
            Dieta diet = new Dieta();

            Diet newdiet = new Diet(foodstuff, diet);

            double totalValue = newdiet.TotalValue();
            Console.WriteLine($"Общая ценность: {totalValue}");
        }
    }
}




