namespace OOP
{
    /// <summary>
    /// Сервисный класс, возвращающий определенный цвет.
    /// </summary>
    public static class ColorsTool
    {
        /// <summary>
        /// Окрашивает элемент в красный цвет.
        /// </summary>
        /// <returns>Красный цвет</returns>
        public static Color GetRed() 
        {
            return Color.LightPink;
        }

        /// <summary>
        /// Окрашивает элемент в белый цвет.
        /// </summary>
        /// <returns>Белый цвет</returns>
        public static Color GetWhite()
        {
            return Color.White;
        }
    }
}
