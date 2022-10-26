using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SearchAlgorithm
{
    class Program
    {
        //Array to be searched
        int[] arr = new int[20];
        //Number of elements of in the array
        int n;
        //Get the number of elements to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 20 elements. \n");

            }

            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Enter array elements : ");
            Console.WriteLine("---------------------------------------------");
            for (i = 0; i<n; i++)
            {
                Console.Write("<" + (i+1) + ">");
                String s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        public void BinarySearch()
        {
            char ch;
            do
            {
                //accept the number to be seacrhed
                Console.Write("\n Enter the element want you to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                //Apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the index of the midde elements
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop to search for the elements in the array
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + " found at position " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + " not found in array.\n");
                Console.WriteLine("\nNumber of comparisson : "+ctr);
                Console.Write("\nContinue search (y/n) : ");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } 
            while ((ch == 'y'));
        }

        public void LinearSearch()
        {
            char ch;
            //search for number of comparisson
            int ctr;
            do
            {
                //Accept the number to be searched
                Console.WriteLine("\nEnter the elements you want to search : ");
                int item = Convert.ToInt32(Console.ReadLine());
                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + " found at position " + (i + 1).ToString());
                        break;
                    }
                }
                if(i== n)
                    Console.WriteLine("\n" + item.ToString() + " not found in the array ");
                Console.WriteLine("\nNumber of comparisson : " + ctr);
                Console.Write("\nContinue Search (y/n) : ");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } while((ch == 'y'));
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;
            do
            {
                do
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("================");
                    Console.WriteLine("1. Linear Search");
                    Console.WriteLine("2. Binary Search");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice ( 1, 2, 3) : ");
                    pilihanmenu = Convert.ToInt32(Console.ReadLine());
                    switch (pilihanmenu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("..................");
                            Console.WriteLine("Linear Search");
                            Console.WriteLine("..................");
                            myList.input();
                            myList.LinearSearch();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("..................");
                            Console.WriteLine("Binary Search");
                            Console.WriteLine("..................");
                            myList.input();
                            myList.BinarySearch();
                            break;
                        case 3:
                            Console.WriteLine("Exit.");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }

                    Console.Write("Pilih menu lagi? (y/n) : ");
                    ch = char.Parse(Console.ReadLine().ToLower());
                    Console.WriteLine("\n\nPress Return to Exit. ");
                    Console.ReadLine();
                    Console.Clear();
                } while (ch ==  'y');

                //to Exit from the console
                
            } while (pilihanmenu != 3);
        }
    }
}
