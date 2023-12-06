

using Async.Models;

namespace Async.Services.IService
{
    public interface IAlbum
    {

        Task<List<Album>> GetAllAlbums();

    }
}
