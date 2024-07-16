public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        if (image[0].Length == 1)
            {
                if (image[0][0] == 0)
                    image[0][0] = 1;
                else
                    image[0][0] = 0;
            }
            else if (image[0].Length > 1 && image[1].Length > 1)
            {
                for (int i = 0; i < image[0].Length; i++)
                {
                    int s = 0, e = image[1].Length - 1;
                    while (s < e)
                    {
                        (image[i][s], image[i][e]) = (image[i][e], image[i][s]);
                        s++; e--;
                    }

                    int n = 0;
                    while (n < image[1].Length)
                    {
                        if (image[i][n] == 0)
                            image[i][n] = 1;
                        else
                            image[i][n] = 0;

                        n++;
                    }
                }
            }

            return image;
    }
}