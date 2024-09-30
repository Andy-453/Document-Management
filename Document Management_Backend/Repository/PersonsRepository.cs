using DocumentManagementBackend.Context;
using DocumentManagementBackend.Model;
using Microsoft.EntityFrameworkCore;

namespace Document_Management_Backend.Repository
{
    public class PersonsRepository : IPersonsRepository
    {
        private readonly DMDbContext _context;

        public PersonsRepository(DMDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Persons>> GetAllPersonsAsync()
        {
            return await _context.Persons
                .Where(s => !s.IsDeleted)
                .ToListAsync();
        }

        public async Task<Persons> GetPersonsAsync(int id)
        {
            return await _context.Persons
                .FirstOrDefaultAsync(s => s.Id == id && !s.IsDeleted);
        }

        public async Task SoftDeletePersonsAsync(int id)
        {
            var persons = await _context.Persons.FindAsync(id);
            if (persons != null)
            {
                persons.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public Task UpdatePersonsAsync(Persons persons)
        {
            throw new NotImplementedException();
        }

        public Task CreatePersonsAsync(Persons persons)
        {
            throw new NotImplementedException();
        }
    }
}
