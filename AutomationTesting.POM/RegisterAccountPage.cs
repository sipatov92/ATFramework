using AutomationTesting.Core;

namespace AutomationTesting.POM
{
    public class RegisterAccountPage : BasePage
    {
        public Control EditFirstName { get; set; }
        public Control EditLastName { get; set; }
        public Control EditEmail { get; set; }
        public Control EditTelephone { get; set; }
        public Control EditPassword { get; set; }
        public Control EditConfirmPassword { get; set; }
        public Control RadioButtonNo { get; set; }
        public Control ButtonAgree { get; set; }
        public Control ButtonContinue { get; set; }

        public override void Initialize()
        {
            EditFirstName = CreateControl("EditFirstName");
            EditLastName = CreateControl("EditLastName");
            EditEmail = CreateControl("EditEmail");
            EditTelephone = CreateControl("EditTelephone");
            EditFirstName = CreateControl("EditFirstName");
            EditPassword = CreateControl("EditPassword");
            EditConfirmPassword = CreateControl("EditConfirmPassword");
            RadioButtonNo = CreateControl("RadioButtonNo");
            ButtonAgree = CreateControl("ButtonAgree");
            ButtonContinue = CreateControl("ButtonContinue");
        }

        public RegisterAccountPage SetFirstName(string value)
        {
            EditFirstName.SetValue(value);
            return this;
        }

        public RegisterAccountPage SetLastName(string value)
        {
            EditLastName.SetValue(value);
            return this;
        }

        public RegisterAccountPage SetEmail(string value)
        {
            EditEmail.SetValue(value);
            return this;
        }
        
        public RegisterAccountPage SetTelephone(string value)
        {
            EditTelephone.SetValue(value);
            return this;
        }
    }
}