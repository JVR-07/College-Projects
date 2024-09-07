using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimulacionManzanas.UserControls
{
    /// <summary>
    /// Interaction logic for HelpPage.xaml
    /// </summary>
    public partial class HelpPage : UserControl
    {
        #region Constructor

        public HelpPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void HiddenAllPanels()
        {
            PnlApproach.Visibility = Visibility.Hidden;
            PnlGenerator.Visibility = Visibility.Hidden;
            PnlAboutUs.Visibility = Visibility.Hidden;
        }

        private void ShowApproachPanel()
        {
            PnlApproach.Visibility = Visibility.Visible;
        }

        private void ShowGeneratorPanel()
        {
            PnlGenerator.Visibility = Visibility.Visible;
        }

        private void ShowAboutUsPanel()
        {
            PnlAboutUs.Visibility = Visibility.Visible;
        }


        #endregion

        #region Events

        private void BtnApproach_Click(object sender, RoutedEventArgs e)
        {
            HiddenAllPanels();
            ShowApproachPanel();
        }

        private void BtnGenerator_Click(object sender, RoutedEventArgs e)
        {
            HiddenAllPanels();
            ShowGeneratorPanel();
        }

        private void BtnAboutUs_Click(object sender, RoutedEventArgs e)
        {
            HiddenAllPanels();
            ShowAboutUsPanel();
        }

        #endregion
    }
}
