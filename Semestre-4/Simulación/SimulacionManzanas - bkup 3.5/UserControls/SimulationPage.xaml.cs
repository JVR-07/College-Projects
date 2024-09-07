using SimulacionManzanas.Class;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Application = SimulationLib.Application;

namespace SimulacionManzanas.UserControls
{
    /// <summary>
    /// Interaction logic for SimulationPage.xaml
    /// </summary>
    public partial class SimulationPage : UserControl
    {
        #region Fields

        private bool Cleaned = false;

        #endregion

        #region Constructor

        public SimulationPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void FillNumbersTable()
        {
            List<PseudoRandomNumberRow> Rows = new List<PseudoRandomNumberRow>();
            foreach (float Number in Global.Pseudorandom.LstNumbers)
            {
                Rows.Add
                    (
                    new PseudoRandomNumberRow()
                    {
                        Index = Global.Pseudorandom.LstNumbers.IndexOf(Number) + 1,
                        Number = Number
                    }
                    );
            }

            DtgNumbers.ItemsSource = Rows;
            DtgNumbers.Items.Refresh();
        }

        private void FillProbabilityDistributionTable()
        {
            List<ProbabilityDistributionRow> Rows = new List<ProbabilityDistributionRow>();
            foreach((float BottomLimit, float TopLimit, int Days) in Global.App.LstProbabilityInterval)
            {
                Rows.Add
                    (
                    new ProbabilityDistributionRow()
                    {
                        Days = Days,
                        BottomLimit = BottomLimit,
                        TopLimit = TopLimit
                    }
                    );
            }

            DtgProbabilityDistribution.ItemsSource = Rows;
            DtgProbabilityDistribution.Items.Refresh();
        }

        private void FillPreviousYearsTable()
        {
            List<PreviousYearsRow> Rows = new List<PreviousYearsRow>();
            int c = 1;
            foreach(int Days in Global.App.GetSimulatedYears())
            {
                Rows.Add
                    (
                    new PreviousYearsRow()
                    {
                        Year = c,
                        Days = Days
                    }
                    );
                c++;
            }

            DtgPreviousYears.ItemsSource = Rows;
            DtgPreviousYears.Items.Refresh();
        }

        private void ShowResults(char SalesPolicy)
        {
            switch (SalesPolicy)
            {
                case '1':
                    {
                        TxtTitleResult.Text = "Política de Ventas Número 1";
                    }
                    break;
                case '2':
                    {
                        TxtTitleResult.Text = "Política de Ventas Número 2";
                    }
                    break;
                case '3':
                    {
                        TxtTitleResult.Text = "Política de Ventas Número 3";
                    }
                    break;
            }
            if (SalesPolicy != '1') TxtActualYearDays.Text = Global.App.ActualYear.ToString();
            if (SalesPolicy != '1') PnlActualYear.Visibility = Visibility.Visible;
            TxtUnitPrice.Text = Global.App.UnitPrice.ToString();
            TxtTotalPrice.Text = Global.App.TotalPrice.ToString();
            PnlPrices.Visibility = Visibility.Visible;
        }

        private void Clear()
        {
            DtgProbabilityDistribution.ItemsSource = null;
            DtgProbabilityDistribution.Items.Refresh();
            DtgNumbers.ItemsSource = null;
            DtgNumbers.Items.Refresh();
            DtgPreviousYears.ItemsSource = null;
            DtgPreviousYears.Items.Refresh();

            TxtTitleResult.Text = "Esperando Resultado";
            PnlActualYear.Visibility = Visibility.Hidden;
            PnlPrices.Visibility = Visibility.Hidden;
            Cleaned = true;
        }

        private void Restore()
        {
            Global.App = Global.AppTemp.Clone() as Application;
            FillNumbersTable();
            FillPreviousYearsTable();
            FillProbabilityDistributionTable();
            ShowResults(Global.App.SalesPolicy);
            Cleaned = false;
        }

        #endregion

        #region Events

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (Global.Generated) FillNumbersTable();
            FillProbabilityDistributionTable();
        }

        private void BtnRunSimulation_Click(object sender, RoutedEventArgs e)
        {
            if (Global.IsFirstTestPassed && Global.IsSecondTestPassed)
            {
                Global.App.SimulatedYears = 50;
                Global.App.LstPseudoRandomNumbers = Global.Pseudorandom.LstNumbers;
                Global.App.RunSimulation();
                FillPreviousYearsTable();
                ShowResults(Global.App.SalesPolicy);
                Global.AppTemp = Global.App.Clone() as Application;
            }
            else MessageBox.Show("Las pruebas de distribución no han sido aprobadas aún", "Algo ha salido mal",MessageBoxButton.OK,MessageBoxImage.Error);
        }

        private void BtnClearSimulation_Click(object sender, RoutedEventArgs e)
        {
            if (!Cleaned) Clear();
        }

        private void BtnRestoreSimulation_Click(object sender, RoutedEventArgs e)
        {
            if (Cleaned) Restore();
        }

        #endregion        
    }
}
