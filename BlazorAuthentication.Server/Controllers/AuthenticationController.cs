using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAuthentication.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        public IdentityDbContext IdentityDbContext { get; }

        public AuthenticationController(IdentityDbContext identityDbContext)
        {
            IdentityDbContext = identityDbContext;
        }

        public IActionResult Login(string username, string password)
        {
        }
    }
}