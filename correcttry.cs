using System;

class Program {
  static void Main(string[] args) {
    Console.WriteLine("Enter the number of students:");
    int listlen = int.Parse(Console.ReadLine());
    int[] studentScores = new int[listlen];
    int sum = 0;

    for (int i = 0; i < listlen; i++) {
      Console.Write($"Enter grade for student {i + 1}: ");
      int score = int.Parse(Console.ReadLine());
      studentScores[i] = score;
      sum += score;
    }

    double average = (double)sum / listlen;
    Console.WriteLine($"Average score: {average:F2}");
  }
}
