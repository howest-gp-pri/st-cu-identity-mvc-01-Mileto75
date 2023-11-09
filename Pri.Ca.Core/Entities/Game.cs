using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Ca.Core.Entities
{
    public class Game : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Publisher Publisher { get; set; }
        public int PublisherId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        //unshadowed foreign key must be string for default identity
        public string ApplicationUserId { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}
