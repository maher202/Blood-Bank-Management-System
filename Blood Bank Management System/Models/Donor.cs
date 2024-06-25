using System.ComponentModel.DataAnnotations;
namespace Blood_Bank_Management_System.Models

{
    public class Donor
    {
        
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Mail { get; set; }
        [Required]

        public string Password { get; set; }
        [Required]
        public int Age { get; set; }

        
        public enum Gender
        {
        Male,
        Famele
        }
        public enum Bloodtype 
        {
        O_positive,
        O_negative,
        B_positive,
        B_negative,
        A_positive,
        A_negative,
        AB_positive,
        AB_negative,
        }

        public enum Disease {
            No_thing,
            Blood_pressure_disorders,
            Thyroid_disease,
            Diabetes,
            Cancer,
            Heart_disorders,
            Hepatitis
        }

        public string? Other_Diseases { get; set; }

        public DateTime? Latest_Donation  { get; set; }
        


    }
}
