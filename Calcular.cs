using System;

namespace PesoTeorico
{
    public static class Calcular{

    public static void BarraRedonda()
    {
            Console.Clear();
            Menu.DrawScreen();
            Console.SetCursorPosition(18,2);
            Console.WriteLine("BARRA REDONDA");
            Console.Write("\n");
            Console.SetCursorPosition(3,5);
            Console.WriteLine("Digite o Diametro da barra: ");
            Console.SetCursorPosition(3,6);
            double diametro = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(3,8);
            Console.WriteLine("Digite a quantidade em Comprimento: ");
            Console.SetCursorPosition(3,9);
            double comprimento = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            const double CFORMULA = 0.0062;  // formula do peso teorico da barra redonda
            double peso = (diametro*diametro)*CFORMULA*comprimento;
            var  pesoBarra = Math.Round(peso,0);

            if (pesoBarra >= 1000)
            {
              var tonelada = pesoBarra / 1000;
              Console.SetCursorPosition(3,11);                
              Console.WriteLine("O Peso teorico é de: {0} t", tonelada); 
            }
              else {
                 Console.SetCursorPosition(3,11);    
                 Console.WriteLine("O Peso teorico é de: {0} kg", pesoBarra);
                   }
            Console.SetCursorPosition(3,15);
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu.Show();       
    }
    public static void BarraQuadrada()
    {
         // Barra Quadrada
            Console.Clear();
            Menu.DrawScreen();
            Console.SetCursorPosition(18,2);
            Console.WriteLine("BARRA QUADRADA");
            Console.Write("\n");
            Console.SetCursorPosition(3,5);
            Console.WriteLine("Digite o Diametro da barra Quadrada: ");
            Console.SetCursorPosition(3,6);
            double diametro = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(3,8);
            Console.WriteLine("Digite a quantidade em Comprimento: ");
            Console.SetCursorPosition(3,9);
            double comprimento = double.Parse(Console.ReadLine());
            
            const double  CFORMULA = 0.0079; // formula do peso teorico da barra quadrada
            double peso = (diametro*diametro)*CFORMULA*comprimento;
            var  pesoBarra = Math.Round(peso,0); 
            
            if (pesoBarra >= 1000)
            {
              var tonelada = pesoBarra / 1000;
              Console.SetCursorPosition(3,11);                
              Console.WriteLine("O Peso teorico é de: {0} t", tonelada); 
            }
              else {
                 Console.SetCursorPosition(3,11);    
                 Console.WriteLine("O Peso teorico é de: {0} kg", pesoBarra);
                   }
            Console.SetCursorPosition(3,15);
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu.Show();    
    }
    public static void Tubo()
    {
            Console.Clear();
            Menu.DrawScreen();
            Console.SetCursorPosition(18,2);
            Console.Write("TUBO");
            Console.Write("\n");
            Console.SetCursorPosition(3,5);
            Console.WriteLine("Digite o Diametro do Tubo:");
            Console.SetCursorPosition(3,6);
            double diametro = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(3,7);
            Console.WriteLine("Digite a Espessura do Tubo");
            Console.SetCursorPosition(3,8);
            double espessura = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(3,9);
            Console.WriteLine("Digite a quantidade em Comprimento: ");
            Console.SetCursorPosition(3,10);
            double comprimento = double.Parse(Console.ReadLine());
            
            const double CFORMULA = 0.02466; // Formula do peso Teorico de Tubo
            double peso = (diametro-espessura)*espessura*CFORMULA*comprimento;
            var pesoTubo = Math.Round(peso,0);
            if (pesoTubo >= 1000)
            {
              var tonelada = pesoTubo/ 1000;
              Console.SetCursorPosition(3,11);                
              Console.WriteLine("O Peso teorico é de: {0} t", tonelada); 
            }
              else {
                 Console.SetCursorPosition(3,11);    
                 Console.WriteLine("O Peso teorico é de: {0} kg", pesoTubo);
                   }
            Console.SetCursorPosition(3,15);
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu.Show();    
        }
   }
}