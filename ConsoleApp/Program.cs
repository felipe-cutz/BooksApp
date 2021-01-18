using BooksApp.Data;
using System;
using System.Linq;
using System.Threading;
using BooksApp.Domain;

namespace ConsoleApp
{
    class Program
    {
        private static BooksContext context = new BooksContext();
      
        static void Main(string[] args)
        {
            context.Database.EnsureCreated();
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

        private static void ShowAuthor()
        {
            throw new NotImplementedException();
        }

        private static void ShowAuthor(string text)
        {
            var authors = context.Authors.ToList();

            Console.WriteLine($"{text}: Se han registrado {authors.Count} autores.");
            foreach (var author in authors)
            {
                Console.WriteLine(author.FirstName + " " + author.LastName);
            }
        }
       

        private static void DeleteAhthor()
        {
            throw new NotImplementedException();
        }

        private static void ModifyAuthor()
        {
            throw new NotImplementedException();
        }

         private static void AddAuthor()
        {
            Console.WriteLine("Agregando un autor.");
            Console.Write("Nombres: ");
            string firstName = Console.ReadLine();
            Console.Write("Apellidos: ");
            string lastName = Console.ReadLine();
            var author = new BooksApp.Data.Author
            {
                FirstName = firstName,
                LastName = lastName
            };
            context.Authors.Add(author);
            context.SaveChanges();
        }
        
    }

}


