static class LogLine
{
    public static string Message(string logLine)
    {
        // throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
        string fullLogLine = logLine;
        string[] message = fullLogLine.Split(": ");
        string trimmedMessage = message[1];
        trimmedMessage = trimmedMessage.Trim();
        return trimmedMessage;
        
    }

    public static string LogLevel(string logLine)
    {
        // throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
        string fullLogLine = logLine;
        char[] separators = ['[', ']'];
        string[] logLevel = fullLogLine.Split(separators);
        string lowercaseLevel = logLevel[1];
        lowercaseLevel = lowercaseLevel.ToLower();
        return lowercaseLevel;
    }

    public static string Reformat(string logLine)
    {
        // throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
        string fullLogLine = logLine;
        char[] separators = ['[', ']', ':'];

        string[] logParts = fullLogLine.Split(separators);
        string logLevel = logParts[1];
        string logLevelLow = logLevel.ToLower();
        
        string logMessage = logParts[3];
        string logMessageTrim = logMessage.Trim();
        return $"{logMessageTrim} ({logLevelLow})";
    }
}
