using NetTopologySuite.Geometries;
using VehicleModel.Classes;

namespace VehicleModel
{
    /// <summary>
    /// Класс "Автомобиль"
    /// </summary>
    abstract class Car : Vehicle
    {
        public string Model { protected set; get; }
        public int PassengerCount { protected set; get; }
        public int PassengerCapacity { protected set; get; }

        public Car(string model, int passengerCapacity, Coordinate coordinate, double speed) 
            : base(coordinate, speed)
        {
            PassengerCount = 0;
            Model = model;
            PassengerCapacity = passengerCapacity;
            Speed = speed;
            Coordinate = coordinate;
        }

        /// <summary>
        /// Посадка пассажиров в салон
        /// </summary>
        /// <param name="passengers">Количество пассажиров</param>
        public virtual void SetPassengers (int passengers)
        {
            if ((PassengerCount + passengers) < PassengerCapacity)
                PassengerCount += passengers;
            else return;
        }
    }
}
