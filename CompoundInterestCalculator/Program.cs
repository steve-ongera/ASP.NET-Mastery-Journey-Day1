using System;

class CompoundInterestCalculator
{
    static void Main()
    {
        Console.WriteLine("=== Compound Interest Calculator ===");

        // Get user inputs
        Console.Write("Enter principal amount (KSh): ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual interest rate (%): ");
        double rate = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Enter number of times interest is compounded per year: ");
        int compounds = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter time (in years): ");
        int years = Convert.ToInt32(Console.ReadLine());

        // Calculate compound interest
        double amount = CalculateCompoundInterest(principal, rate, compounds, years);
        double interest = amount - principal;

        // Display results
        Console.WriteLine("\n--- Results ---");
        Console.WriteLine($"Final Amount: KSh {amount:F2}");
        Console.WriteLine($"Total Interest Earned: KSh {interest:F2}");
    }

    static double CalculateCompoundInterest(double p, double r, int n, int t)
    {
        return p * Math.Pow((1 + r / n), n * t);
    }
}
