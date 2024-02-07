using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LoginPage.Pages;
using Microsoft.Extensions.Logging;

namespace LoginPage;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Sign(object sender, RoutedEventArgs e)
    {
        mainFrame1.Content = new Sign(null);
    }

    private void Button_Login(object sender, RoutedEventArgs e)
    {
        mainFrame2.Content = new loginPage();
    }
}