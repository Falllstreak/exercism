public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int resistLevel = 10;
        
        switch(color) 
        {
          case "black":
            resistLevel = 0;
            break;
          case "brown":
            resistLevel = 1;
            break;
          case "red":
            resistLevel = 2;
            break;
          case "orange":
            resistLevel = 3;
            break;
          case "yellow":
            resistLevel = 4;
            break;
          case "green":
            resistLevel = 5;
            break;
          case "blue":
            resistLevel = 6;
            break;
          case "violet":
            resistLevel = 7;
            break;
          case "grey":
            resistLevel = 8;
            break;
          case "white":
            resistLevel = 9;
            break;
        }

        return resistLevel;
    }

    public static string[] Colors()
    {
        string[] expected = ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"];
        return expected;
    }
}