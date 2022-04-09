// See https://aka.ms/new-console-template for more information
using HelloWorld.Person;
using HelloWorld.Math;

Console.WriteLine("Hello, World!");

byte number = 2;
int count = 10;
float totalPrice = 17.01f;
char character = 'A';
string firstName = "Alfred";
bool isWorking = false;
var newNumber = 17; // Figures out the type with var already
const float Pi = 3.14f;

Console.WriteLine(number);
Console.WriteLine(count);
Console.WriteLine(totalPrice);
Console.WriteLine(character);
Console.WriteLine(firstName);
Console.WriteLine(isWorking);
Console.WriteLine(newNumber);
// String interpolation
Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
Console.WriteLine(Pi);

// Explicit and implicit type conversions
int i = 1;
byte b = (byte)i;
Console.WriteLine("Converted i to b {0}", b);
// Can convert non-compatible types
string s = "1";
i = Convert.ToInt32(s);
int j = int.Parse(s);
Console.WriteLine("Converted i {0} and j {1}", i, j);

try
{
    var anotherNumber = "1234";
    byte newByte = Convert.ToByte(anotherNumber);
    Console.WriteLine(newByte);
} catch (Exception)
{
    Console.WriteLine("The number could not be converted to a byte");
}

// Operators
var numA = 1;
var numB = 3;
Console.WriteLine("Sum of a and b: {0}", numA + numB);

Person alfred = new Person();
alfred.FirstName = "Alfred";
alfred.LastName = "Lucero";
alfred.Introduce();

var calculator = new Calculator();
var result = calculator.Add(1, 2);
Console.WriteLine("Result of calc adding {0}", result);