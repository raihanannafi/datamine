public class StringManipulator
{
    public string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public string CapitalizeString(string input)
    {
        return input.ToUpper();
    }

    public int CountOccurrences(string input, char character)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == character)
                count++;
        }
        return count;
    }
    public bool IsPalindrome(string input)
    {
        // Remove non-alphanumeric characters and convert to lowercase
        string cleanedInput = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();

        // Compare the cleaned input with its reversed version
        string reversed = ReverseString(cleanedInput);
        return cleanedInput.Equals(reversed);
    }

}