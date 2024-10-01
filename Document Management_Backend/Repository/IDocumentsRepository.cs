using DocumentManagementBackend.Model;

namespace Document_Management_Backend.Repository
{
    public interface IDocumentsRepository
    {
        Task<IEnumerable<Documents>> GetAllDocumentsAsync();
        Task<Documents> GetDocumentsAsync(int id);
        Task CreateDocumentsAsync(Documents documents);
        Task UpdateDocumentsAsync(Documents documents);
        Task SoftDeleteDocumentsAsync(int id);
    }
}
