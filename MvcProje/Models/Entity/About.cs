using System.ComponentModel.DataAnnotations;

namespace MvcProje.Models.Entity
{
    public class About
    {
        public int AboutId { get; set; }   
        public string AboutDetail { get; set; } 
        public string AboutImage { get; set; }

        public bool AboutStatus { get; set; }   

    }
}
