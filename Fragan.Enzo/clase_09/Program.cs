using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehiculos;

namespace clase_09
{
  class Program
  {
    static void Main(string[] args)
    {
      Auto miAuto = new Auto("AFG44RT58",4, EMarca.Fiat,6);
      Moto miMoto = new Moto("OHJD5J4F5",2,EMarca.Iveco,32);
      Camion miCamion = new Camion("H59T82YF7",8,EMarca.Zanella,10);

      lavadero miLavadero = new lavadero(10, 12, 30);

      miLavadero += miAuto;
      miLavadero += miMoto;
      miLavadero += miCamion;

      Console.WriteLine(miLavadero.ToString());
      Console.ReadLine();
    }
  }
}
