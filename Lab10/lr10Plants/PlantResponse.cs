namespace lr10Plants
{
    /// <summary>
    /// Ответ оь справочников растений
    /// </summary>
    public class PlantResponse
    {
        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Признак успешного выполнения запроса
        /// </summary>
        public bool IsSuccess { get; set; }

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
