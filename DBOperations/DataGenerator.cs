using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieStore.Entities;



namespace MovieStore.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider provider)
        {
            using (var context = new MovieDBContext(provider.GetRequiredService<DbContextOptions<MovieDBContext>>()))
            {
                if (context.Movies.Any()) // Herhangi biri
                {
                    return;
                }

                context.Actors.AddRange
                ( new Actor
                    {
                        Name = "Will",
                        Surnme = "Smith",
                        BirthOfDate = new DateTime(25/09/1968)
                    },          
                 new Actor
                    {
                        Name = "Leonardo",
                        Surnme = "DiCaprio",
                        BirthOfDate = new DateTime(11/11/1974)
                    },         
                 new Actor
                    {
                        Name = "Bradd",
                        Surnme = "Pitt",
                        BirthOfDate = new DateTime(18/12/1963)
                    },               
                 new Actor
                    {
                        Name = "Angelina",
                        Surnme = "Jolie",
                        BirthOfDate = new DateTime(04/06/1975)
                    },
                 new Actor
                    {
                        Name = "Jack ",
                        Surnme = "Nicholson",
                        BirthOfDate = new DateTime(22/04/1937)
                    },
                 new Actor
                    {
                        Name = "Charlie ",
                        Surnme = "Hunnam",
                        BirthOfDate = new DateTime(10/04/1980)
                    }
                );

                context.Genres.AddRange
                (   new Genre
                    {
                        Name = "Science Fiction"
                    },
                    new Genre
                    {
                        Name = "Horror"
                    },
                    new Genre
                    {
                        Name = "Action"
                    },
                    new Genre
                    {
                        Name = "Comedy"
                    },
                    new Genre
                    {
                        Name = "Fastastic"
                    },
                    new Genre
                    {
                        Name = "Animation"
                    },
                    new Genre
                    {
                        Name = "Crime"
                    }
                );

                context.Directors.AddRange
                (
                    new Director
                    {
                        Name = "Stanley",
                        Surname = "Kubrick",
                        BirthOfDate = new DateTime(26/07/1928)
                    },
                    new Director
                    {
                        Name = "Quentin ",
                        Surname = "Tarantino",
                        BirthOfDate = new DateTime(27/03/1963)
                    },
                    new Director
                    {
                        Name = "Martin ",
                        Surname = "Scorsese",
                        BirthOfDate = new DateTime(17/11/1942)
                    },
                    new Director
                    {
                        Name = "Christopher Nolan",
                        Surname = "Nolan",
                        BirthOfDate = new DateTime(30/07/1970)
                    },
                    new Director
                    {
                        Name = "Nuri Bilge",
                        Surname = "Ceylan",
                        BirthOfDate = new DateTime(26/01/1959)
                    },
                    new Director
                    {
                        Name = "David ",
                        Surname = "Fincher",
                        BirthOfDate = new DateTime(28/08/1962)
                    }
                );
                context.SaveChanges();
                
                
                
                
            }
        }
    }
}