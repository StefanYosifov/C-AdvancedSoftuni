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

namespace Kursova
{
    public partial class Form1 : Form
    {
        List<Lease> property = new List<Lease>(); // Масив от обекти в който пазим обектите
        const string fileName = "Kursova.dat"; //Име на файл
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e) 
        {
           // Влизаме във for цикъл и проверяваме на всеки обект града дали е равен на 
           // текстът от текстбокса
           // ако е равен го добавяме във листбокса 
           for(int i=0; i < property.Count; i++)
            {
                if (property[i].Adress == textBox1.Text)
                {
                    listBox1.Items.Add($"ID: {property[i].ID} City: {property[i].Adress} Price: {property[i].Price}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                // За всяка колона взимаме съответната стойност
                // ИД,Град,Име,Дата,Цена,(изчисляваната от клика на мишката) разлика
                // Правим тия променливи на един общ обект и записваме в масив
                string ID = dataGridView1[0, i].Value.ToString();
                string City = dataGridView1[1, i].Value.ToString();
                string Name = dataGridView1[2, i].Value.ToString();
                DateTime date = DateTime.Parse(dataGridView1[3, i].Value.ToString());
                double price = double.Parse(dataGridView1[4, i].Value.ToString());
                int dateDifference = int.Parse(dataGridView1[5, i].Value.ToString());
                Lease lease = new Lease(ID, City, Name, date, price,dateDifference); // Обект
                property.Add(lease); // Добавяне в масива
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Изчисляваме на разликата между датата и сега
            if (e.ColumnIndex == 5) //При кликане в 5 колонка
            {
                DateTime now = DateTime.Now; // Сега
                DateTime old = DateTime.Parse(dataGridView1[3, e.RowIndex].Value.ToString()); // Датата на 3-та колона
                dataGridView1[5, e.RowIndex].Value = (now - old).Days; // Разликата
            }
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            //Правим променлива, която е равна на нула
            // Изчисляваме сумата от цената на ден по броят дни
            // Ако тая сума е > от първоначалната променлива, то тя става сумата и така взимаме най-голямата
            listBox2.Items.Clear();
            double biggestSum = 0;
            for(int i = 0; i < property.Count; i++)
            {
                double priceForADay = property[i].Price / 30;
                int days = int.Parse(property[i].DateDiff.ToString());
                double sum = priceForADay * days;
                if(sum> biggestSum)
                {
                    biggestSum = sum;
                }
            }
            listBox2.Items.Add($"{biggestSum:F2}"); // Записваме в листбокса
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //Отваряне на поток и запис на всяка колона
            using(var stream = File.Open(fileName, FileMode.OpenOrCreate))
            {
                using(BinaryWriter writer=new BinaryWriter(stream))
                {
                    for(int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        writer.Write(dataGridView1[0, i].Value.ToString());
                        writer.Write(dataGridView1[1, i].Value.ToString());
                        writer.Write(dataGridView1[2, i].Value.ToString());
                        writer.Write(dataGridView1[3, i].Value.ToString());
                        writer.Write(dataGridView1[4, i].Value.ToString());
                        writer.Write(dataGridView1[5, i].Value.ToString());
                    }
                }
            }
            MessageBox.Show("Направихте запис");
        }
    }
}
