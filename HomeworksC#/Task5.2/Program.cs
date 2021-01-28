using System;
using System.Collections.Generic;

namespace Task5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ElementToFind = -10;
            const int MinValue = 20;

            List<int> integerList = new List<int> { 24, -10, 15, 7, -3, -10, 42, 1, -21, 37 };

            printList(integerList);
            printPositionsOfElementInList(ElementToFind, integerList);

            RemoveElementsThatGreaterThanMinValue(MinValue, integerList);
            printList(integerList);

            InsertElement(2, 1, integerList);
            InsertElement(8, -3, integerList);
            InsertElement(5, -4, integerList);

            printList(integerList);

            integerList.Sort();
            Console.WriteLine("Sorting list...");
            printList(integerList);
        }

        private static void printList(List<int> list)
        {
            Console.Write("Elements of list:");

            foreach(int element in list)
            {
                Console.Write(" " + element);
            }

            Console.WriteLine();
        }

        private static void printPositionsOfElementInList(int element, List<int> list)
        {
            Console.Write("Positions with element " + element + ":");
            int ListLength = list.Count;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == element)
                {
                    Console.Write(" " + i);
                }
            }

            Console.WriteLine();
        }

        private static void RemoveElementsThatGreaterThanMinValue(int minValue, List<int> list)
        {
            Console.WriteLine("Removing elements that are greater than " + minValue + " ...");

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > minValue)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void InsertElement(int index, int element, List<int> list)
        {
            Console.WriteLine("Inserting element " + element + " in position " + index + " ...");
            list.Insert(index, element);
        }
    }
}
