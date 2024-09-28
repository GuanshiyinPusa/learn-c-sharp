Console.WriteLine("Enter the number of students:");
int listlen = Console.ReadLine();
int[] studentScores = new int[listlen];
int sum = 0;
foreach (int num in listlen) {
  Console.WriteLine("Enter the grade for student" num ": ");
  int score = Console.ReadLine();
  studentScores = AddElement(studentScores, score);
  sum += score;
}
int average = sum / listlen;
Console.WriteLine(average);
