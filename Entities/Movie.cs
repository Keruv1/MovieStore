using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;




namespace MovieStore.Entities

{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string MovieName { get; set; }
        public DateTime PublishDate { get; set; }
        public string Genre { get; set; }
        public Director Director { get; set; }
        public Actor Actor { get; set; }
        public decimal price { get; set; }

    }
}
