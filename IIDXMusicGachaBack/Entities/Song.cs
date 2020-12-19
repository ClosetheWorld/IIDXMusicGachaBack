using System.ComponentModel.DataAnnotations;

namespace IIDXMusicGachaBack.Entities
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }

        public double Bpm { get; set; }

        public double? MaxBpm { get; set; }

        public string Genre { get; set; }

        public int Level { get; set; }

        public SongDifficulty Difficulty { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum SongDifficulty
    {
        Beginner = 1,
        Normal = 2,
        Hyper = 3,
        Another = 4,
        Leggendaria = 5
    }
}
