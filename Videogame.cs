using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
  internal class Videogame
  {
    public long Id { get; set; }
    public string Name { get; set; }
    public string Fabricante { get; set; }
    public int Nota { get; set; }

    private void Fabricar()
      => Console.WriteLine($"{Name} fabricado");

    public void Vender()
      => Console.WriteLine($"{Name} vendido com sucesso");
  }
}
