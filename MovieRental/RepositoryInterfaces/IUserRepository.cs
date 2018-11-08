using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.RepositoryInterfaces
{
    public interface IUserRepository
    {
        object GetUser();
        object GetUserbyId(int userId);
    }
}
