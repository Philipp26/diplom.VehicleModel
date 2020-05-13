using NetTopologySuite.Geometries;
using OSMLSGlobalLibrary.Map;
using VehicleModel.Enumerators;

namespace VehicleModel.Classes
{
    /// <summary>
    /// Класс "Транспортное средство"
    /// </summary>
    [CustomStyle(
        @"new ol.style.Style({
            image: new ol.style.Circle({
                opacity: 1.0,
                scale: 1.0,
                radius: 3,
                fill: new ol.style.Fill({
                    color: 'rgba(255, 0, 255, 0.4)'
                }),
                stroke: new ol.style.Stroke({
                    color: 'rgba(0, 0, 0, 0.4)',
                    width: 1
                }),
            })
        });
        ")]
    public abstract class Vehicle : Point, IMoveble
    {
        public double Speed { get; set; }
        public Coordinate Coordinate { get; set; }
        public Vehicle(Coordinate coordinate, double speed) : base(coordinate)
        {
            Speed = speed;
            Coordinate = coordinate;
        }

        public void Move()
        {
            var direction = Directions.Down;

            switch(direction)
            {
                case Directions.Down:
                    MoveHandler.MoveDown(this);
                    break;
                case Directions.Up:
                    MoveHandler.MoveUp(this);
                    break;
                case Directions.Left:
                    MoveHandler.MoveLeft(this);
                    break;
                case Directions.Right:
                    MoveHandler.MoveRight(this);
                    break;
                case Directions.DownLeft:
                    MoveHandler.MoveDownLeft(this);
                    break;
                case Directions.DownRight:
                    MoveHandler.MoveDownRight(this);
                    break;
                case Directions.UpRight:
                    MoveHandler.MoveUpRight(this);
                    break;
                case Directions.UpLeft:
                    MoveHandler.MoveUpLeft(this);
                    break;                
            }
        }
    }
}
