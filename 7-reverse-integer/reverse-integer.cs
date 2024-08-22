public class Solution {
    public int Reverse(int x) {
        bool isNegative = false;
        if(x <0){
            isNegative = true;
                      if (x == int.MinValue) {
                return 0;
            }
        }
        x= Math.Abs(x);
        string number = x.ToString();
        string result = "";
        for(int i = number.Length-1; i >= 0; i--){
            result = $"{result}{number[i]}";
        }
        try
        {
            int intValue2 = checked((int)int.Parse(result));
            if(isNegative){
                return intValue2 * (-1);
            }
            return intValue2;
        }
        catch (OverflowException)
        {
            return 0;
        }
    }
}