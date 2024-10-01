using DocumentManagementBackend.Model;

namespace Document_Management_Backend.Service
{
    public interface IDocumentsService
    {
        Task<IEnumerable<Documents>> GetAllDocumentsAsync();
        Task<Documents> GetDocumentsAsync(int id);
        Task CreateDocumentsAsync(Documents document);
        Task UpdateDocumentsAsync(Documents document);
        Task SoftDeleteDocumentsAsync(int id);
    }
}
 