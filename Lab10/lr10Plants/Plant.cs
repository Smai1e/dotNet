using System;

namespace lr10Plants
{
    /// <summary>
    /// Растение
    /// </summary>
    [Serializable]
    public class Plant
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Семейство
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        /// Отдел
        /// </summary>
        public PlantDepartament Departament { get; set; } = PlantDepartament.Цветковые;

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Переопределение метода ToString()
        /// </summary>
        public override string ToString()
        {
            return $"Название: {Title}\nСемейство: {Family}\nОтдел: {Departament}\nОписание: {Description}";
        }

        /// <summary>
        /// Валидна ли запись
        /// </summary>
        public bool isValid()
        {
            if (string.IsNullOrWhiteSpace(Title)) return false;
            if (string.IsNullOrWhiteSpace(Family)) return false;
            if (string.IsNullOrWhiteSpace(Description)) return false;
            return true;
        }
    }
}
