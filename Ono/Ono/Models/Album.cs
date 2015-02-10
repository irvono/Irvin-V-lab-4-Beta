using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ono.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public int UserID { get; set; }

        // Every album has many photos and a particular photo can only belong to one album
        public virtual ICollection<Photo> Photos { get; set; }

        // A User can have many albums 
        public virtual User User { get; set; }
    }
}
