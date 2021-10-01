using System.Collections.Generic;
using Holism.Services.Models;
using Holism.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Holism.Services.DataAccess
{
    public class ServicesContext : DatabaseContext
    {
        public override string ConnectionStringName => "Services";

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PostHtml> PostHtmls { get; set; }

        public DbSet<AttachedFile> AttachedFiles { get; set; }

        public DbSet<TicketView> TicketViews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
