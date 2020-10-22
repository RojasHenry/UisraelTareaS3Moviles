using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Toast;
using TareaS2HRojas.Class;
using Xamarin.Forms;

namespace TareaS3HRojas
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<SeguimientoClass> seguimientoList = new ObservableCollection<SeguimientoClass>();
        public ObservableCollection<SeguimientoClass> SeguimientoList { get { return seguimientoList; } }

        public MainPage(string user)
        {
            InitializeComponent();
            Title = "Simulador de notas Uisrael";
            notasList.ItemsSource = SeguimientoList;
            txtuseractual.Text += " "+user;
        }

        public void btnCalcular_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!entryNotaS1.Text.Trim().Equals("") || !entryExamenS1.Text.Trim().Equals("")
            || !entryNotaS2.Text.Trim().Equals("") || !entryExamenS2.Text.Trim().Equals(""))
            {
                double nota1 = Convert.ToDouble(entryNotaS1.Text.Trim());
                if (nota1 < 0 || nota1 > 10)
                {
                    CrossToastPopUp.Current.ShowToastMessage("Campo Nota de seguimiento 1 valor incorrecto");
                    return;
                }
                double examen1 = Convert.ToDouble(entryExamenS1.Text.Trim());
                if (examen1 < 0 || examen1 > 10)
                {
                    CrossToastPopUp.Current.ShowToastMessage("Campo Exámen 1 valor incorrecto");
                    return;
                }

                double nota2 = Convert.ToDouble(entryNotaS2.Text.Trim());
                if (nota2 < 0 || nota2 > 10)
                {
                    CrossToastPopUp.Current.ShowToastMessage("Campo Nota de seguimiento 2 valor incorrecto");
                    return;
                }
                double examen2 = Convert.ToDouble(entryExamenS2.Text.Trim());
                if (examen2 < 0 || examen2 > 10)
                {
                    CrossToastPopUp.Current.ShowToastMessage("Campo Exámen 2 valor incorrecto");
                    return;
                }

                SeguimientoClass seguimiento = new SeguimientoClass
                {
                    nota1 = string.Format("{0:F2}", nota1 * 0.3),
                    examen1 = string.Format("{0:F2}", examen1 * 0.2),
                    nota2 = string.Format("{0:F2}", nota2 * 0.3),
                    examen2 = string.Format("{0:F2}", examen2 * 0.2)
                };

                seguimientoList.Add(seguimiento);
                btnlimpiar.IsEnabled = true;
                btnCalcular.IsEnabled = false;
            }
            else
            {
                DisplayAlert("Alerta", "Complete todos los campos", "Aceptar");
            }

        }

        void btnlimpiar_Clicked(System.Object sender, System.EventArgs e)
        {
            entryNotaS1.Text = "";
            entryNotaS2.Text = "";
            entryExamenS1.Text = "";
            entryExamenS2.Text = "";

            btnlimpiar.IsEnabled = false;
            btnCalcular.IsEnabled = true;
            seguimientoList.Clear();
        }

    }
}
