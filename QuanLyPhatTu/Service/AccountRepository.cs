//using Microsoft.AspNetCore.Identity;
//using Microsoft.IdentityModel.JsonWebTokens;
//using QuanLyPhatTu.Entities;
//using QuanLyPhatTu.IService;
//using QuanLyPhatTu.Model;
//using System.Security.Claims;

//namespace QuanLyPhatTu.Service
//{
//    public class AccountRepository : IAccountRepository
//    {
//        private readonly UserManager<ApplicationUser> userManager;
//        private readonly SignInManager<ApplicationUser> signInManager;
//        private readonly IConfiguration configuration;

//        public AccountRepository(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager, IConfiguration configuration) 
//        {
//            this.userManager = userManager; ;
//            this.signInManager = signInManager;
//            this.configuration = configuration;
//        }
//        public async Task<string> SignInAsync(SignInModel model)
//        {
//            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
//            if(!result.Succeeded)
//            {
//                return string.Empty;
//            }
//            var authClaims = new List<Claim>
//            {
//                new Claim(ClaimTypes.Email, model.Email),
//                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
//            };
            
//        }

//        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
//        {
//            var user = new ApplicationUser
//            {
//                Ho = model.Ho,
//                Ten = model.Ten,
//                TenDem = model.TenDem,
//                Email = model.Email,
//                UserName = model.Email

//            };
//            return await userManager.CreateAsync(user,model.Password);
//        }
//    }
//}
