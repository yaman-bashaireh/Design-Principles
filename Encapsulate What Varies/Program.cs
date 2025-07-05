﻿namespace Encapsulate_What_Varies
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = Pizza.Order(PizzaConstants.VegeterianPizza);
            Console.WriteLine(pizza);
        }
    }

    class Pizza
    {
        public virtual string Title => $"{nameof(Pizza)}";
        public virtual decimal Price => 10m;

        private static Pizza Create(string type)
        {
            Pizza pizza;
            if (type.Equals(PizzaConstants.CheesePizza))
                pizza = new Cheese();
            else if (type.Equals(PizzaConstants.VegeterianPizza))
                pizza = new Vegeterian();
            else
                pizza = new Chicken();
            return pizza;
        }

        public static Pizza Order(string type)
        {
            //    Pizza pizza;                                     \\ Encapsulate What Varies
            //    if (type.Equals("Cheese"))
            //        pizza = new Cheese();
            //    else if (type.Equals("Cheese"))
            //        pizza = new Cheese();
            //    else if ......
            //        .......

            Pizza pizza = Create(type);

            Prepare();

            Cook();

            Cut();

            return pizza;
        }
        private static void Prepare()
        {
            Console.Write("preparing...");
            Thread.Sleep(500);
            Console.WriteLine(" completed");
        }
        private static void Cook()
        {
            Console.Write("cooking...");
            Thread.Sleep(500);
            Console.WriteLine(" completed");
        }
        private static void Cut()
        {
            Console.Write("cutting and boxing...");
            Thread.Sleep(500);
            Console.WriteLine(" completed");
        }
        public override string ToString()
        {
            return $"\n{Title}" +
                   $"\n\tPrice: {Price.ToString("C")}";
        }

    }

    class Cheese : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Cheese)}"; 
        public override decimal Price => base.Price + 3m;
    }
    class Chicken : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Chicken)}";
        public override decimal Price => base.Price + 6m;
    }
    class Vegeterian : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Vegeterian)}";
        public override decimal Price => base.Price + 4m;
    }
}