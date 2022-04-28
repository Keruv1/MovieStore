using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;



namespace MovieStore.Entities
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Customer Customer { get; set; }
        public Movie Movie { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
        
    }
}