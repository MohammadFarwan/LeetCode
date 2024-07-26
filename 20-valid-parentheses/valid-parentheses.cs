public class Solution {
    public bool IsValid(string s) {
        if (s.Length <= 1)
            return false;

        var bracketQueue = new List<int>();
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                bracketQueue.Add(1);
                continue;       
            }
            if (s[i] == '[')
            {
                bracketQueue.Add(2);
                continue;       
            }
            if (s[i] == '{')
            {
                bracketQueue.Add(3);
                continue;       
            }
            if (bracketQueue.Count == 0)
                return false;
            if (s[i] == ')' && bracketQueue[bracketQueue.Count - 1] == 1)
            {
                bracketQueue.RemoveAt(bracketQueue.Count - 1);
                continue;
            }
            if (s[i] == ']' && bracketQueue[bracketQueue.Count - 1] == 2)
            {
                bracketQueue.RemoveAt(bracketQueue.Count - 1);
                continue;
            }
            if (s[i] == '}' && bracketQueue[bracketQueue.Count - 1] == 3)
            {
                bracketQueue.RemoveAt(bracketQueue.Count - 1);
                continue;
            }
            
            return false;
        }
        return bracketQueue.Count == 0;
    }
}