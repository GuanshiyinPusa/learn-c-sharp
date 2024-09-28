using System;

namespace DataTypeApplication {
class Program {
  static void Main(string[] args) {
    Console.WriteLine("Size of int: {0}", sizeof(int));
    Console.WriteLine("Size of short: {0}", sizeof(short));
    Console.WriteLine("Size of long: {0}", sizeof(long));
    Console.WriteLine("Size of float: {0}", sizeof(float));
    Console.WriteLine("Size of double: {0}", sizeof(double));
    Console.WriteLine("Size of decimal: {0}", sizeof(decimal));
    Console.ReadLine();
  }
}
}
