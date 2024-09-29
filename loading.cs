using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XKsTOR
{
    public partial class loading : Form
    {
        private ProgressBar progressBar;
        private Label label;
        private Timer timer;

        public loading()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(674, 323);

            progressBar = new ProgressBar();
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Dock = DockStyle.Top;
            progressBar.MarqueeAnimationSpeed = 30;
            this.Controls.Add(progressBar);

            label = new Label();
            label.Text = "Iniciando el programa, por favor espere";
            label.Dock = DockStyle.Top;
            label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Controls.Add(label);

            timer = new Timer();
            timer.Interval = 5000; // 5 segundos de espera simulando la carga
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Detenemos el timer
            this.Close(); // Cerramos el formulario de loading
            XKsTOR mainForm = new XKsTOR(); // Creamos una nueva instancia del MainForm
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void loading_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
