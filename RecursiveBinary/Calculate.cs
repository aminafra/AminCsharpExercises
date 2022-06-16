namespace RecursiveBinary;

public class Calculate
{
    public int DecToBin(int dec)
    {
        int result;
        if (dec != 0)
        {
            result = DecToBin(dec / 2) + (dec % 2);
            Console.Write(result);
            return 0;
        }
        else
        {
            return 0;
        }
    }
}