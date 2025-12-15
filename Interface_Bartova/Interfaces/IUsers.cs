using System.Collections.Generic;
using Interface_Bartova.Models;

namespace Interface_Bartova.Interfaces
{
    public interface IUsers
    {
        void All(out List<Users> Users);
    }
}
