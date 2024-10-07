using MenuPractice;

var calculator = new Calculator();

Console.WriteLine("=== Calculator Program ===");
Console.WriteLine($"Addition of 5 and 3: {calculator.Add(5, 3)}");
Console.WriteLine($"Subtraction of 5 and 3: {calculator.Subtract(5, 3)}");
Console.WriteLine($"Multiplication of 5 and 3: {calculator.Multiply(5, 3)}");
Console.WriteLine($"Division of 6 and 3: {calculator.Divide(6, 3)}");

// Test for exception
try
{
    Console.WriteLine($"Division of 6 and 0: {calculator.Divide(6, 0)}");
}
catch (DivideByZeroException ex)
{

    Console.WriteLine(ex.Message);
}