using System;

namespace ExampleNamespace
{
    public class Person
    {
        // Private fields
        private string name;
        private int age;

        // Public property for Name with getter and setter
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Public property for Age with getter and setter
        public int Age
        {
            get { return age; }
            set 
            { 
                if (value >= 0) // Validate that age is non-negative
                {
                    age = value; 
                }
                else
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
            }
        }

        // Constructor to initialize Person object
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display Person details
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Person object
            Person person = new Person("Alice", 30);
            
            // Display initial details
            person.DisplayInfo();
            
            // Update the properties
            person.Name = "Bob";
            person.Age = 25;
            
            // Display updated details
            person.DisplayInfo();
        }
    }
}
