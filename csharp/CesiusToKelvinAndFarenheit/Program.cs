using System;

namespace CesiusToKelvinAndFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //C to F --> ( (C * 9) / 5) + 32 )
            //F to C --> ((( F - 32 ) * 5) / 9)

            string inputOption, inputTemperature;
            double temperature;

            Console.WriteLine("A qué grados quieres convertir? (Celsius/Farenheit).");

            inputOption = Console.ReadLine();

            Console.WriteLine("Dime los grados.");

            inputTemperature = Console.ReadLine();
            
            temperature = Double.Parse(inputTemperature);

            if(inputOption == "Farenheit")
            {
                temperature = (((temperature - 32) * 5) / 9);
                
                Console.WriteLine($"La temperatura en Celsius es {temperature}");
            }
            else
            {
                temperature = (((temperature * 9) / 5) + 32);

                Console.WriteLine($"La temperatura en Farenheit es {temperature}");
            }
        }
    }
}
