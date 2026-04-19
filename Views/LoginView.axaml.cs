using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication1.Views;

public partial class LoginView : UserControl
{
    public event EventHandler? LoginRequested;

    public LoginView()
    {
        InitializeComponent();
        SignInButton.Click += OnSignInClick;
    }

    private void OnSignInClick(object? sender, RoutedEventArgs e)
    {
        var username = UsernameBox.Text?.Trim() ?? string.Empty;
        var password = PasswordBox.Text ?? string.Empty;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            return;

        LoginRequested?.Invoke(this, EventArgs.Empty);
    }
}
