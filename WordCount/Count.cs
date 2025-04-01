using System.Text.RegularExpressions;

namespace WordCount;

public class Count
{
    private int c_count;

    public Count()
    {
        this.c_count = 0;
    }

    public int CountBytes(string fileName)
    {
        using (FileStream fs=File.OpenRead(fileName))
        {
            return (int)fs.Length;
        }
        

    }

    public int CountLines(string fileName)
    {
        int count = 0;
        var sr=Helper.GetStreamReader(fileName);
        string line = "";
        while ((line=sr.ReadLine())!=null)
        {
            count++;
        }
        return count;
    }

    public int CountWords(string fileName)
    {
        
        var sr=Helper.GetStreamReader(fileName);
        
        var words = Regex.Split(sr.ReadToEnd(),@"[\s]+");
        
        return words.Length-1;
        
    }

    public int CountChars(string fileName)
    {
        var sr=Helper.GetStreamReader(fileName);

        var chars = sr.ReadToEnd().ToCharArray().Length;
        
        return chars;
    }
    
    
}