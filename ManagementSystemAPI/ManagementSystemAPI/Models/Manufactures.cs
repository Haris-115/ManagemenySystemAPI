using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystemAPI.Models
{
    public class Manufactures
    {
        [Key]
        public int manufactures_id { get; set; }
        public string manufactures_name { get; set; }
        public string lisence { get; set; }
        public string address { get; set; }
        

        [ForeignKey("distributors_id")]
        public int distributors_id { get; set; }
    }
}
