using System;
using System.Text;

namespace CsharpDay02Assignment
{
   class Program
   {
       static void Main()
       {

            #region Problem1
            //Console.Write("Enter a number (string): ");
            //string input = Console.ReadLine();

            //try
            //{
            //    int value1 = int.Parse(input);
            //    Console.WriteLine("int.Parse result: " + value1);

            //    int value2 = Convert.ToInt32(input);
            //    Console.WriteLine("Convert.ToInt32 result: " + value2);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //} 
            #endregion



            #region Problem2
            //Console.Write("Enter another number: ");
            //string input2 = Console.ReadLine();

            //if (int.TryParse(input2, out int result))
            //    Console.WriteLine("Valid number: " + result);
            //else
            //    Console.WriteLine("Invalid input"); 
            #endregion



            #region Problem3
            //object obj;

            //obj = 10;
            //Console.WriteLine("HashCode (int): " + obj.GetHashCode());

            //obj = "Hello";
            //Console.WriteLine("HashCode (string): " + obj.GetHashCode());

            //obj = 10.5;
            //Console.WriteLine("HashCode (double): " + obj.GetHashCode()); 
            #endregion



            #region Problem4
            //int[] arr1 = { 5 };
            //int[] arr2 = arr1;

            //arr1[0] = 20;
            //Console.WriteLine("Value from arr2: " + arr2[0]); 
            #endregion



            #region Problem5
            //string s = "Welcome";
            //Console.WriteLine("Before HashCode: " + s.GetHashCode());

            //s += " Hi Waleed";
            //Console.WriteLine("After HashCode: " + s.GetHashCode()); 
            #endregion



            #region Problem6
            //StringBuilder sb = new StringBuilder("Hi waleed");
            //Console.WriteLine("Before HashCode: " + sb.GetHashCode());

            //sb.Append(" Welcome");
            //Console.WriteLine("After HashCode: " + sb.GetHashCode()); 
            #endregion



            #region Problem7
            //Console.Write("Enter first number: ");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sum is " + n1 + n2);
            //Console.WriteLine(string.Format("Sum is {0}", n1 + n2));
            //Console.WriteLine($"Sum is {n1 + n2}"); 
            #endregion



            #region Problem8
            //StringBuilder sb2 = new StringBuilder("Hi Waleed");

            //sb2.Append(" Welcome");
            //sb2.Replace("Welcome", "Back");
            //sb2.Insert(3, "Mr ");
            //sb2.Remove(0, 3);

            //Console.WriteLine(sb2.ToString()); 
            #endregion

        }
   }

}
