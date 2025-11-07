using System;
using System.Collections;

namespace Apalabrados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Pantalla principal
                Console.Title = "Apalabrados";
                Console.WriteLine("Este es un juego de trivia con puntaje. ¿Estás listo para el desafío?");
                Console.Write("Ingresa tu nombre: ");
                string nombre = Console.ReadLine();
                bool playagain = true;

                while (playagain)
                {
                    int puntaje = 0;

                    // Preguntas
                    string[] preguntas = {
                        "¿Quién creó la teoría de la relatividad general?",
                        "¿Cuánto es aproximadamente el número e (Euler)?",
                        "¿Cuántos Estados tiene Estados Unidos?"
                    };

                    // Opciones
                    string[,] opciones = {
                        { "Albert Einstein", "Obama", "Isaac Newton" },
                        { "2.71", "3.14", "1.78" },
                        { "cincuenta", "cincuenta y uno", "cincuenta y dos" }
                    };

                    // Respuestas correctas 
                    int[] rightansw = { 0, 0, 0 };

                    // Mostrable
                    for (int i = 0; i < preguntas.Length; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"Pregunta {i + 1}: {preguntas[i]}");

                        for (int j = 0; j < opciones.GetLength(1); j++)
                        {
                            Console.WriteLine($"{j}. {opciones[i, j]}");
                        }

                        Console.Write("Tu respuesta (0-2): ");
                        //Comprobar respuesta
                        try
                        {
                            int respuesta = int.Parse(Console.ReadLine());
                            if (respuesta == rightansw[i])
                            {
                                Console.WriteLine("¡Respuesta Correcta! +10 pts");
                                puntaje += 10;
                            }
                            else
                            {
                                Console.WriteLine("Nope, respuesta incorrecta. +0 pts");
                            }
                        }
                        //manejo de excepciones
                        catch (FormatException)
                        {
                            Console.WriteLine("⚠ Entrada inválida. Se cuenta como incorrecta.");
                        }

                        Console.WriteLine("Presiona ENTER para continuar...");
                        Console.ReadLine();
                    }
                    //Mostrar resultados
                    Console.WriteLine($"\n{nombre}, tu puntaje final es: {puntaje} puntos.");
                    Console.Write("¿Quieres jugar otra vez? (s/n): ");
                    string repetir = Console.ReadLine().ToLower();
                    playagain = repetir == "s";
                }

                Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Se ha producido un error en el funcionamiento del código.");
            }
        }
    }
}
