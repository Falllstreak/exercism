abstract class Character
{

    protected string characterClass;
    
    protected Character(string characterType)
    {
        characterClass = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {characterClass}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable() == true)
        {
            return 10;
        } else {
            return 6;
        }
    }
}

class Wizard : Character
{
    bool spellPrepared = false;
    
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (spellPrepared == false)
        {
            return 3;
        } else {
            return 12;
        }
    }

    public override bool Vulnerable()
    {
        if (spellPrepared == false)
        {
            return true;
        } else {
            return false;
        }
    }
    
    public void PrepareSpell()
    {
        spellPrepared = true;
    }
}
