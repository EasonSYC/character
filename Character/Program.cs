internal class Program
{
    static void Main()
    {
        Character.Classes.Character firstCharacter = new("Royal", new(2019, 01, 01), 70, 30);

        firstCharacter.Learn();
        Console.WriteLine($"Name of First Character: {firstCharacter.GetName()}");
        Console.WriteLine($"Age of First Character: {firstCharacter.ReturnAge()}");
        Console.WriteLine($"Intelligence of First Character: {firstCharacter.GetIntelligence()}");

        Character.Classes.MagicCharacter firstMagic = new("Fire", "Light", new(2018, 03, 03), 75, 22);

        firstMagic.Learn();
        Console.WriteLine($"Name of First Magic Character: {firstMagic.GetName()}");
        Console.WriteLine($"Age of First Magic Character: {firstMagic.ReturnAge()}");
        Console.WriteLine($"Intelligence of First Magic Character: {firstMagic.GetIntelligence()}");
    }
}