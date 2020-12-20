using AutoMapper;

namespace IIDXMusicGachaBack.Entities.Dtos.Mappings
{
    public class SongMapping : Profile
    {
        /// <summary>
        /// mapping setting
        /// </summary>
        public SongMapping()
        {
            CreateMap<Song, GetSongResponse>()
                .ForMember(x => x.Bpm, y => y.MapFrom(z => z.MaxBpm != null ? z.Bpm.ToString() + " - " + z.MaxBpm.ToString() : z.Bpm.ToString()))
                .IgnoreAllPropertiesWithAnInaccessibleSetter();
        }
    }
}
