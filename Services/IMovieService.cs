using DailyAdvice.Dtos.MovieDtos;

namespace DailyAdvice.Services
{
    public interface IMovieService
    {
        public Task<List<GetMovieDto>> GetMovieListAsync();
        public Task<GetMovieByIdDto> GetMovieByIdAsync(int id);
        public Task CreateMovieAsync(CreateMovieDto createMovieDto);
        public Task UpdateMovieAsync(UpdateMovieDto updateMovieDto);
        public Task DeleteMovieAsync(string id);
    }
}
