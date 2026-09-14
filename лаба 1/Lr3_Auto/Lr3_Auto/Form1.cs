using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr3_Auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //задание параметров очередному авто из гаража
            Auto auto = new Auto(numberTextBox.Text, modelTextBox.Text, colorTextBox.Text, fioTextBox.Text);
            //добавление авто в гараж
            bool result = garage.ДобавитьАвто(auto);
            if (result)
                //обновление (вывод) списка авто в listBox1
                ВыводСпискаАвто();
            else
                //добавление авто - неудачное
                MessageBox.Show("В гараже нет места!", "Гараж", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        Garage garage; //гараж - список авто

        private void Form1_Load(object sender, EventArgs e)
        {
            //выделение памяти для гаража
            garage = new Garage();
        }

        private void ВыводСпискаАвто()
        {
            listBox1.Items.Clear(); //очистка списка listBox1
            for (int i = 0; i < garage.КолАвто(); i++)
            {
                listBox1.Items.Add(garage.ПолучитьАвто(i).Описание());
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            garage.СортироватьПоФИО();
            //обновление (вывод) списка авто в listBox1
            ВыводСпискаАвто();
        }
    }
}
