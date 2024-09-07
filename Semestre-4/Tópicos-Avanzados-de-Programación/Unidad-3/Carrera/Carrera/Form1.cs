using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Eventing.Reader;
using System.Timers;

namespace Carrera
{
    public partial class Form1 : Form
    {
        public string mx1 = "derecha";
        public string mx2 = "derecha";
        public string mx3 = "derecha";
        public string mx4 = "derecha";
        public string mx5 = "derecha";
        Taxi taxiBlancoCafe;
        Taxi taxiBlancoVerde;
        Taxi taxiRojo;
        Taxi taxiVerde;
        Taxi taxiAzulAmarillo;
        Dictionary<string, int> DictXPositionTaxis;
        bool IsTaxiWinner = false, IsRaceFinished = false;
        int a = 0, b = 0, c = 0, d = 0, e1 = 0;
        Random ran = new Random();
        public Form1()
        {
            InitializeComponent();            
        }

        Thread proceso_1;
        Thread proceso_2;
        Thread proceso_3;
        Thread proceso_4;
        Thread proceso_5;

        private void InitializeTaxis()
        {
            taxiBlancoCafe = new Taxi("Taxi Blanco y Café", 2, 136);
            taxiBlancoVerde = new Taxi("Taxi Blanco y Verde", 2, 228);
            taxiRojo = new Taxi("Taxi Rojo", 2, 321);
            taxiVerde = new Taxi("Taxi Verde", 2, 407);
            taxiAzulAmarillo = new Taxi("Taxi Azul y Amarillo", 2, 501);
        }
        private void DefineBacheDelay()
        {
            Random ran = new Random();
            taxiBlancoCafe.Bache.Delay = ran.Next(2, 25);
            taxiBlancoVerde.Bache.Delay = ran.Next(2,25);
            taxiRojo.Bache.Delay = ran.Next(2, 25);
            taxiVerde.Bache.Delay = ran.Next(2, 25);
            taxiAzulAmarillo.Bache.Delay = ran.Next(2, 25);
        }

        private void DefineBacheXPosition()
        {
            Random ran = new Random();
            taxiBlancoCafe.Bache.XPosition = ran.Next(350, 900);
            taxiBlancoVerde.Bache.XPosition = ran.Next(350, 900);
            taxiRojo.Bache.XPosition = ran.Next(350, 900);
            taxiVerde.Bache.XPosition = ran.Next(350, 900);
            taxiAzulAmarillo.Bache.XPosition = ran.Next(350, 900);
        }

        private void DefineBacheLocation()
        {
            BacheTaxiBlancoCafe.Location = new Point(taxiBlancoCafe.Bache.XPosition, taxiBlancoCafe.Bache.YPosition);
            BacheTaxiVerdeBlanco.Location = new Point(taxiBlancoVerde.Bache.XPosition, taxiBlancoVerde.Bache.YPosition);
            BacheTaxiRojo.Location = new Point(taxiRojo.Bache.XPosition, taxiRojo.Bache.YPosition);
            BacheTaxiVerde.Location = new Point(taxiVerde.Bache.XPosition, taxiVerde.Bache.YPosition);
            BacheTaxiAzulAmarillo.Location = new Point(taxiAzulAmarillo.Bache.XPosition, taxiAzulAmarillo.Bache.YPosition);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            velocidad1();
            ptbTaxiBlancoCafe.Location = new Point(taxiBlancoCafe.XPosition, taxiBlancoCafe.YPosition);            
            if(IsTaxiWinner) Winner();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            velocidad2();
            ptbTaxiBlancoVerde.Location = new Point(taxiBlancoVerde.XPosition, taxiBlancoVerde.YPosition);
            if (IsTaxiWinner) Winner();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            velocidad3();
            if(c > 0)ptbTaxiRojo.Location=new Point(taxiRojo.XPosition, taxiRojo.YPosition);
            if (IsTaxiWinner) Winner();
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            velocidad4();
            if(d > 0)ptbTaxiVerde.Location=new Point(taxiVerde.XPosition, taxiVerde.YPosition);
            if (IsTaxiWinner) Winner();
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            velocidad5();
            if(e1 > 0)ptbTaxiAzulAmarillo.Location=new Point(taxiAzulAmarillo.XPosition, taxiAzulAmarillo.YPosition);            
            if (IsTaxiWinner) Winner();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

           
        }

