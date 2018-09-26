using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2TablesSite.Models
{
    public class GamingModels
    {

        public class Game
        {
            public int Id { get; set; }
            public string Title { get; set; } 
            public string Genre { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string Rating { get; set; }

            public List<Character> Characters;
            public List<Platform> Platform;
            public Developer Developer;
               
            
        }
        
        public class Character { }

        public class Developer
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public List<Game> Games { get; set; }


        }

        public class Platform {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime ReleaseDate { get; set; }

            public List<Game> Games { get; set; }

        }
    }
}