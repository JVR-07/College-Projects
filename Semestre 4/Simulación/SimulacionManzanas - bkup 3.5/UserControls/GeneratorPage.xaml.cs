using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using PseudorandomGenerator;
using SimulacionManzanas.Class;

namespace SimulacionManzanas.UserControls
{
    /// <summary>
    /// Interaction logic for GeneratorPage.xaml
    /// </summary>
    public partial class GeneratorPage : UserControl
    {
        #region Fields

        public bool Cleaned { get; set; } = false;

        #endregion

        #region Constructor
        public GeneratorPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods
        
        private bool GetVariablesValues()
        {
            bool CorrectFormat = true;
            // Setting Values to the generator
            try { Global.Pseudorandom.MultiplicativeConstant = float.Parse(TxtConstMult.Text); }
            catch (FormatException) 
            {
                MessageBox.Show("No se ha podido leer la constante múltiplicativa\nPor favor, ingrese un número válido",
                                "Algo ha salido mal",MessageBoxButton.OK,MessageBoxImage.Error);
                CorrectFormat = false;
            }

            try { Global.Pseudorandom.AdditiveConstant = float.Parse(TxtConstAdd.Text); }
            catch (FormatException)
            {
                MessageBox.Show("No se ha podido leer la constante aditiva\nPor favor, ingrese un número válido",
                                "Algo ha salido mal", MessageBoxButton.OK, MessageBoxImage.Error);
                CorrectFormat = false;
            }

            try { Global.Pseudorandom.Seed = float.Parse(TxtSeed.Text); }
            catch 
            {
                MessageBox.Show("No se ha podido leer la semilla\nPor favor, ingrese un número válido",
                                "Algo ha salido mal", MessageBoxButton.OK, MessageBoxImage.Error);
                CorrectFormat = false;
            }

            try { Global.Pseudorandom.Module = float.Parse(TxtMod.Text); }
            catch
            {
                MessageBox.Show("No se ha podido leer el módulo\nPor favor, ingrese un número válido",
                                "Algo ha salido mal", MessageBoxButton.OK, MessageBoxImage.Error);
                CorrectFormat = false;
            }

            try { Global.Pseudorandom.Quantity = int.Parse(TxtQuantity.Text); }
            catch
            {
                MessageBox.Show("No se ha podido leer la cantidad de números a generar\nPor favor, ingrese un número válido",
                                "Algo ha salido mal", MessageBoxButton.OK, MessageBoxImage.Error);
                CorrectFormat = false;
            }

            return CorrectFormat;
        }

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

            DtgNumbersGenerated.ItemsSource = Rows;
            DtgNumbersGenerated.Items.Refresh();
            Global.Generated = true;
            Global.Cleaned = false;
        }

        private void ClearTextBoxes()
        {
            TxtConstMult.Text = null;
            TxtConstAdd.Text = null;
            TxtSeed.Text = null;
            TxtMod.Text = null;
            TxtQuantity.Text = null;
        }

        private void Clear()
        {   // Clearing Table
            DtgNumbersGenerated.ItemsSource = null;
            DtgNumbersGenerated.Items.Refresh();
            // Clearing Generator
            if (Global.PseudorandomTemp.LstNumbers.Count == 0) Global.PseudorandomTemp = Global.Pseudorandom.Clone() as Pseudorandom;
            Global.Pseudorandom.Clear();
            //Clearing Textboxes
            ClearTextBoxes();
            Global.Cleaned = true;
        }

        private void RestoreTextBoxes()
        {
            TxtConstMult.Text = Global.PseudorandomTemp.MultiplicativeConstant.ToString();
            TxtConstAdd.Text = Global.PseudorandomTemp.AdditiveConstant.ToString();
            TxtSeed.Text = Global.PseudorandomTemp.Seed.ToString();
            TxtMod.Text = Global.PseudorandomTemp.Module.ToString();
            TxtQuantity.Text = Global.PseudorandomTemp.Quantity.ToString();
        }

        private void Restore()
        {
            //Restoring TextBoxes
            RestoreTextBoxes();
            // Restoring Generator
            Global.Pseudorandom = Global.PseudorandomTemp.Clone() as Pseudorandom;
            Global.PseudorandomTemp.Clear();
            // Restoring the table
            FillNumbersTable();
        }

        #endregion

        #region Events

        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            // Reading textboxes
            if (GetVariablesValues())
            {
                // Running the generator
                Global.Pseudorandom.Generate();
                Global.PseudorandomTemp = Global.Pseudorandom.Clone() as Pseudorandom;
                // Filling the table
                FillNumbersTable();
                Global.Generated = true;
            }            
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            if (!Cleaned)
            {
                Clear();
                Cleaned = true;
            }
        }

        private void BtnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (Cleaned)
            {
                Restore();
                Cleaned = false;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (Global.Generated)
            {
                FillNumbersTable();
                Restore();
            }
        }

        #endregion
    }
}
