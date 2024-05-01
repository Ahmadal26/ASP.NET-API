using WebApplication1.Models;
using System.ComponentModel.DataAnnotations;
using WebApplication5.Models.WebApplication1.Models;

namespace WebApplication5.Models
{
    public class AddBranchRequest : IValidatableObject
    {
        public string LocationName { get; set; }
        [Url]
        public string LocationURL { get; set; }
        public string BranchManager { get; set; }

        //custom validation
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (LocationName.StartsWith("-"))
            {
                yield return new ValidationResult("Name can not start with -");
            }
        }
    }
    public class BankBranchResponse
    {
        public string LocationName { get; set; }
        public string LocationURL { set; get; }
        public string BranchManager { set; get; }
        public IEnumerable<EmployeeResponse> Employees { get; set; }
    }
}