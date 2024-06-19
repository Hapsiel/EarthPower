using Airlanes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace EarthPower
{
    public partial class Seeker : Form
    {
        public Seeker()
        {
            InitializeComponent();

        }

        private void Seeker_Load(object sender, EventArgs e)
        {
        }
        public void Btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "ПЕЕЕНИИИС";
        }
        int counter = 0;
        public void Create()
        {
            for (int i = 0; i < counter; i++)
            {
                flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
            }
            counter = 0;
            flowLayoutPanel1.Controls.Remove(flowLayoutPanel1);
            int max = Convert.ToInt32(textBox2.Text);
            int min = Convert.ToInt32(textBox1.Text);
            StreamReader read = new StreamReader(@"C:\Work\EarthPower\ticket.txt");
            Ticket[] lis = new Ticket[5];
            for (int i = 0; i < 5; i++)
            {
                lis[i] = JsonSerializer.Deserialize<Ticket>(read.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (lis[i].Cost >= min && lis[i].Cost <= max)
                {
                    Panel pn = new Panel();
                    flowLayoutPanel1.Controls.Add(pn);
                    counter++;
                    pn.Size = new Size(400, 100);
                    pn.BackColor = Color.Orange;
                    TextBox tx1 = new TextBox();
                    tx1.Size = new Size(200, 25);
                    tx1.Text = lis[i].Start.ToString() + "->" + lis[i].End.ToString();
                    TextBox tx2 = new TextBox();
                    tx2.Size = new Size(100, 25);
                    tx2.Text = lis[i].Date;
                    tx2.Location = new Point(0, 75);
                    TextBox tx3 = new TextBox();
                    tx3.Text = lis[i].Class;
                    tx3.Size = new Size(75, 25);
                    tx3.Location = new Point(325, 75);
                    TextBox tx4 = new TextBox();
                    tx4.Text = "Цена = " + lis[i].Cost.ToString();
                    tx4.Size = new Size(175, 25);
                    tx4.Location = new Point(225, 0);
                    TextBox tx5 = new TextBox();
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BronButton_Click(object sender, EventArgs e)
        {
            var br = new Bron();
            br.ShowDialog();
        }
    }
}
