using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sakiny.DTO;
using Sakiny.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IConfiguration configuration;

        public AccountController(UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }

        [HttpPost("UserRegister")]
        public async Task<IActionResult> UserRegister(RegisterUserDto registerUserDto)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser ApplicationUser = new ApplicationUser();
                ApplicationUser.FirstName = registerUserDto.FirstName;
                ApplicationUser.LastName = registerUserDto.LastName;
                ApplicationUser.Email = registerUserDto.Email;
                ApplicationUser.Address = registerUserDto.Address;
                ApplicationUser.UserName = registerUserDto.UserName;
                ApplicationUser.Email = registerUserDto.Email;
                ApplicationUser.ProfileImage = registerUserDto.ProfileImage;
                ApplicationUser.IsDeleted = false;
                IdentityResult result = await userManager.CreateAsync(ApplicationUser, registerUserDto.Password);
                RegisterDto registerDto = new RegisterDto();

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(ApplicationUser, "User");
                    User user = new User();
                    user.ApplicationUserId = ApplicationUser.Id;
                    user.NationalNumber = registerUserDto.NationalNumber;

                  //  accountRepository.AddShipper(shipper);
                    registerDto.Message = "Success";    
                    return Ok(registerDto);
                }
                else
                    registerDto.Message = "Failed";
                return BadRequest(registerDto);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost("OwnerRegister")]
        public async Task<IActionResult> OwnerRegister(RegisterUserDto registerUserDto)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser ApplicationUser = new ApplicationUser();
                ApplicationUser.FirstName = registerUserDto.FirstName;
                ApplicationUser.LastName = registerUserDto.LastName;
                ApplicationUser.Email = registerUserDto.Email;
                ApplicationUser.Address = registerUserDto.Address;
                ApplicationUser.UserName = registerUserDto.UserName;
                ApplicationUser.Email = registerUserDto.Email;
                ApplicationUser.ProfileImage = registerUserDto.ProfileImage;
                ApplicationUser.IsDeleted = false;
                IdentityResult result = await userManager.CreateAsync(ApplicationUser, registerUserDto.Password);
                RegisterDto registerDto = new RegisterDto();

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(ApplicationUser, "Owner");
                    Owner owner = new Owner();
                    owner.ApplicationUserId = ApplicationUser.Id;
                    owner.IdentityImage = registerUserDto.IdntityImage;

                    //  accountRepository.AddShipper(shipper);
                    registerDto.Message = "Success";
                    return Ok(registerDto);
                }
                else
                    registerDto.Message = "Failed";
                return BadRequest(registerDto);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost("CookerRegister")]
        public async Task<IActionResult> CookerRegister(RegisterUserDto registerUserDto)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser ApplicationUser = new ApplicationUser();
                ApplicationUser.FirstName = registerUserDto.FirstName;
                ApplicationUser.LastName = registerUserDto.LastName;
                ApplicationUser.Email = registerUserDto.Email;
                ApplicationUser.Address = registerUserDto.Address;
                ApplicationUser.UserName = registerUserDto.UserName;
                ApplicationUser.Email = registerUserDto.Email;
                ApplicationUser.ProfileImage = registerUserDto.ProfileImage;
                ApplicationUser.IsDeleted = false;
                IdentityResult result = await userManager.CreateAsync(ApplicationUser, registerUserDto.Password);
                RegisterDto registerDto = new RegisterDto();

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(ApplicationUser, "Cooker");
                    Cooker cooker = new Cooker();
                    cooker.ApplicationUserId = ApplicationUser.Id;
                    cooker.Availability = registerUserDto.Availablility;

                    //  accountRepository.AddShipper(shipper);
                    registerDto.Message = "Success";
                    return Ok(registerDto);
                }
                else
                    registerDto.Message = "Failed";
                return BadRequest(registerDto);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost("AdminRegister")]
        public async Task<IActionResult> AdminRegister(RegisterUserDto registerUserDto)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser ApplicationUser = new ApplicationUser();
                ApplicationUser.FirstName = registerUserDto.FirstName;
                ApplicationUser.LastName = registerUserDto.LastName;
                ApplicationUser.Email = registerUserDto.Email;
                ApplicationUser.Address = registerUserDto.Address;
                ApplicationUser.UserName = registerUserDto.UserName;
                ApplicationUser.Email = registerUserDto.Email;
                ApplicationUser.ProfileImage = registerUserDto.ProfileImage;
                ApplicationUser.IsDeleted = false;
                IdentityResult result = await userManager.CreateAsync(ApplicationUser, registerUserDto.Password);
                RegisterDto registerDto = new RegisterDto();

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(ApplicationUser, "Admin");
                    Admin admin = new Admin();
                    admin.ApplicationUserId = ApplicationUser.Id;
                    

                    //  accountRepository.AddShipper(shipper);
                    registerDto.Message = "Success";
                    return Ok(registerDto);
                }
                else
                    registerDto.Message = "Failed";
                return BadRequest(registerDto);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }



        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginUserDto userDto)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser applicationUser = await userManager.FindByNameAsync(userDto.UserName);//.FindByNameAsync(userDto.UserName);
                LoginDto loginDto = new LoginDto();
                if (applicationUser != null && await userManager.CheckPasswordAsync(applicationUser, userDto.Password))
                {

                    var authKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:SecretKey"]));
                    SigningCredentials credentials = new SigningCredentials(authKey, SecurityAlgorithms.HmacSha256);

                    List<Claim> myClaims = new List<Claim>();

                    myClaims.Add(new Claim(ClaimTypes.NameIdentifier, applicationUser.Id));
                    myClaims.Add(new Claim(ClaimTypes.Name, applicationUser.UserName));
                    myClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

                    JwtSecurityToken MyToken = new JwtSecurityToken(
                        issuer: configuration["JWT:ValidIssuer"],
                        audience: configuration["JWT:ValidAudience"],
                        expires: DateTime.Now.AddHours(6),
                        claims: myClaims,


                        signingCredentials: credentials
                        );
                    loginDto.Message = "Success";

                    return Ok(
                        new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(MyToken),
                            expiration = MyToken.ValidTo,
                            Messege = "Success"
                        });

                }
                else
                {
                    loginDto.Message = "Invalid UserName";
                    return BadRequest(loginDto);
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }

}

