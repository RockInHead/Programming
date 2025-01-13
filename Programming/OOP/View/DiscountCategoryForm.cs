using OOP.Model.Discounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.View
{
    /// <summary>
    /// Формa для управления категориями скидок.
    /// </summary>
    public partial class DiscountCategoryForm : Form
    {
        // <summary>
        /// Получает или устанавливает объект PercentDiscount, который содержит информацию о скидке.
        /// </summary>
        public PercentDiscount Discount { get; set; } = new PercentDiscount();

        /// <summary>
        /// Конструктор формы DiscountCategoryForm. 
        /// Инициализирует компоненты и заполняет ComboBox категориями из перечисления Category.
        /// </summary>
        public DiscountCategoryForm()
        {
            InitializeComponent();
            DiscountCategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
        }

        /// <summary>
        /// Обработчик события клика по кнопке "ОК". 
        /// Устанавливает выбранную категорию скидки и закрывает форму с результатом OK.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Объект события.</param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (DiscountCategoryComboBox.SelectedItem == null)
            {
                return; 
            }

            Discount.DiscountCategory = (Category)DiscountCategoryComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Обработчик события клика по кнопке "Отмена". 
        /// Закрывает форму с результатом Cancel.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Объект события.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
