/*
 20181111
 ALVARO CÉSPEDES ROMERO
 Creacion de un ejemplo, para el grupo Adsi
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ejemploGraficosChart
{
    public partial class Form1 : Form
    {
        int s1 = 0, s2 = 0;

        public Form1()
        {
            InitializeComponent();

            // Para  no mostrar vacio el grafico al principio
            chart1.Series.Clear(); // Inicializa el tipo de grafico
            chart1.Series.Add("Series1");// Agrega una serie
            chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            // Seleccionar el tipo de grafico que se mostrara


            chart1.Series["Series1"].LegendText = "MOTOS";
            chart1.Series["Series1"].Points.AddY(90);// Agrega un punto a esa serie
            labelMotos.Text = "2";

            chart1.Series.Add("Series2");// Agrega otra serie
            chart1.Series["Series2"].LegendText = "CARROS";
            chart1.Series["Series2"].Points.AddY(30);// Agrega un punto a la otra serie
            labelCarros.Text = "2";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         
            

            chart1.Series.Clear(); // Inicializa el tipo de grafico
         
            chart1.Series.Add("Series1");// Agrega una serie
            chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            // Seleccionar el tipo de grafico que se mostrara
           


            chart1.Series["Series1"].LegendText = "MOTOS";
            chart1.Series["Series1"].Points.AddY(s1);// Agrega un punto a esa serie
            chart1.Series["Series1"].Label = s1.ToString();


            chart1.Series.Add("Series2");// Agrega otra serie
            chart1.Series["Series2"].LegendText = "CARROS";
            chart1.Series["Series2"].Points.AddY(s2);// Agrega un punto a la otra serie
            chart1.Series["Series2"].Label = s2.ToString();
        }

       

        private void trackMotos_Scroll(object sender, EventArgs e)
        {
            labelMotos.Text = trackMotos.Value.ToString();
            s1 = trackMotos.Value; // La variable podria omitirse y que se cargue directa
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackCarros_Scroll(object sender, EventArgs e)
        {
            labelCarros.Text = trackCarros.Value.ToString();
            s2 = trackCarros.Value;// Tambien puede omitirse y que la lea, directo del track
        }

      
    }
}


/*
 * Enlaces consultados:
 * 
 https://msdn.microsoft.com/en-us/library/dd456769.aspx
 Disponible en el repositorio: https://github.com/alvaroadsi/ejemploGraficosChart
*/
