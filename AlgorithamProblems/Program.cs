// See https://aka.ms/new-console-template for more information
using System;
namespace AlgorithamProblems
{
    class program
    {
      
        public static void Main(String[] args)
        {

            string[] names = { "prasanna lakshmi", "lakshmi prasanna", "vara lakshmi", "lakshmi vara" };
            AlgorithamProblems.InsertSort value = new AlgorithamProblems.InsertSort();
            value.InsertionSort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }



        }

        
    }
}

