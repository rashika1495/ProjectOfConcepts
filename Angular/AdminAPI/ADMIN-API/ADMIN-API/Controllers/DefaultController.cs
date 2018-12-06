using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADMINAPI.DTO;
using ADMINAPI.Helpers;
using ADMINAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ADMINAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public DefaultController(UserManager<ApplicationUser> userManager,
                                    SignInManager<ApplicationUser> signInManager,
                                    IConfiguration configuration)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("RegisterUser")]
        public async Task<IActionResult> RegisterUser(UserDTO dto)
        {
            try
            {
                var user = new ApplicationUser
                {
                    Email = dto.Email,
                    PhoneNumber = dto.ContactNumber,
                    UserName = dto.Email,
                    CreateDate=DateTime.UtcNow
                    
                };
                var result = await _userManager.CreateAsync(user, dto.Password);
                if (result.Succeeded)
                {
                    var context = new ContactDbContext();
                    var user1 = new User
                    {
                        FirstName = dto.FirstName,
                        LastName = dto.LastName,
                        Email = dto.Email,
                        ContactNumber = dto.ContactNumber,
                        Password = dto.Password,
                        IsActive = true
                    };
                    context.User.Add(user1);
                    context.SaveChanges();
                }
                return APIResponseCreator.GetResponse(ResponseCode.SUCCESS_CODE, "Success.", null, System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return APIResponseCreator.GetResponse(ResponseCode.FAILED_CODE, ex.ToString(), null, System.Net.HttpStatusCode.OK);
            }
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginDTO dto)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(dto.Email, dto.Password, dto.RememberMe, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    return APIResponseCreator.GetResponse(ResponseCode.SUCCESS_CODE, "Success.", null, System.Net.HttpStatusCode.OK);
                }
                return APIResponseCreator.GetResponse(ResponseCode.FAILED_CODE, result.ToString(), dto.Email, System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return APIResponseCreator.GetResponse(ResponseCode.FAILED_CODE, ex.ToString(), null, System.Net.HttpStatusCode.OK);
            }
        }
    }
}