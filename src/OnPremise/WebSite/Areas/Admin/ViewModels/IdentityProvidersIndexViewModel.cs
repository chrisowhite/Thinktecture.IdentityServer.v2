using System.Linq;

namespace Thinktecture.IdentityServer.Web.Areas.Admin.ViewModels
{
    public class IdentityProvidersIndexViewModel
    {
        private Repositories.IIdentityProviderRepository identityProviderRepository;

        public IdentityProvidersIndexViewModel(Repositories.IIdentityProviderRepository identityProviderRepository)
        {
            // TODO: Complete member initialization
            this.identityProviderRepository = identityProviderRepository;
            this.IdentityProviders =
                identityProviderRepository.GetAll()
                .Select(x => new IPModel { ID = x.ID, Name = x.DisplayName })
                .ToArray();
        }

        public IPModel[] IdentityProviders { get; set; }
    }

    public class IPModel 
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool Delete { get; set; }
    }
}