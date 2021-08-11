using System.ComponentModel.DataAnnotations;

namespace ManagementSystemAPI.Models
{

    public class Distributors
    {
        [Key]
        public int distributors_id { get; set; }
        public string distributors_name { get; set; }
        public string distributors_lisence { get; set; }
        public int distributors_number { get; set; }
    }
}
