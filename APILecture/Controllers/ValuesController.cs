using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FizzWare.NBuilder;

namespace APILecture.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Voter> Get()
        {

            var model = Builder<Voter>.CreateListOfSize(3)
                .All()
                .With(x => x.Party = Faker.EnumFaker.SelectFrom<Party>().ToString())
                .With(x => x.Name = Faker.NameFaker.Name())
                .With(x => x.Token = Guid.NewGuid().ToString())
                .With(x => x.Id = Faker.NumberFaker.Number())
        .Build();



            return model;
        }

        // GET api/values/5
        public Voter Get(int id)
        {
            var model = Builder<Voter>.CreateNew()
               .With(x => x.Party = Faker.EnumFaker.SelectFrom<Party>().ToString())
               .With(x => x.Name = Faker.NameFaker.Name())
               .With(x => x.Token = Guid.NewGuid().ToString())
               .With(x => x.Id = id)
        .Build();

            return model;
        }

        [Route("api/Values/AllBlackPeopleThatAreRepublican")]
        public IEnumerable<Voter> GetAllVotersThatAreRegisterd()
        {
            var model = Builder<Voter>.CreateListOfSize(1)
              .All()
              .With(x => x.Party = Faker.EnumFaker.SelectFrom<Party>().ToString())
              .With(x => x.Name = Faker.NameFaker.Name())
              .With(x => x.Token = Guid.NewGuid().ToString())
              .With(x => x.Id = Faker.NumberFaker.Number())
      .Build();


            return model;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public enum Party
    {
        Democrat,
        Republican,
        Libertityian,
        Independent

    }
}
