using ABMCursos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ABMCursos.ViewModels
{
    public class CursosViewModel: BaseViewModel
    {
        public Command Add_Clicked { get; set; }
        public ObservableCollection<CursoModel> Cursos { get; set; }
        public CursosViewModel()
        {
            Add_Clicked = new Command(AddClickedEvent);
            Cursos = new ObservableCollection<CursoModel>();
        }

        private void AddClickedEvent(object obj)
        {
            System.Diagnostics.Debug.WriteLine("lo que sea");
           // Navigation.PushModalAsync(new NavigationPage(new Curso(viewModel)));
        }

        public void guardarCurso(CursoModel curso)
        {
            curso.Id = Cursos.Count;
            Cursos.Add(curso);
        }

        public void actualizarCurso(CursoModel curso)
        {
            Cursos[curso.Id].NomCurso =  curso.NomCurso;
            Cursos[curso.Id].descCurso = curso.descCurso;
        }

        public void eliminarCurso(CursoModel curso)
        {
            for (int i = curso.Id + 1; i < Cursos.Count; i++)
            {
                Cursos[i].Id--;
            }
            Cursos.Remove(curso);

        }
    }
}
