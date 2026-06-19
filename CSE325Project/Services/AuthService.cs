namespace CSE325Project.Services
// Provides authentication services for the application, including login and logout functionality.
{
    public class AuthService
    {
        public bool IsLoggedIn { get; private set; }
        public string? CurrentUser { get; private set; }

        public bool Login(string username, string password)
        {
            if (username == "student" && password == "studyhub")
            {
                IsLoggedIn = true;
                CurrentUser = username;
                return true;
            }

            return false;
        }

        public void Logout()
        {
            IsLoggedIn = false;
            CurrentUser = null;
        }
    }
}
