using System;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    public class ClientConfiguration
    {
        public Guid ClientConfigurationId { get; set; }
        public string AccountLogin { get; set; }
        public string AccountPassword { get; set; }
        public string LoginUrl { get; set; }
        public bool IsActive { get; set; }

        public static ClientConfiguration Create(string login, string password, string loginUrl, bool isActive)
        {
            return new ClientConfiguration
            {
                ClientConfigurationId = Guid.NewGuid(),
                AccountLogin = login,
                AccountPassword = password,
                LoginUrl = loginUrl,
                IsActive = isActive
            };
        }
    }
}
