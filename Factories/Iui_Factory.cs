using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theme_FactoryAbstract.Factories;
using Theme_FactoryAbstract.Products;

namespace Theme_FactoryAbstract.Factories
{
    public interface Iui_Factory
    {
        //Al momento se hace referencia a alguna de este metodo, se creara el objeto segun los atributos de la interfaz
        I_Boton CreateButton();
        I_Texto CreateText();
    }
}
