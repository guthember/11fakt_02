using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoProgram
{
  class Program
  {
    static void Main(string[] args)
    {
      // változó bevezetése
      // String nev = "Nagy János"
      // típus -> String
      // neve -> nev
      // tartalma -> "Nagy János" (kezdő érték megadása nem kötelező)
      String nev; // név tárolására

      Console.Write("Írd be a neved: ");
      nev = Console.ReadLine();

      Console.Write("Hello ");
      Console.WriteLine(nev);

      Console.ReadKey();
    }
  }
}