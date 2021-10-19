using System.Threading;
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


        public Control EditFirstNameControl => CreateControl("EditFirstName");
        public Control EditLastNameControl => CreateControl("EditLastName");
        public Control EditEmailControl => CreateControl("EditEmail");
        public Control EditTelephoneControl => CreateControl("EditTelephone");
        public Control EditPasswordControl => CreateControl("EditPassword");
        public Control EditConfirmPasswordControl => CreateControl("EditConfirmPassword");
        public Control RadioButtonNoControl => CreateControl("RadioButtonNo");
        public Control ButtonAgreeControl => CreateControl("ButtonAgree");
        public Control ButtonContinueControl => CreateControl("ButtonContinue");


        public override void Initialize()
        {
        }

        public RegisterAccountPage SetFirstName(string value)
        {
            Thread.Sleep(3000);
            EditFirstNameControl.SetValue(value);
            return this;
        }

        public RegisterAccountPage SetLastName(string value)
        {
            EditLastNameControl.SetValue(value);
            return this;
        }

        public RegisterAccountPage SetEmail(string value)
        {
            EditEmailControl.SetValue(value);
            return this;
        }

        public RegisterAccountPage SetTelephone(string value)
        {
            EditTelephoneControl.SetValue(value);
            return this;
        }

        public RegisterAccountPage SetPassword(string value)
        {
            EditPasswordControl.SetValue(value);
            return this;
        }

        public RegisterAccountPage SetConfirmPassword(string value)
        {
            EditConfirmPasswordControl.SetValue(value);
            return this;
        }

        public RegisterAccountPage ClickRadioButtonNo()
        {
            RadioButtonNoControl.Click();
            return this;
        }

        public RegisterAccountPage ClickButtonAgree()
        {
            ButtonAgreeControl.Click();
            return this;
        }

        public RegisterAccountPage ClickButtonContinue()
        {
            ButtonContinueControl.Click();
            return this;
        }
    }
}