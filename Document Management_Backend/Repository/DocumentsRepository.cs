using DocumentManagementBackend.Context;
using DocumentManagementBackend.Model;
using Microsoft.EntityFrameworkCore;

namespace DocumentManagementBackend.Repository
{
    public class DocumentsRepository : IDocumentsRepository
    {
        private readonly DMDbContext _context;

        public DocumentsRepository(DMDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Documents>> GetAllDocumentsAsync()
        {
            return await _context.Documents
                .Where(s => !s.IsDeleted)
                .ToListAsync();
        }

        public async Task<Documents> GetDocumentsAsync(int id)
        {
            return await _context.Documents
                .FirstOrDefaultAsync(s => s.Id == id && !s.IsDeleted);
        }

        public async Task SoftDeleteDocumentsAsync(int id)
        {
            var documents = await _context.Documents.FindAsync(id);
            if (documents != null)
            {
                documents.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public Task UpdateDocumentsAsync(Documents documents)
        {
            throw new NotImplementedException();
        }

        public async Task CreateDocumentsAsync(Documents documents)
        {
            await _context.Documents.AddAsync(documents);
            await _context.SaveChangesAsync();  
        }
    }
}
