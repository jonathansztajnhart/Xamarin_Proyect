using ABMCursos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABMCursos.ViewModels
{
    public class CursoViewModel: BaseViewModel
    {
        public CursoModel Curso { get; set; }
        public bool IsNewCurso { get; set; }
        //public string CursoNombre
        //{
        //    get { return Curso.NomCurso; }
        //    set
        //    {
        //        Curso.NomCurso = value;
        //        OnPropertyChanged();
        //    }
        //}
        //public string CursoDescripcion
        //{
        //    get { return Curso.descCurso; }
        //    set
        //    {
        //       Curso.descCurso = value;
        //       OnPropertyChanged();
        //    }
        //}
       
        public CursoViewModel(CursoModel curso = null)
        {
            IsNewCurso = curso == null;
            Titulo = IsNewCurso ? "Crear curso" : "Editar curso";
            Curso = curso ?? new CursoModel();
        }
       
    }
}
