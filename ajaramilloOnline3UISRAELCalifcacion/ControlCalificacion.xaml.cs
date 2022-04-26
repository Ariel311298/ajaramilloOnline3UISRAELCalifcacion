using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ajaramilloOnline3UISRAELCalifcacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlCalificacion : ContentPage
    {
        public ControlCalificacion(string usuario, string contrasena)
        {
            InitializeComponent();
            lblNombre.Text = usuario;
        }

        private void btnCalcularParcial1_Clicked(object sender, EventArgs e)
        {
            try
            {
                double notaCalcSeg1 = Convert.ToDouble(txtNotaCalcSeg1.Text);
                double notaCalcExam1 = Convert.ToDouble(txtNotaCalcExam1.Text);
                double notaParcial1 = notaCalcSeg1 + notaCalcExam1;
                txtNotaParcial1.Text = notaParcial1.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }

        private void txtNotaSeg1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double notaSeg1 = Convert.ToDouble(txtNotaSeg1.Text);
                double notaSegDec1 = 0.3;
                double notaCalcSeg1 = notaSeg1 * notaSegDec1;
                txtNotaCalcSeg1.Text = notaCalcSeg1.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void txtNotaExam1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double notaExam1 = Convert.ToDouble(txtNotaExam1.Text);
                double notaExamDec1 = 0.2;
                double notaCalcExam1 = notaExam1 * notaExamDec1;
                txtNotaCalcExam1.Text = notaCalcExam1.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDefectoNotaSeg1_Clicked(object sender, EventArgs e)
        {
            try
            {
                double defectoNotaSeg1 = 0.00;
                double defectoCalcNotaSeg1 = 0.00;
                string defectoNotaS1 = "";
                double defectoTotalCalcNotaSeg1 = defectoNotaSeg1 * defectoCalcNotaSeg1;
                txtNotaSeg1.Text = defectoNotaS1;
                txtNotaCalcSeg1.Text = defectoTotalCalcNotaSeg1.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDefectoNotaExam1_Clicked(object sender, EventArgs e)
        {
            try
            {
                double defectoNotaExam1 = 0.00;
                double defectoCalcNotaExam1 = 0.00;
                string defectoNotaE1 = "";
                double defectoTotalCalcNotaExam1 = defectoNotaExam1 * defectoCalcNotaExam1;
                txtNotaExam1.Text = defectoNotaE1;
                txtNotaCalcExam1.Text = defectoTotalCalcNotaExam1.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void txtNotaSeg2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double notaSeg2 = Convert.ToDouble(txtNotaSeg2.Text);
                double notaSegDec2 = 0.3;
                double notaCalcSeg2 = notaSeg2 * notaSegDec2;
                txtNotaCalcSeg2.Text = notaCalcSeg2.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void txtNotaExam2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double notaExam2 = Convert.ToDouble(txtNotaExam2.Text);
                double notaExamDec2 = 0.2;
                double notaCalcExam2 = notaExam2 * notaExamDec2;
                txtNotaCalcExam2.Text = notaCalcExam2.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDefectoNotaSeg2_Clicked(object sender, EventArgs e)
        {
            try
            {
                double defectoNotaSeg2 = 0.00;
                double defectoCalcNotaSeg2 = 0.00;
                string defectoNotaS2 = "";
                double defectoTotalCalcNotaSeg2 = defectoNotaSeg2 * defectoCalcNotaSeg2;
                txtNotaSeg2.Text = defectoNotaS2;
                txtNotaCalcSeg2.Text = defectoTotalCalcNotaSeg2.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDefectoNotaExam2_Clicked(object sender, EventArgs e)
        {
            try
            {
                double defectoNotaExam2 = 0.00;
                double defectoCalcNotaExam2 = 0.00;
                string defectoNotaE2 = "";
                double defectoTotalCalcNotaExam2 = defectoNotaExam2 * defectoCalcNotaExam2;
                txtNotaExam2.Text = defectoNotaE2;
                txtNotaCalcExam2.Text = defectoTotalCalcNotaExam2.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnCalcularParcial2_Clicked(object sender, EventArgs e)
        {
            try
            {
                double notaCalcSeg2 = Convert.ToDouble(txtNotaCalcSeg2.Text);
                double notaCalcExam2 = Convert.ToDouble(txtNotaCalcExam2.Text);
                double notaParcial2 = notaCalcSeg2 + notaCalcExam2;
                txtNotaParcial2.Text = notaParcial2.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }

        private void txtNotaFinal_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double notaFinal = Convert.ToDouble(txtNotaFinal.Text);
                if (notaFinal >= 7)
                {
                    lblEstado.Text = "APROBADO";
                    return;
                }

                if (notaFinal >= 5.00 && notaFinal <= 6.99)
                {
                    lblEstado.Text = "COMPLEMENTARIO";
                    return;
                }

                if (notaFinal < 5)
                {
                    lblEstado.Text = "REPROBADO";
                    return;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtNotaParcial1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double notaParcial1 = Convert.ToDouble(txtNotaParcial1.Text);
                double notaParcial2 = Convert.ToDouble(txtNotaParcial2.Text);
                double notaFinal = notaParcial1 + notaParcial2;
                txtNotaFinal.Text = notaFinal.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void txtNotaParcial2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double notaParcial1 = Convert.ToDouble(txtNotaParcial1.Text);
                double notaParcial2 = Convert.ToDouble(txtNotaParcial2.Text);
                double notaFinal = notaParcial2 + notaParcial1;
                txtNotaFinal.Text = notaFinal.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            try
            {
                txtNotaSeg1.Text = "";
                txtNotaSeg2.Text = "";
                txtNotaExam1.Text = "";
                txtNotaExam2.Text = "";
                double defectoNotaSeg1 = 0.00;
                double defectoCalcNotaSeg1 = 0.00;
                double defectoNotaSeg2 = 0.00;
                double defectoCalcNotaSeg2 = 0.00;
                double defectoTotalCalcNotaSeg1 = defectoNotaSeg1 * defectoCalcNotaSeg1;
                txtNotaCalcSeg1.Text = defectoTotalCalcNotaSeg1.ToString();
                double defectoTotalCalcNotaSeg2 = defectoNotaSeg2 * defectoCalcNotaSeg2;
                txtNotaCalcSeg2.Text = defectoTotalCalcNotaSeg2.ToString();
                double defectoNotaExam1 = 0.00;
                double defectoCalcNotaExam1 = 0.00;
                double defectoTotalCalcNotaExam1 = defectoNotaExam1 * defectoCalcNotaExam1;
                txtNotaCalcExam1.Text = defectoTotalCalcNotaExam1.ToString();
                double defectoNotaExam2 = 0.00;
                double defectoCalcNotaExam2 = 0.00;
                double defectoTotalCalcNotaExam2 = defectoNotaExam2 * defectoCalcNotaExam2;
                txtNotaCalcExam2.Text = defectoTotalCalcNotaExam2.ToString();
                double defectoNotaParcial1 = 0.00;
                txtNotaParcial1.Text = defectoNotaParcial1.ToString();
                double defectoNotaParcial2 = 0.00;
                txtNotaParcial2.Text = defectoNotaParcial2.ToString();
                double defectoNotaFinal = 0.00;
                txtNotaFinal.Text = defectoNotaFinal.ToString();
                lblEstado.Text = "REPROBADO";
            }
            catch (Exception ex)
            {

            }
        }
    }
}