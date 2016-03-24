using System.Data.Entity;
using APILecture.Controllers;

namespace APILecture.Models
{
    public class VotingDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public VotingDbContext() : base("name=VotingDbContext")
        {
        }

        public DbSet<Voter> Voters { get; set; }
    }
}