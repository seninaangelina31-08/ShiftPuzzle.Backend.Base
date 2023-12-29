namespace HomePracticeB;

class InterestCalculator
{
    public static double CalculateCompoundInterest(double principal, double annualRate, int years)
    {
        for (int year = 0; year < years; year++)
        {
            principal += principal * annualRate;
        }
        return principal;
    }

    static void Main(string[] args)
    {
        double initialPrincipal = 1000;
        double annualRate = 0.05;
        int numberOfYears = 5;

        double finalAmount = CalculateCompoundInterest(initialPrincipal, annualRate, numberOfYears);
        Console.WriteLine($"Конечная сумма после {numberOfYears} лет: {finalAmount}");
    }
}
