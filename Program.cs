using System; 
// sera acrescentado o peso de chapa 
namespace PesoTeorico
{
class Program {
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("|=|=|=|=| Escolha o Material que deseja saber o Peso teorico por metro: |=|=|=|=|");
        Console.WriteLine("-------------------");

        Console.WriteLine("1 - BARRA REDONDA");
        Console.WriteLine("2 - BARRA QUADRADA");
        Console.WriteLine("3 - TUBO");
        Console.WriteLine("4 - SAIR");

        Console.WriteLine("-------------------");
        Console.WriteLine("Selecione uma opção: ");

        short escolha = short.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1: BarraRedonda();break;
            case 2: BarraQuadrada(); break;
            case 3: Tubo(); break;
            case 4: Sair();break;
            default: Menu(); break;
        }
    }

    static void BarraRedonda()
    {
        Console.Clear();

                Console.WriteLine("Digite o Diametro da barra redonda: ");
                double diametro = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade em Comprimento para  Saber o Peso: (ex:6, 12,100...)");
                double comprimento = double.Parse(Console.ReadLine());

                const double CFORMULA = 0.0062;
            // formula do peso teorico da barra redonda
                double peso = (diametro*diametro)*CFORMULA*comprimento;
                 var  pesoBarra = Math.Round(peso,0);                
                Console.WriteLine("O Peso teorico é de: {0}Kg ", pesoBarra);

                Console.ReadKey();
                Menu();               
    }

    static void BarraQuadrada()
    {
         // Barra Quadrada
            Console.Clear();
            Console.WriteLine("Digite o Diametro da barra Quadrada: ");
            double diametro = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade em Comprimento para Saber o Peso: (ex:6, 12,100...)");
            double comprimento = double.Parse(Console.ReadLine());
            // formula do peso teorico da barra quadrada
            const double  CFORMULA = 0.0079;
            double peso = (diametro*diametro)*CFORMULA*comprimento;
            var  pesoBarra = Math.Round(peso,0);          
            Console.WriteLine("O Peso teorico é de: {0}Kg ", pesoBarra);
            Console.ReadKey();
            Menu();
    }
    static void Tubo()
    {
        Console.Clear();
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
        Console.ReadKey();
        Menu();
        }
    static void Sair ()
    {
          Console.Clear();
          Console.WriteLine("|||||||-Obrigado por usar nossos serviços!!!-|||||||");
          System.Environment.Exit(0);
    }

    }
}

// APÓS CALCULAR UMA VEZ PERGUNTA SE DESEJA CALCULAR NOVAMENTE.
        /* do{
            Console.WriteLine("Novo Calculo? [1]sim [2]não");
            selecione=int.Parse(Console.ReadLine());
            } while(selecione != 1 && selecione != 2);

             if (selecione==1){  
                    goto inicio;
            }
            else if (selecione ==2){
               Console.Clear();
               Console.WriteLine("Obrigado por usar nossos serviços!!!");
                }
    }
}
}*/