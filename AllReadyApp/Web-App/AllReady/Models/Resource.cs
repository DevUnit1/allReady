using System.ComponentModel.DataAnnotations;

namespace AllReady.Models
{
    public class Resource : Capability 
    {
        //TODO: Change this from string to Location
        [Display(Name = "Current location")]
        public string CurrentLocation { get; set; }

        [Display(Name = "Number in location")]
        public int NumberInLocation { get; set; }
    }
}
