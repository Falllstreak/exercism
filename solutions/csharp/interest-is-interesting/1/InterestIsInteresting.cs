static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        // throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
        
        if (balance >= 0 && balance < 1000){
            return 0.5f;
        } else if (balance >= 1000 && balance < 5000) {
            return 1.621f;
        } else if (balance >= 5000) {
            return 2.475f;
        } else {
            return 3.213f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        // throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");

        if (balance >= 0 && balance < 1000){
            return balance * 0.005m;
        } else if (balance >= 1000 && balance < 5000) {
            return balance * 0.01621m;
        } else if (balance >= 5000) {
            return balance * 0.02475m;
        } else {
            return balance * 0.03213m;
        }
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        // throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");

        decimal firstTier = balance * 0.005m;
        decimal secondTier = balance * 0.01621m;
        decimal thirdTier = balance * 0.02475m;
        decimal negativeTier = balance * 0.03213m;
        
        if (balance >= 0 && balance < 1000){
            return balance + firstTier;
        } else if (balance >= 1000 && balance < 5000) {
            return balance + secondTier;
        } else if (balance >= 5000) {
            return balance + thirdTier;
        } else {
            return balance + negativeTier;
        }
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        // throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
        
        int years = 0;

    while (balance < targetBalance)
    {
        float interestRate = InterestRate(balance);
        decimal interest = balance * (decimal)(interestRate / 100);

        balance = balance + interest;
        years = years + 1;
    }

    return years;
        
    }
}
