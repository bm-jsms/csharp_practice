Console.WriteLine("Im learning C#");

// program that calculates the area of ​​a rectangle

double sidea;
double sideb;
double result;

Console.WriteLine("\nCalculate the area of ​​a rectangle!!");

Console.WriteLine("Insert value A: ");
sidea = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insert value B: ");
sideb = Convert.ToDouble(Console.ReadLine());

result = sidea * sideb;
Console.WriteLine("\nSide A: " + sidea + "\tSide B: " + sideb + "\nThe area of reactangle is: " + result);