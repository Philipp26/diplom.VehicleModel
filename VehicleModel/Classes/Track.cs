using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleModel.Classes
{
    /// <summary>
    /// Класс "Грузовой автомобиль"
    /// </summary>
    class Track : Car
    {
        public double BodyVolume { private set; get;}
        public double UsedVolume { private set; get; }

        public Track(string model, int passengerCapacity, double bodyVolume, Coordinate coordinate, double speed) 
            : base(model, passengerCapacity, coordinate, speed)
        {
            PassengerCount = 0;
            UsedVolume = 0;
            Model = model;
            PassengerCapacity = passengerCapacity;
            BodyVolume = bodyVolume;
        }

        /// <summary>
        /// Погрузка указанного объема груза в кузов
        /// </summary>
        /// <param name="cargoVolume">Объем груза</param>
        public void UpLoading (double cargoVolume)
        {
            if ((UsedVolume + cargoVolume) < BodyVolume)
                UsedVolume += cargoVolume;
            else return;
        }
    }
}
