using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ono.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Skill { get; set; }// Photographer, artist, videograper etc. . . .
        public string Password { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
