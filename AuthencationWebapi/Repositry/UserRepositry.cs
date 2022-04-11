using AuthencationWebapi.Context;
using AuthencationWebapi.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AuthencationWebapi.Repositry
{
    public class UserRepositry : IUserRepositry
    {
        private readonly UserContext _user;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _singinmanager;
        private readonly IConfiguration _configuration;

        public UserRepositry(UserContext user, UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> singinmanager, IConfiguration configuration) { _user = user;_userManager = userManager;_singinmanager = singinmanager;_configuration = configuration; }
        public async Task<IdentityResult> register(tbluser user)
        {
            var users = new ApplicationUser()
            {
                fname=user.fname,
                lname=user.lname,   
               Email=user.email,
                UserName = user.email
            };
            return await _userManager.CreateAsync(users,user.password);
            
        }
        public async Task<string> LoginAsync(loginmodel singin)
        {
            var result = await _singinmanager.PasswordSignInAsync(singin.email, singin.password, false, false);

            if (!result.Succeeded)
            {
                return null;
            }

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, singin.email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public async Task<ICollection<tbluser>> userlists()
        {
            return await _user.Tblusers.ToListAsync();
        }
    }
}
