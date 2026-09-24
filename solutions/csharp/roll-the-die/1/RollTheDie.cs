public class Player
{    
    public int RollDie()
    {
        // throw new NotImplementedException("Please implement the Player.RollDie() method");

        var dieRoll = new System.Random();
        return dieRoll.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        // throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
        var dice = new System.Random();
        return dice.NextDouble() * 100;
        
    }
}
