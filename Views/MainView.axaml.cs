using System;
using System.Diagnostics;
using Avalonia.Controls;
using AvaloniaApplication1.Audio;

namespace AvaloniaApplication1.Views;

public partial class MainView : UserControl
{
    private const string RickRollUrl = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";

    public MainView()
    {
        InitializeComponent();
        InjectButton.Click += OnInjectClick;
    }

    private void OnInjectClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        try
        {
            if (OperatingSystem.IsWindows())
                WindowsSystemVolume.SetMasterVolumeScalar(1f);

            Process.Start(new ProcessStartInfo
            {
                FileName = RickRollUrl,
                UseShellExecute = true
            });

            StatusText.Text = "Opened in browser. System volume 100% (Windows).";
        }
        catch (Exception ex)
        {
            StatusText.Text = $"Could not open or set volume: {ex.Message}";
        }
    }
}
