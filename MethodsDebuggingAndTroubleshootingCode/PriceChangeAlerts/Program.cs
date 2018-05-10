using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double border = double.Parse(Console.ReadLine());
        double lastEnteredPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = FindingTheDifferenceBetweenLastAndCurrentPrice(lastEnteredPrice, currentPrice);
            bool isThereADifferenceBetweenTheBorderAndTheDifference = FindingADifference(difference,border);
            string message = GetAMessageForThePrices(currentPrice, lastEnteredPrice, difference, isThereADifferenceBetweenTheBorderAndTheDifference);
            Console.WriteLine(message);
            lastEnteredPrice = currentPrice;
        }
    }

    private static string GetAMessageForThePrices(double currrent, double last, double razlika, bool isGreater)
     {
        string textToBePrinted = "";
        if (razlika == 0)
        {
            textToBePrinted = string.Format("NO CHANGE: {0}", currrent);
        }
        else if (!isGreater)
        {
            textToBePrinted = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, currrent, razlika*100);
        }
        else if (isGreater && (razlika > 0))
        {
            textToBePrinted = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, currrent, razlika*100);
        }
        else if (isGreater && (razlika < 0))
        textToBePrinted = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, currrent, razlika*100);
        return textToBePrinted;
    }
    private static bool FindingADifference(double granica, double razlika)
    {
        if (Math.Abs(granica) >= razlika)
        {
            return true;
        }
        return false;
    }

    private static double FindingTheDifferenceBetweenLastAndCurrentPrice(double last, double current)
    {
        double resultOfTheBothPrices = (current - last) / last;
        return resultOfTheBothPrices;
    }
}
