using Airlanes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airlanes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Agregator;
using MySql.Data.MySqlClient;
using System.Security.Permissions;

namespace EarthPower
{
    public partial class Bron : Form
    {
        public Bron()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int counter =0;
        public void Create()
        {
            
            flowLayoutPanel1.Controls.Remove(flowLayoutPanel1);
            int ID = Convert.ToInt32(textBox1.Text);
            StreamReader read = new StreamReader(@"C:\Work\EarthPower\ticket.txt");
            Ticket[] lis = new Ticket[5];
            for (int i = 0; i < 5; i++)
            {
                lis[i] = JsonSerializer.Deserialize<Ticket>(read.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (lis[i].ID == ID)
                {
                    Panel pn = new Panel();
                    flowLayoutPanel1.Controls.Add(pn);
                    counter++;
                    pn.Size = new Size(400, 100);
                    pn.BackColor = Color.Orange;
                    System.Windows.Forms.TextBox tx1 = new System.Windows.Forms.TextBox();
                    tx1.Size = new Size(200, 25);
                    tx1.Text = lis[i].Start.ToString() + "->" + lis[i].End.ToString();
                    System.Windows.Forms.TextBox tx2 = new System.Windows.Forms.TextBox();
                    tx2.Size = new Size(100, 25);
                    tx2.Text = lis[i].Date;
                    tx2.Location = new Point(0, 75);
                    System.Windows.Forms.TextBox tx3 = new System.Windows.Forms.TextBox();
                    tx3.Text = lis[i].Class;
                    tx3.Size = new Size(75, 25);
                    tx3.Location = new Point(325, 75);
                    System.Windows.Forms.TextBox tx4 = new System.Windows.Forms.TextBox();
                    tx4.Text = "Цена = " + lis[i].Cost.ToString();
                    tx4.Size = new Size(175, 25);
                    tx4.Location = new Point(225, 0);
                    System.Windows.Forms.TextBox tx5 = new System.Windows.Forms.TextBox();
                    tx5.Text = "ID:" + lis[i].ID.ToString();
                    tx5.Size = new Size(100, 25);
                    tx5.Location = new Point(300, 50);
                    pn.Controls.Add(tx1);
                    pn.Controls.Add(tx2);
                    pn.Controls.Add(tx3);
                    pn.Controls.Add(tx4);
                    pn.Controls.Add(tx5);
                }

            }
        }
        int counter2 = 0;
        public void Create2()
        {
            for (int i = 0; i < counter; i++)
            {
                flowLayoutPanel2.Controls.RemoveAt(flowLayoutPanel2.Controls.Count - 1);
            }
            counter2 = 0;
            flowLayoutPanel2.Controls.Remove(flowLayoutPanel2);
            StreamReader read = new StreamReader(@"C:\Work\EarthPower\bron.txt");
            Ticket[] lis = new Ticket[5];
            for (int i = 0; i < 3; i++)
            {
                lis[i] = JsonSerializer.Deserialize<Ticket>(read.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {

                Panel pn = new Panel();
                flowLayoutPanel2.Controls.Add(pn);
                counter++;
                pn.Size = new Size(400, 100);
                pn.BackColor = Color.Orange;
                System.Windows.Forms.TextBox tx1 = new System.Windows.Forms.TextBox();
                tx1.Size = new Size(200, 25);
                tx1.Text = lis[i].Start.ToString() + "->" + lis[i].End.ToString();
                System.Windows.Forms.TextBox tx2 = new System.Windows.Forms.TextBox();
                tx2.Size = new Size(100, 25);
                tx2.Text = lis[i].Date;
                tx2.Location = new Point(0, 75);
                System.Windows.Forms.TextBox tx3 = new System.Windows.Forms.TextBox();
                tx3.Text = lis[i].Class;
                tx3.Size = new Size(75, 25);
                tx3.Location = new Point(325, 75);
                System.Windows.Forms.TextBox tx4 = new System.Windows.Forms.TextBox();
                tx4.Text = "Цена = " + lis[i].Cost.ToString();
                tx4.Size = new Size(175, 25);
                tx4.Location = new Point(225, 0);
                System.Windows.Forms.TextBox tx5 = new System.Windows.Forms.TextBox();
                tx5.Text = "ID:" + lis[i].ID.ToString();
                tx5.Size = new Size(100, 25);
                tx5.Location = new Point(300, 50);
                pn.Controls.Add(tx1);
                pn.Controls.Add(tx2);
                pn.Controls.Add(tx3);
                pn.Controls.Add(tx4);
                pn.Controls.Add(tx5);


            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void BronButton_Click(object sender, EventArgs e)
        {
            int NID = Convert.ToInt32(textBox1.Text);
            DB dB = new DB();
            Ticket tick = new Ticket();
            DataTable table = new DataTable();
            StreamReader read2 = new StreamReader(@"C:\Work\EarthPower\ticket.txt");
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            StreamReader read = new StreamReader(@"C:\Work\EarthPower\user.txt");
            string json = read.ReadToEnd();
            User user = JsonSerializer.Deserialize<User>(json);
            Ticket[] lis = new Ticket[5];
            for (int i = 0; i < 5; i++)
            {
                lis[i] = JsonSerializer.Deserialize<Ticket>(read2.ReadLine());
            }
            read.Close();
            read2.Close();
            for (int i = 0; i < 5; i++)
            {
                if (NID == lis[i].ID)
                {
                    tick = lis[i];
                }
            }
            MySqlCommand command3 = new MySqlCommand("INSERT INTO `bron` (`Email`, `ID`) VALUES (@e, @i);", dB.getConnection());
            command3.Parameters.Add("@e", MySqlDbType.VarChar).Value = user.Login;
            command3.Parameters.Add("@i", MySqlDbType.VarChar).Value = Convert.ToString(tick.ID);
            dB.openconnection();
            if (command3.ExecuteNonQuery() == 1)
            {
                StreamWriter write = new StreamWriter(@"C:\Work\EarthPower\bron.txt");
                string jjjson = JsonSerializer.Serialize(tick);
                write.WriteLine(jjjson);
                write.Close();
            }
            dB.closeconnection();
            Create2();
        }

        private void Bron_Load(object sender, EventArgs e)
        {
            Create2();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
