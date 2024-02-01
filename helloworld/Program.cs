Console.WriteLine("Im learning C#");

// program that calculates the area of ​​a rectangle

var sideA = 1.1;
var sideB = 1.1;
var result = 1.1;

Console.WriteLine("\nCalculate the area of ​​a rectangle!!");

Console.WriteLine("Insert value A: ");
sideA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insert value B: ");
sideB = Convert.ToDouble(Console.ReadLine());

result = sideA * sideB;
Console.WriteLine("\nSide A: " + sideA + "\tSide B: " + sideB + "\nThe area of reactangle is: " + result);