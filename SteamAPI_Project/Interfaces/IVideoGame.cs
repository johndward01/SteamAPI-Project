using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SteamAPI_Project.Interfaces
{
    interface IVideoGame
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Price { get; set; }

    }
}
