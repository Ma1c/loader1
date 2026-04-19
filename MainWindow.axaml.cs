using Avalonia.Controls;
using AvaloniaApplication1.Views;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ShowLogin();
    }

    private void ShowLogin()
    {
        var login = new LoginView();
        login.LoginRequested += OnLoginRequested;
        Shell.Content = login;
    }

    private void OnLoginRequested(object? sender, System.EventArgs e)
    {
        if (sender is LoginView login)
            login.LoginRequested -= OnLoginRequested;

        Shell.Content = new MainView();
    }
}
