using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.Strategy
{
//    Strategy Pattern
//Definition:
//Defines a family of algorithms, encapsulates each one, and makes them interchangeable.Strategy lets the algorithm vary independently from clients that use it.
//Use Case:
//Sorting a collection of items using different sorting strategies.
    public interface ISortStrategy
    {
        void Sort(List<int> list);
    }

    public class BubbleSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("Sorting using Bubble Sort");
            // Implement bubble sort algorithm here
        }
    }

    public class QuickSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("Sorting using Quick Sort");
            // Implement quick sort algorithm here
        }
    }

    //Context
    public class Sorter
    {
        private ISortStrategy _sortStrategy;
        //public Sorter(ISortStrategy sortStrategy)
        //{
        //    _sortStrategy = sortStrategy;
        //}
        public Sorter()
        {
            
        }
        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }
        public void Sort(List<int> list)
        {
            _sortStrategy.Sort(list);
        }
    }
}
