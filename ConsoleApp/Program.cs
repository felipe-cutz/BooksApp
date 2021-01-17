using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char lectura;
            do
            {
                Console.WriteLine("[A]gregar autor | [M]odificar autor | [E]liminar autor | " +
                    "[V]er autores | [S]alir");
                Console.Write("Selecciona una opción: ");
                lectura = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                switch (lectura)
                {
                    case 'A':
                        AddAuthor();
                        break;
                    case 'M':
                        ModifyAuthor();
                        break;
                    case 'E':
                        DeleteAhthor();
                        break;
                    case 'V':
                        ShowAuthor();
                        break;
                    case 'S':
                        Console.WriteLine("Adios. Programa finalizado.");
                        break;
                    default:
                        break;
                }
             
                
                Console.WriteLine();
            } while (lectura != 'S');
                Console.WriteLine("");
            





        }


         static void ShowAuthor()
        {
            Console.WriteLine("Mostrando autores...");
        }

        private static void DeleteAhthor()
        {
            throw new NotImplementedException();
        }

        private static void ModifyAuthor()
        {
            throw new NotImplementedException();
        }

         static void AddAuthor()
        {
            Console.WriteLine("Agregando autor...");
        }
        
        
    }

}


