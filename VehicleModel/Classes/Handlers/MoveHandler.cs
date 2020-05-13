namespace VehicleModel.Classes
{
    /// <summary>
    /// Класс "Обработчик движения"
    /// </summary>
    public static class MoveHandler
    {
        public static void MoveUp(Vehicle movedObject) =>
            movedObject.Y *= movedObject.Speed;        

        public static void MoveDown(Vehicle movedObject) =>
            movedObject.Y *= (-1) * movedObject.Speed;        

        public static void MoveLeft(Vehicle movedObject) =>        
            movedObject.X *= (-1) * movedObject.Speed;        

        public static void MoveRight(Vehicle movedObject) =>
            movedObject.X *= movedObject.Speed;

        public static void MoveUpRight(Vehicle movedObject)
        {
            movedObject.Y *= movedObject.Speed;
            movedObject.X *= movedObject.Speed;
        }

        public static void MoveUpLeft(Vehicle movedObject)
        {
            movedObject.Y *= movedObject.Speed;
            movedObject.X *= (-1) * movedObject.Speed;
        }

        public static void MoveDownRight(Vehicle movedObject)
        {
            movedObject.Y *= (-1) * movedObject.Speed;
            movedObject.X *= movedObject.Speed;
        }

        public static void MoveDownLeft(Vehicle movedObject)
        {
            movedObject.Y *= (-1) * movedObject.Speed;
            movedObject.X *= (-1) * movedObject.Speed;
        }
    }
}
