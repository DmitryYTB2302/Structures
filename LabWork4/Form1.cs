using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace аудиторная4
{
        struct Employee
        {
        public string DepartmentName;  //Название кафедры 
        public string FioHeadOfDep;  //Фио зав. кафедры
        public int NumberOfTeachers;  //Количество преподавателей 
        public string TheAddress;  //Адрес
        public string FirstDepartmentName; //Стартовые данные кафедра
        public string FirstFioHeadOfDep; //Стартовые данные фио
        public int FirstNumberOfTeachers; //Стартовые данны кол. преподователей
        public string FirstTheAddress; //Стартовые данные адрес
        public string SecondDepartmentName;
        public string SecondFioHeadOfDep;
        public int SecondNumberOfTeachers;
        public string SecondTheAddress;

        public Employee(string f, string p, int e, string d, string ff, string fp, int fe, string fd,string sf, string sp, int se, string sd)
        {
            DepartmentName = f;
            FioHeadOfDep = p;
            NumberOfTeachers = e;
            TheAddress = d;
            FirstDepartmentName = ff;
            FirstFioHeadOfDep = fp;
            FirstNumberOfTeachers = fe;
            FirstTheAddress = fd;
            SecondDepartmentName = sf;
            SecondFioHeadOfDep = sp;
            SecondNumberOfTeachers = se;
            SecondTheAddress = sd;

        }
    }

        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
            worker[cout].DepartmentName = comboBox1.Text;
            worker[cout].FioHeadOfDep = textBox1.Text;
            worker[cout].NumberOfTeachers = Convert.ToInt32(textBox2.Text);
            worker[cout].TheAddress = textBox4.Text;
            dataGridView1.Rows.Add(worker[cout].DepartmentName, worker[cout].FioHeadOfDep, worker[cout].TheAddress, worker[cout].NumberOfTeachers.ToString());
            cout++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Вычислительной техники");
            comboBox1.Items.Add("Систем автоматизации управления");
            comboBox1.Items.Add("Радиоэлектронных средств");
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderText = "Каферда";
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[2].HeaderText = "Адрес";
            dataGridView1.Columns[3].HeaderText = "Количество преподавателей";
           
            
            

            
            
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].HeaderText = "Каферда";
            dataGridView2.Columns[1].HeaderText = "ФИО";
            dataGridView2.Columns[2].HeaderText = "Адрес";
            dataGridView2.Columns[3].HeaderText = "Количество преподавателей"; 
            dataGridView2.RowHeadersVisible = false;

        }
        Employee[] worker = new Employee[8];
        int cout = 0;

        private void button2_Click(object sender, EventArgs e)
        {
           
            
                dataGridView2.Rows.Clear();
                int select1 = Convert.ToInt32(textBox3.Text);
                foreach (Employee wSel in worker)
                {
                    if (wSel.NumberOfTeachers >= select1)
                    {
                        dataGridView2.Rows.Add(wSel.DepartmentName, wSel.FioHeadOfDep, wSel.TheAddress , wSel.NumberOfTeachers.ToString());
                        
                       
                    }
                    if(wSel.FirstNumberOfTeachers >= select1)
                    {
                        dataGridView2.Rows.Add(wSel.FirstDepartmentName, wSel.FirstFioHeadOfDep, wSel.FirstTheAddress, wSel.FirstNumberOfTeachers.ToString());
                    }
                    if(wSel.SecondNumberOfTeachers>=select1)
                    {
                        dataGridView2.Rows.Add(wSel.SecondDepartmentName, wSel.SecondFioHeadOfDep, wSel.SecondTheAddress, wSel.FirstNumberOfTeachers.ToString());

                    }
                    








                }
                



            
            

           
        }

        private void добавитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void выполнитьЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            worker[cout].FirstDepartmentName = "Систем автоматизации управления";
            worker[cout].FirstFioHeadOfDep = "Ланских Ю.В.";
            worker[cout].FirstNumberOfTeachers = 16;
            worker[cout].FirstTheAddress = "ул. Московская 39";
            worker[cout].SecondDepartmentName = "Вычислительной техники";
            worker[cout].SecondFioHeadOfDep = "Долженкова М.Л.";
            worker[cout].SecondNumberOfTeachers = 12;
            worker[cout].SecondTheAddress = "ул. Московская 39";
            dataGridView1.Rows.Add(worker[cout].FirstDepartmentName, worker[cout].FirstFioHeadOfDep, worker[cout].FirstTheAddress, worker[cout].FirstNumberOfTeachers.ToString());
            dataGridView1.Rows.Add(worker[cout].SecondDepartmentName, worker[cout].SecondFioHeadOfDep, worker[cout].SecondTheAddress, worker[cout].SecondNumberOfTeachers.ToString());
            cout++;








        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
