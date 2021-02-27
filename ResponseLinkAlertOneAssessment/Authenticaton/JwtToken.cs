using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponseLinkAlertOneAssessment.Authenticaton
{
    public class JwtToken
    {
        // this key would be stored elsewhere in a non-demo application
        // key must be > 256
        private const string SECRET_KEY = "tUsCcTSddc8GTfdtsyWNZhkbF5r87J4JLeXTLdDyanFp9wtTxnh2Z3xwhy53VGMHNawFMZftt2JEaMUK2P36NHqq9yZJg26peZGhUzyuwhrmN2TmNpuUvSBKjsUcx8h2keM5SHWqhhFaHqDm4LQ2ffvsVASnrHPmqFheQYp5jxh4nk2fC5eK28sV2Mzpj6rG6FcQU8ELz7eCyj7Z8DgfqC8J4K8Dp4MmKbpDr8ybkJPYrsxBTBBVVqrkEhZawWYd";
        public static readonly SymmetricSecurityKey SIGNING_KEY =
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET_KEY));

        public static string GenerateJwtToken()
        {
            var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials
                (SIGNING_KEY, SecurityAlgorithms.HmacSha256);

            var header = new JwtHeader(credentials);

            DateTime expires = DateTime.UtcNow.AddMinutes(10);
            int ts = (int)(expires - new DateTime(1970, 1, 1)).TotalSeconds;

            var payload = new JwtPayload
            {
                {"sub", "testSubject" },
                {"Name", "Tom" },
                {"email", "thomasgriffith91@gmail.com" },
                {"exp", ts },
                {"iss", "https://localhost:44321" },
                {"aud", "https://localhost:44321" }
            };

            var secToken = new JwtSecurityToken(header, payload);
            var handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(secToken);
        }
    }
}
