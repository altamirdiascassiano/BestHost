using BestHost.Infra;
using BestHost.Model;
using Newtonsoft.Json;

namespace BestHost.BusinessRules
{
    public class HostAdminBR
    {
        private AdminHostRepository _adminHostRepository = null;
        public HostAdminBR()
        {
            _adminHostRepository = new AdminHostRepository();
        }

        public string GetAllHostAdmin()
        {
            return JsonConvert.SerializeObject(_adminHostRepository.GetAll(), Formatting.Indented);
        }

        public void Add(HostAdmin hostAdmin)
        {
            _adminHostRepository.Add(MapEntityToDBEntity(hostAdmin));
        }

        public void Delete(HostAdmin hostAdmin)
        {
            _adminHostRepository.Delete(MapEntityToDBEntity(hostAdmin));
        }
        public void Update(HostAdmin hostAdmin)
        {
            _adminHostRepository.Update(MapEntityToDBEntity(hostAdmin));
        }

        private HostAdminDB MapEntityToDBEntity(HostAdmin hostAdmin)
        {
            return new HostAdminDB()
            {
                Id= hostAdmin.Id,
                Name = hostAdmin.Name,
                VirtualName = hostAdmin.VirtualName,
                Age = hostAdmin.Age,
                EmailAddress = hostAdmin.EmailAddress,
                FacebookPage = hostAdmin.FacebookPage,
                PhoneNumber = hostAdmin.PhoneNumber
            };
        }
    }
}
