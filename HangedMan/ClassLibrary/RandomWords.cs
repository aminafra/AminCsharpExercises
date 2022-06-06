namespace HangedManClasses;

public class RandomWords
{
    private string[] _words = new string[]
    {
        "dotnet", "nodejs", "laravel", "drogon", "django",
        "symfony", "actix", "spring", "csharp", "vuejs",
        "express","flask","cakephp","onrails","fiber",
        "python", "java", "scala", "fsharp", "ruby",
        "cobol", "pascal"
    };
    public string[] Words
    {
        get { return _words; }
    }

    public string Generate()
    {
        Random rnd = new Random();
        int rndIndx = rnd.Next(0, Words.Length);
        string randomWord = Words[rndIndx];
        return randomWord;
    }
}