using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using StarterProject.Api.Data;
using StarterProject.Api.Data.Entites;
using StarterProject.Api.Features.Users;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarterProject.Api.Controllers
{
    [Route("api/[controller]")]
    public class UserResultController : Controller
    {
        private readonly DataContext dataContext;
        private readonly IUserRepository _userRepository;

        public UserResultController(DataContext _dataContext, IUserRepository userRepository)
        {
            _dataContext = dataContext;
            _userRepository = userRepository;


        }

        [HttpGet]
        public IActionResult GetResult(int userid)
        {
            var user = _userRepository.GetResult(userid);
            return Ok(user);
        }



        [HttpPost]
        public IActionResult StoreResult(int userid, UserResultDto dto)
        {
             //var userResults = dataContext.Set<UserResult>().;
             //userResults = u;
            
            dataContext.SaveChanges();
            return Ok(true);

        }
        
    }
}
