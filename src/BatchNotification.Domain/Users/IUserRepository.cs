using BatchNotification.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchNotification.Domain.Users
{
    public interface IUserRepository : IAsyncRepository<User>
    {
    }
}
