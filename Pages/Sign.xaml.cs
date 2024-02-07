using System.Windows;
using System.Windows.Controls;

using LoginPage.Domain.Entity;
using LoginPage.Service.IService;
using LoginPage.Service.Service;

namespace LoginPage.Pages;

public partial class Sign : Page
{
    private readonly IUserService service;
    public Sign(UserService service)
    {
        InitializeComponent();
        this.service = service;
    }

    private void Button_Save(object sender, RoutedEventArgs e)
    {
        int AGe = int.Parse(age.Text);
        User user = new User()
        {
          Id = 1,
          FirstName = firstname.Text,
          LastName = lastname.Text,
          Email = email.Text,
          Password = password.Template.ToString(),
          Age =AGe
        };
        service.CreateAsync(user);
        MessageBox.Show("Succesfully");
    }
}