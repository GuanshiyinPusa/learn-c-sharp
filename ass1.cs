Console.WriteLine(@"Hello!
What do you want to do?
[S]ee all TODOs
[A]dd a TODO
[R]emove a TODO
[E]xit");

ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Read a key press
char option = char.ToUpper(
    keyInfo.KeyChar); // Get the character and convert it to uppercase

Console.WriteLine(); // Move to the next line after the key press

switch (option) {
case 'S':
  Console.WriteLine("Showing all TODOs...");
  break;

case 'A':
  Console.WriteLine("Adding a TODO...");
  break;

case 'R':
  Console.WriteLine("Removing a TODO...");
  break;

case 'E':
  Console.WriteLine("Exiting...");
  Environment.Exit(0); // Exit the program
  break;

default:
  Console.WriteLine("Incorrect input, please choose S, A, R, or E.");
  break;
}
