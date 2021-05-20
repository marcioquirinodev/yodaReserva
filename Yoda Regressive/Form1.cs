using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yoda_Regressive
{
    public partial class Form1 : Form
    {
        private int segundos;
        private int minutos;
        private int horas;
        private int diasRestantes;
        private DateTime dataReserva;
        private DateTime hoje;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var amanha = DateTime.Today.AddDays(1);
            hoje = DateTime.Now;
            var horasRestantes = amanha.Subtract(hoje);
            dataReserva = new DateTime(2021, 11, 13, 0, 0, 0);
            diasRestantes = (int)dataReserva.Subtract(hoje).TotalDays;
            horas = (int)(horasRestantes.TotalHours);
            minutos = (int)((horasRestantes.TotalHours - (int)(horasRestantes.TotalHours)) * 60);

           
            segundos = 60 - DateTime.Now.Second;
            rotulo.Text = segundos.ToString();
            rotuloMinutos.Text = minutos.ToString("00");
            rotuloHoras.Text = horas.ToString("00");
            rotuloDias.Text = diasRestantes.ToString("00");
            this.timer1.Enabled = true;
            Acabou(dataReserva, hoje);

        }

        private void Timer1Tick(object sender, EventArgs e)
        {


            Acabou(dataReserva, hoje);

            if (segundos > 0)
            {
                rotuloDias.Text = diasRestantes.ToString("00");
                rotuloHoras.Text = horas.ToString("00");
                rotuloMinutos.Text = minutos.ToString("00");
                rotulo.Text = segundos.ToString("00");
                segundos--;
            }
            else if (segundos == 0)
            {
                rotulo.Text = segundos.ToString("00");
                if (minutos > 0)
                {
                    minutos--;
                    rotuloMinutos.Text = minutos.ToString("00");
                    segundos = 59;
                }
                else if (minutos == 0)
                {
                    rotuloMinutos.Text = minutos.ToString("00");
                    if (horas > 0)
                    {
                        horas--;
                        rotuloHoras.Text = horas.ToString("00");
                        minutos = 59;
                        segundos = 59;
                    }
                    else if (horas == 0)
                    {
                        rotuloHoras.Text = horas.ToString("00");
                        if (diasRestantes > 0)
                        {
                            diasRestantes--;
                            rotuloDias.Text = diasRestantes.ToString("00");
                            horas = 23;
                            minutos = 59;
                            segundos = 59;
                        }
                        else if (diasRestantes == 0 && horas == 00 && minutos == 00 & segundos == 00)
                        {
                            rotuloDias.Text = "00";
                            rotulo.Text="00";
                            rotuloHoras.Text = "00";
                            rotuloMinutos.Text = "00";

                            rotuloReserva.Text = "Partiu Reserva!! Adsumus!!";
                            timer1.Enabled = false;

                        }

                    }
                }

            }

        }

        private void Acabou(DateTime x, DateTime y)
        {
            if (x <= y)
            {
                rotuloDias.Text = "00";
                rotulo.Text = "00";
                rotuloHoras.Text = "00";
                rotuloMinutos.Text = "00";

                rotuloReserva.Text = "Partiu Reserva!! Adsumus!!";
                timer1.Enabled = false;

            }
        }
    }
}
