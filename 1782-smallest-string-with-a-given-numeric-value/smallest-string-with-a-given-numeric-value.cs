public class Solution {
    const int maxChar = 26;
    public string GetSmallestString(int n, int k) {
        int kLeft = k;
        char[] charArray = new char[n];
        for(int i=n; i>0; --i)
        {
            int minimumNeeded = i-1;
            int availableK = kLeft - minimumNeeded;
            int currentCharValue = Math.Min(availableK, maxChar);
            charArray[i-1] = (char)(currentCharValue + 'a' - 1);
            kLeft -= currentCharValue;
            // Console.WriteLine(charArray);
        }

        return new string(charArray);
    }
}