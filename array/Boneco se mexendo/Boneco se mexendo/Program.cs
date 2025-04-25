// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
while (true)
{
    Console.Clear();
    DesenharBoneco(true);
    Thread.Sleep(500); // Espera meio segundo

    Console.Clear();
    DesenharBoneco(false);
    Thread.Sleep(500);
}
    

    static void DesenharBoneco(bool bracosLevantados)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("   O   "); // Cabeça
    if (bracosLevantados)
    {
        Console.WriteLine("  /|\\ "); // Braços para cima
    }
    else
    {
        Console.WriteLine("  \\|/ "); // Braços para baixo
    }
    Console.WriteLine("   |   "); // Tronco
    Console.WriteLine("  / \\ "); // Pernas




}
