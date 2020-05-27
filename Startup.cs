using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows;

public class Startup : Window
{
	public static Window MainWindows;

	static double _width { get; set; }
	static double _height { get; set; }

	[STAThread]
	public static void Main()
	{

		CreateWindow(800, 600, false, "PrositSync", "PrositSync", true);

	}

	public static void CreateWindow(double width = 800, double height = 600, bool fullScreen = false, string appName = "name", string appTitle = "title", bool isRealizable = true)
    {
		MainWindows = new Window();

		_width = width;
		_height = height;

		if (isRealizable)
			MainWindows.ResizeMode = ResizeMode.CanResize;
		else
			MainWindows.ResizeMode = ResizeMode.NoResize;

		if (fullScreen)
        {
			_width = SystemParameters.PrimaryScreenWidth;
			_height = SystemParameters.PrimaryScreenHeight;
		}

		MainWindows.Width = _width;
		MainWindows.Height = _height;
		MainWindows.Name = appName;
		MainWindows.Title = appTitle;
		MainWindows.WindowStartupLocation = WindowStartupLocation.CenterScreen;

		MainWindows.Show();
		System.Windows.Threading.Dispatcher.Run();
	}
}
