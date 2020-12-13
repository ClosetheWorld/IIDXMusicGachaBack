using System.Threading.Tasks;
using IIDXMusicGachaBack.Entities;

namespace IIDXMusicGachaBack.Repositories
{
    public interface ISongRepository
    {
        Task<Song> GetAsync();
    }
}
