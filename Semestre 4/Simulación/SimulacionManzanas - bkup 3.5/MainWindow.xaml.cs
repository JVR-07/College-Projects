using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using SimulacionManzanas.UserControls;

namespace SimulacionManzanas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor

        public MainWindow()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            ShowWelcomePage();
        }

        #endregion

        #region Methods

        private void ShowWelcomePage()
        {
            ContentControl.Content = new WelcomePage();
        }

        private void ShowGenertorPage()
        {
            ContentControl.Content = new GeneratorPage();
        }

        private void ShowFirstTestPage()
        {
            ContentControl.Content = new FirstTestPage();
        }

        private void ShowSecondTestPage()
        {
            ContentControl.Content = new SecondTestPage();
        }

        private void ShowSimulationPage()
        {
            ContentControl.Content = new SimulationPage();
        }

        private void ShowHelpPage()
        {
            ContentControl.Content = new HelpPage();
        }

        #endregion

        #region Events

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWdn, int wMsg, int wParam, int lParam);

        private void ControlBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper Helper = new WindowInteropHelper(this);
            SendMessage(Helper.Handle, 161, 2, 0);
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal) this.WindowState = WindowState.Maximized;
            else this.WindowState = WindowState.Normal;
        }

        private void BtnLogo_Click(object sender, RoutedEventArgs e)
        {
            ShowWelcomePage();
        }

        private void BtnGenerator_Click(object sender, RoutedEventArgs e)
        {
            ShowGenertorPage();
        }

        private void BtnFirstTest_Click(object sender, RoutedEventArgs e)
        {
            ShowFirstTestPage();
        }

        private void BtnSecondTest_Click(object sender, RoutedEventArgs e)
        {
            ShowSecondTestPage();
        }

        private void BtnSimulation_Click(object sender, RoutedEventArgs e)
        {
            ShowSimulationPage();
        }

        private void BtnHelp_Click(object sender, RoutedEventArgs e)
        {
            ShowHelpPage();
        }

        #endregion
    }
}
