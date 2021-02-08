using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {

        }
        public double EngineSize { get; set; } = 6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F-150";
        public int SetCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";

        public bool HasFourWheelDrive { get; set; } = true;

        public bool HasChangedGears { get; set; }


        

       
        public int SeatCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears!");
            }

        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park");
                HasChangedGears = false;
                }
            else
            {
                Console.WriteLine("Can't park until we change gears!");
            }
        }

        public void ChangedGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        //bool IVehicle.ChangedGears(bool isChanged)
        //{
        //    throw new NotImplementedException();
        //}
    }

}






