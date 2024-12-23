using Avalonia;
using System;

namespace AvaloniaApp;

class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        Console.WriteLine("Application started");

        BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);
    }

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
                     .UsePlatformDetect()
                     .LogToTrace();
}

