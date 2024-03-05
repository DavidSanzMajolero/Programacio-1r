using System;
using System.IO;

namespace AdvCalendar
{
    public class Program
    {
        public static void Main()
        {
            int result = 0;
            const string numString = "one two three four five six seven eight nine";
            const string rutaArchivo = @"C:\Users\argo\Desktop\David Sanz\Programacio\C#\m3\UF4\Files_TXT\input.txt";

            string[] lineas = File.ReadAllLines(rutaArchivo);

            foreach (string linea in lineas)
            {
                int primerNumero = 0;
                int ultimoNumero = 0;

                for (int i = 0; i < linea.Length; i++)
                {
                    if (char.IsDigit(linea[i]))
                    {
                        primerNumero = linea[i] - '0';
                        break;
                    }
                    else if (numString.Contains(linea[i].ToString()))
                    {
                        switch (linea[i].ToString())
                        {
                            case "one":
                                primerNumero = 1;
                                break;
                            case "two":
                                primerNumero = 2;
                                break;
                            case "three":
                                primerNumero = 3;
                                break;
                            case "four":
                                primerNumero = 4;
                                break;
                            case "five":
                                primerNumero = 5;
                                break;
                            case "six":
                                primerNumero = 6;
                                break;
                            case "seven":
                                primerNumero = 7;
                                break;
                            case "eight":
                                primerNumero = 8;
                                break;
                            case "nine":
                                primerNumero = 9;
                                break;
                        }
                        break;
                    }
                }

                for (int i = linea.Length - 1; i >= 0; i--)
                {
                    if (char.IsDigit(linea[i]))
                    {
                        ultimoNumero = linea[i] - '0';
                        break;
                    }
                    else if (numString.Contains(linea[i].ToString()))
                    {
                        switch (linea[i].ToString())
                        {
                            case "one":
                                ultimoNumero = 1;
                                break;
                            case "two":
                                ultimoNumero = 2;
                                break;
                            case "three":
                                ultimoNumero = 3;
                                break;
                            case "four":
                                ultimoNumero = 4;
                                break;
                            case "five":
                                ultimoNumero = 5;
                                break;
                            case "six":
                                ultimoNumero = 6;
                                break;
                            case "seven":
                                ultimoNumero = 7;
                                break;
                            case "eight":
                                ultimoNumero = 8;
                                break;
                            case "nine":
                                ultimoNumero = 9;
                                break;
                        }
                        break;
                    }
                }

                result += int.Parse(primerNumero.ToString() + ultimoNumero.ToString());
            }

            Console.WriteLine(result);
        }
    }
}
