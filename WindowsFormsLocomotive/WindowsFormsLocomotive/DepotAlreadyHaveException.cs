using System;

namespace WindowsFormsLocomotive
{
    /// <summary>
    /// Класс-ошибка "Если на парковке уже есть автомобиль с такими же характеристиками"
    /// </summary>
    class DepotAlreadyHaveException : Exception
    {
        public DepotAlreadyHaveException() : base("На парковке уже есть такая машина")
        { }
    }
}
