using Avalonia.Controls;
using Avalonia.Input.Platform;
using Avalonia.Interactivity;

namespace PasswordGeneratorUI;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnGenerate(object? sender, RoutedEventArgs e)
    {
   
        // 1. Variables
        string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        string SpecialChars = "!#-_().";
        string Numbers = "0123456789";

        // 3. Options 
        int lenght = (int)Math.Round(LengthSlider.Value);
        string includeSpecialChars = SpecialsCheck.IsChecked == true ? "y" : "n";
        string includeNumbers = NumbersCheck.IsChecked == true ? "y" : "n";

        // 4.1 Password Generation Logic
        string GeneratedPassword = "";

        if (includeSpecialChars == "y")
        {
            Letters += SpecialChars;
        }

        if (includeNumbers == "y")
        {
            Letters += Numbers;
        }

        // 4.2 Random Password Generation
        Random random = new Random();

        for (int i = 0; i < lenght; i++)
        {
            int index = random.Next(Letters.Length);
            GeneratedPassword += Letters[index];
        }

        // 5. Output Password
        OutputBox.Text = GeneratedPassword;
        CopyButton.IsEnabled = true;
        CopyButton.Content = "Copy";
    }
    
    // 6. Copy Password to ClipBoard
    private async void OnCopy(object? sender, RoutedEventArgs e)
    {
        var text = OutputBox.Text;
        if (string.IsNullOrEmpty(text)) return;

        var clipboard = TopLevel.GetTopLevel(this)?.Clipboard;
        if (clipboard is null) return;

        await clipboard.SetTextAsync(text);

        CopyButton.Content = "Copied!";
        await Task.Delay(1500);
        CopyButton.Content = "Copy";
    }
}
