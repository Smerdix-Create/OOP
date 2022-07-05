public class ReverseStr
{
    public void ReverseString(string str)
    {
        char[] chars = str.ToCharArray();
        for (int i = 0; i < str.Length; i++)
        {
            chars[i] = str[str.Length - 1 - i];
        }
        Console.WriteLine(chars);
    }
}

