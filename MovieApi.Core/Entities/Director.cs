using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Core.Entities
{
    public class Director
    {

        public int Id { get; set; }
        public string DirectorName { get; set; }
        public ICollection<MovieModel> movies { get; set; } //1'e çok ilişki.

    }
}
