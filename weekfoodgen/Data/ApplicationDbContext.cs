using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using weekfoodgen.Models;

namespace weekfoodgen.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {

        }
        public virtual DbSet<ViikkoLista> ViikkoLista { get; set; }
        public virtual DbSet<Ruoka> Ruoka { get; set; }
        public virtual DbSet<RaakaAine> RaakaAine { get; set; }
    }
}