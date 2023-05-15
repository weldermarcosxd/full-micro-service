using Microsoft.Extensions.Configuration;

namespace Pdi.Full.Micro.Service.Services.Extensions
{
    public static class ConfigurationExtensions
    {
        private const string JwtSecretKey = "JWT_SECRETKEY"; 
        
        public static string ObterJwtSecret(this IConfiguration configuration)
        {
            return configuration.GetValue(JwtSecretKey, string.Empty);
        }
    }
}