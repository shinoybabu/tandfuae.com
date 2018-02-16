using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tandfuae.Models
{
    public class ContactUsContext: DbContext
    {
        public ContactUsContext():base("name=ContactUsConnectionString")
        {
            //Database.SetInitializer<SchoolDBContext>(new CreateDatabaseIfNotExists<SchoolDBContext>());

            //Database.SetInitializer<ContactUsContext>(new DropCreateDatabaseIfModelChanges<ContactUsContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ContactUsContext, tandfuae.Migrations.Configuration>("ContactUsConnectionString"));
        }

        public DbSet<ContactUs> ContactsUss { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
