using Ono.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ono.DAL
{
    public class OnoInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<OnoContext>
    {
        protected override void Seed(OnoContext context)
        {
            var users = new List<User>
            {
                new User{UserID=1,LastName="Carson",FirstName="Alexander",Email="carsAlex@live.com", Skill="Photographer", Password="driveHonda240", Address="137 Olive st", Phone= 541-222-2222,},
                new User{UserID=2,LastName="Hess",FirstName="Nate",Email="curlymustache@gmail.com", Skill="Graphic Design", Password="100klife", Address="9875 Ice Lake Dr", Phone= 606-852-5555,},
                new User{UserID=3,LastName="Vargas",FirstName="Irvin",Email="vargasirvin@live.com", Skill="Videographer", Password="12iv0507zmz", Address="499 49th st", Phone= 541-555-5555,}
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var albums = new List<Album>
            {
                new Album{AlbumID=1,Title="Project",UserID=1},
                new Album{AlbumID=2,Title="Euro Style",UserID=2},
                new Album{AlbumID=3,Title="Fortunes",UserID=3}
               
            };
            albums.ForEach(s => context.Albums.Add(s));
            context.SaveChanges();

            var photos = new List<Photo>
            {
                new Photo{PhotoID=1, Name="Exo",AlbumID=1 , UserID=1},
                new Photo{PhotoID=2, Name="GTI mk1",AlbumID=2 , UserID=2},
                new Photo{PhotoID=3, Name="OB Mod",AlbumID=3 , UserID=3}

               
            };
            photos.ForEach(s => context.Photos.Add(s));
            context.SaveChanges();

            var videos = new List<Video>
            {
                new Video{VideoID=1, Title="Scorched in Fire", GenreID=1, UserID=1},
                new Video{VideoID=2, Title="Homework", GenreID=2, UserID=2},
                new Video{VideoID=3, Title="Metal", GenreID=3, UserID=3},

               
            };
            videos.ForEach(s => context.Videos.Add(s));
            context.SaveChanges();

            var genres = new List<Genre>
            {
                new Genre{GenreID=1, GenreName="Action", Description="Fast pace with a lot of movement and keeps the audience eyes moving" },
                new Genre{GenreID=2, GenreName="Comedy", Description="Humorous, funny, and easy to watch" },
                new Genre{GenreID=3, GenreName="Horror", Description="Violence and brutality" }
               
            };
            genres.ForEach(s => context.Genres.Add(s));
            context.SaveChanges();

            var events = new List<Event>
            {
                new Event{EventID=1, Title="Video Premiere", Description="Premiere of my first short film", EventDateTime=DateTime.Parse("2015-04-15"), UserID=1 },
                new Event{EventID=2, Title="Photo Gallery", Description="My friend is having a gallery show!", EventDateTime=DateTime.Parse("2015-10-22"), UserID=2 },
                new Event{EventID=3, Title="Music Video Help", Description="Need help filming and producing a music video", EventDateTime=DateTime.Parse("2015-02-29"), UserID=3 }
               
            };
            events.ForEach(s => context.Events.Add(s));
            context.SaveChanges();

        }
    }
}
