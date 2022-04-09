// See https://aka.ms/new-console-template for more information
// Classes
// Combining related fields and methods

namespace HelloWorld.Person
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}