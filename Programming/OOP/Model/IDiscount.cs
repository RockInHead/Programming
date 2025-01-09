using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    /// <summary>
    /// Интерфейс для скидок. 
    /// Имеет функции расчета, применения и обновления скидки.
    /// </summary>
    public interface IDiscount
    {
        string Info { get; }
        double Calculate(List<Item> items);
        double Apply(List<Item> items);
        void Update(List<Item> items);
    }
}
