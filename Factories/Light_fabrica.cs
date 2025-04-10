using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theme_FactoryAbstract.Factories;
using Theme_FactoryAbstract.Products;

namespace Theme_FactoryAbstract.Factories
{
    public class LightFabrica : Iui_Factory
    {
        public I_Boton CreateButton()
        {
            return new LightBoton();
        }

        //La implementacion de "=>" es lo mismo que el "return"
        public I_Texto CreateText() => new Light_texto();




    }
}
