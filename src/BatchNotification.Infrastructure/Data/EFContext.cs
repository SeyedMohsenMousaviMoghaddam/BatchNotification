using Microsoft.EntityFrameworkCore;

namespace BatchNotification.Infrastructure.Data
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }
    }
}
