using System;

namespace Assignment01_Drone
{
    class Drone
    {
        private int batteryLife;
        private int altitude;
        private bool isFlying;

        public Drone(int battery)
        {
            batteryLife = battery;
            altitude = 0;
            isFlying = false;
        }
        
        public void Fly()
        {
            if (batteryLife > 20)
            {
                isFlying = true;
                altitude = 100;
                Console.WriteLine("Drone is flying.");
            }
            else
            {
                Console.WriteLine("Battery too low to fly.");
            }
        }

        public void Move()
        {
            if (isFlying)
            {
                Console.WriteLine("Drone is moving.");
                batteryLife -= 10;
            }
            else
            {
                Console.WriteLine("Drone cannot move because it is not flying.");
            }
        }

        public void Land()
        {
            if (isFlying)
            {
                isFlying = false;
                altitude = 0;
                Console.WriteLine("Drone has landed.");
            }
            else
            {
                Console.WriteLine("Drone is already on the ground.");
            }
        }

        public void ShowBattery()
        {
            Console.WriteLine("Battery Life: " + batteryLife + "%");
        }

        public void ShowAltitude()
        {
            Console.WriteLine("Altitude: " + altitude + " meters");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Drone drone = new Drone(80);

            drone.Move();

            drone.Fly();

            drone.Move();

            drone.ShowBattery();

            drone.ShowAltitude();

            drone.Land();

            drone.ShowAltitude();
        }
    }
}