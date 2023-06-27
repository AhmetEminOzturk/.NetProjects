using APlusMicroServiceProject.IdentityServer.Dtos;
using APlusMicroServiceProject.IdentityServer.Models;
using APlusMicroServiceProject.Shared.Dtos;
using IdentityServer4.Hosting.LocalApiAuthentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using static IdentityServer4.IdentityServerConstants;

namespace APlusMicroServiceProject.IdentityServer.Controllers
{
    [Authorize(LocalApi.PolicyName)]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpDto signUpDto)
        {
            var user = new ApplicationUser()
            {
                UserName = signUpDto.Username,
                Email = signUpDto.Email,
                UserCity = signUpDto.UserCity,
                UserCountry = signUpDto.UserCountry
            };
            var result = await _userManager.CreateAsync(user, signUpDto.Password);
            if (!result.Succeeded) 
            {
                return BadRequest(Response<NoContent>.Fail(result.Errors.Select(x=> x.Description).ToList(),400));
            }
            return NoContent();
        }
    }
}
