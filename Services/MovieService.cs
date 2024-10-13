using AutoMapper;
using DailyAdvice.Context;
using DailyAdvice.Dtos.MovieDtos;
using DailyAdvice.Entities;
using Microsoft.EntityFrameworkCore;

namespace DailyAdvice.Services
{
    public class MovieService : IMovieService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public MovieService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateMovieAsync(CreateMovieDto createMovieDto)
        {
            var movie = _mapper.Map<Movie>(createMovieDto);
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
        }

        public Task DeleteMovieAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<GetMovieByIdDto> GetMovieByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetMovieDto>> GetMovieListAsync()
        {
            var values = await _context.Movies.ToListAsync();
            return _mapper.Map<List<GetMovieDto>>(values);
        }

        public Task UpdateMovieAsync(UpdateMovieDto updateMovieDto)
        {
            throw new NotImplementedException();
        }
    }
}
