using System;

namespace PesoTeorico
{
    public static class Calcular{

    public static void BarraRedonda()
    {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("BARRA REDONDA");
            Console.WriteLine("---------------");
            Console.WriteLine("Digite o Diametro da barra: ");
            double diametro = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade em Comprimento: (ex:6, 12,100...)");
            double comprimento = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            const double CFORMULA = 0.0062;
            // formula do peso teorico da barra redonda
            double peso = (diametro*diametro)*CFORMULA*comprimento;
            var  pesoBarra = Math.Round(peso,0);                
            Console.WriteLine("O Peso teorico é de: {0} kg", pesoBarra);
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu.Show();       
    }
    public static void BarraQuadrada()
    {
         // Barra Quadrada
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("BARRA QUADRADA");
            Console.WriteLine("---------------");
            Console.WriteLine("Digite o Diametro da barra Quadrada: ");
            double diametro = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade em Comprimento para Saber o Peso: (ex:6, 12,100...)");
            double comprimento = double.Parse(Console.ReadLine());
            // formula do peso teorico da barra quadrada
            const double  CFORMULA = 0.0079;
            double peso = (diametro*diametro)*CFORMULA*comprimento;
            var  pesoBarra = Math.Round(peso,0);          
            Console.WriteLine("O Peso teorico é de: {0}Kg ", pesoBarra);
            
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu.Show();   
    }
    public static void Tubo()
    {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("BARRA QUADRADA");
            Console.WriteLine("---------------");
            Console.WriteLine("Digite o Diametro do Tubo:");
            double diametro = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Espessura do Tubo");
            double espessura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade em Comprimento para saber o peso: (ex:6, 12 , 100...)");
            double comprimento = double.Parse(Console.ReadLine());
            // Formula do peso Teorico de Tubo
            const double CFORMULA = 0.02466;
            double peso = (diametro-espessura)*espessura*CFORMULA*comprimento;
            var pesoTubo = Math.Round(peso,0);
            Console.WriteLine("O peso teorico é de: {0}Kg",pesoTubo);
            
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu.Show();  
        }
   }
}