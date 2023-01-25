using System.Reflection;
using Reflection;

void ListInObject<T>(T x)
{
  var type = x.GetType();

  Console.WriteLine(string.Join("\n", type.GetRuntimeProperties()));
  Console.WriteLine(string.Join("\n", type.GetRuntimeMethods()));
}

T Instantiate<T>()
  => Activator.CreateInstance<T>();

var console = new Videogame()
{
  Id = 123,
  Name = "PS5",
  Fabricante = "Sony",
  Nota = 9
};

var num = 1;

ListInObject(console);
Console.WriteLine("\n------------------\n");
ListInObject(num);
Console.WriteLine("\n------------------\n");

var console2 = Instantiate<Videogame>();
Console.WriteLine(console2);
