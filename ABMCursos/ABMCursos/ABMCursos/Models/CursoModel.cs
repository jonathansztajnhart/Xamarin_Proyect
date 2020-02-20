using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ABMCursos.Models
{
    public class CursoModel: INotifyPropertyChanged
    {
        public int Id { get; set; }
        private string NomCurso { get; set; }
        private string descCurso { get; set; }

        public string CursoNombre
        {
            get { return NomCurso; }
            set
            {
                NomCurso = value;
                OnPropertyChanged();
            }
        }
        public string CursoDescripcion
        {
            get { return descCurso; }
            set
            {
                descCurso = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
