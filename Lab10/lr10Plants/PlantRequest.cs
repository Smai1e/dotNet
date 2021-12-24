namespace lr10Plants
{
    /// <summary>
    /// Запрос к справочнику растений
    /// </summary>
    public class PlantRequest
    {
        /// <summary>
        /// Тип запроса
        /// </summary>
        public PlantRequestType Type { get; set; }

        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Информация о растении
        /// </summary>
        public Plant Plant { get; set; }
    }
}
