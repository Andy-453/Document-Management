using Document_Management_Backend.Repository;
using DocumentManagementBackend.Model;

namespace Document_Management_Backend.Service
{
    public class PersonsService : IPersonsService
    {
        private readonly IPersonsRepository _personsRepository;

        public PersonsService(IPersonsRepository personsRepository)
        {
            _personsRepository = personsRepository;
        }

        public Task<IEnumerable<Persons>> GetAllPersonsAsync()
        {
            return _personsRepository.GetAllPersonsAsync();
        }

        public Task<Persons> GetPersonsAsync(int id)
        {
            return _personsRepository.GetPersonsAsync(id);
        }

        public async Task CreatePersonsAsync(Persons person)
        {
            await _personsRepository.CreatePersonsAsync(person);
        }

        public async Task UpdatePersonsAsync(Persons person)
        {
            await _personsRepository.UpdatePersonsAsync(person);
        }

        public async Task SoftDeletePersonsAsync(int id)
        {
            await _personsRepository.SoftDeletePersonsAsync(id);
        }
    }
}
