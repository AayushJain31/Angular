using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PatientLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCTraining1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        // GET: api/<SecurityController>
        [HttpGet]
        public void Get()
        {
           
        }
        private string GenerateJSONWebToken(string User)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("qwerty@#$%0987uio"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim("Issuer" , "Aayush"),
                new Claim("Admin", "true"),
                new Claim(JwtRegisteredClaimNames.UniqueName, User)
            };

            var token = new JwtSecurityToken("Aayush",
            "Aayush",
            claims,
            expires: DateTime.Now.AddMinutes(60),
            signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        // GET api/<SecurityController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<SecurityController>
        [HttpPost]
        public IActionResult Post([FromBody] Users UserObj)
        {
            if (UserObj.user.Equals("Aayush") && UserObj.password.Equals("Aayush"))
            {
                string token =  GenerateJSONWebToken(UserObj.user);
                //JObject json = JObject.Parse(token);
                return Ok(token);
            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized);
            }
        }

        // PUT api/<SecurityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SecurityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
