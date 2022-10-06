using AutoMapper;
using Microsoft.AspNetCore.Http;
using Movies.AppDbContext;
using Movies.Entities;
using Movies.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Service
{
    public class UserLikeMovieService : IUserLikeMovieService
    {
        private MovieDbContext _context;

        public UserLikeMovieService(MovieDbContext context)
        {
            _context = context;
        }

        public UserLikeMovies GetByUserIdAndMovieId(int userId, int movieId)
        {
            return _context.UserLikeMovies.Where(x => !x.Deleted && 
                (x.UserId == userId && x.MovieId == movieId)
            ).FirstOrDefault();
        }
    }
}
