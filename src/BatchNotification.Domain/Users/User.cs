using BatchNotification.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchNotification.Domain.Users
{
    public partial class User : BaseEntity<int>
    {
        public User()
        {
        }

        public string UserName { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

    }
}
