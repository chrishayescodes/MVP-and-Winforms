namespace ClassLibrary1
{
    public interface IUserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ErrorMessage { get; set; }
        public bool ShowFormErrors { get; set; }
        public event EventHandler SaveAttempted;
    }
}