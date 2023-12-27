//medium lvl var № 12
try
{
    Console.Write("Введите количество футболистов:");
    int n = int.Parse(Console.ReadLine());
    FootballPlayer[] players = new FootballPlayer[n];

    for (int i = 0; i < n; i++)
    {
        players[i] = new FootballPlayer();
        Console.Write("Введите фамилию: ");
        players[i].lastName = Console.ReadLine();
        Console.Write("Введите дату рождения: ");
        players[i].dateOfBirth = Console.ReadLine();
        Console.Write("Введите место рождения: ");
        players[i].birthPlace = Console.ReadLine();
        Console.Write("Введите количество игр: ");
        players[i].gamesPlayed = int.Parse(Console.ReadLine());
        Console.Write("Введите количество желтых карточек: ");
        players[i].yellowCards = int.Parse(Console.ReadLine());
        Console.Write("Введите амплуа:");
        players[i].amplua = Console.ReadLine();

    }
    for (int i = 0; i < n; i++)
    {
        if (CalculateAge(players[i].dateOfBirth) > 20 && (players[i].gamesPlayed / players[i].yellowCards) < 10)
        {
            Console.WriteLine($"Фамилия: {players[i].lastName}");
            Console.WriteLine($"Дата рождения: {players[i].dateOfBirth}");
            Console.WriteLine($"Место рождения: {players[i].birthPlace}");
            Console.WriteLine($"Количество игр: {players[i].gamesPlayed}");
            Console.WriteLine($"Количество желтых карточек: {players[i].yellowCards}");
            Console.WriteLine($"Амлуа: {players[i].amplua}");
            Console.ReadLine();
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
static int CalculateAge(string dateOfBirth)
{
    DateTime birthDate = DateTime.Parse(dateOfBirth);
    DateTime currentDate = DateTime.Now;
    int age = currentDate.Year - birthDate.Year;
    if (currentDate < birthDate.AddYears(age))
    {
        age--;
    }
    return age;
}
    
struct FootballPlayer
{
    public string lastName;
    public string dateOfBirth;
    public string birthPlace;
    public int gamesPlayed;
    public int yellowCards;
    public string amplua;
}