        private void btnreinicar_Click(object sender, EventArgs e)
        {

            mx1 = "derecha";
            mx2 = "derecha";
            mx3 = "derecha";
            mx4 = "derecha";
            mx5 = "derecha";
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            e1 = 0;
            taxiBlancoCafe = null;
            //taxiBlancoCafe.Bache.Passed = false;
            taxiBlancoVerde = null;
            //taxiBlancoVerde.Bache.Passed = false;
            taxiRojo = null;
            //taxiRojo.Bache.Passed = false;
            taxiVerde = null;
            //taxiVerde.Bache.Passed = false;
            taxiAzulAmarillo = null;
            //taxiBlancoCafe.Bache.Passed = false;
            InitializeTaxis();
            ptbTaxiBlancoCafe.Location=new Point(taxiBlancoCafe.XPosition, taxiBlancoCafe.YPosition);
            ptbTaxiBlancoVerde.Location=new Point(taxiBlancoVerde.XPosition, taxiBlancoVerde.YPosition);
            ptbTaxiRojo.Location= new Point(taxiRojo.XPosition, taxiRojo.YPosition);
            ptbTaxiVerde.Location= new Point(taxiVerde.XPosition, taxiVerde.YPosition);
            ptbTaxiAzulAmarillo.Location= new Point(taxiAzulAmarillo.XPosition, taxiAzulAmarillo.YPosition);
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            proceso_1.Abort();
            proceso_2.Abort();
            proceso_3.Abort();
            proceso_4.Abort();
            proceso_5.Abort();
            lblganador.Text = "";
            IsTaxiWinner = false;
            IsRaceFinished = false;
            BacheTaxiBlancoCafe.Visible = false;
            BacheTaxiVerdeBlanco.Visible = false;
            BacheTaxiRojo.Visible = false;
            BacheTaxiVerde.Visible = false;
            BacheTaxiAzulAmarillo.Visible = false;
            DictXPositionTaxis = null;
        }
        private void btninicar_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled= true;
            timer5.Enabled = true;

            InitializeTaxis();
            DefineBacheDelay();
            DefineBacheXPosition();
            DefineBacheLocation();            

            BacheTaxiBlancoCafe.Visible = true;
            BacheTaxiVerdeBlanco.Visible = true;
            BacheTaxiRojo.Visible = true;
            BacheTaxiVerde.Visible = true;
            BacheTaxiAzulAmarillo.Visible = true;


