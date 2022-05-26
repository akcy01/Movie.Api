using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieApi.Core.Entities
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public int PublishYear { get; set; }
        public string MovieGenre { get; set; }
        public string Director { get; set; }
        public int Price { get; set; }
      


    }

}
