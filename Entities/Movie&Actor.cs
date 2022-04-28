using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;



namespace MovieStore.Entities
{
    public class MovieActor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}