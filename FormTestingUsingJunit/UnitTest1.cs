using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationAndJUnit;

namespace FormTestingUsingJunit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstNameValidation()
        {
            isValid obj = new isValid();
            string FistName = "Aakash";
            bool ExspectedResult = true;
            bool result = isValid.CheckFirstName(FistName);
            Assert.AreEqual(ExspectedResult,result);
        }
        [TestMethod]
        public void LastNameValidation()
        {
            isValid obj = new isValid();
            string LastName = "Potdar";
            bool ExspectedResult = true;
            bool result = isValid.CheckLastName(LastName);
            Assert.AreEqual(ExspectedResult, result);
        }
        [TestMethod]
        public void MobileNumberValidation()
        {
            isValid obj = new isValid();
            string number = "91-7387302460";
            bool ExspectedResult = true;
            bool result = isValid.CheckMobileNumber(number);
            Assert.AreEqual(ExspectedResult, result);
        }
        [TestMethod]
        public void MailIdValidation()
        {
            isValid obj = new isValid();
            string Id = "Potdar.Aakash@google.com";
            bool ExspectedResult = true;
            bool result = isValid.CheckMailId(Id);
            Assert.AreEqual(ExspectedResult, result);
        }
        [TestMethod]
        public void PasswordValidation()
        {
            isValid obj = new isValid();
            string password = "Aakash@112";
            bool ExspectedResult = true;
            bool result = isValid.CheckPassword(password);
            Assert.AreEqual(ExspectedResult, result);
        }
    }
}
