using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiceLibrary.DataContext;

namespace SampleService.Controllers
{
    public class CarsController : ApiController
    {
        // GET: api/Cars
        public IEnumerable<Model> Index()
        {
            //return new string[] { "value1", "value2" };
            using (var context = new ExperimentationDBEntities())
            {
                var allModels = from model in context.Models
                                select model;

                return allModels;
            }

            ////return new string[] { "value1", "value2" };
            //using (var context = new ServiceLibrary.DataContext.ExperimentationDBEntities())
            //{
            //    var allModels = from model in context.Models
            //                    select model;

            //    return allModels;
            //}
        }

        // GET: api/Cars
        public IEnumerable<Model> Get()
        {
            {
                //return new string[] { "value1", "value2" };
                using (var context = new ExperimentationDBEntities())
                {
                    var allModels = from model in context.Models
                                    select model;

                    var models = allModels.ToList();

                    return models;
                }
            }
        }

        // GET: api/Cars/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cars
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cars/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cars/5
        public void Delete(int id)
        {
        }
    }
}
