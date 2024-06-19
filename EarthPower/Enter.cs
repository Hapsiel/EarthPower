using Airlanes;
using System.Text.Json;
namespace EarthPower
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();

        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var reg = new Register();
            reg.ShowDialog();
        }

        FileInfo check = new FileInfo(@"C:\Work\EarthPower\user.txt");
        private void Enter_Load(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader(@"C:\Work\EarthPower\user.txt");
            if (check.Exists)
            {
                string json = read.ReadToEnd();
                User user = JsonSerializer.Deserialize<User>(json);
                read.Close();
                LoginTextBox.Text = user.Login;
                PasswordTextBox.Text = user.Password;

            }
            //FileInfo checks = new FileInfo(@"C:\Work\EarthPower\ticket.txt");
            //checks.Create();
            //string jjson;
            //StreamWriter writ = new StreamWriter(@"C:\Work\EarthPower\ticket.txt");
            //Ticket[] lis = new Ticket[5];
            //lis[0] = new Ticket("Moscow", "Urupins",15,"25.12.24","Bomj",99);
            //jjson = JsonSerializer.Serialize<Ticket>(lis[0]);
            //writ.WriteLine(jjson);
            //lis[1] = new Ticket("Krisjopl", "AdNahui", 666, "12.2.666", "Gresnik", 1);
            //jjson = JsonSerializer.Serialize<Ticket>(lis[1]);
            //writ.WriteLine(jjson);
            //lis[2] = new Ticket("Moscow", "Kreml", 2, "22.4.22", "Lux", 666666);
            //jjson = JsonSerializer.Serialize<Ticket>(lis[2]);
            //writ.WriteLine(jjson);
            //lis[3] = new Ticket("Voronezh", "Ptrtrburg", 120, "28.11.23", "Econom", 7500);
            //jjson = JsonSerializer.Serialize<Ticket>(lis[3]);
            //writ.WriteLine(jjson);
            //lis[4] = new Ticket("IWantSleep", "MyBed", 1, "19.6.24", "Sleepy", 0);
            //jjson = JsonSerializer.Serialize<Ticket>(lis[4]);
            //writ.WriteLine(jjson);
            //writ.Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader(@"C:\Work\EarthPower\user.txt");
            if (check.Exists)
            {
                string json = read.ReadToEnd();
                User user = JsonSerializer.Deserialize<User>(json);
                read.Close();
                if(user.InstaEnter == true)
                {
                    var sek = new Seeker();
                    this.Hide();
                    sek.ShowDialog();
                }
            }
        }
    }
}