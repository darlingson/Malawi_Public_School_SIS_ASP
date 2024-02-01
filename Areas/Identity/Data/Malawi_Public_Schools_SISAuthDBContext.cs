using Malawi_Public_Schools_SIS.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Malawi_Public_Schools_SIS.Data;

public class Malawi_Public_Schools_SISAuthDBContext : IdentityDbContext<Malawi_Public_Schools_SISUser>
{
    public Malawi_Public_Schools_SISAuthDBContext(DbContextOptions<Malawi_Public_Schools_SISAuthDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
