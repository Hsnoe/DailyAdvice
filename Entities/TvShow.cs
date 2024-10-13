namespace DailyAdvice.Entities
{
    public class TvShow
    {
        public int TvShowId { get; set; }
        public string TvShowName { get; set; }
        public string TvShowDescription { get; set; }
        public int TvShowRate { get; set; }
        public string TvShowImageUrl { get; set; }
        public DateTime TvShowDate { get; set; }
        public string TvShowComment { get; set; }
        public int TvShowDrictor { get; set; }
    }
}
