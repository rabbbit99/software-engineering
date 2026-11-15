using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr4_Goods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Product> LoadProducts(string v)
        {
            if (File.Exists(v))
            {
                var x = File.ReadAllLines(v).Skip(1).Select(str =>
                    new Product(str)).ToList();
                return x;
            }
            else
                return new List<Product>();
        }

        List<Product> products;

        private void Form1_Load(object sender, EventArgs e)
        {
            //загрузка данных о товарах из файла
            products = LoadProducts("Товары.csv");
            //вывод товаров в dataGridView1
            dataGridView1.DataSource = products;//привязка данных к таблице dataGridView1
                                                //автоматически сгенерировать столбцы таблицы по свойствам привязанных объектов
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoResizeColumns(); //подогнать размер столбцов таблицы под содержимое
        }
    }
}
