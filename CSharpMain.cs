using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Write a C# Sharp program to sort elements of an array in ascending order.
//Test Data :
//Input the size of array : 5
//Input 5 elements in the array :
//element - 0 : 2
//element - 1 : 7
//element - 2 : 4
//element - 3 : 5
//element - 4 : 9

namespace C_Practice
{
    class CSharpMain
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[]arr = new int[size];

            Console.Write("Enter all the " + size + " Elements of array : ");
            for(int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array Eements Before Sorted : ");
            for( int i = 0; i < size;i++)
            {
                Console.Write(arr[i]+" ");
            }

            getAscendingOrder(arr);
        }

        public static void getAscendingOrder(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length-1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Array Elements after Sorting : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }  
}
