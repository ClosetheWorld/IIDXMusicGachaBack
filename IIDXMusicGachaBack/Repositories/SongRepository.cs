using System;
using System.Threading.Tasks;
using IIDXMusicGachaBack.Entities;
using IIDXMusicGachaBack.Infrastructures;
using Microsoft.EntityFrameworkCore;

namespace IIDXMusicGachaBack.Repositories
{
    public class SongRepository : ISongRepository
    {
        private readonly AppDbContext _db;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="db"></param>
        public SongRepository(AppDbContext db)
        {
            _db = db;            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<Song> GetAsync()
        {
            var songs = await _db.Songs.ToListAsync();
            _ = new Random();

            return songs[new Random().Next(0, songs.Count)];
        }
    }
}
