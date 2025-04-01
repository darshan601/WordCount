namespace WordCount;

public class Helper
{
    public static StreamReader GetStreamReader(string path)
    {
        try
        {
            return File.OpenText(path);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File not found" + path);
            throw;
        }
        
    }
}