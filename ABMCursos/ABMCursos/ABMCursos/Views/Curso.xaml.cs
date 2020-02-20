using ABMCursos.Models;
using ABMCursos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ABMCursos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Curso : ContentPage
    {
        CursoModel Model; 
        CursosViewModel viewModels;
        public Curso(CursoModel model, CursosViewModel viewModels)
        {
            this.Model = model; 
            this.viewModels = viewModels;
            //btnEliminar.IsVisible = true;
            InitializeComponent();
            BindingContext = this.Model;
        }

        public Curso(CursosViewModel viewModels)
        {
            this.Model = new CursoModel();
            this.viewModels = viewModels;
            InitializeComponent();
            BindingContext = this.Model;
        }

        public Curso()
        {
            InitializeComponent();
            this.Model = new CursoModel();
            CursosViewModel cursosViewModel = new CursosViewModel();
            BindingContext = this.Model;
        }

        public void Cancel_Clicked(object sender, EventArgs eventArgs)
        {
            Navigation.PopModalAsync();
        }
        public void Save_Clicked(object sender, EventArgs eventArgs)
        {
            string message = viewModel.IsNewCurso ? "GuardarCurso" : "ActualizarCurso";
            viewModel.CursoNombre = nomCurso.Text;
            viewModel.CursoDescripcion = descCurso.Text;
            if (message == "GuardarCurso")
            {
                viewModels.guardarCurso(viewModel.Curso);
            }
            else
            {
                viewModels.actualizarCurso(viewModel.Curso);
            }
            Navigation.PopModalAsync();
        } 
    }
}