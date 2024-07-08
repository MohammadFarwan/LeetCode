public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int> numbers = new List<int>();
        for(int i = 0; i < words.Length; i++) {
            if(words[i].Contains(x))
            numbers.Add(i);
        }
        return numbers;
    }
}