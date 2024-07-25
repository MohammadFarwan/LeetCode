public class Solution {
    public string ReversePrefix(string word, char ch) {
        var index = word.IndexOf(ch);        
        if(index == -1) return word;
        var wordArr = word.ToCharArray();
        Array.Reverse(wordArr, 0, index + 1);
        return new string(wordArr);
    }
}