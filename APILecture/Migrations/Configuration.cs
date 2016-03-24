using APILecture.Controllers;
using FizzWare.NBuilder;

namespace APILecture.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<APILecture.Models.VotingDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(APILecture.Models.VotingDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            if (!context.Voters.Any())
            {
                var voters = Builder<Voter>.CreateListOfSize(10000)
                    .All()
                    .With(x => x.Party = Faker.EnumFaker.SelectFrom<Party>().ToString())
                    .With(x => x.Name = Faker.NameFaker.Name())
                    .With(x => x.Token = Guid.NewGuid().ToString())
                    .With(x => x.Id = Faker.NumberFaker.Number())
                    .Build();

                context.Voters.AddRange(voters);
            }

        }
    }
}
