using Document_Management_Backend.Repository;
using DocumentManagementBackend.Model;

namespace Document_Management_Backend.Service
{
    public class DocumentsService : IDocumentsService
    {
        private readonly IDocumentsRepository _documentsRepository;

        public DocumentsService(IDocumentsRepository DocumentsRepository)
        {
            _documentsRepository = DocumentsRepository;
        }

        public Task<IEnumerable<Documents>> GetAllDocumentsAsync()
        {
            return _documentsRepository.GetAllDocumentsAsync();
        }

        public Task<Documents> GetDocumentsAsync(int id)
        {
            return _documentsRepository.GetDocumentsAsync(id);
        }

        public async Task CreateDocumentsAsync(Documents document)
        {
            await _documentsRepository.CreateDocumentsAsync(document);
        }

        public async Task UpdateDocumentsAsync(Documents document)
        {
            await _documentsRepository.UpdateDocumentsAsync(document);
        }

        public async Task SoftDeleteDocumentsAsync(int id)
        {
            await _documentsRepository.SoftDeleteDocumentsAsync(id);
        }
    }
} 