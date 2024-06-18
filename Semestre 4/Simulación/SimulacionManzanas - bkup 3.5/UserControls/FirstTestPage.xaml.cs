using FrequencyTestLib;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using SimulacionManzanas.Class;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace SimulacionManzanas.UserControls
{
    /// <summary>
    /// Interaction logic for FirstTestPage.xaml
    /// </summary>
    public partial class FirstTestPage : UserControl
    {
        #region Fields

        FrequencyTest FT = new FrequencyTest();
        List<(float, float)> LstIntervalsProb = new List<(float, float)>();
        List<IntervalsRow> LstIntervalRows = new List<IntervalsRow>();
        List<string> LstIntervalsNames = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        public SeriesCollection FESeries { get; set; }
        public SeriesCollection FOSeries { get; set; }
        int IntervalsCount { get; set; } = 0;

        #endregion

        #region Constructor

        public FirstTestPage()
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
                FT.Intervals = IntervalsCount + 1;
                LstIntervalsProb = FT.GetIntervals();
                LstIntervalRows.Clear();
                FillIntervalsTable();
            }
        }

        private void RemoveInterval()
        {
            if (!(IntervalsCount == 2))
            {
                ClearIntervalTable();
                FT.Intervals = IntervalsCount - 1;
                LstIntervalsProb = FT.GetIntervals();
                LstIntervalRows.Clear();
                FillIntervalsTable();
            }
        }

        private bool GetAlpha()
        {
            try
            {
                float alpha = float.Parse(TxtAlpha.Text);
                if (0.0f < alpha && alpha <= 1.00) { FT.Alpha = alpha; return true; }
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
        #region ShowExpectedFrequency()
        //private void ShowExpectedFrequency()
        //{
        //    switch (IntervalsCount)
        //    {
        //        case 2:
        //            {
        //                FESeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                };
        //                chrtFE.DataContext = this;
        //            }
        //            break;
        //        case 3: 
        //            {
        //                FESeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    }
        //                };
        //                chrtFE.DataContext = this;
        //            }
        //            break;
        //        case 4: 
        //            {
        //                FESeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[3],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    }
        //                };
        //                chrtFE.DataContext = this;
        //            }
        //            break;
        //        case 5: 
        //            {
        //                FESeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },                                
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[3],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[4],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    }
        //                };
        //                chrtFE.DataContext = this;
        //            }
        //            break;
        //        case 6: 
        //            {
        //                FESeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[3],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[4],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[5],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    }
        //                };
        //                chrtFE.DataContext = this;
        //            }
        //            break;
        //        case 7: 
        //            {
        //                FESeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[3],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[4],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[5],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[6],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    }
        //                };
        //                chrtFE.DataContext = this;
        //            }
        //            break;
        //        case 8: 
        //            {
        //                FESeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[3],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[4],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[5],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[6],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[7],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    }
        //                };
        //                chrtFE.DataContext = this;
        //            }
        //            break;
        //        case 9: 
        //            {
        //                FESeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[3],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[4],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[5],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[6],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[7],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[8],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    }
        //                };
        //                chrtFE.DataContext = this;
        //            }
        //            break;
        //        case 10: 
        //            {
        //                FESeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[3],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[4],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[5],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[6],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[7],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[8],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[9],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(FT.GetExpectedFrequency()) },
        //                        DataLabels = true
        //                    }
        //                };
        //                chrtFE.DataContext = this;
        //            } break;
        //    }
        //}
        #endregion

        #region ShowObservedFrequency()
        //private void ShowObservedFrequency()
        //{
        //    int[] ObservedFrequency = FT.GetObservedFrequency();
        //    switch (IntervalsCount)
        //    {
        //        case 2:
        //            {
        //                FOSeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[0]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[1]) },
        //                        DataLabels = true
        //                    },
        //                };
        //                chrtFO.DataContext = this;
        //            }
        //            break;
        //        case 3:
        //            {
        //                FOSeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[0]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[1]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[2]) },
        //                        DataLabels = true
        //                    }
        //                };
        //                chrtFO.DataContext = this;
        //            }
        //            break;
        //        case 4:
        //            {
        //                FOSeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[0]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[1]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[2]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[3],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[3]) },
        //                        DataLabels = true
        //                    }
        //                };
        //                chrtFO.DataContext = this;
        //            }
        //            break;
        //        case 5:
        //            {
        //                FOSeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[0]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[1]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[2]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[3],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[3]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[4],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[4]) },
        //                        DataLabels = true
        //                    },
        //                };
        //                chrtFO.DataContext = this;
        //            }
        //            break;
        //        case 6:
        //            {
        //                FOSeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[0]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[1]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[2]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[3],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[3]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[4],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[4]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[5],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[5]) },
        //                        DataLabels = true
        //                    },
        //                };
        //                chrtFO.DataContext = this;
        //            }
        //            break;
        //        case 7:
        //            {
        //                FOSeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[0]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[1]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[2]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[3],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[3]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[4],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[4]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[5],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[5]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[6],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[6]) },
        //                        DataLabels = true
        //                    },
        //                };
        //                chrtFO.DataContext = this;
        //            }
        //            break;
        //        case 8:
        //            {
        //                FOSeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[0]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[1]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[2]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[3],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[3]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[4],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[4]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[5],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[5]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[6],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[6]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[7],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[7]) },
        //                        DataLabels = true
        //                    },
        //                };
        //                chrtFO.DataContext = this;
        //            }
        //            break;
        //        case 9:
        //            {
        //                FOSeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[0]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[1]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[2]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[3],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[3]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[4],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[4]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[5],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[5]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[6],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[6]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[7],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[7]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[8],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[8]) },
        //                        DataLabels = true
        //                    },
        //                };
        //                chrtFO.DataContext = this;
        //            }
        //            break;
        //        case 10:
        //            {
        //                FOSeries = new SeriesCollection
        //                {
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[0],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[0]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[1],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[1]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[2],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[2]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[3],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[3]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[4],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[4]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[5],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[5]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[6],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[6]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[7],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[7]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[8],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[8]) },
        //                        DataLabels = true
        //                    },
        //                    new PieSeries
        //                    {
        //                        Title = LstIntervalsNames[9],
        //                        Values = new ChartValues<ObservableValue> { new ObservableValue(ObservedFrequency[9]) },
        //                        DataLabels = true
        //                    }
        //                };
        //                chrtFO.DataContext = this;
        //            }
        //            break;
        //    }
        //}

        #endregion

        #endregion

        #region Events

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            FT.Intervals = 4;
            LstIntervalsProb = FT.GetIntervals();
            if (Global.Generated) FillNumbersTable();
            FillIntervalsTable();
            FT.LstPseudoRandomNumbers = Global.Pseudorandom.LstNumbers;
        }

        private void BtnAddInterval_Click(object sender, RoutedEventArgs e)
        {
            AddInterval();
        }

        private void BtnRemoveInterval_Click(object sender, RoutedEventArgs e)
        {
            RemoveInterval();
        }

        private void BtnRunTest_Click(object sender, RoutedEventArgs e)
        {
            if (GetAlpha())
            {
                if (FT.Approved())
                {
                    TxtBlkResult.Text = "Los datos SÍ están distribuidos uniformemente";
                    TxtBlkResult.Visibility = Visibility.Visible;
                }
                else
                {
                    TxtBlkResult.Text = "Los datos NO están distribuidos uniformemente";
                    TxtBlkResult.Visibility = Visibility.Visible;
                }
                FESeries = Global.ShowExpectedFrequency(LstIntervalsNames, FT.GetExpectedFrequency(), IntervalsCount, FESeries, this);
                chrtFE.DataContext = this; chrtFE.Update();
                FOSeries = Global.ShowObservedFrequency(LstIntervalsNames, FT.GetObservedFrequency(), IntervalsCount, FOSeries, this);
                chrtFO.DataContext = this; chrtFO.Update();
                Global.IsFirstTestPassed = true;
            }
        }

        #endregion
    }

}
