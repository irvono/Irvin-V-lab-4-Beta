using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ono.Models
{
    public class Video
    {
        public int VideoID { get; set; }
        public string Title { get; set; }
        public int GenreID { get; set; }
        public int UserID { get; set; }

        //The 1 side of the relationship
        public virtual User User { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
