using System;
using System.Collections.Generic;

namespace CarsComponents
{
    public enum Side { Left, Right }
    public enum Diraction { Front, Back }

    public class Wheel
    {

        public Side Side { get; set; }
        public Diraction Diraction { get; set; }
        public int AirPressure { get => new Random(DateTime.Now.GetHashCode()).Next(29, 38); }
    }
    public class Car
    {
        public event EventHandler<WheelEventArgs> WheelAirPressureLow;
        List<Wheel> wheels = new List<Wheel>();
        private void CheckAirPressure()
        {
            foreach (var wheel in wheels)
            {
                if (wheel.AirPressure < 34)
                {
                    OnWheelAirPressureLow(wheel);
                }

            }
        }

        private void OnWheelAirPressureLow(Wheel wheel)
        {
            if (WheelAirPressureLow != null)
            {
                WheelAirPressureLow(this, new WheelEventArgs() { Whell = wheel });
            }
        }
    }
}
