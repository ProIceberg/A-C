using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;


namespace Search_and_Sort
{
    public static class Globals
    {
        public static int[] net1 = new int[1];
        public static int[] net2 = new int[1];
        public static int[] net3 = new int[1];
        public static int[] net4 = new int[1];
        public static int[] net5 = new int[1];
        public static int[] net6 = new int[1];
        public static int[] net7 = new int[1];
        public static int[] net8 = new int[1];
        public static int iteration = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Analyse = 0;
            while (Analyse <= 0 || Analyse >= 9)
            {
                Console.Write("What network would you want to analyse 1, 2 or 3 ?: ");
                string Choice = Console.ReadLine();
                while (!int.TryParse(Choice, out Analyse))
                {
                    Console.Write("\n Hey please pick a number. \n What network would you want to analyse 1, 2 or 3 ?: ");
                    Choice = Console.ReadLine();
                }
                Analyse = Convert.ToInt32(Choice);
                Program.Loder(Analyse);
            }
            
            switch(Analyse)
            {
                case 1:
                    Console.WriteLine("case 1");
                    Console.WriteLine(Globals.net1.Length);
                    sort(Globals.net1, 1, 1, 10);
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    Console.WriteLine(Globals.net2.Length);
                    sort(Globals.net2, 2, 1, 10);
                    break;
                case 3:
                    Console.WriteLine("case 3");
                    Console.WriteLine(Globals.net3.Length);
                    sort(Globals.net3, 3, 1, 10);
                    break;
                case 4:
                    Console.WriteLine("case 4");
                    Console.WriteLine(Globals.net4.Length);
                    sort(Globals.net4, 4, 1, 10);
                    break;
                case 5:
                    Console.WriteLine("case 5");
                    Console.WriteLine(Globals.net5.Length);
                    sort(Globals.net5, 5, 1, 50);
                    break;
                case 6:
                    Console.WriteLine("case 6");
                    Console.WriteLine(Globals.net6.Length);
                    sort(Globals.net6, 5, 1, 50);
                    break;
                case 7:
                    Console.WriteLine("case 7");
                    Console.WriteLine(Globals.net7.Length);
                    sort(Globals.net7, 5, 1, 50);
                    break;
                case 8:
                    Console.WriteLine("case 8");
                    Console.WriteLine(Globals.net8.Length);
                    sort(Globals.net8, 5, 1, 50);
                    break;
            }



        }
        public static void sort(int[] arr, int array, int run, int jump)
        {
            int x;
            int[] z = arr;
            while (run < 10)
            {
                z = arr;
                Globals.iteration = 0;
                switch (run)
                {

                    case 1:
                        Console.WriteLine("loop");
                        Console.WriteLine("Heap Sort");
                        heap(z, z.Length, true);
                        Console.Write("\nSorted Array using a heap sort in Acccending order is: ");

                        Console.WriteLine("\nThis took Iteration " + Globals.iteration);
                        break;
                    case 2:
                        heap(z, z.Length, false);
                        Console.Write("\nSorted Array using a heap sort in deccending order is: ");
                        Console.WriteLine("\nThis is Iteration " + Globals.iteration);
                        break;
                    case 3:
                        cocktailSorta(z);
                        Console.WriteLine("Sorted array ");
                        Console.WriteLine("\nThis took Iteration " + Globals.iteration);
                        break;
                    case 4:
                        cocktailSortb(z);
                        Console.WriteLine("Sorted array ");
                        Console.WriteLine("\nThis took Iteration " + Globals.iteration);
                        break;
                    case 5:
                        gnomea(z, z.Length);
                        Console.WriteLine("Sorted array gnome ");
                        Console.WriteLine("\nThis took Iteration " + Globals.iteration);
                        break;
                    case 6:
                        gnomeb(z, z.Length);
                        Console.WriteLine("Sorted array gnome ");
                        Console.WriteLine("\nThis took Iteration " + Globals.iteration);
                        break;
                    case 7:
                        inserb(z, z.Length);
                        Console.WriteLine("\nSorted array inser ");
                        Console.WriteLine("\nThis took Iteration " + Globals.iteration);

                        break;
                    case 8:
                        inserA(z, z.Length);
                        Console.WriteLine("\nSorted array inser ");
                        Console.WriteLine("\nThis took Iteration " + Globals.iteration);
                        array = 9;
                        break;
                    case 9:
                        Console.Write("\n Hey please pick a number to search: ");
                        int serchvalue = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n Hey what search option 1: Binary option 2:jump");
                        int type = Convert.ToInt32(Console.ReadLine());
                        serach(z, serchvalue, type,1,"n", serchvalue);
                        break;
                }
                for (x = 0; x < z.Length; x = x + jump)
                {
                    Console.Write(z[x] + " ");
                }
                Program.Loder(array);
                switch (array)
                {
                    case 1:
                        arr = Globals.net1;
                        break;
                    case 2:
                        arr = Globals.net2;
                        break;
                    case 3:
                        arr = Globals.net3;
                        break;
                    case 4:
                        arr = Globals.net4;
                        break;
                    case 5:
                        arr = Globals.net5;
                        break;
                    case 6:
                        arr = Globals.net6;
                        break;
                    case 7:
                        arr = Globals.net7;
                        break;
                    case 8:
                        arr = Globals.net8;
                        break;
                    case 9:
                        break;
                }

                run++;
            }
        }
        public static void serach(int[] z, int x, int search,int run,string YN, int origin)
        {
            int[] arr = z;
            int n = arr.Length;
            bool more;
            int f = 0;
            int b = 0;
            var result = new List<int>();
            result.Add(-1);
            switch (search)
            {
                case 1:
                    result[0] = binarySearch(arr, 0, n - 1, x); break;
                case 2:
                    result[0] = Jump(arr, x);break;
            }
            // how meny instances
            if (result[0] == -1) {
                more = false;
            }
                
            else
                more = true;
            while (more)
            {
                if (arr[result[f] + 1] == x)
                {
                    result.Add(result[f] + 1);
                    f++;
                }
                if (arr[result[0] - b] == x && result[0] - b != 0)
                {
                    if (result[0] - b != result[0])
                    {
                        result.Add(result[0] - b);
                    }
                    b++;
                }

                else
                    more = false;
            }
            if (result[0] == -1)
            {
                if (run == 1)
                {
                    Console.WriteLine("Element not present");
                    Console.WriteLine("would you like to find the closest value Y/n");
                    YN = Console.ReadLine();
                }
                if (YN == "n") ;
                else if (result[0] == -1 && YN != "n")
                {

                    run++;
                    ;
                    if (run % 2 > 0)
                    {
                        serach(z, origin - (int)(run / 2), search, run, "y", origin);
                    }
                    else
                    {
                        serach(z, origin + (int)(run / 2), search, run, "y", origin);
                    }
                }


            }
            else if (run % 2 == 0)
            {
                Console.WriteLine("Element " + x + " was found at index : ");
                for (int t = 0; t < result.Count; t++)
                {
                    Console.WriteLine(result[t]);
                }
            }
        }
        public static void Loder(int files)
        {
            int counter = 0;
            string line;
            switch (files)
            {
                case 1:
                    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Net_1_256.txt");
                    System.IO.StreamReader file = new System.IO.StreamReader(path);
                    while ((line = file.ReadLine()) != null)
                    {
                        Array.Resize(ref Globals.net1, (counter + 1));
                        Globals.net1[counter] = int.Parse(line);
                        counter++;
                    }
                    break;

                case 2:
                    string path2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Net_2_256.txt");
                    System.IO.StreamReader file2 = new System.IO.StreamReader(path2);
                    while ((line = file2.ReadLine()) != null)
                    {
                        Array.Resize(ref Globals.net2, (counter + 1));
                        Globals.net2[counter] = int.Parse(line);
                        counter++;
                    }
                    break;
                case 3:
                    string path3 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Net_3_256.txt");
                    System.IO.StreamReader file3 = new System.IO.StreamReader(path3);
                    while ((line = file3.ReadLine()) != null)
                    {
                        Array.Resize(ref Globals.net3, (counter + 1));
                        Globals.net3[counter] = int.Parse(line);
                        counter++;
                    }
                    break;
                case 4:
                    string path4 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Net_1-3_512_merge.txt");
                    System.IO.StreamReader file4 = new System.IO.StreamReader(path4);
                    while ((line = file4.ReadLine()) != null)
                    {
                        Array.Resize(ref Globals.net4, (counter + 1));
                        Globals.net4[counter] = int.Parse(line);
                        counter++;
                    }
                    break;
                case 5:
                    string path5 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Net_1_2048.txt");
                    System.IO.StreamReader file5 = new System.IO.StreamReader(path5);
                    while ((line = file5.ReadLine()) != null)
                    {
                        Array.Resize(ref Globals.net5, (counter + 1));
                        Globals.net5[counter] = int.Parse(line);
                        counter++;
                    }
                    break;
                case 6:
                    string path6 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Net_2_2048.txt");
                    System.IO.StreamReader file6 = new System.IO.StreamReader(path6);
                    while ((line = file6.ReadLine()) != null)
                    {
                        Array.Resize(ref Globals.net6, (counter + 1));
                        Globals.net6[counter] = int.Parse(line);
                        counter++;
                    }
                    break;
                case 7:
                    string path7 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Net_3_2048.txt");
                    System.IO.StreamReader file7 = new System.IO.StreamReader(path7);
                    while ((line = file7.ReadLine()) != null)
                    {
                        Array.Resize(ref Globals.net7, (counter + 1));
                        Globals.net7[counter] = int.Parse(line);
                        counter++;
                    }
                    break;
                case 8:
                    string path8 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Net_1-3_4096_merge.txt");
                    System.IO.StreamReader file8 = new System.IO.StreamReader(path8);
                    while ((line = file8.ReadLine()) != null)
                    {
                        Array.Resize(ref Globals.net8, (counter + 1));
                        Globals.net8[counter] = int.Parse(line);
                        counter++;
                    }
                    break;

            }
            
           
            counter = 0;
           
            counter = 0;
           

            counter = 0;
           
            counter = 0;

            counter = 0;
            
            counter = 0;
           
        }
        public static void heap(int[] arr, int x, bool order)
        {

            Console.Write(order);
            if (order)
            {


                for (int y = x / 2 - 1; y >= 0; y--)
                    heapera(arr, x, y);
                for (int y = x - 1; y >= 0; y--)
                {
                    int temp = arr[0];
                    arr[0] = arr[y];
                    arr[y] = temp;
                    heapera(arr, y, 0);

                }
            }
            else
            {
                for (int y = x / 2 - 1; y >= 0; y--)
                    heaperb(arr, x, y);
                for (int y = x - 1; y >= 0; y--)
                {
                    int temp = arr[0];
                    arr[0] = arr[y];
                    arr[y] = temp;
                    heaperb(arr, y, 0);
                }

            }
        }
        public static void heapera(int[] arr, int x, int y)
        {
            Globals.iteration++;
            int larger = y;
            int lef = 2 * y + 1;
            int rig = 2 * y + 2;
            if (lef < x && arr[lef] > arr[larger])
                larger = lef;
            if (rig < x && arr[rig] > arr[larger])
                larger = rig;
            if (larger != y)
            {
                int swp = arr[y];
                arr[y] = arr[larger];
                arr[larger] = swp;
                heapera(arr, x, larger);

            }
        }
        public static void heaperb(int[] arr, int x, int y)
        {
            Globals.iteration++;
            int larger = y;
            int lef = 2 * y + 1;
            int rig = 2 * y + 2;
            if (lef < x && arr[lef] < arr[larger])
                larger = lef;
            if (rig < x && arr[rig] < arr[larger])
                larger = rig;
            if (larger != y)
            {
                int swp = arr[y];
                arr[y] = arr[larger];
                arr[larger] = swp;
                heaperb(arr, x, larger);
            }
        }
        static void cocktailSorta(int[] arr)
        {
            bool swap = true;
            int sta = 0;
            int ed = arr.Length;

            while (swap == true)
            {
                swap = false;
                for (int x = sta; x < ed - 1; ++x)
                {
                    if (arr[x] < arr[x + 1])
                    {
                        int temp = arr[x + 1];
                        arr[x + 1] = arr[x];
                        arr[x] = temp;
                        swap = true;
                        Globals.iteration++;
                    }
                }

                // if nothing moved, then array is sorted. 
                if (swap == false)
                    break;

                // otherwise, reset the swapped flag so that it 
                // can be used in the next stage 
                swap = false;

                // move the ed point back by one, because 
                // item at the ed is in its rightful spot 
                ed = ed - 1;

                // from top to bottom, doing the 
                // same comparison as in the previous stage 
                for (int x = ed - 1; x >= sta; x--)
                {
                    if (arr[x] < arr[x + 1])
                    {
                        int temp = arr[x + 1];
                        arr[x + 1] = arr[x];
                        arr[x] = temp;
                        swap = true;
                    }
                }

                // increase the staing point, because 
                // the last stage would have moved the next 
                // smallest number to its rightful spot. 
                sta = sta + 1;
            }
        }
        static void cocktailSortb(int[] arr)
        {
            {
                bool swap = true;
                int sta = 0;
                int ed = arr.Length;

                while (swap == true)
                {
                    swap = false;
                    for (int x = sta; x < ed - 1; ++x)
                    {
                        if (arr[x] < arr[x + 1])
                        {
                            int temp = arr[x + 1];
                            arr[x + 1] = arr[x];
                            arr[x] = temp;
                            swap = true;
                            Globals.iteration++;
                        }
                    }

                    // if nothing moved, then array is sorted. 
                    if (swap == false)
                        break;

                    // otherwise, reset the swapped flag so that it 
                    // can be used in the next stage 
                    swap = false;

                    // move the ed point back by one, because 
                    // item at the ed is in its rightful spot 
                    ed = ed - 1;

                    // from top to bottom, doing the 
                    // same comparison as in the previous stage 
                    for (int x = ed - 1; x >= sta; x--)
                    {
                        if (arr[x] > arr[x + 1])
                        {
                            int temp = arr[x + 1];
                            arr[x + 1] = arr[x];
                            arr[x] = temp;
                            swap = true;
                        }
                    }

                    // increase the staing point, because 
                    // the last stage would have moved the next 
                    // smallest number to its rightful spot. 
                    sta = sta + 1;
                }
            }
        }
        public static void gnomea(int[] arr, int x)
        {
            int z = 0;
            while (z < x)
            {
                Globals.iteration++;
                if (z == 0)
                {
                    z++;
                }
                if (arr[z] >= arr[z - 1])
                {
                    z++;
                }
                else
                {
                    int tmp = 0;
                    tmp = arr[z];
                    arr[z] = arr[z - 1];
                    arr[z - 1] = tmp;
                    z--;
                }
            }
        }
        public static void gnomeb(int[] arr, int x)
        {
            int z = 0;
            while (z < x)
            {
                Globals.iteration++;
                if (z == 0)
                {
                    z++;
                }
                if (arr[z] <= arr[z - 1])
                {
                    z++;
                }
                else
                {
                    int tmp = 0;
                    tmp = arr[z];
                    arr[z] = arr[z - 1];
                    arr[z - 1] = tmp;
                    z--;
                }
            }
        }
        public static void inserA(int[] arr, int x)
        {
            for (int y = 1; y < x; ++y)
            {
                int tmp = arr[y];
                int z = y - 1;
                while (z >= 0 && arr[z] > tmp)
                {
                    Globals.iteration++;
                    arr[z + 1] = arr[z];
                    z = z - 1;
                }
                arr[z + 1] = tmp;
            }
        }
        public static void inserb(int[] arr, int x)
        {
            for (int y = 1; y < x; ++y)
            {
                int tmp = arr[y];
                int z = y - 1;
                while (z >= 0 && arr[z] < tmp)
                {
                    Globals.iteration++;
                    arr[z + 1] = arr[z];
                    z = z - 1;
                }
                arr[z + 1] = tmp;
            }
        }
        public static int binarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the 
                // middle itself 
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then 
                // it can only be present in left subarray 
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                // Else the element can only be present 
                // in right subarray 
                return binarySearch(arr, mid + 1, r, x);
            }

            // We reach here when element is not present 
            // in array 
            return -1;
        }

        public static int Jump(int[] arr, int x)
        {
            int n = arr.Length;

            // Finding block size to be jumped 
            int step = (int)Math.Floor(Math.Sqrt(n));

            // Finding the block where element is 
            // present (if it is present) 
            int prev = 0;
            while (arr[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }

            // Doing a linear search for x in block 
            // beginning with prev. 
            while (arr[prev] < x)
            {
                prev++;

                // If we reached next block or end of 
                // array, element is not present. 
                if (prev == Math.Min(step, n))
                    return -1;
            }

            // If element is found 
            if (arr[prev] == x)
                return prev;

            return -1;
        }
    }
}

