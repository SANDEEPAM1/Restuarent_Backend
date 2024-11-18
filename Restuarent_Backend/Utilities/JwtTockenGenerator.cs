using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Restuarent_Backend.Utilities
{
    public  class JwtTockenGenerator
    {
        private static string _jwtKey;
        private static string _jwtIssure;
        private static string _jwtAudience;

        public JwtTockenGenerator(IConfiguration configuration)
        {
            _jwtKey = configuration["Jwt:Key"];
            _jwtIssure = configuration["Jwt:Issuer"];
            _jwtAudience = configuration["Jwt:Audience"];
        }
        public string GenerateJwtToken(IdentityUser user, IList<string> roles)
        {
            var Claims = new List<Claim>  
           {
             new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
             new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
             new Claim("UserId",user.Id)
           };

            foreach (var role in roles)
            {
                Claims.Add(new Claim(ClaimTypes.Role, role));
                Claims.Add(new Claim("role", role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtKey));
            var credentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwtIssure,
                audience: _jwtAudience,
                claims: Claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);
            
               return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
