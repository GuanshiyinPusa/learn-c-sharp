using System;

namespace TypeConvertApplication {
class StringConversion {
  static void Main(string[] args) {
    int i = 75;
    float f = 53.005f;
    double d = 2345.7652;
    bool b = true;
    string s = "56.7";
    int j = 1;
    string t = "2000-9-10";

    Console.WriteLine(i.ToString());
    Console.WriteLine(f.ToString());
    Console.WriteLine(d.ToString());
    Console.WriteLine(b.ToString());
    Console.WriteLine(Convert.ToDouble(s));
    Console.WriteLine(Convert.ToBoolean(j));
    Console.WriteLine(Convert.ToDateTime(t));
    Console.ReadKey();
  }
}
}
