using System;

namespace Rotate_Image
{
  class Program
  {
    static void Main(string[] args)
    {
      int[][] matrix = new int[3][] { new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 }, new int[3] { 7, 8, 9 } };
      Solution s = new Solution();
      s.Rotate(matrix);
      foreach (var row in matrix)
        Console.WriteLine(string.Join(",", row));
    }
  }

  public class Solution
  {
    public void Rotate(int[][] matrix)
    {
      int length = matrix.Length;
      // Matrix transform
      for (int i = 0; i < length; i++)
      {
        for (int j = i; j < length; j++)
        {
          if (i == j) continue;
          int temp = matrix[i][j];
          matrix[i][j] = matrix[j][i];
          matrix[j][i] = temp;
        }
      }

      // Swap last index with first and so on
      for (int i = 0; i < length; i++)
      {
        int m = 0, n = length - 1;
        while (m < n)
        {
          int temp = matrix[i][m];
          matrix[i][m] = matrix[i][n];
          matrix[i][n] = temp;
          m++; n--;
        }
      }
    }
  }
}
