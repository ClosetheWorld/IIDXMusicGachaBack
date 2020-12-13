using System.Collections.Generic;
using System.Threading.Tasks;
using IIDXMusicGachaBack.Entities.Dtos;

namespace IIDXMusicGachaBack.Usecases
{
    public interface IGetSongUsecase
    {
        Task<List<GetSongResponse>> GetAsync(int count);
    }
}
