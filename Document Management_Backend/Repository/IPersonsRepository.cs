using DocumentManagementBackend.Model;

namespace DocumentManagementBackend.Repository
{
    public interface IPersonsRepository
    {
        Task<IEnumerable<Persons>> GetAllPersonsAsync();
        Task<Persons> GetPersonsAsync(int id);
        Task CreatePersonsAsync(Persons persons);
        Task UpdatePersonsAsync(Persons persons);
        Task SoftDeletePersonsAsync(int id);
    }
}
