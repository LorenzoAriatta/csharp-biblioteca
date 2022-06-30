using System;

public class UsersList
{
	List<User> users;

	public UsersList()
	{
		users = new List<User>();
	}

	public void UserRegistration(string surname, string name, string email, string password, string phone)
    {
		User newUser = new User(surname, name, email, password, phone);
		users.Add(newUser);
    }

	public void UserInfo()
    {
		foreach(User user in users)
        {
			Console.WriteLine($"Hello {user.name} {user.surname}! \n Your info: \n email: {user.email} \n phone: {user.phone}");
		}
	}
}
