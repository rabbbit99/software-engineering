using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr3_Auto
{
    class Auto
    {
        string госномер;
        string модель;
        string цвет;
        string фио;

        public Auto() //конструктор без параметров
        {
            госномер = ""; модель = ""; цвет = ""; фио = "";
        }

        public Auto(string госномер, string модель, string цвет, string фио)
        {
            this.госномер = госномер;
            this.модель = модель;
            this.цвет = цвет;
            this.фио = фио;
        }

        // вывод всех данных об автомобиле в виде строкового описания
        public string Описание()
        {
            return string.Format("{0}, {1}, {2}, {3}", модель, цвет, госномер, фио);
        }

        public string ПолучитьФИО()
        {
            return фио;
        }

    }
}
