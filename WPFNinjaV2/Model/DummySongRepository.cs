using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollectionMVVMLight.Model
{
    class DummySongRepository : ISongRepository
    {
        public List<Song> ToList()
        {
            var songs = new List<Song>();

            songs.Add(new Song { Id = 1, Artist = "Madonna", Title = "Holiday" });
            songs.Add(new Song { Id = 2, Artist = "Prince", Title = "1999" });
            songs.Add(new Song { Id = 3, Artist = "Michael Jackson", Title = "Billy Jean" });
            songs.Add(new Song { Id = 4, Artist = "U2", Title = "One" });

            return songs;
        }
    }
}
