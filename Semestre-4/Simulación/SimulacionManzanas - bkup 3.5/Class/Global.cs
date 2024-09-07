using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using PseudorandomGenerator;
using SimulationLib;
using System.Collections.Generic;
using System.Windows.Controls;

namespace SimulacionManzanas.Class
{
    public static class Global
    {
        public static bool Generated { get; set; } = false;
        public static bool Cleaned {  get; set; } = false;
        public static Pseudorandom Pseudorandom { get; set; } = new Pseudorandom();
        public static Pseudorandom PseudorandomTemp { get; set; } = new Pseudorandom();
        public static Application App { get; set; } = new Application();
        public static Application AppTemp { get; set; } = new Application();
        public static bool IsFirstTestPassed { get; set; }
        public static bool IsSecondTestPassed { get; set; } 

        public static SeriesCollection ShowObservedFrequency(List<string> LstIntervalsNames, int[] ExpectedFrequency, int IntervalsCount, SeriesCollection FESeries, UserControl This)
        {
            switch (IntervalsCount)
            {
                case 2:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[0]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[1]) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 3:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[0]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[1]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[2]) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 4:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[0]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[1]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[2]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[3],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[3]) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 5:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[0]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[1]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[2]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[3],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[3]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[4],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[4]) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 6:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[0]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[1]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[2]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[3],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[3]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[4],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[4]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[5],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[5]) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 7:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[0]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[1]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[2]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[3],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[3]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[4],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[4]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[5],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[5]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[6],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[6]) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 8:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[0]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[1]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[2]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[3],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[3]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[4],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[4]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[5],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[5]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[6],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[6]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[7],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[7]) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 9:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[0]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[1]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[2]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[3],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[3]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[4],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[4]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[5],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[5]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[6],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[6]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[7],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[7]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[8],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[8]) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 10:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[0]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[1]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[2]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[3],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[3]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[4],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[4]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[5],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[5]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[6],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[6]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[7],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[7]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[8],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[8]) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[9],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency[9]) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
            }
            return FESeries;
        }

        public static SeriesCollection ShowExpectedFrequency(List<string> LstIntervalsNames, float ExpectedFrequency, int IntervalsCount, SeriesCollection FESeries, UserControl This)
        {
            switch (IntervalsCount)
            {
                case 2:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 3:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 4:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[3],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 5:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[3],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[4],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 6:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[3],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[4],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[5],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 7:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[3],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[4],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[5],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[6],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 8:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[3],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[4],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[5],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[6],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[7],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 9:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[3],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[4],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[5],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[6],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[7],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[8],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
                case 10:
                    {
                        FESeries = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = LstIntervalsNames[0],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[1],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[2],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[3],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[4],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[5],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[6],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[7],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[8],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = LstIntervalsNames[9],
                                Values = new ChartValues<ObservableValue> { new ObservableValue(ExpectedFrequency) },
                                DataLabels = true
                            }
                        };
                    }
                    break;
            }
            return FESeries;
        }
    }
}
