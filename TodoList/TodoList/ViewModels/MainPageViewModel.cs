using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TodoList.Model;
using Xamarin.Forms;

namespace TodoList.ViewModels
{
    public class MainPageViewModel:InotifyPropertyChanged
    {
        public event PropertyChangingEventArgs
        DataStore dataStore = new DataStore();

        public MainPageViewModel()...

        private void agregarevent ()
        {
            agregarCommand = new Command(agregarevent);
        }

        private void agregarevent()
        {
            dataStore.Add(nombre);
            Nombre = "";
            
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public ObservableCollection<Task> Tasks
        {
            get { return dataStore.Tasks; }
        }

        private Command agregarCommand;

        public Command Agregar
        {
            get { return agregarCommand; }
            set { agregarCommand = value; }
        }

    }
}
