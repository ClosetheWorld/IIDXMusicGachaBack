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
                .IgnoreAllPropertiesWithAnInaccessibleSetter();
        }
    }
}
