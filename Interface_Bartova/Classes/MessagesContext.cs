using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_Bartova.Interfaces;
using Interface_Bartova.Models;

namespace Interface_Bartova.Classes
{
    public class MessagesContext : Messages , IMessages
    {
        public static List<Messages> AllMessages;
        public MessagesContext() => All(out AllMessages);
        public MessagesContext(string Messege, DateTime Creat, int IdUser): base(Messege, Creat, IdUser) { }
        public void All(out List<Messages> Messages) =>
            Messages = new List<Messages>();
        public void Delete()=>
            AllMessages.Remove(this);
        public void Save(bool Update = false)
        {
            if (Update ==false)
                AllMessages.Add(this);
        }
    }
}
