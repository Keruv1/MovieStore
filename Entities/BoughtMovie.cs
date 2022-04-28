using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;




namespace MovieStore.Entities
{
    public class BoughtMovie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}