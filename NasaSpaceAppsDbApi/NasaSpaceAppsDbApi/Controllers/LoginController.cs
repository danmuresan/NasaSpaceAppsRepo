using NasaSpaceAppsDbApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace NasaSpaceAppsDbApi.Controllers
{
    public class LoginController : ApiController
    {
        private NasaDbContext db = new NasaDbContext();

        [ResponseType(typeof(User))]
        public async Task<IHttpActionResult> CheckLoginCredentials(LoginModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var foundUser = await db.Users.FirstOrDefaultAsync(x => x.Username == user.Username && x.Password == user.Password);

            if (foundUser == null)
            {
                return Ok(false);
            }
            else
            {
                return Ok(user);
            }
        }
    }
}
