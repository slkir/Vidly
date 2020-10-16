using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Vidly.Dto;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // API /api/movies
        [HttpGet]
        public IEnumerable<MovieDto> GetMovies()
        {
            return _context.Movies.Select(Mapper.Map<Movie, MovieDto>);
        }

        // API /api/movies/1
        [HttpGet]
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        // API /api/movies
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (ModelState.IsValid)
            {
                var movieToAdd = Mapper.Map<MovieDto, Movie>(movieDto);
                movieToAdd.DateAdded = DateTime.Now;
                movieToAdd.ReleaseDate = DateTime.Now;

                _context.Movies.Add(movieToAdd);
                _context.SaveChanges();

                movieDto.Id = movieToAdd.Id;
                return Created(new Uri(Request.RequestUri + "/" + movieDto.Id), movieDto);
            }
            else
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.BadRequest);
            }
        }

        // API /api/movies/1
        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movieToDelete = _context.Movies.FirstOrDefault(m => m.Id == id);

            if (movieToDelete == null)
                return NotFound();

            _context.Movies.Remove(movieToDelete);
            _context.SaveChanges();

            return Ok();
        }

        // API /api/movies/
        [HttpPut]
        public IHttpActionResult EditMovie(MovieDto movieDto)
        {
            var existingMovie = _context.Movies.SingleOrDefault(m => m.Id == movieDto.Id);

            if (existingMovie == null)
                return NotFound();

            existingMovie.Name = movieDto.Name;
            _context.SaveChanges();

            existingMovie.Id = movieDto.Id;

            return Ok(Mapper.Map<Movie, MovieDto>(_context.Movies.Single(m => m.Id == movieDto.Id)));
        }
    }
}