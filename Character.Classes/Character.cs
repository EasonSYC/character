namespace Character.Classes;

public class Character
{
    private readonly string _characterName;
    private readonly DateOnly _dateOfBirth;
    protected double _intelligence;
    private readonly int _speed;

    public Character(string characterName, DateOnly dateOfBirth, double intelligence, int speed)
    {
        _characterName = characterName;
        _dateOfBirth = dateOfBirth;
        _intelligence = intelligence;
        _speed = speed;
    }

    public double GetIntelligence()
    {
        return _intelligence;
    }

    public string GetName()
    {
        return _characterName;
    }

    public void SetIntelligence(double intelligence)
    {
        _intelligence = intelligence;
    }

    public virtual void Learn()
    {
        _intelligence *= 1.1;
    }

    public int ReturnAge()
    {
       int yearNow = DateTime.Today.Year;
       int yearBorn = _dateOfBirth.Year;
       return yearNow - yearBorn;
    }
}