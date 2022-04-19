using HelpDesk.Architecture.Application.Requests;

namespace HelpDesk.Architecture.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}