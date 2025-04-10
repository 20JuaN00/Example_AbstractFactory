using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theme_FactoryAbstract.Factories;
using Theme_FactoryAbstract.Products;

namespace Theme_FactoryAbstract.Factories
{
    public class Dark_fabrica : Iui_Factory
    {
        public I_Boton CreateButton() => new DarkBoton();
        public I_Texto CreateText() => new Dark_texto();

    }
}
