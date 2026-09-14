using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr3_Auto
{
    class Garage
    {
        const int MAXAUTO = 10;
        Auto[] masAuto; //массив авто
        int count; //текущее число авто в гараже
        
        //конструктор
        public Garage()
        {
            masAuto = new Auto[MAXAUTO];
        }

        //добавление авто в гараж
        public bool ДобавитьАвто(Auto auto)
        {
            if (count < MAXAUTO)
            {
                masAuto[count] = auto;
                count++;
                return true;
            }
            return false;
        }

        //получить авто по его порядковому номеру
        public Auto ПолучитьАвто(int index)
        {
            if (index < count)
                return masAuto[index];
            return null;
        }

        //текущее количество авто в гараже
        public int КолАвто()
        {
            return count;
        }

        //сортировка списка автомобилей в порядке возрастания ФИО
        public void СортироватьПоФИО()
        {
            for (int i = 0; i < count - 1; i++)
            {
                int minind = i;//индекс мин. авто
                Auto minauto = masAuto[i];
                for (int j = i + 1; j < count; j++)
                    if (minauto.ПолучитьФИО().CompareTo(masAuto[j].ПолучитьФИО()) == 1)
                    {
                        minauto = masAuto[j];
                        minind = j;
                    }
                //обмен мин. авто и первого в несортированной части
                masAuto[minind] = masAuto[i];
                masAuto[i] = minauto;
            }
        }

    }
}
