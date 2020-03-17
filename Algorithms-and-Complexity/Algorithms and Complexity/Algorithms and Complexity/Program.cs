using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms_and_Complexity // Thomas Hardcastle - 19705445
{
    public static class Globals
    {
        public static int[] network = new int[1];
        public static int iteration = 0;
        public static int jump = 10;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // Providing the user with a choice on which array they want to choose
            int choice = 0;
            while (choice >= 9 || choice <= 0)
            {
                Console.WriteLine("Which array would you like to use");
                Console.WriteLine("1. Net_1_256.txt");
                Console.WriteLine("2. Net_1_2048.txt");
                Console.WriteLine("3. Net_2_256.txt");
                Console.WriteLine("4. Net_2_2048.txt");
                Console.WriteLine("5. Net_3_256.txt");
                Console.WriteLine("6. Net_3_2048.txt");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            lode(choice);
            Console.WriteLine("which sort would you like to use: ");
            choice = Convert.ToInt32(Console.ReadLine());
            sort(choice);

        }
        public static void sort(int choice)
        {

        }
        // A counter that makes a check that the choice is less than 7 and is applicable 
        public static void lode(int choice)
        {
            string line;
            int counter = 0;
            string filename = "Net_1_256.txt";
            if (choice < 7)
            {
                switch (choice)
                {
                    case 1:
                        filename = "Net_1_256.txt";
                        break;
                    case 2:
                        filename = "Net_2_256.txt";
                        break;
                    case 3:
                        filename = "Net_3_256.txt";
                        break;
                    case 4:
                        filename = "Net_1_2048.txt";
                        Globals.jump = 50;
                        break;
                    case 5:
                        filename = "Net_2_2048.txt";
                        Globals.jump = 50;
                        break;
                    case 6:
                        filename = "Net_3_2048.txt";
                        Globals.jump = 50;
                        break;
                }
                // A method so that the program can always find the directory of the folder and containing files.
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"NTD\" + filename);
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    // A method that resizes the array so that it can always fit the the contents of the array 
                    Array.Resize(ref Globals.network, (counter + 1));
                    Globals.network[counter] = int.Parse(line);
                    counter++;
                }
            }
            else if (choice == 7)
            {
                Globals.jump = 10;
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"NTD\Net_1_256.txt");
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                string path2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"NTD\Net3_256.txt");
                System.IO.StreamReader file2 = new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    Array.Resize(ref Globals.network, (counter + 2));
                    Globals.network[counter] = int.Parse(line);
                    Globals.network[counter + 1] = int.Parse(file2.ReadLine());
                    counter++;
                }
            }
            else
            {
                Globals.jump = 50;
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"NTD\Net_1_2048.txt");
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                string path2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"NTD\Net3_2048.txt");
                System.IO.StreamReader file2 = new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    Array.Resize(ref Globals.network, (counter + 2));
                    Globals.network[counter] = int.Parse(line);
                    Globals.network[counter + 1] = int.Parse(file2.ReadLine());
                    counter++;
                }
            }
            for (int x = 0; x < Globals.network.Length; x = x + Globals.jump)
            {
                Console.Write(Globals.network[x] + " ");
            }
        }
        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // An index of a smaller event
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If the current element is smaller than the pivot
                if (arr[j] < pivot)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Swap arr[i+1] and arr[high] (or pivot)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        //QuickSort primary function
        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // partitioning index
                int pi = partition(arr, low, high);

                // Sorting recursively before and and after partition
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

        // A utility function to print the array size of n
        static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                Console.WriteLine(arr[i] + " ");

            Console.WriteLine();
        }

        static void CocktailSort(int[] a)
        {
            bool swapped = true;
            int start = 0;
            int end = a.Length;

            while (swapped == true)
            {
                // reset the swapped the flag on entering the loop, because it might be true from a previous interation.
                swapped = false;

                // loop from bottom to top same as the bubble sort
                for (int i = start; i < end - 1; ++i)
                {
                    if (a[i] > a[i + i])
                    {
                        int temp = a[i];
                        a[i] = a[i + i];
                        a[i + i] = temp;
                        swapped = true;
                    }
                }

                // if nothing moved, then the array is sorted
                if (swapped == false)
                    break;

                // otherwise, reset the swapped flag so that it can be used in the next stage
                swapped = false;

                // move the end point back by one, because item at the end is in its rightful spot
                end = end - 1;

                // from top to bottom, doing the same comparison as in the previous stage
                for (int i = end - 1; i >= start; i--)
                {
                    if (a[i] > a[i + i])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        swapped = true;
                    }
                }

                // increase the starting point, because the last stage would have moved the next smallest number to its rightful cost
                start = start + 1;
            }
        }

        /* Prints the array */
        static void printArray(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
                Console.WriteLine(a[i] + " ");
            Console.WriteLine();
        }
        static void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap the temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }
        void sort(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);

            // One by one extract an element from heap
            for (int i = n - 1; i >= 0; i--)
            {
                // Move the current root to the end
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // Call max heapify on the reduced heap
                heapify(arr, i, 0);
            }
        }

        // To heapify a subtree rooted with node i which is an index in arr[]. n is the size of the heap
        void heapify(int[] arr, int n, int i)
        {
            int largest = i; // This initializes the largest as the root
            int l = 2 * i + 1; // left = 2 * i + 1
            int r = 2 * i + 2; // right = 2 * i + 2

            // If left the left child is larger than the root
            if (l < n && arr[l] > arr[largest])
                largest = 1;

            // If the right child is larger than the root 
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // If the largest is no the root
            if (largest != 1)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursivly heapify the affected sub-tree
                heapify(arr, n, largest);
            }
        }
        public static int search(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        static int binarySearch(int[] arr, int l, int r, int x)
        {
            // Returns the index of x if it present in the arr[], else return - 1
            if (r >= 1)
            {
                int mid = 1 + (r - 1) / 2;

                // If the element is present at the middle itself
                if (arr[mid] == x)
                    return mid;

                // If the element is smaller than the mid. then it can only be present in the left subarray
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                // Else the element can only be present in the right subarray
                return binarySearch(arr, l, mid - 1, x);
            }

            // Reach where the element is not present in the array
            return -1;
        }
    }
}
     

 


