using ABMCursos.Models;
using ABMCursos.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ABMCursos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private static CursosViewModel viewModel;
        public MainPage()
        {
            if(viewModel == null)
            {
                viewModel = new CursosViewModel();
            }
            InitializeComponent();
            BindingContext = viewModel;
        }

        public void Add_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new Curso(viewModel)));
        }

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var Curso = args.SelectedItem as CursoModel;
            if (Curso == null)
                return;

            Navigation.PushModalAsync(new NavigationPage(new Curso(new CursoModel(Curso), viewModel)));

            listaCursos.SelectedItem = null;
        }

    }
}
