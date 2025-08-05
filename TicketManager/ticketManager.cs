// User enters their age
Console.Write("Enter your age: ");
double age = Convert.ToDouble(Console.ReadLine());

double result;

if (age <= 12)
{
    result = 10 - 7;
    Console.WriteLine("Ghc" + result + " - Here you go kiddo, enjoy your discounted ticket!");
}
else if (age >= 65)
{
    result = 10 - 7;
    Console.WriteLine("Ghc" + result + " - Here you go Grandpa/Grandma, enjoy your discounted ticket!");
}
else if (age >= 13 && age <= 64)
{
    result = 10;
    Console.WriteLine("Ghc" + result + " - No discount!!, enjoy your ticket bozo!");
}
else
{
    Console.WriteLine("If you're seeing this message, the system prolly just hates you for being you. Please try again.");
}
