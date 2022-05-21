using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstNameIsNotEmpty()
        {
            var user = new DummyUser();
            var presenter = new UserInfoPresenter(user);
            user.Email = "Bob@";
            user.Save();
            Assert.AreEqual(expected: null, actual: user.FirstName, message: "The FirstName field should be initialized as null");
            Assert.IsTrue(user.ShowFormErrors, "Null first name should trigger validation error");
            Assert.AreEqual(expected: "\nFirst Name cannot be empty", actual: user.ErrorMessage, "Empty FirstName should have correct error msg");

            user.FirstName = "Bob";
            user.Save(); // save is our only trigger for validation right now
            Assert.AreEqual(expected: "Bob", actual: user.FirstName, message: "The FirstName must be set to a value to remove error");
            Assert.IsFalse(condition: user.ShowFormErrors, message: "A filled in FirstName should not trigger an error");
            Assert.AreEqual(expected:null,actual:user.ErrorMessage,"Filled in first name should remove error message");

            
        }

        [TestMethod]
        public void EmailIsNotEmpty()
        {
            var user = new DummyUser();
            var presenter = new UserInfoPresenter(user);
            user.FirstName = "Bob";
            user.Save();
            Assert.AreEqual(expected: null, actual: user.Email, message: "The Email field should be initialized as null");
            Assert.IsTrue(user.ShowFormErrors, "Null Email should trigger validation error");
            Assert.AreEqual(expected: "\nEmail cannot be empty", actual: user.ErrorMessage, "Empty Email should have correct error msg");

            user.Email = "Bob@";
            user.Save(); // save is our only trigger for validation right now
            Assert.AreEqual(expected: "Bob@", actual: user.Email, message: "The Email must be set to a value to remove error");
            Assert.IsFalse(condition: user.ShowFormErrors, message: "An appropriate filled in Email should not trigger an error");
            Assert.AreEqual(expected: null, actual: user.ErrorMessage, "Filled in Email should remove error message");


        }

        [TestMethod]
        public void EmailHasAtSymbol()
        {
            var user = new DummyUser();
            var presenter = new UserInfoPresenter(user);
            user.FirstName = "Bob";
            user.Email = "Bob";
            user.Save();
            Assert.AreEqual(expected: "Bob", actual: user.Email, message: "The Email field should be initialized as 'Bob'");
            Assert.IsTrue(user.ShowFormErrors, "Invalid Email should trigger validation error");
            Assert.AreEqual(expected: "\nEmail must contain @ symbol", actual: user.ErrorMessage, "Empty Email should have correct error msg");

            user.Email = "Bob@";
            user.Save(); // save is our only trigger for validation right now
            Assert.AreEqual(expected: "Bob@", actual: user.Email, message: "The Email must be set to a value to remove error");
            Assert.IsFalse(condition: user.ShowFormErrors, message: "A filled in Email should not trigger an error");
            Assert.AreEqual(expected: null, actual: user.ErrorMessage, "Filled in Email should remove error message");


        }

    }

    class DummyUser : IUserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ErrorMessage { get; set; }
        public bool ShowFormErrors { get; set; }
        public event EventHandler? SaveAttempted;

        // Imitate button click s
        public void Save() => SaveAttempted?.Invoke(this, EventArgs.Empty);
    }
}