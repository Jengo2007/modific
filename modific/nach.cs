using System;
namespace modific
{
    class HomeDevice
    {
        private string DeviceName;
        protected int EnergyConsumption;
        private bool IsOn;

        public string GetDeviceName
        {
            get { return DeviceName; }
            set { DeviceName = value; }
        }

        public int GetEnergyConsumption
        {
            get { return EnergyConsumption; }
            set { EnergyConsumption = value; }
        }

        public bool GetIsOn
        {
            get { return IsOn; }
            set { IsOn = value; }
        }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Turned On");
            
            
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Turned Off");
        }

        public void SetEnergyConsumption(int value)
        {
            EnergyConsumption += value;
            Console.WriteLine("Уровень потребления энергии "+EnergyConsumption);
        }
      

     

        public HomeDevice(string DeviceName, int EnergyConsumption,bool IsOn)
        {
            this.DeviceName = DeviceName;
            this.EnergyConsumption = EnergyConsumption;
            this.IsOn = IsOn;
        }
        
           
            
        
    }
}