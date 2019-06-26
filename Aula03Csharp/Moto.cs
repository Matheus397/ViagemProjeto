using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03Csharp
{
    public class Moto : Veiculo
    {
        public int Cilindradas;
        public Moto()
        {

        }

        public void Dirigir(decimal xKms, string clima)
        {

            if (qtdeKm() >= xKms)
            {
                Console.WriteLine($"A moto avançou {qtdeKm()} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms, clima), 2)} litros.");
                viajado += xKms;
            }
            else
            {
                
                Console.WriteLine($"A moto avançou {qtdeKm()} quilometro(s). Combustível atual : {0} litros. - Abasteça-a!");
                QntTanqueAtual = 0;
                viajado += qtdeKm();
            }
        }

        public decimal Consumo(decimal xKms, string clima)
        {
            if (FiltroCombustivelEntupido || clima == "RUIM")
                return QntTanqueAtual -= xKms / ( KmPorLitro + (KmPorLitro * 20 / 100));
      
            else if (FiltroCombustivelEntupido && clima == "RUIM")

                return QntTanqueAtual -= xKms / (KmPorLitro + (KmPorLitro * 40 / 100));

            else
                return QntTanqueAtual -= xKms / KmPorLitro;

        }

    }
}
