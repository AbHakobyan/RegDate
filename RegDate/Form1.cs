using System;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace RegDate
{
    public partial class Form1 : Form
    {
        SqlCommand command;
        int id;
        bool getClick = false;
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\localDBOXOTNIK;Initial Catalog=MyRegistr;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GetCheckRecords())
            {
                connection.Open();
                command = new SqlCommand
                (
                    "Insert into Students Values (@Fname,@Sname,@Email,@PaymantDay,@Age)"
                    , connection
                    );

                command.Parameters.AddWithValue("@Fname", txtName.Text);
                command.Parameters.AddWithValue("@Sname", txtSname.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@PaymantDay", txtPaymentDay.Text);
                command.Parameters.AddWithValue("@Age", txtAge.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Your inpud adding datebase");
                connection.Close();
            }
            else
            {
                MessageBox.Show("Insert all fields");
            }

            
        }
        private void GetClear()
        {
            txtName.Text = "";
            txtSname.Text = "";
            txtEmail.Text = "";
            txtPaymentDay.Text = "";
            txtAge.Text = "";
        }

        private bool GetCheckRecords()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text.Length == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void GetSelectRecorder()
        {

            command = new SqlCommand
                (
                    "Select * from Students", connection
                );
            connection.Open();
            DataTable table = new DataTable();
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSelectRecorder();
        }

        private void btXmbagrel_Click(object sender, EventArgs e)
        {
            command = new SqlCommand(
            "Update Students set " +
                "fname = @Fname," +
                "sname = @Sname," +
                "email = @Email," +
                "paymantday = @PaymantDay," +
                "age = @Age  Where ID = @id",connection
            );
            connection.Open();
            command.Parameters.AddWithValue("@Fname", txtName.Text);
            command.Parameters.AddWithValue("@Sname", txtSname.Text);
            command.Parameters.AddWithValue("@Email", txtEmail.Text);
            command.Parameters.AddWithValue("@PaymantDay", txtPaymentDay.Text);
            command.Parameters.AddWithValue("@Age", txtAge.Text);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
            connection.Close();
            GetClear();
            GetSelectRecorder();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtSname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(); 
                txtEmail.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtPaymentDay.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString(); 
                txtAge.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Please Select Row");
            }
        }

        private void btJnjel_Click(object sender, EventArgs e)
        {
            command = new SqlCommand
                (
                    "Delete from Students Where ID = @id",connection
                );
            connection.Open();
            command.Parameters.AddWithValue("ID",id);
            command.ExecuteNonQuery();
            connection.Close();
            GetSelectRecorder();
            GetClear();

        }

        private void btToxerJnjel_Click(object sender, EventArgs e)
        {
            GetClear();
        }

        private void btFiltr_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From Students Where fname = @name";
            connection.Open();
            command.Parameters.AddWithValue("@name",txtFnameFiltr.Text);
            DataTable table = new DataTable();
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);
            dataGridView1.DataSource = table;
            connection.Close();
            GetClear();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (!getClick)
            {
                this.Size = new Size(1215, 497);
                getClick = !getClick;
            }
            else
            {
                this.Size = new Size(814, 497);
                getClick = !getClick;
            }
        }
    } 
}

