// See https://aka.ms/new-console-template for more information
using System;
namespace AlgorithamProblems
{
    class program
    {

        public static void Main(String[] args)
        {
            String[] input = { "prasanna", "arjun", "abhi", "soniya" };
            String find = "arjun";
            AlgorithamProblems.BinarySearch example = new AlgorithamProblems.BinarySearch();
            int result = example.binarySearch(input, find);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at " + "index " + result);
        }

    }



}

    


