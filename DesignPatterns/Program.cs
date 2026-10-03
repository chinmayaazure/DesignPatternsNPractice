using System.Diagnostics;
using DesignPatterns.AbstractFactory;
using DesignPatterns.FactoryPattern;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            FactoryClientCode();
            AbstractFactoryClientCode();

            StrategyClientCode();

            UseFuncDelegate();

            UseActionDelegate();

           
        }


        static void AbstractFactoryClientCode()
        {
            // Simple configuration logic simulating runtime preference
            bool isDarkMode = true;
            IUIFactory currentFactory;

            if (isDarkMode)
            {
                currentFactory = new DarkUIFactory();
            }
            else
            {
                currentFactory = new LightUIFactory();
            }

            // Pass the chosen variant factory into the client application
            Application app = new Application(currentFactory);
            app.Paint();
        }
        static void FactoryClientCode()
        {
            // The client code works with factories through their base class
            VehicleFactory factory;

            // Scenario A: Client wants a car
            factory = new CarFactory();
            factory.DeliverVehicle();

            Console.WriteLine();

            // Scenario B: Client wants a truck
            factory = new TruckFactory();
            factory.DeliverVehicle();
        }

        static void StrategyClientCode()
        {
            // The client code can work with different strategies
            Sorter sorter = new Sorter();
            var numbers = new List<int> { 5, 2, 8, 3, 1 };
            sorter.SetSortStrategy(new QuickSort());
            sorter.Sort(numbers);

        }


        
        //public delegate TResult Func<in T, out TResult>(T arg);        

       

        static void UseFuncDelegate()
        {
            //public delegate TResult Func<in T, out TResult>(T arg);
            Func<int, int> squareFunc = Square;
            int result = squareFunc(5);
            Console.WriteLine($"Square of 5 is: {result}");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Using Func to transform a list
            List<int> squaredNumbers = TransformList(numbers, x => x * x);
        }

        static int Square(int number)
        {
            return number * number;
        }

        
        static List<TResult> TransformList<T, TResult>(List<T> list, Func<T, TResult> transformer)
        {
            List<TResult> transformedList = new List<TResult>();
            foreach (var item in list)
            {
                
                transformedList.Add(transformer(item));
            }
            return transformedList;
        }


        static void UseActionDelegate()
        {
            Action<string> printAction = PrintName;
            printAction("John Doe");
            ListOperationOnAction(action: printAction, list: new List<string> { "Alice", "Bob", "Charlie" });
        }

        static void ListOperationOnAction<T>(List<T> list, Action<T> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }

        static void PrintName(string name)
        {
            Console.WriteLine($"Name: {name}");
        }




        static void FactoryStrategyRegistration()
        {
            
        }
    }
}
