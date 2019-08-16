using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginPage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnLoginClicked(object obj, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.entryMatricula.Text) )
            {
                if(String.IsNullOrEmpty(this.entryPassword.Text))
                {
                    await DisplayAlert("Error!", "Los campos Matricula y Password estan vacios!", "Ok");
                }
                else
                await DisplayAlert("Error!", "El campo Matricula esta vacio!", "Ok");
            }else
            {
                if(string.IsNullOrEmpty(this.entryPassword.Text))
                {
                    await DisplayAlert("Error!", "El campo Password esta vacio!", "Ok");
                }
                else
                {
                    await DisplayAlert("Bienvenido!", $"Hola Matricula: {this.entryMatricula.Text} \n \nPase Feliz Dia :3", "Ok");
                }
            }
        }
    }
}
