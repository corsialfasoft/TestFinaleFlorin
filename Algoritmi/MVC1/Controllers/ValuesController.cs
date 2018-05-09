using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVC1.Models;

namespace MVC1.Controllers {
	public class ValuesController : ApiController {
		// GET api/values
		DomainModel dm = new DomainModel();
		public IEnumerable<Menu> Get() {
			return dm.CercaMenu("");
		}

		// GET api/values/5
		public Menu Get(int id) {
			return dm.VediMenu(id);
		}

		// POST api/values
		public void Post([FromBody]Menu value) {
			dm.AddMenu(value);
		}

		// PUT api/values/5
		public void Put(int id,[FromBody]string value) {
		}

		// DELETE api/values/5
		public void Delete(int id) {
		}
		[Route("../api/values/primi")]
		[HttpGet]
		public List<Primo> Primi (){
			return dm.VediMenu(1).primi;
		}
		[Route("../api/values/secondi")]
		[HttpGet]
		public List<Secondo> Secondi(){
			return dm.VediMenu(1).secondi;
		}

	}
}
