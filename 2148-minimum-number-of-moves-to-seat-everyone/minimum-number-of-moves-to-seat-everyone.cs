public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
        int sum = 0;
        Array.Sort(seats);
        Array.Sort(students);
        for(int i = 0; i < seats.Length; i++){
            sum += Math.Abs(seats[i] - students[i]);
        }
        return sum;
    }
}