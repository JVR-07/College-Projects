using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using LiveCharts;
using SeriesTestLib;
using SimulacionManzanas.Class;

namespace SimulacionManzanas.UserControls
{
    public partial class SecondTestPage : UserControl
    {
        #region Fields

        SeriesTest ST = new SeriesTest();
        List<(float, float)> LstIntervalsProb = new List<(float, float)>();
        List<IntervalsRow> LstIntervalRows = new List<IntervalsRow>();
        List<PairsRow> LstPairsRow = new List<PairsRow>();
        List<string> LstIntervalsNames = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        int IntervalsCount { get; set; }
        bool DefinedPairs { get; set; } = false;
        public SeriesCollection FESeries { get; set; }
        public SeriesCollection FOSeries { get; set; }

        #endregion

        #region Constructor

        public SecondTestPage()
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

        private void FillIntervalsTable()
        {
            IntervalsCount = 0;
            foreach ((float BottomLimit, float TopLimit) in LstIntervalsProb)
            {
                LstIntervalRows.Add
                    (
                    new IntervalsRow()
                    {
                        Name = LstIntervalsNames[IntervalsCount],
                        BottomLimit = BottomLimit,
                        TopLimit = TopLimit
                    }
                    );
                IntervalsCount++;
            }
            DtgIntervals.ItemsSource = LstIntervalRows;
            DtgIntervals.Items.Refresh();
        }

        private void FillPairsTable()
        {
            List<(float, float)> LstPairs = new List<(float, float)>();
            LstPairs = ST.GetPairs();
            foreach ((float FirstElement, float SecondElement) in ST.GetPairs())
            {
                LstPairsRow.Add
                    (
                    new PairsRow()
                    {
                        Index = ST.GetPairs().IndexOf((FirstElement, SecondElement)) + 1,
                        Pair = $"[ { FirstElement } - { SecondElement } ]"
                    }
                    );
            }
            DtgPairs.ItemsSource = LstPairsRow;
            DtgPairs.Items.Refresh();
        }

        private void ClearIntervalTable()
        {
            DtgIntervals.ItemsSource = null;
            DtgIntervals.Items.Refresh();
        }

        private void AddInterval()
        {
            if (!(IntervalsCount == 10))
            {
                ClearIntervalTable();
                ST.Groups = IntervalsCount + 1;
                LstIntervalsProb = ST.GetIntervals();
                LstIntervalRows.Clear();
                FillIntervalsTable();
            }
        }

        private void RemoveInterval()
        {
            if (!(IntervalsCount == 2))
            {
                ClearIntervalTable();
                ST.Groups = IntervalsCount - 1;
                LstIntervalsProb = ST.GetIntervals();
                LstIntervalRows.Clear();
                FillIntervalsTable();
            }
        }

        private bool GetAlpha()
        {
            try
            {
                float alpha = float.Parse(TxtAlpha.Text);
                if (0.0f < alpha && alpha <= 1.00) { ST.Alpha = alpha; return true; }
                else throw new ArgumentOutOfRangeException("El valor de alpha está fuera del rango permitido\nAlpha solo puede tomar valores entre 0 y 1");

            }
            catch (FormatException)
            {
                MessageBox.Show("No se ha podido leer el valor de alfa\nPor favor, ingrese un número válido",
                                "Algo ha salido mal", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.ToString(), "Algo ha salido mal", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        private int[] GetGroupObservedFrequency()
        {
            int[] Result = new int[ST.Groups];

            for(int i = 0; i < ST.Groups; i++)
            {
                for(int j = 0; j < ST.Groups; j++)
                {
                    Result[i] += ST.GetObservedFrequency()[i, j];
                }
            }
            return Result;
        }

        #endregion

        #region Events

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ST.Groups = 4;
            LstIntervalsProb = ST.GetIntervals();
            if (Global.Generated && Global.IsFirstTestPassed) FillNumbersTable();
            FillIntervalsTable();
            ST.LstPseudoRandomNumbers = Global.Pseudorandom.LstNumbers;
        }

        private void BtnAddInterval_Click(object sender, RoutedEventArgs e)
        {
            AddInterval();
        }

        private void BtnRemoveInterval_Click(object sender, RoutedEventArgs e)
        {
            RemoveInterval();
        }

        private void BtnDefPairs_Click(object sender, RoutedEventArgs e)
        {
            FillPairsTable();
            DefinedPairs = true;

        }

        private void BtnRunTest_Click(object sender, RoutedEventArgs e)
        {
            if(GetAlpha())
            {
                if (DefinedPairs)
                {
                    if (ST.Approved())
                    {
                        TxtBlkResult.Text = "Los datos SÍ están distribuidos uniformemente";
                        TxtBlkResult.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        TxtBlkResult.Text = "Los datos NO están distribuidos uniformemente";
                        TxtBlkResult.Visibility = Visibility.Visible;
                    }
                    FESeries = Global.ShowExpectedFrequency(LstIntervalsNames, ST.GetExpectedFrequency() * ST.Groups, IntervalsCount, FESeries, this);
                    chrtFE.DataContext = this; chrtFE.Update();
                    FOSeries = Global.ShowObservedFrequency(LstIntervalsNames, GetGroupObservedFrequency(), IntervalsCount, FOSeries, this);
                    chrtFO.DataContext = this; chrtFO.Update();
                    Global.IsSecondTestPassed = true;
                }
                else MessageBox.Show("Los pares aún no han sido definidos", "Algo ha salido mal", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #endregion
    }
}
