namespace ClassLibrary1;

public class UserInfoPresenter
{
    private readonly IUserInfo _form;

    public UserInfoPresenter(IUserInfo form)
    {
        _form = form;
        _form.SaveAttempted += _form_SaveAttempted;
    }

    private void _form_SaveAttempted(object? sender, EventArgs e)
    {
        _form.ShowFormErrors = false;
        _form.ErrorMessage = null;
        if (string.IsNullOrEmpty(_form.FirstName))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nFirst Name cannot be empty";
        }
        if (string.IsNullOrEmpty(_form.Email))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nEmail cannot be empty";
        }

        if (!string.IsNullOrEmpty(_form.Email) && !_form.Email.Contains("@"))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nEmail must contain @ symbol";
        }

    }
}