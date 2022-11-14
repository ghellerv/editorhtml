
public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

        DrawScreen();
        WriteOptions();

        var option = short.Parse(Console.ReadLine());
        HandleMenuOption(option);
    }

    public static void DrawScreen()
    {
        Console.WriteLine("Digite o número de linhas: ");
        int numLinhas = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número de colunas: ");
        int numColunas = int.Parse(Console.ReadLine());

        Start(0);
        Console.WriteLine($"Gerando {numLinhas}x{numColunas}...");
        Thread.Sleep(1000);
        Console.Clear();

        Colunas(numColunas);

        for (int lines = 0; lines <= 10; lines++)
        {
            Console.Write("|");
            for (int i = 0; i <= numLinhas; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.Write("\n");
        }

        Colunas(numColunas);
    }

    static void Colunas(int numColunas)
    {
        Console.Write("+");
        for (int i = 0; i <= numColunas; i++)
        {
            Console.Write("-");
        }

        Console.Write("+");
        Console.Write("\n");
    }

    static void Start(int time)
    {
        int currentTime = 4;

        while (currentTime > time)
        {
            Console.Clear();
            currentTime--;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000); // Processador dormir por 1 segundo.
        }

        Console.Clear();
    }

    public static void WriteOptions()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("=========");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Selecione uma posição: ");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("1 - Novo Arquivo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("2 - Abrir");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("0 - Sair");
        Console.SetCursorPosition(3, 10);
        Console.Write("Opção: ");
    }

    public static void HandleMenuOption(short option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("View"); break;
            case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
            default: Show(); break;
        }
    }
}