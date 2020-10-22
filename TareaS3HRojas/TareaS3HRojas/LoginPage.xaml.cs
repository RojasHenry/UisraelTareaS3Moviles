using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TareaS3HRojas
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Title = "Login";
        }

        async void btnIniciar_Clicked(System.Object sender, System.EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;

            if(user.Equals("") || pass.Equals(""))
            {
                await DisplayAlert("Alerta", "Complete todos los campos", "Aceptar");
            }
            else
            {
                if (user.Equals("estudiante2020") && pass.Equals("uisrael2020"))
                {
                    await Navigation.PushAsync(new MainPage(user));
                }
                else
                {
                    await DisplayAlert("Alerta", "Credenciales inválidas", "Aceptar");
                }
                
            }
        }
    }
}
