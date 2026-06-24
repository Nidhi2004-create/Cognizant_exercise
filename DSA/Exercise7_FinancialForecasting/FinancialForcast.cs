using System;

public class FinancialForecast
{
    public static double PredictFutureValue(
        double currentValue,
        double growthRate,
        int years)
    {
        // Base Case
        if (years == 0)
        {
            return currentValue;
        }

        // Recursive Case
        return PredictFutureValue(
            currentValue * (1 + growthRate),
            growthRate,
            years - 1);
    }
}