using BatchNotification.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchNotification.Infrastructure.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>
        , IUserRepository
    {
        public UserRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}
