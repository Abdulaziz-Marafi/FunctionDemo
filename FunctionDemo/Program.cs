// C# Functions 
#region AllFunctions
void greet(string name)
{
    Console.WriteLine("Hello " + name + ", welcome to my program.");
}
double calculateVolume(double length, double width, double height)
{
    return length * width * height;
}
// Overloaded volume method (it does not work in main as overloaded methods need to be in a class)
//double calculateVolume(double length, double width)
//{
//    return length * width;
//}
int returnSpooky(int num)
{
    if (num%2 == 0)
    {
        return num * 2;
    }else
    {
        return num * num;
    }
}

double toFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}

void checkVowel (char c)
{
    if (Char.IsLetter(c))
    {
        // is letter
        if (c =='a' || c =='i' || c == 'e'|| c == 'o' || c == 'u' || c == 'A' || c == 'I' || c == 'E' || c == 'O' || c == 'U')
        {
            Console.WriteLine("The entered character is a vowel");
        }
        else
        {
            Console.WriteLine("The entered character is a consonant");
        }
    }
    else
    {
        // not letter
        Console.WriteLine("The entered character is not a letter.");
    }
}

double currencyExchange(double amount, double rate)
{
    return amount * rate;
}
#endregion


#region TestingTheFunctions

// Task 1
Console.WriteLine("\n");
Console.WriteLine("Task 1:Greet Function ");
Console.WriteLine("----------------------");
Console.WriteLine("\n");
Console.WriteLine("Please enter your name: ");
Console.WriteLine("----------------------- ");
string name = Console.ReadLine();

Console.WriteLine("\n");
greet(name);


// Task 2
Console.WriteLine("\n");
Console.WriteLine("Task 2:Box Volume");
Console.WriteLine("-----------------");
Console.WriteLine("\n");
Console.WriteLine("Please enter the height of the box: ");
Console.WriteLine("----------------------------------- ");
double height = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the length of the box: ");
Console.WriteLine("----------------------------------- ");
double length = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the width of the box: ");
Console.WriteLine("---------------------------------- ");
double width = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n");
Console.WriteLine("The Volume of the box is: "+ calculateVolume(length,width,height));


// Task 3
Console.WriteLine("\n");
Console.WriteLine("Task 3:Odd or Even: ");
Console.WriteLine("------------------- ");
Console.WriteLine("\n");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n");
Console.WriteLine("The new number produced is: "+returnSpooky(num));

//Task 4
Console.WriteLine("\n");
Console.WriteLine("Task 4:Celsius to Fahrenheit: ");
Console.WriteLine("----------------------------- ");
Console.WriteLine("\n");

Console.WriteLine("Please enter the temprature in celsius: ");
Console.WriteLine("--------------------------------------- ");
double celsius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n");
Console.WriteLine("The degree in Fahrenhiet is "+ toFahrenheit(celsius)+"°F");


//Task 5

Console.WriteLine("\n");
Console.WriteLine("Task 5:Vowel or a Consonant: ");
Console.WriteLine("\n");
Console.WriteLine("Please enter a single character: ");
Console.WriteLine("-------------------------------- ");
char c = Convert.ToChar(Console.ReadLine());

Console.WriteLine("\n");
checkVowel(c);

//Task 6 
Console.WriteLine("\n");
Console.WriteLine("Task 6:Currency Exchange: ");
Console.WriteLine("\n");
Console.WriteLine("Please enter the amount of money you wish to convert: ");
Console.WriteLine("----------------------------------------------------- ");
double amount = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n");
Console.WriteLine("Please enter the currency exchange rate: ");
Console.WriteLine("---------------------------------------- ");
double rate = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The converted amount in the new currncy is "+currencyExchange(amount,rate));

#endregion