using System;

namespace p06_pizza
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0 || args.Length < 3){
                Menu();
                return 1;
            }
            char tam = char.Parse(args[0].ToUpper());
            string tamano = "";

            if (tam == 'P')
                tamano = "Pequeña";
            else if (tam == 'M')
                tamano = "Mediana";
            else
                tamano = "Grande";

            // Ingrediente
            string[] ings = args[1].Split("+");
            string ingredientes = "";
            foreach (string i in ings)
            {
                switch (char.Parse(i.ToUpper()))
                {
                    case 'C':
                        ingredientes += "Champiñones "; break;
                    case 'E':
                        ingredientes += "Extraqueso "; break;
                    case 'P':
                        ingredientes += "Piña "; break;
                    case 'T':
                        ingredientes += "Tomates "; break;
                }
            }

            char cub = char.Parse(args[2].ToUpper());
            string cubierta = "";
            if (cub == 'D')
                cubierta = "Delgada";
            else
                cubierta = "Gruesa";

            char lug = char.Parse(args[3].ToUpper());
            string lugar = lug == 'A' ? "Aqui" : "Llevar";

            Console.WriteLine("Tu pizza es de tamaño: {0}",tamano);
            Console.WriteLine("Ingredientes: {0}", ingredientes);
            Console.WriteLine("Cubierta: {0}", cubierta);
            Console.WriteLine("Lugar: {0}", lugar);
            return 0;
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Tamaño: (P)equeña, (M)ediana, (G)rande");
            Console.WriteLine("Ingredientes: C hampiñones + E xtra queso + P iña + T omates");
            Console.WriteLine("Cubierta: (D)elgada, (G)ruesa");
            Console.WriteLine("Donde: (A)qui, (L)levar");
        }
    }
}