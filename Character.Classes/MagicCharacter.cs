namespace Character.Classes;

public class MagicCharacter : Character
{
    private readonly string _element;

    public MagicCharacter(string element, string characterName, DateOnly dateOfBirth, double intelligence, int speed) : base(characterName, dateOfBirth, intelligence, speed)
    {
        _element = element;
    }

    public override void Learn()
    {
        _intelligence *= _element switch
        {
            "Fire" or "Water" => 1.2,
            "Earth" => 1.3,
            _ => 1.1,
        };
    }
}