            //Iniciar hilo 1
            try
            {
                proceso_1 = new Thread(new ThreadStart(Funcion1));
                proceso_1.Name = "TaxiBlancoCafe";                
                proceso_1.Start();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            //iniicar hilo 2
            try
            {
                proceso_2 = new Thread(new ThreadStart(Funcion2));
                proceso_2.Name = "TaxiBlancoVerde";
                proceso_2.Start();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            //iniicar hilo 3
            try
            {
                proceso_3 = new Thread(new ThreadStart(Funcion3));
                proceso_3.Name = "TaxiRojo";
                proceso_3.Start();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            //iniciar hilo 4
            try
            {
                proceso_4 = new Thread(new ThreadStart(Funcion4));
                proceso_4.Name = "TaxiVerde";
                proceso_4.Start();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            //iniciar hilo 5
            try
            {
                proceso_5 = new Thread(new ThreadStart(Funcion5));
                proceso_5.Name = "TaxiAzulAmarillo";
                proceso_5.Start();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
            
        }


        // se pausa la carrera
        private void btnpausar_Click(object sender, EventArgs e)
        {
            //hilo 1
            try
            {
                proceso_1.Suspend();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            //hilo 2
            try
            {
                proceso_2.Suspend();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            //hilo 3
            try
            {
                proceso_3.Suspend();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            //hilo 4
            try
            {
                proceso_4.Suspend();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            //hilo 5
            try
            {
                proceso_5.Suspend();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
        }

        //se reinicia la carrera
        private void btnreanudar_Click(object sender, EventArgs e)
        {
            //hilo 1
            try
            {
                proceso_1.Resume();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            //hilo 2
            try
            {
                proceso_2.Resume();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            //hilo 3
            try
            {
                proceso_3.Resume();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            //hilo 4
            try
            {
                proceso_4.Resume();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            //hilo 5
            try
            {
                proceso_5.Resume();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
        }


        ///codigo de los hilos
        public void Funcion1()
        {
            int v1 = ran.Next(10, 25);
            int tempv1 = v1;
            while (true)
            {
                if (!taxiBlancoCafe.Bache.Passed && taxiBlancoCafe.XPosition >= taxiBlancoCafe.Bache.XPosition)
                {
                    a = 0;
                    v1 = 50;
                    a -= taxiBlancoCafe.Bache.Delay;
                    taxiBlancoCafe.Bache.Passed = true;
                }
                else
                {
                    if (a >= 0 && taxiBlancoCafe.Bache.Passed) v1 = ran.Next(10, 25);
                    Thread.Sleep(v1);
                    a++;
                }
            }
        }

       

        public void velocidad1()
        {
            posicion1();
            if (mx1 == "derecha")
            {
                if(a > 0) taxiBlancoCafe.XPosition += a;
                
            }
            else 
            {

            }
        }

        public void posicion1() 
        {
            if (taxiBlancoCafe.XPosition >= 1100) 
            {
                mx1 = "derecha";
                timer1.Stop();
                if(!IsTaxiWinner && !IsRaceFinished) IsTaxiWinner = true;
            }
        }

        //hilo 2 codigo
        public void Funcion2()
        {

            int v2 = ran.Next(10, 25);
            int tempv2 = v2;
            while (true)
            {
                if (!taxiBlancoVerde.Bache.Passed && taxiBlancoVerde.XPosition >= taxiBlancoVerde.Bache.XPosition)
                {
                    b = 0;
                    v2 = 50;
                    b -= taxiBlancoVerde.Bache.Delay;
                    taxiBlancoVerde.Bache.Passed = true;
                }
                else
                {
                    if (b >= 0 && taxiBlancoVerde.Bache.Passed) v2 = ran.Next(10, 25);
                    Thread.Sleep(v2);
                    b++;
                }
            }
        }

       

        public void velocidad2()
        {
            posicion2();
            if (mx2 == "derecha")
            {
                if(b > 0) taxiBlancoVerde.XPosition += b;

            }
            else
            {

            }
        }

        public void posicion2()
        {
            if (taxiBlancoVerde.XPosition >= 1100)
            {
                mx2 = "derecha";
                timer2.Stop();
                if (!IsTaxiWinner && !IsRaceFinished) IsTaxiWinner = true;
            }
        }

        

        //codigo hilo 3
        public void Funcion3()
        {
            int v3 = ran.Next(10, 25);
            int tempv3 = v3;
            while (true)
            {
                if (!taxiRojo.Bache.Passed && taxiRojo.XPosition >= taxiRojo.Bache.XPosition)
                {
                    c = 0;
                    v3 = 50;
                    c -= taxiRojo.Bache.Delay;
                    taxiRojo.Bache.Passed = true;
                }
                else
                {
                    if (c >= 0 && taxiRojo.Bache.Passed) v3 = ran.Next(10, 25);
                    Thread.Sleep(v3);
                    c++;
                }
            }
        }

        public void velocidad3()
        {
            posicion3();
            if (mx3 == "derecha")
            {
                if(c > 0) taxiRojo.XPosition += c;

            }
            else
            {

            }
        }

        public void posicion3()
        {
            if (taxiRojo.XPosition >= 1100)
            {
                mx3 = "derecha";
                timer3.Stop();
                if (!IsTaxiWinner && !IsRaceFinished) IsTaxiWinner = true;
            }
        }

        //coidgo hilo 4
        public void Funcion4()
        {
            int v4 = ran.Next(10, 25);
            int tempv4 = v4;
            while (true)
            {
                if (!taxiVerde.Bache.Passed && taxiVerde.XPosition >= taxiVerde.Bache.XPosition)
                {  
                    d = 0;
                    v4 = 50;
                    d -= taxiVerde.Bache.Delay;
                    taxiVerde.Bache.Passed = true;
                }
                else
                {
                    if (d >= 0 && taxiVerde.Bache.Passed) v4 = ran.Next(10, 25);
                    Thread.Sleep(v4);
                    d++;
                }
            }
        }

        public void velocidad4()
        {
            posicion4();
            if (mx4 == "derecha")
            {
                if(d > 0) taxiVerde.XPosition += d;

            }
            else
            {

            }
        }

        public void posicion4()
        {
            if (taxiVerde.XPosition >= 1100)
            {
                mx4 = "derecha";
                timer4.Stop();
                if (!IsTaxiWinner && !IsRaceFinished)  IsTaxiWinner = true;
            }
        }

        

        //codigo hilo 5
        public void Funcion5()
        {
            int v5 = ran.Next(10, 25);
            int tempv5 = v5;
            while (true)
            {
                if (!taxiAzulAmarillo.Bache.Passed && taxiAzulAmarillo.XPosition >= taxiAzulAmarillo.Bache.XPosition)
                {
                    e1 = 0;
                    v5 = 50;
                    e1 -= taxiAzulAmarillo.Bache.Delay;
                    taxiAzulAmarillo.Bache.Passed = true;
                }
                else
                {
                    if (e1 >= 0 && taxiAzulAmarillo.Bache.Passed) v5 = ran.Next(10, 25);
                    Thread.Sleep(v5);
                    e1++;
                }
            }
        }

        public void velocidad5()
        {
            posicion5();
            if (mx5 == "derecha")
            {
                if(e1 > 0) taxiAzulAmarillo.XPosition += e1;

            }
            else
            {

            }
        }

        public void posicion5()
        {
            if (taxiAzulAmarillo.XPosition >= 1100)
            {
                mx5 = "derecha";
                timer5.Stop();
                if (!IsTaxiWinner && !IsRaceFinished) IsTaxiWinner = true;
            }
        }

        public void Winner()
        {

            DictXPositionTaxis = new Dictionary<string, int>()
            {
                { taxiBlancoCafe.Name, taxiBlancoCafe.XPosition},
                { taxiBlancoVerde.Name, taxiBlancoVerde.XPosition},
                { taxiRojo.Name, taxiRojo.XPosition},
                { taxiVerde.Name, taxiVerde.XPosition},
                { taxiAzulAmarillo.Name, taxiAzulAmarillo.XPosition }
            };
            int ValueWinner = DictXPositionTaxis.Values.Max();

            lblganador.Text = DictXPositionTaxis.ToList().Find(x => x.Value == ValueWinner).Key;
            IsTaxiWinner = false;
            IsRaceFinished = true;
        }
    }

    public class Taxi
    {
        #region Fields
        public string Name { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public Bache Bache { get; set; }

        #endregion

        #region Constructor
        public Taxi(string name, int xPosition, int yPosition)
        {
            Name = name;
            XPosition = xPosition;
            YPosition = yPosition;
            Bache = new Bache(name, yPosition);
        }
        #endregion
    }

    public class Bache
    {
        #region Fields
        public string Name { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public int Delay { get; set; }
        public bool Passed { get; set; } = false;

        #endregion

        #region Constructor
        public Bache(string name, int yPosition)
        {
            Name = name;
            YPosition = yPosition;
        }
        #endregion
    }

}
