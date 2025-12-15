using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Bartova.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Creat { get; set; }
        public int IdUser { get; set; }
        public Messages() { }
        public Messages(string message, DateTime creat, int idUser) {
            Message = message;
            Creat = creat;
            IdUser = idUser;
        }
    }
}
