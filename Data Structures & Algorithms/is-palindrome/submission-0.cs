public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        string cleanedString = new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();
        int startIndex = 0;
        int endIndex = cleanedString.Length - 1;

        while(startIndex < endIndex)
        {
            if(cleanedString[startIndex] != cleanedString[endIndex])
            {
                return false;
            }

            startIndex++;
            endIndex--;
        }

        return true;
    }
}
