using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ono.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }
        public string Name { get; set; }
        public int AlbumID { get; set; }
        public int UserID { get; set; }

        public virtual ICollection<Album> Albums { get; set; }

        public virtual User User { get; set; }
    }
}
