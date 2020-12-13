using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using IIDXMusicGachaBack.Entities;
using IIDXMusicGachaBack.Entities.Dtos;
using IIDXMusicGachaBack.Repositories;
using IIDXMusicGachaBack.Usecases;

namespace IIDXMusicGachaBack.Interactors
{
    public class GetSongInteractor : IGetSongUsecase
    {
        private readonly IMapper _mapper;
        private readonly ISongRepository _repo;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="repo"></param>
        public GetSongInteractor(IMapper mapper, ISongRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public async Task<List<GetSongResponse>> GetAsync(int count)
        {
            List<Song> songs = new List<Song>();
            for (int i = 0; i < count; i++)
            {
                songs.Add(await _repo.GetAsync());
            }

            return _mapper.Map<List<GetSongResponse>>(songs);
        }
    }
}
