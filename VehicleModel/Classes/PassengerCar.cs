using NetTopologySuite.Geometries;

namespace VehicleModel.Classes
{
    /// <summary>
    /// Класс "Легковой автомобиль"
    /// </summary>
    class PassengerCar : Car
    {
        const int MaxPassengerQty = 4;

        private CarBodyType BodyType;

        public PassengerCar(string model, int passengerCapacity, Coordinate coordinate, double speed, CarBodyType carBodyType) 
            : base(model, passengerCapacity, coordinate, speed)
        {
            Model = model;
            PassengerCapacity = passengerCapacity < MaxPassengerQty ? passengerCapacity : MaxPassengerQty;
            BodyType = carBodyType;
        }
    }
}
