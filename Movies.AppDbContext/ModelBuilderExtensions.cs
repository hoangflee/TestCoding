using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Entities
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(
                new Users() { Id = 1, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false, 
                UserName = "user", PasswordHash = "$2a$10$8gmvdASPQtXPwQQuwpR66u.VOUvH.E66QUoG8egLGUSzcgfpIZgOG", Email = "user@gmail.com" }
            );

            modelBuilder.Entity<Entities.Movies>().HasData(
                new Entities.Movies() { Id = 1, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 1", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 2, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 2", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 3, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 3", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 4, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 4", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 5, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 5", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 6, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 6", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 7, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 7", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 8, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 8", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 9, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 9", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 10, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 10", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },

                new Entities.Movies() { Id = 11, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 11", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 12, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 12", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 13, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 13", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 14, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 14", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 15, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 15", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 16, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 16", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 17, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 17", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 18, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 18", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 19, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 19", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 20, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 20", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },

                new Entities.Movies() { Id = 21, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 21", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 22, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 22", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 23, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 23", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 24, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 24", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 25, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 25", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 26, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 26", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 27, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 27", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 28, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 28", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 29, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 29", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 30, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 30", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },

                new Entities.Movies() { Id = 31, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 31", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 32, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 32", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 33, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 33", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 34, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 34", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 35, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 35", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 36, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 36", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 37, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 37", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 38, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 38", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 39, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 39", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 40, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 40", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },

                new Entities.Movies() { Id = 41, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 41", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 42, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 42", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 43, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 43", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 44, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 44", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 45, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 45", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 46, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 46", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 47, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 47", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 48, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 48", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 49, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 49", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 50, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 50", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },

                new Entities.Movies() { Id = 51, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 51", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 52, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 52", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 53, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 53", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 54, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 54", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 55, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 55", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 56, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 56", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 57, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 57", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 58, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 58", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 59, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 59", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" },
                new Entities.Movies() { Id = 60, Created = DateTime.Now, CreatedBy = string.Empty, Updated = DateTime.Now, UpdatedBy = string.Empty, Deleted = false,
                    Title = "Phim số 60", Likes = 0, Images = "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg" }
            );
        }
    }
}
