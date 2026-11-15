using System;
using System.Collections.Generic;
using System.Text;

namespace Lb3_autoPower
{
    class Garage
    {
        const int MaxAuto = 10;
        Auto[] masAuto;
        int count;

        public Garage()
        {
            masAuto = new Auto[MaxAuto];
        }

        public bool ДобавитьАвто(Auto auto)
        {
            if (count < MaxAuto)
            {
                masAuto[count] = auto;
                count++;
                return true;
            }
            return false;
        }

        public Auto ПолучитьАвто(int index)
        {
            if (index < count)
                return masAuto[index];
            return null;
        }

        public int ТранспортныйНалог(Auto auto) 
        {
            int tax;
            int power = auto.ПолучитьМощность();
            if (power < 100) 
                return tax = power * 9;
            if (100 <= power && power < 150) 
                return tax = 20 * power; 
            if (150 <= power && power < 200)  
                return tax = 40 * power; 
            if (200 <= power && power < 250) 
                return tax = 75 * power; 
            if (power >= 250)
                return tax = 150 * power;
        }

        public int КолАвто()
        {
            return count;
        }

        public void СортироватьПоМощности()
        {
            for (int i = 0; i < count - 1; i++)
            {
                int minind = i;//индекс мин. авто
                Auto minauto = masAuto[i];
                for (int j = i + 1; j < count; j++)
                    if (minauto.ПолучитьМощность().CompareTo(masAuto[j].ПолучитьМощность()) > 0 )
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
