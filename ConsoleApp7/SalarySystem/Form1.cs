using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarySystem
{
    public partial class Form1 : Form
    {
        public string data = "";
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            Db.ListOfWorker.Add(new Workerlist("Yasin", "Quliyev", "yasinyg@code.edu.az", 400, 26, new DateTime(2017, 1, 18)));
            Db.ListOfWorker.Add(new Workerlist("Ülvi", "Musayev", "ulvime@code.edu.az", 660, 34, new DateTime(2016, 6, 28)));
            Db.ListOfWorker.Add(new Workerlist("Samir", "Kərimov", "samir@code.edu.az", 240, 32, new DateTime(2018, 9, 6)));
            Db.ListOfWorker.Add(new Workerlist("Yolçu", "Nəsib", "yolchu@code.edu.az", 550, 54, new DateTime(2019, 1, 4)));
            Db.ListOfWorker.Add(new Workerlist("Samir", "Dadaşzadə", "samirda@code.edu.az", 230, 23, new DateTime(2012, 12, 16)));
            Db.ListOfWorker.Add(new Workerlist("Elgün", "Musayev", "elgunmu@code.edu.az", 110, 12, new DateTime(2014, 4, 17)));
            var bindingsource1 = new BindingSource();
            bindingsource1.DataSource = Db.ListOfWorker;
            dataGridView1.DataSource = bindingsource1;
            averagetextbox.Text = Convert.ToString(AverageOfSalary());
            label9.Text = Convert.ToString(dataGridView1.RowCount);
            label13.Text = Convert.ToString(AverageOfWorkTime());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workerlist Adam = new Workerlist(textBoxName.Text,textBoxSurname.Text,textBoxEmail.Text,Convert.ToInt16(textBoxSalary.Text),Convert.ToInt16(textBoxWorkHours.Text),dateTimePicker1.Value.Date);

            Db.ListOfWorker.Add(Adam);

            var bindingsource1 = new BindingSource();  
            bindingsource1.DataSource = Db.ListOfWorker;
            dataGridView1.DataSource = bindingsource1;
            averagetextbox.Text = Convert.ToString(AverageOfSalary());
            label9.Text = Convert.ToString(dataGridView1.RowCount);
            label13.Text= Convert.ToString(AverageOfWorkTime());
        }



       
        public int AverageOfSalary()
        {
            int toplammaas = 0;
            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                var variable = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                toplammaas += variable;
            }
            return toplammaas / dataGridView1.RowCount;
        }
        public int AverageOfWorkTime()
        {
            int toplamwork = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                var variable = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                toplamwork += variable;
            }
            return toplamwork / dataGridView1.RowCount;
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int selectedid = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            MessageBox.Show(Convert.ToString(selectedid));
            //data = dataGridView1.CurrentCell.OwningColumn.Name;

            //foreach (var item in Db.ListOfWorker)
            //    {
            //        if (item.Id==selectedid)
            //        {
            //            item.UserType = UserType.Admin;
            //        }
            //    }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Salary"], ListSortDirection.Ascending);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
            if (checkBox1.Checked == true)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    var variable = Convert.ToInt64(dataGridView1.Rows[i].Cells[4].Value);
                    if (variable > AverageOfSalary())
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Visible = false;

                    }
                }
                
            }
            if(checkBox1.Checked==false)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (true)
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                }
            }
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    var variable = Convert.ToInt64(dataGridView1.Rows[i].Cells[5].Value);
                    if (variable > AverageOfWorkTime())
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Visible = false;

                    }
                }

            }
            if (checkBox2.Checked == false)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (true)
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
    }
}
