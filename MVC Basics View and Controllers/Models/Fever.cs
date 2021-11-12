using System.ComponentModel.DataAnnotations;



namespace Fever.Models
{
    public class FeverModel
    {
        [Required(ErrorMessage = "Please enter tempure level")]
        public float CheckFever { get; set; }
        public string Unit { get; set; }
        public bool Ishypothermia
        {
            get; set;

        }
}
}