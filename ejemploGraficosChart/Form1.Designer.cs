namespace ejemploGraficosChart
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackMotos = new System.Windows.Forms.TrackBar();
            this.trackCarros = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMotos = new System.Windows.Forms.Label();
            this.labelCarros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(22, 52);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(452, 353);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // trackMotos
            // 
            this.trackMotos.Location = new System.Drawing.Point(519, 66);
            this.trackMotos.Maximum = 100;
            this.trackMotos.Name = "trackMotos";
            this.trackMotos.Size = new System.Drawing.Size(129, 45);
            this.trackMotos.TabIndex = 1;
            this.trackMotos.TickFrequency = 10;
            this.trackMotos.Scroll += new System.EventHandler(this.trackMotos_Scroll);
            // 
            // trackCarros
            // 
            this.trackCarros.Location = new System.Drawing.Point(519, 142);
            this.trackCarros.Maximum = 100;
            this.trackCarros.Name = "trackCarros";
            this.trackCarros.Size = new System.Drawing.Size(129, 45);
            this.trackCarros.TabIndex = 2;
            this.trackCarros.TickFrequency = 10;
            this.trackCarros.Scroll += new System.EventHandler(this.trackCarros_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMotos
            // 
            this.labelMotos.AutoSize = true;
            this.labelMotos.Location = new System.Drawing.Point(668, 66);
            this.labelMotos.Name = "labelMotos";
            this.labelMotos.Size = new System.Drawing.Size(35, 13);
            this.labelMotos.TabIndex = 4;
            this.labelMotos.Text = "label1";
            // 
            // labelCarros
            // 
            this.labelCarros.AutoSize = true;
            this.labelCarros.Location = new System.Drawing.Point(671, 142);
            this.labelCarros.Name = "labelCarros";
            this.labelCarros.Size = new System.Drawing.Size(35, 13);
            this.labelCarros.TabIndex = 5;
            this.labelCarros.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.labelCarros);
            this.Controls.Add(this.labelMotos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackCarros);
            this.Controls.Add(this.trackMotos);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EJEMPLO DE USO DE UN GRAFICO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar trackMotos;
        private System.Windows.Forms.TrackBar trackCarros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMotos;
        private System.Windows.Forms.Label labelCarros;
    }
}

