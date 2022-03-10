
var character1 = new Character("Lelouch", 
    "To defeat evil, I shall become a even greater evil", 
    "lelouch vi Britannia commands you to Live!", 0);
var chracter2 = new Character("Batman", "Fear is a tool", "I'm vengeance", 0);

character1.speak(1);
chracter2.setLevel(2);
chracter2.speak(2);

class Character
{
    private string name;
    private string phrase1;
    private string phrase2;
    private int level;
    public Character(string Name, string Phrase1, string Phrase2, int Level)
    {
        name = Name;
        phrase1 = Phrase1;
        phrase2 = Phrase2;
        level = Level;
    }

    public void speak(int phraseNum)
    {
        switch (phraseNum)
        {
            case 1:
                Console.WriteLine($"{name}: {phrase1}");
                break;
            case 2:
                Console.WriteLine($"{name}: {phrase2}");
                break;
        }
    }

    public void setLevel(int newLevel)
    {
        level = newLevel;
        Console.WriteLine($"{name}: is now level {level}" );
    }
}