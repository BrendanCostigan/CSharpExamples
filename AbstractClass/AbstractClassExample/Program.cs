using System;
using System.Diagnostics;

namespace Brendan.AbstractClass
{

    public class AbstratcClass
    {
        public static void Main()
        {
            Fred fred = new AbstractClass.Fred();

            fred.Count = 5;         // Note Count is in the abstract class

            // Error from next line: Cannot create an instance of the abstract class or interface 'ConsoleApplication1.Person' when Person is an abstract class 
            //Person p = new Person();

            // If the method fred.SayVirtualHello is commented out then you get the output from SayVirtualHello in the abstract class Person.

            Console.WriteLine(fred.SayVirtualHello());
            Console.WriteLine(fred.Age());

            Console.ReadKey();
        }
    }

    public class Fred: Person
    {
        //public string message;
        public string SayVirtualHello()
        {
            return "I'm Fred";
        }

        // The person class has the abstract class Age which must be inherited by this class that inherits Person
        // The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
        public override int Age()
        {
            DateTime dateOfBirth = new DateTime(1980, 03, 25);

            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age)) age--;

            return age;
        }
    }

    // Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes. 
    // Members marked as abstract, or included in an abstract class, must be implemented by classes that derive from the abstract class.

    public abstract class Person                // Class must be abstract to contain an abstract method
    {
        public int Count;

        public virtual string SayVirtualHello()          // The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class.
        {
            return  "I'm a person";
        }

        // Age cannot have a body becuase it is an abstract class and we are telling the inheriting class to implement an age method
        public abstract int Age();

    }
}
