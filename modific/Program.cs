using System;
using System.Net.Http.Headers;

namespace modific
{
    
    class Program
    {
        static void Main(string[] args)
        {
            AirConditioner airConditioner = new AirConditioner();
            Console.WriteLine("Кондиционер:"+airConditioner.GetDeviceName);
            Console.WriteLine(airConditioner.GetEnergyConsumption+"V");
            Console.WriteLine(airConditioner.GetIsOn);
            airConditioner.SetEnergyConsumption(13);
            Heater heater = new Heater();
            Console.WriteLine("Обогреватель:"+heater.GetDeviceName);
            Console.WriteLine(heater.GetEnergyConsumption+"V");
            Console.WriteLine(heater.GetIsOn);
            heater.SetEnergyConsumption(23);
            
        }
    }
}