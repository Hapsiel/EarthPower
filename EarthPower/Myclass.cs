using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Airlanes
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool InstaEnter { get; set; }
        
        public User() { }
        public User(string Login, string Password, bool InstaEnter) {
            this.Login = Login;
            this.Password = Password;
            this.InstaEnter = InstaEnter;
        }
        

    }
    public class Ticket
    {
        public string Start { get; set; }

        public string End { get; set; }

        public int SeatCount { get; set; }

        public string Date { get; set; }

        public string Class { get; set; }
        
        public int Cost { get; set; }

        public int ID { get; set; }

        public Ticket() { }
        public Ticket(string st, string en, int sc, string dt, string cl, int c, int id  ) {
            this.Start = st;
            this.End = en;
            this.SeatCount = sc;
            this.Date = dt;
            this.Class = cl;
            this.Cost = c;
            this.ID = id;
        }
    }

}
