using System;
using System.Globalization;
// sera acrescentado o peso de chapa 
namespace PesoTeorico
{
public static class Menu {
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkBlue; // cor de fundo
        Console.ForegroundColor = ConsoleColor.White; // cor da letra

        DrawScreen();
        WriteOptions();

        short escolha = short.Parse(Console.ReadLine());
        HandleMenuEscolha(escolha);

    }

    public static void DrawScreen()
        {
            // linha horizontal  +---------------+
            Console.Write("+");
            for (int i = 0; i <50; i++)
                Console.Write("-");

                Console.Write("+");
                Console.Write("\n");
            // fim linha horizontal.

            // LINHA VERTICAL |
            for(int lines =0; lines <=10; lines++)
            {
                Console.Write("|");
                for (int i=1; i<=50;i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            } // FIM LINHA VERTICAL

            Console.Write("+");
            for (int i = 0; i <50; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");  
        }


    public static void WriteOptions()
    {
        Console.SetCursorPosition(18,2);
        Console.WriteLine("PESO TEORICO");
        Console.SetCursorPosition(16,3);
        Console.WriteLine("=================");
        Console.SetCursorPosition(3,4);
        Console.WriteLine("Selecione uma opção abaixo para saber o peso:");
        Console.SetCursorPosition(18,6);
        Console.WriteLine("1 - BARRA REDONDA");
        Console.SetCursorPosition(18,7);
        Console.WriteLine("2 - BARRA QUADRADA");
        Console.SetCursorPosition(18,8);
        Console.WriteLine("3 - TUBO");
        Console.SetCursorPosition(18,10);
        Console.WriteLine("0 - SAIR");
    }

    public static void HandleMenuEscolha(short escolha)

    {

        switch (escolha)
        {
            case 1: Calcular.BarraRedonda();break;
            case 2: Calcular.BarraQuadrada(); break;
            case 3: Calcular.Tubo(); break;
            case 0: {
                    Console.Clear();
                    Console.WriteLine("Obrigado por usar nossos serviços!");
                    Environment.Exit(0);
                    break;
                    }
            default: Show(); break;
        }
    }


    }
      
    }


