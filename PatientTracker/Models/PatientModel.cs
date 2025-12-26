using System.ComponentModel.DataAnnotations;

namespace PatientTracker.Models
{
    public class PatientModel
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z]{3,10}$", ErrorMessage = "First name must be between 3 and 10 characters long and contain only letters.")]
		public string FirstName { get; set; }

        [Required]
		[RegularExpression(@"^[A-Za-z]{3,10}$", ErrorMessage = "Last name must be between 3 and 10 characters long and contain only letters.")]

		public string LastName { get; set; }
        public bool headacheExists { get; set; }
        public int headachePainValue { get; set; }
        public bool chestpainExists { get; set; }
        public int chestPainValue { get; set; }
        public bool muscleacheExists { get; set; }
        public int muscleAcheValue { get; set; }
    }
}
