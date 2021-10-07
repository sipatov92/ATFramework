using AutomationTesting.Core;

namespace AutomationTesting.POM.RegisterAccountPage
{
    public class RegisterAccountPage
    {
        public CustomControl EditFirstName { get; set; }
        public CustomControl EditLastName { get; set; }
        public CustomControl EditEmail { get; set; }
        public CustomControl EditTelephone { get; set; }
        public CustomControl EditPassword { get; set; }
        public CustomControl EditConfirmPassword { get; set; }
        public CustomControl RadioButtonNo { get; set; }
        public CustomControl ButtonAgree { get; set; }
        public CustomControl ButtonContinue { get; set; }
    }
}