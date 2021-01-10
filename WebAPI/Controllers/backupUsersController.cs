//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.Extensions.Options;
//using System.Text;
//using System.Security.Claims;
//using System.IdentityModel.Tokens.Jwt;
//using Microsoft.IdentityModel.Tokens;
//using System.Security.Cryptography;
////using WebAPI.Models;
//using System.Data;
//using Microsoft.Extensions.Configuration;
//using System.Data.SqlClient;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace WebAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UsersController : ControllerBase
//    {

//        //private readonly authenticateDBContext _context;
//        private readonly IConfiguration _configuration;


//        //[HttpGet]
//        //public IEnumerable<User> Get()
//        //{
//        //    using (authenticateDBContext dbContext = new authenticateDBContext())
//        //    {
//        //        return dbContext.Users.ToList();
//        //    }
//        //}


//        [HttpGet]
//        public JsonResult Get()
//        {
//            string query = @"
//                select Email, Password from dbo.Users";
//            DataTable table = new DataTable();
//            string sqlDataSource = "Data Source =.; Initial Catalog = authenticateDB; Integrated Security = True";
//            SqlDataReader myReader;
//            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
//            {
//                myCon.Open();
//                using (SqlCommand myCommand = new SqlCommand(query, myCon))
//                {
//                    myReader = myCommand.ExecuteReader();
//                    table.Load(myReader);
//                    myReader.Close();
//                    myCon.Close();
//                }
//            }

//            return new JsonResult(table);
//        }

//        //public User Get(int id)
//        //{
//        //    using (authenticateDBContext dbContext = new authenticateDBContext())
//        //    {
//        //        return dbContext.Users.FirstOrDefault(e => e.UserId == id);
//        //    }
//        //}

//        //// GET api/<UsersController>/5
//        //[HttpGet("{id}")]
//        //public string Get(int id)
//        //{
//        //    return "value";
//        //}

//        // POST api/<UsersController>
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }

//        // PUT api/<UsersController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/<UsersController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
