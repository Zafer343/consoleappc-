// Define a new class named 'MathOperation'.
public class MathOperation
{
    // Define a void method named 'PerformOperation' that takes two integer parameters.
    public void PerformOperation(int num1, int num2)
    {
        // Perform a math operation on the first integer. Here, we'll simply double it.
        int result = num1 * 2;

        // Display the result of the operation and the second integer.
        Console.WriteLine($"Result of doubling the first number: {result}");
        Console.WriteLine($"Second number: {num2}");
    }
}

public class Program
{
    static void Main()
    {
        // Instantiate the MathOperation class.
        MathOperation operation = new MathOperation();

        // Call the 'PerformOperation' method using positional parameters.
        operation.PerformOperation(5, 10);

        // Call the 'PerformOperation' method using named parameters.
        operation.PerformOperation(num1: 7, num2: 14);
    }
}
