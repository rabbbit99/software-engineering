using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr4_Goods
{
    internal class Product
    {
        public string ProductName { get; set; } //Наименование товара
        public string CompanyName { get; set; } //Организация
        public double Cost { get; set; }    //Стоимость
        public double Price { get; set; }    //Цена продажи
        public double Count { get; set; }    //Текущее количество
        public int MinCount { get; set; }    //Минимальный запас
        public int DesiredCount { get; set; }    //Желаемый запас
        public string UnitDescription { get; set; }    //Количество в позиции
        public string CategoryName { get; set; }    //Название категории товара

    }
}
