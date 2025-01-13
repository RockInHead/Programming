namespace OOP.Model
{
    /// <summary>
    /// Хранит данные о корзине покупок:Список товаров, Суммарная стоимость всех товаров.
    /// </summary>
    public class Cart:ICloneable
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Суммарная стоимость всех товаров.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Задает и возвращает список всех товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает суммарную стоимость всех товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                double summ=0;
                foreach(Item cost in Items) 
                {
                    summ += cost.Cost;
                }
                if (summ > 0)
                {
                    return _amount = summ;
                }
                else
                {
                    return _amount = 0;
                }
            }
        }
        /// <summary>
        /// Создает пустой/начальный экземпляр класса. Всем полям присваивается значение по умолчанию.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }

        /// <summary>
        /// Создает экземпляр класса.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public Cart(List<Item> items)
        {
            Items = items;
        }

        /// <summary>
        /// Возвращает копию по всем полям, кроме Amount.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Cart(this.Items);
        }
    }
}
