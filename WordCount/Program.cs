// See https://aka.ms/new-console-template for more information

using WordCount;

internal class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        // string path="/Users/darshanuttammistry/Downloads/test.txt";

        var count = new Count();

        if (Console.IsInputRedirected)
        {
            var input = Console.In.ReadToEnd();
            ProcessInput(input, args, count);
            return;
        }
        
        
        
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: ccwc [-c | -l | -w | -m] <file>");
            return;
        }

        if (args.Length == 1)
        {
            string path = args[0];

            if (CheckFileNotExists(path))
            {
                return;
            }

            PrintAllCounts(path, count);
        }
        else if (args.Length == 2)
        {
            string option = args[0];
            string path = args[1];

            if (CheckFileNotExists(path))
            {
                return;
            }

            ProcessFile(option, path, count);

        }
    }

    public static void PrintAllCounts(string path, Count count)
    {
        Console.WriteLine($"Reading File: {path}");
        Console.WriteLine($"Bytes: {count.CountBytes(path)} {path}");
        Console.WriteLine($"Lines: {count.CountLines(path)} {path}");
        Console.WriteLine($"Words: {count.CountWords(path)} {path}");
        Console.WriteLine($"Characters: {count.CountChars(path)} {path}");

    }

    public static void ProcessFile(string option, string path, Count count)
    {
        Console.WriteLine($"Reading File: {path}");

        switch (option)
        {
            case "-c":
                Console.WriteLine($" Characters: {count.CountChars(path)} {path})");
                break;
            case "-l":
                Console.WriteLine($" Lines: {count.CountLines(path)} {path}");
                break;
            case "-w":
                Console.WriteLine($"Words: {count.CountWords(path)} {path}");
                break;
            case "-m":
                Console.WriteLine($"Bytes: {count.CountBytes(path)} {path}");
                break;
            default:
                Console.WriteLine("Invalid Option. Usage: ccwc [-c | -l | -w | -m] <file>");
                break;
            
        }
        
    }

    public static void ProcessInput(string input, string[] args, Count count)
    {
        if (args.Length == 0)
        {
            Console.WriteLine($"Lines: {input.Split('\n').Length}");
            Console.WriteLine($"Words: {input.Split(new char[]{' ', '\n'},StringSplitOptions.RemoveEmptyEntries).Length}");
            Console.WriteLine($"Characters: {input.Length}");
            return;
        }
        else if (args.Length == 1)
        {
            switch (args[0])
            {
                case "-c":
                    Console.WriteLine($" Characters: {input.Length}");
                    break;
                case "-l":
                    Console.WriteLine($" Lines: {input.Split('\n').Length}");
                    break;
                case "-w":
                    Console.WriteLine($"Words: {input.Split(new char[]{' ', '\n'},StringSplitOptions.RemoveEmptyEntries).Length}");
                    break;
                case "-m":
                    Console.WriteLine($"Bytes: {input.Length}");
                    break;
                default:
                    Console.WriteLine("Invalid Option. Usage: ccwc [-c | -l | -w | -m] <file>");
                    break;
            
            }
        }
    }
    
    public static bool CheckFileNotExists(string path)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine($"File {path} does not exist.");
            return true;
        }

        return false;
    }
}