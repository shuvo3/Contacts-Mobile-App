namespace Contacts.Maui.Views;

public partial class ContactPage : ContentPage
{
	public ContactPage()
	{
		InitializeComponent();

		List<string> contacts = new List<string>()
		{
			"John",
			"Shuvo",
			"Mehedi",
			"Riad",
			"Samir"
		};

		listContacts.ItemsSource = contacts;
	}

}