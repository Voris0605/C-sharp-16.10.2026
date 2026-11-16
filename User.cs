public class User
{
    public string FirstName;

    public string LastName;

    public string UserName;

    private string password;

    public User(string f, string l, string u, string p)
    {
        FirstName = f;
        LastName = l;
        UserName = u;
        password = p;
    }
    public void GetInfo()
    {
        System.Console.WriteLine($"Enter your fullname: {FirstName} {LastName}");
        System.Console.WriteLine($"Enter your username: {UserName}");
    }
    public bool Login(string username, string pass)
    {
        if(UserName == username && password == pass)
        {
            System.Console.WriteLine("Login successful");
            return true;
        }
        else
        {
            System.Console.WriteLine("Login failed");
            return false;
        }
    } 
}