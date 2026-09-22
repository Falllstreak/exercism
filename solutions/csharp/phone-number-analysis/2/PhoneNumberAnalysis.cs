public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        // throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
        string[] splitNumber = phoneNumber.Split("-");

        bool IsNewYork = (splitNumber[0] == "212");
        bool IsFake = (splitNumber[1] == "555");
        string LocalNumber = splitNumber[2];
        
        return (IsNewYork, IsFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.Item2;

//    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
//    {
//        throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
//        return phoneNumberInfo.Item2;
//    }
}
