using System;

namespace HelloWorld1
{

    public class Invoice
    {
        // Fields
        private int[] numbers;
        private String name;
        private int age;

        // Constructor
        public Invoice()
        {
           // numbers = new int[] { 1, 2, 3 ,4}; // Initialize the array
        }

        public void DisplayInvoiceAmount(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        public int[] GetNumbers() // Method to return the array
        {
            return numbers;
        }

    }
}    