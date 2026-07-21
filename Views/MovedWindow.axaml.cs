using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace EveCortex.Views;

// Final-release farewell notice: Eve Cortex has been renamed to EVE Console. Points existing
// users at the new repo's latest release. Their data is copied forward automatically on the
// new app's first run, so the two can coexist during the transition.
public partial class MovedWindow : Window
{
    private const string DownloadUrl = "https://github.com/kernoeve/EveConsole/releases/latest";

    public MovedWindow() => InitializeComponent();

    private void OnDownloadClick(object? sender, RoutedEventArgs e)
    {
        try
        {
            Process.Start(new ProcessStartInfo(DownloadUrl) { UseShellExecute = true });
        }
        catch
        {
            // Best-effort — if the shell can't open a browser, just close the dialog.
        }
        Close();
    }

    private void OnLaterClick(object? sender, RoutedEventArgs e) => Close();
}
