public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        int index = str.IndexOf(delimiter);
        return str.Substring(index + delimiter.Length);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string firstDelimiter, string secondDelimiter)
    {
        int firstIndex = str.IndexOf(firstDelimiter);
        int secondIndex = str.IndexOf(secondDelimiter);

        return str.Substring(firstIndex + firstDelimiter.Length, secondIndex - firstIndex - 
        firstDelimiter.Length);
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        int index = str.IndexOf(": ");
        return str.Substring(index + 2);
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        int firstIndex = str.IndexOf("[");
        int secondIndex = str.IndexOf("]");

        return str.Substring(firstIndex + 1, secondIndex - firstIndex - 
        1);
    }
}