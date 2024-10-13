namespace DailyAdvice.Dtos.MovieDtos
{
    public class UpdateMovieDto
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public int MovieRate { get; set; }
        public string MovieImageUrl { get; set; }
        public DateTime MovieDate { get; set; }
        public string MovieComment { get; set; }
        public int MovieDrictor { get; set; }
    }
}
