namespace Contacts.Maui.Views;

public partial class ContactPage : ContentPage
{
	public ContactPage()
	{
		InitializeComponent();

		List<Contact> contacts = new List<Contact>()
		{
			new Contact() {Name = "John", Email = "john@email.com"},
			new Contact() {Name = "Shuvo", Email = "shuvo@email.com"},
			new Contact() {Name = "mehedi", Email = "mehedi@email.com"},
			new Contact() {Name = "Riad", Email = "riad@email.com"},
			new Contact() {Name = "Samir", Email = "samir@email.com"},
		};

		listContacts.ItemsSource = contacts;
	}

	public class Contact
	{
        public string Name { get; set; }
        public string Email { get; set; }
    }

}