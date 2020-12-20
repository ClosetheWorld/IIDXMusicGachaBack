namespace IIDXMusicGachaBack.Entities.Dtos
{
    public class GetSongResponse
    {
        public string Title { get; set; }

        public string Artist { get; set; }

        public string Bpm { get; set; }

        public string Genre { get; set; }

        public int Level { get; set; }

        public SongDifficulty Difficulty { get; set; }
    }
}
