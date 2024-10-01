using DocumentManagementBackend.Model;

namespace DocumentManagementBackend.Service
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
 