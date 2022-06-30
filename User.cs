using System;

public class User
{
	protected string surname;

	protected string name;

	protected string email;

	protected string password;

	protected uint phone;
	public User(string surname, string name, string email, string password, uint phone)
	{
		this.surname = surname;
		this.name = name;
		this.email = email;
		this.password = password;
		this.phone = phone;
	}

	public virtual void ToString()
    {
        Console.WriteLine($"Welcome {this.surname} {this.name}! \n Your info: \n email: {this.email} \n phone: {this.phone}");
    }
}
