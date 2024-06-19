using Agregator;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airlanes;
using System.Text.Json;
namespace EarthPower
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        FileInfo check = new FileInfo(@"C:\Work\EarthPower\user.txt");
        StreamWriter writ = new StreamWriter(@"C:\Work\EarthPower\user.txt");
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            string FNF = FNFTextBox.Text;
            string Number = NumberTextBox.Text;

            DB dB = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Email`= @l", dB.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = email;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (Number.Length > 9)
            {
                if (table.Rows.Count == 0)
                {
                    MySqlCommand command3 = new MySqlCommand("INSERT INTO `users` (`FNF`, `Email`, `Password`, `Number`) VALUES (@LoginUse, @mail, @pass, @num);", dB.getConnection());
                    command3.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
                    command3.Parameters.Add("@LoginUse", MySqlDbType.VarChar).Value = FNF;
                    command3.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email;
                    command3.Parameters.Add("@num", MySqlDbType.VarChar).Value = Number;
                    dB.openconnection();
                    if (command3.ExecuteNonQuery() == 1)
                    {
                        ErrorLabel.Text = "Аккаунт зарегестрирован";
                        var user = new User(email, password, true);
                        string json = JsonSerializer.Serialize<User>(user);
                        if (check.Exists)
                        {
                            writ.Write(json);
                            writ.Close();
                        }
                        else
                        {
                            check.Create();
                            writ.Write(json);
                            writ.Close();
                        }
                    }
                    else { ErrorLabel.Text = "произошла ошибка"; }
                    dB.closeconnection();
                }
                else { ErrorLabel.Text = "Такая почта уже есть"; }
            }
            else { ErrorLabel.Text = "Длинна номера слишком короткая"; }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
