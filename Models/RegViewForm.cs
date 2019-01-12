using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models
{
    public class RegViewForm
    {
        
        [Required(ErrorMessage = "What's yer name, hun?")]
        [MinLength(4, ErrorMessage = "A name at least 4 characters long, silly billy")]
        [Display(Name="First Name")]
        public string FirstName {get;set;}

        [Required(ErrorMessage = "What's yer name, hun?")]
        [MinLength(4, ErrorMessage = "A name at least 4 characters long, silly billy")]
        [Display(Name = "Last Name")]
        public string LastName {get;set;}

        [Display(Name = "Age:")]
        [Required(ErrorMessage = "How old are you, kid?")]
        [MinValue(18, ErrorMessage = "You gotta be 18 to get in")]
        
        public int Age{get;set;}

        [Required(ErrorMessage = "'Email' field required")]
        [EmailAddress(ErrorMessage = "That's not a valid email address!")]
        [Display(Name = "Email Address")]
        public string Email{get;set;}

        [Required(ErrorMessage = "What's the secret password?")]
        [MinLength(8, ErrorMessage = "Keep Going...")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password{get;set;}

        



    }
    public class MaxValueAttribute : ValidationAttribute
    {   
        private readonly int _maxValue;
        public MaxValueAttribute(int maxValue)
        {
            _maxValue = maxValue;
        }
        public override bool IsValid(object value)
        {
            return (int) value <= _maxValue;
        }
    }

    public class MinValueAttribute : ValidationAttribute
    {
        private readonly int _minValue;
        public MinValueAttribute(int minValue)
        {
            _minValue = minValue;
        }
        public override bool IsValid(object value)
        {
            return (int) value >= _minValue;
        }
    }
}