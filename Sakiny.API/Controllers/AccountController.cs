using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sakiny.DTO;
using Sakiny.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Sakiny.Services;
using Sakiny.Repository.UnitOfWork;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IConfiguration configuration;
        private IMapper _mapper;
        private AccountService _accountService;
        IUnitOfWork _unitOfWork;
        public AccountController(UserManager<ApplicationUser> userManager, IConfiguration configuration,IMapper mapper, AccountService accountService, IUnitOfWork unitOfWork)
        {
            this.userManager = userManager;
            this.configuration = configuration;
            _mapper=mapper;
            _accountService = accountService;
            _unitOfWork = unitOfWork;
        }

        [HttpPost("UserRegister")]
        public async Task<IActionResult> UserRegister(RegisterUserDto registerUserDto)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser ApplicationUser = _mapper.Map<ApplicationUser>(registerUserDto);

                IdentityResult result = await userManager.CreateAsync(ApplicationUser, registerUserDto.Password);
                RegisterDto registerDto = new RegisterDto();

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(ApplicationUser, "User");
                    User user = new User();
                    user.ApplicationUserId = ApplicationUser.Id;
                    user.NationalNumber = registerUserDto.NationalNumber;

                    _accountService.AddUser(user);
                    _unitOfWork.CommitChanges();

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
        public async Task<IActionResult> OwnerRegister(RegisterOwnerDto registerOwnerDto)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser ApplicationUser = _mapper.Map<ApplicationUser>(registerOwnerDto);

                IdentityResult result = await userManager.CreateAsync(ApplicationUser, registerOwnerDto.Password);
                RegisterDto registerDto = new RegisterDto();

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(ApplicationUser, "Owner");
                    Owner owner = new Owner();
                    owner.ApplicationUserId = ApplicationUser.Id;
                    owner.IdentityImage = registerOwnerDto.IdntityImage;

           
                    _accountService.AddOwner(owner);
                    _unitOfWork.CommitChanges();

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
        public async Task<IActionResult> CookerRegister(RegisterCookerDto registerCookerDto)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser ApplicationUser = _mapper.Map<ApplicationUser>(registerCookerDto);

                IdentityResult result = await userManager.CreateAsync(ApplicationUser, registerCookerDto.Password);
                RegisterDto registerDto = new RegisterDto();

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(ApplicationUser, "Cooker");
                    Cooker cooker = new Cooker();
                    cooker.ApplicationUserId = ApplicationUser.Id;
                    cooker.Availability = registerCookerDto.Availablility;


                    _accountService.AddCooker(cooker);
                    _unitOfWork.CommitChanges();

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
        public async Task<IActionResult> AdminRegister(RegisterAdminDto registerAdminDto)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser ApplicationUser = _mapper.Map<ApplicationUser>(registerAdminDto);

                IdentityResult result = await userManager.CreateAsync(ApplicationUser, registerAdminDto.Password);
                RegisterDto registerDto = new RegisterDto();

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(ApplicationUser, "Admin");
                    Admin admin = new Admin();
                    admin.ApplicationUserId = ApplicationUser.Id;


                    _accountService.AddAdmin(admin);
                    _unitOfWork.CommitChanges();

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

