using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEFCodeFirst.Entities;
namespace HandsOnAPIUsingEFCodeFirst.Interfaces
{
    public interface MovieInterface
    {
        List<Movie> GetAllMovies();
        Movie GetMovieByID(int id);
        void AddMovie(Movie movie);
        void DeleteMovie(int id);
        void EditMovie(Movie product);
        Movie GetMoviesByLang(string lang);
        Movie GetMoviesByActor(string actor);
        Movie GetMoviesByDirector(string director);
    }
}
