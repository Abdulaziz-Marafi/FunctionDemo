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
#endregion


#region TestingTheFunctions
Console.WriteLine("\n");
Console.WriteLine("Task 1:Greet Function ");
Console.WriteLine("----------------------");
Console.WriteLine("\n");
Console.WriteLine("Please enter your name: ");
Console.WriteLine("----------------------- ");
string name = Console.ReadLine();

Console.WriteLine("\n");
greet(name);


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


Console.WriteLine("\n");
Console.WriteLine("Task 3:Odd or Even: ");
Console.WriteLine("------------------- ");
Console.WriteLine("\n");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n");
Console.WriteLine("The new number produced is: "+returnSpooky(num));

#endregion