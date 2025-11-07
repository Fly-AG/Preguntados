using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Apalabrados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Pantalla principal
                Console.Title = "Apalabrados";
                Console.WriteLine("Esto juego de trivia con puntuaje, ¿estás listo para el desafío?");
                Console.Write("Ingresa tu nombre: ");
                String nombre = Console.ReadLine();
                bool playagain = true;

                while (playagain = true)
                {
                    int puntuaje = 0;
                    //preguntas
                    string[] preguntas = {
                        "¿Quién creó la teoría de la relatividad general?",
                        "¿Cuánto es aproximadamente el numero e (euler)?",
                        "¿Cuántos Estados tiene los Estados Unidos?"
                    //opciones
                    };
                    string[,] opciones = {
                        { "Albert Einstein", "Obama", "Isaac Newton" },
                        { "2.71", "3.14", "1.78" },
                        { "cincuenta", "cincuenta y uno", "cincuenta y dos" }

                    };
                    //respuestas
                    int[] rightansw = { 1, 1, 1 };

                    for (int i = 0; i < preguntas.Length; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"Pregunta {i + 1}: {preguntas[i]}");
                        for (int j = 0; j < 4; j++)
                        {
                            Console.WriteLine($"{j}. {opciones[i, j]}");
                        }
                        Console.Write("Tu respuesta (0-3): ");
                    

                        }
                    }
            }
            catch (FormatException)
            {
                Console.Write("Ha ocurrido un error en el funcionamiento del código, por favor ingrese los datos correspondientes");
            }

        }
    }
}
