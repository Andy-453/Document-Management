using DocumentManagementBackend.Model;

namespace DocumentManagementBackend.Service
{
    public interface IPersonsService
    {
        Task<IEnumerable<Persons>> GetAllPersonsAsync();
        Task<Persons> GetPersonsAsync(int id);
        Task CreatePersonsAsync(Persons person);
        Task UpdatePersonsAsync(Persons person);
        Task SoftDeletePersonsAsync(int id);
    }
}
