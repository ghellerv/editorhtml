using System.Text;

public static class Editor
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.WriteLine("MODO EDITOR");
        Console.WriteLine("----------");
        Start();
    }

    public static void Start()
    {
        var file = new StringBuilder();

        do
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        }
        // Enquanto não aperta ESC
        while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("-------------");
        Console.WriteLine(" Deseja salvar o arquivo?");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        var salvar = short.Parse(Console.ReadLine());

        if (salvar == 1)
        {
            Console.WriteLine("Caminho do arquivo: ");
            var path = Console.ReadLine();
            using (var fileSave = new StreamWriter(path))
            {
                fileSave.Write(file);
            }
        }


    }
}