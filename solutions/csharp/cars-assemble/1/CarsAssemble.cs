static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        // throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");


        int x = speed;
        
        if (x >= 1 && x <= 4)
        {
            return 1.00;
        } else if (x >= 5 && x <= 8) {
            return 0.90;
        } else if (x == 9) {
            return 0.80;
        } else if (x == 10) {
            return 0.77;
        } else {
            return 0.00;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        // throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
        int x = speed;

        if (x == 1)
        {
            return 1.00 * (x * 221);
        } else if (x == 2)
        {
            return 1.00 * (x * 221);
        } else if (x == 3)
        {
            return 1.00 * (x * 221);
        } else if (x == 4)
        {
            return 1.00 * (x * 221);
        } else if (x == 5)
        {
            return 0.90 * (x * 221);
        } else if (x == 6)
        {
            return 0.90 * (x * 221);
        } else if (x == 7)
        {
            return 0.90 * (x * 221);
        } else if (x == 8)
        {
            return 0.90 * (x * 221);
        } else if (x == 9)
        {
            return 0.80 * (x * 221);
        } else if (x == 10)
        {
            return 0.77 * (x * 221);
        } else
        {
            return 0.00;
        }
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        // throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
        int x = speed;

        if (x == 1)
        {
            return (int)Math.Round(1.00 * (x * 221)) / 60;
        } else if (x == 2)
        {
            return (int)Math.Round(1.00 * (x * 221)) / 60;
        } else if (x == 3)
        {
            return (int)Math.Round(1.00 * (x * 221)) / 60;
        } else if (x == 4)
        {
            return (int)Math.Round(1.00 * (x * 221)) / 60;
        } else if (x == 5)
        {
            return (int)Math.Round(0.90 * (x * 221)) / 60;
        } else if (x == 6)
        {
            return (int)Math.Round(0.90 * (x * 221)) / 60;
        } else if (x == 7)
        {
            return (int)Math.Round(0.90 * (x * 221)) / 60;
        } else if (x == 8)
        {
            return (int)Math.Round(0.90 * (x * 221)) / 60;
        } else if (x == 9)
        {
            return (int)Math.Round(0.80 * (x * 221)) / 60;
        } else if (x == 10)
        {
            return (int)Math.Round(0.77 * (x * 221)) / 60;
        } else
        {
            return 0;
        }
    }
}
