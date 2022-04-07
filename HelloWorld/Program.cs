// See https://aka.ms/new-console-template for more information
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