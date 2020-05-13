using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleModel.Classes
{
    /// <summary>
    /// Класс "Автобус"
    /// </summary>
    class Bus : Car
    {
        /// <summary>
        /// Конструктор класса Bus. В конструкторе реализована проверка на минимальное количество мест. Минимум 9.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="passengerCapacity"></param>
        /// <param name="coordinate"></param>
        /// <param name="speed"></param>
        public Bus(string model, int passengerCapacity, Coordinate coordinate, double speed) : base(model, passengerCapacity, coordinate, speed)
        {
            Model = model;
            PassengerCapacity = passengerCapacity < 9 ? 9 : passengerCapacity;
        }
    }
}
