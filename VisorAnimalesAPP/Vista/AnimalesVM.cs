using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisorAnimalesAPP.Vista
{ 
    public class AnimalesVM
    {
        public ObservableCollection<Animales> Animales { get; set; }
        public AnimalesVM() {
            Animales = new ObservableCollection<Animales>
            {
                new Animales {nombre= "Tigre", imagen= "animal1.jpg", fecha = DateTime.Today.ToString("dd/MM/yyyy"), descripcion = "Gatito" },
                new Animales {nombre= "León", imagen= "animal2.jpg", fecha = DateTime.Today.ToString("dd/MM/yyyy"), descripcion = "Gatito grande" },
                new Animales {nombre= "Panda", imagen= "animal3.jpg", fecha = DateTime.Today.ToString("dd/MM/yyyy"), descripcion = "Bicho grande peludo en blanco y negro" },
                new Animales {nombre= "Lince", imagen= "animal4.jpg", fecha = DateTime.Today.ToString("dd/MM/yyyy"), descripcion = "Gatito mas chico" },
                new Animales {nombre= "Zebra", imagen= "animal5.jpg", fecha = DateTime.Today.ToString("dd/MM/yyyy"), descripcion = "El animale que se quedo en los 80" },
                new Animales {nombre= "Buitre", imagen= "animal6.jpg", fecha = DateTime.Today.ToString("dd/MM/yyyy"), descripcion = "El que te lo roba todo" },
            };
        } 
    }
}
