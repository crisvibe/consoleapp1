using System;

namespace ConsoleAppOne {
    class Program {
        static void Main(string[] args) {
            int[] myArray = new int[10];
            int i;

            System.Console.WriteLine("Read and Print elements of an array");

            // Loop through the array and assign a value to each array value
            for (i = 0; i < 10; i++) {
                System.Console.WriteLine("element - {0} : ", i);
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");

            // Loop to print the elements of the array
            for(i = 0; i < 10; i++)  
            {  
                Console.Write("{0}  ", myArray[i]);  // Print each element of the array
            } 

            Console.Write("\n");
        }
    }
}