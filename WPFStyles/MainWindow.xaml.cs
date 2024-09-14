using System.Windows;

namespace WPFStyles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isDarkMode = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SwitchTheme_Click(object sender, RoutedEventArgs e)
        {
            // Logic to determine current theme can be added here
            _isDarkMode = !_isDarkMode /* Determine the current theme */;            
            ChangeTheme(_isDarkMode ? "Light" : "Dark");
        }

        private void ChangeTheme(string theme)
        {
            var dict = new ResourceDictionary();
            switch (theme)
            {
                case "Dark":
                    dict.Source = new Uri("DarkTheme.xaml", UriKind.Relative);
                    break;
                case "Light":
                    dict.Source = new Uri("LightTheme.xaml", UriKind.Relative);
                    break;
            }
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dict);
        }
    }
}