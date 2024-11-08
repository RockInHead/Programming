using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Services
{
    static class DataTools
    {
        /*public delegate bool SortingCriteria(Item item);*/

        public static List<Item> Filter(List<Item> items,Func<Item,bool> sortingCriteria)
        {
            List<Item> newItems = new List<Item>();
            foreach (Item item in items)
            {
                if (sortingCriteria(item))
                {
                    newItems.Add(item);
                }
            }
            return newItems;
        }
        /*public List<Item> SortOver5000(List<Item> items)
        {
            List<Item> newItems = new List<Item>();
            foreach (Item item in items)
            {
                if(item.Cost > 5000)
                {
                    newItems.Add(item);
                }
            }
            return newItems;
        }
        public List<Item> SortSmartphones(List<Item> items)
        {
            List<Item> newItems = new List<Item>();
            foreach (Item item in items)
            {
                if (item.Category ==Category.Смартфоны)
                {
                    newItems.Add(item);
                }
            }
            return newItems;
        }*/
    }
}
