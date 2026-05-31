public class Solution 
{
    private List<string> res = new List<string>();
    private Dictionary<char, string> digitToChar = new Dictionary<char, string> 
    {
        {'2', "abc"}, {'3', "def"}, {'4', "ghi"}, {'5', "jkl"},
        {'6', "mno"}, {'7', "qprs"}, {'8', "tuv"}, {'9', "wxyz"}
    };

    public List<string> LetterCombinations(string digits) 
    {
        if (digits.Length == 0) 
        {
            return res;
        }

        Backtrack("", digits);
        return res;
    }

    private void Backtrack(string curStr, string digits) 
    {
        int index = curStr.Length;

        if (index == digits.Length) 
        {
            res.Add(curStr);
            return;
        }

        foreach (char c in digitToChar[digits[index]]) 
        {
            Backtrack(curStr + c, digits);
        }
    }
}
