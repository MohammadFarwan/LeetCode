public class Solution {
    public int CountKeyChanges(string s) {
        string str = s.ToLower();
        char[] chars = str.ToCharArray();
        int count = 0;
        for(int i = 0; i < chars.Length - 1 ; i++)
        {
            int w = i+1;
            if(chars[i] != chars[w])
            {
                count++;
            }
        //  Console.WriteLine(chars[i]);
        }
        return count;
    }
}