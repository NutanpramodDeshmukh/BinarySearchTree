using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindnodeBST
{
    public class Demo
    {
        public static void SearchItem(int[] array, int item)
        {
            int itemAtIndex = Array.BinarySearch(array, 0, array.Length, item);

            if (itemAtIndex >= 0)
            {
                Console.WriteLine("Item " + item + " found at index " + itemAtIndex);
            }
            else
            {
                Console.WriteLine("Item does not found");
            }
        }

        public static void Main()
        {
            int[] intArray = { 56, 30, 70, 22, 40, 60, 95, 11, 3, 16, 63, 67 };

            SearchItem(intArray, 63);
        }
    }
}
