public class ReverseStr
{
    public void ReverseString(string str)
    {
        char[] chars = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            chars[i] = str[str.Length - 1 - i];
        }
    }
}

