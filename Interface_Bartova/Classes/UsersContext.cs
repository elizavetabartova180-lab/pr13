using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_Bartova.Interfaces;
using Interface_Bartova.Models;

namespace Interface_Bartova.Classes
{
    public class UsersContext: Users, IUsers
    {
        public List<Users> AllUsers;
        public UsersContext() =>
            this.All(out AllUsers);
        public void All(out List<Users> Users)
        {
            Users = new List<Users>();
            AllUsers.Add(new Users( 1, "Аликина Ольга"));
            AllUsers.Add(new Users( 2, "Бояркин Данил"));
            AllUsers.Add(new Users( 3, "Бурмантов Владислав"));
            AllUsers.Add(new Users( 4, "Дыджин максим"));
            AllUsers.Add(new Users( 5, "Евдокимов Даниил"));
            AllUsers.Add(new Users( 6, "Костюнин Никита"));
            AllUsers.Add(new Users( 7, "Кучин Данил"));
            AllUsers.Add(new Users( 8, "Мотырев Александр"));
            AllUsers.Add(new Users( 9, "Пликина Ольга"));
            AllUsers.Add(new Users( 10, "Заликина Ольга"));
            AllUsers.Add(new Users( 11, "Аликина Марина"));
            AllUsers.Add(new Users( 12, "Евдокимов Никита"));
            AllUsers.Add(new Users( 13, "Мотырев Даниил"));

        }
    }
}
