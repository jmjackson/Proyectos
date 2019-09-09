using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class Principal : Form
    {
        //estas variablaes son para controlar el tiempo
        TimeSpan timeElapsed;
        DateTime lastElapsed;
        public Principal()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void TimeTicker(object sender, EventArgs e)
        {
            //el tiempo transcurrido le llamaremos timeElapsed EL cual se restara del ultimo 
            //Last Elpsed
            timeElapsed += DateTime.Now - lastElapsed;
            //Ultimo Last Elapsed
            lastElapsed = DateTime.Now;
            //Aqui Pasamos los valores del timeelapsed en horas, minutos y segundos, al Label.Convirtiendolo Antes en 
            //String.
            LabelCronometer.Text = Convert.ToString(new TimeSpan(timeElapsed.Hours,timeElapsed.Minutes,timeElapsed.Seconds));
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //Si nuestro boton de estar esta prendido se desactiva el boton  y activa
            //el boton de Pause y el Timework, Pasandole el lastElapsed.
            ButtonStart.Enabled = false;
            ButtonPause.Enabled = true;
            TimeWork.Enabled = true;
            lastElapsed = DateTime.Now;
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            //SI nuestro boton Pause esta encendido, el STart debera estar desactivado,
            //y el TimeWork Tambien lo debe de estar.
            ButtonStart.Enabled = true;
            ButtonPause.Enabled = false;
            TimeWork.Enabled = false;
            
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            //SI presionamos Stop, entonces se tiene que reiniciar a 0;
            ButtonStart.Enabled = true;
            ButtonPause.Enabled = false;
            TimeWork.Enabled = false;
            lastElapsed = DateTime.Now;
            timeElapsed = DateTime.Now - lastElapsed;
            LabelCronometer.Text = Convert.ToString(new TimeSpan(timeElapsed.Hours, timeElapsed.Minutes, timeElapsed.Seconds));
        }
    }
}
