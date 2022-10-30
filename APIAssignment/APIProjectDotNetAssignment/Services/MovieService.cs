using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEFCodeFirst.Entities;
using HandsOnAPIUsingEFCodeFirst.Interfaces;
using HandsOnAPIUsingEFCodeFirst.Database;
using System.Numerics;

namespace HandsOnAPIUsingEFCodeFirst.Services
{
    public class MovieService : MovieInterface
    {
        private readonly ECommerceDBContext context;
        public MovieService()
        {
            this.context = new ECommerceDBContext();
        }
        public void AddMovie(Movie movie)
        {
            context.Movies.Add(movie);
            context.SaveChanges();
        
        }

        public void DeleteMovie(int id)
        {
            Movie movie = context.Movies.SingleOrDefault(i => i.MovieId == id);
            context.Movies.Remove(movie);
            context.SaveChanges();
        }

        public void EditMovie(Movie movie)
        {
            context.Movies.Update(movie);
            context.SaveChanges();
        }

        public Movie GetMovieByID(int id)
        {
            Movie product = context.Movies.SingleOrDefault(i => i.MovieId == id);
            return product;
        }

        public List<Movie> GetAllMovies()
        {
           return context.Movies.ToList();
        }

        public Movie GetMoviesByActor(string actor)
        {
            Movie movie = context.Movies.SingleOrDefault(i => i.actor.Equals(actor));
            return movie;
        }

        public Movie GetMoviesByLang(string lang)
        {
            Movie movie = context.Movies.SingleOrDefault(i => i.lang.Equals(lang));
            return movie;
        }

        public Movie GetMoviesByDirector(string director)
        {
            Movie movie = context.Movies.SingleOrDefault(i => i.director.Equals(director));
            return movie;
        }

    }
}
