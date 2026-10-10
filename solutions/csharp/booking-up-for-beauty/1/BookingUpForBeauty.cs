static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        char[] delimiters = ['/', ' ', ':', ','];
        string[] dateElements = appointmentDateDescription.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
    
        int month;
        int day;
        int year;
        int hour;
        int minute;
        int second;
    
        if (int.TryParse(dateElements[0], out month))
        {
            // 7/25/2019 13:45:00
            day = int.Parse(dateElements[1]);
            year = int.Parse(dateElements[2]);
            hour = int.Parse(dateElements[3]);
            minute = int.Parse(dateElements[4]);
            second = int.Parse(dateElements[5]);
        }
        else if (dateElements.Length == 6)
        {
            // June 3, 2019 11:30:00
            month = DateTime.ParseExact(dateElements[0], "MMMM", null).Month;
            day = int.Parse(dateElements[1]);
            year = int.Parse(dateElements[2]);
            hour = int.Parse(dateElements[3]);
            minute = int.Parse(dateElements[4]);
            second = int.Parse(dateElements[5]);
        }
        else
        {
            // Thursday, December 5, 2019 09:00:00
            month = DateTime.ParseExact(dateElements[1], "MMMM", null).Month;
            day = int.Parse(dateElements[2]);
            year = int.Parse(dateElements[3]);
            hour = int.Parse(dateElements[4]);
            minute = int.Parse(dateElements[5]);
            second = int.Parse(dateElements[6]);
        }
    
        return new DateTime(year, month, day, hour, minute, second);
    }
    
    public static bool HasPassed(DateTime appointmentDate)
    {
        if (DateTime.Now > appointmentDate)
        {
            return true;
        } else {
            return false;
        }
        
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18)
        {
            return true;
        } else {
            return false;
        }
    }

    public static string Description(DateTime appointmentDate)
    {
            string dateString = appointmentDate.ToString("G");

            return $"You have an appointment on {dateString}.";
    }

    public static DateTime AnniversaryDate()
    {
        var anniversaryDate = new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
        return anniversaryDate;
    }
}