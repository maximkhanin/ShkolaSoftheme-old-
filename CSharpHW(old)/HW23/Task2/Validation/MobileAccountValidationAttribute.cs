using System.ComponentModel.DataAnnotations;

namespace Task2.Validation
{
    class MobileAccountValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var mobileAccount = value as MobileAccount;
            if (string.IsNullOrEmpty(mobileAccount.FirstName))
            {
                ErrorMessage = "FirstName is Null";
                return false;
            }
            if (string.IsNullOrEmpty(mobileAccount.LastName))
            {
                ErrorMessage = "LastName is Null";
                return false;
            }
            return true;
        }
    }
}
