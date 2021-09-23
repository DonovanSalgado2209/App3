using System;
using System.Collections.Generic;
using System.Text;

namespace App3.ViewModels
{
    class MainPageViewModel : ViewModelBase
    {
        private string nombre;
        private string primerApellido;
        private string segundoApellido;

        public MainPageViewModel()
            {
            nombre = "Ingresa tu nombre";
            primerApellido = "Ingresa tu primer apellido";
            segundoApellido = "Ingresa tu segundo apellido";               
            }
  
        public string Nombre
        { 
            
            get => nombre; 
            set
            {
                if (string.Equals(nombre, value)) return;
                var data = nombre.CompareTo(value);

                nombre = value;
                RaisePropertyChanged(nameof(Nombre));
                RaisePropertyChanged(nameof(SinUpdate));
            }
        }
        public string PrimerApellido 
        { 
            get => primerApellido;
            set
            {
                if (string.Equals(primerApellido, value)) return;
                var data = primerApellido.CompareTo(value);

                primerApellido = value;
                RaisePropertyChanged(nameof(PrimerApellido));
                RaisePropertyChanged(nameof(SinUpdate2));
            }
        }
        public string Segundoapellido 
        {
            get => segundoApellido; 
            set
            {
                if (string.Equals(segundoApellido, value)) return;
                var data = segundoApellido.CompareTo(value);

                segundoApellido = value;
                RaisePropertyChanged(nameof(Segundoapellido));
                RaisePropertyChanged(nameof(SinUpdate3));
            }
        }
        public string SinUpdate
        {
            get => nombre;
         
        }
        public string SinUpdate2
        {
            get => primerApellido;       
        }
        public string SinUpdate3
        {
            get => segundoApellido;
        }

    }



}
