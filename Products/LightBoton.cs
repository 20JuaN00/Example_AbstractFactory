using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Theme_FactoryAbstract.Products;

namespace Theme_FactoryAbstract.Products
{
    //Se hace herencia de los metodos de la interfaz boton que usara la clase lightboton
    public class LightBoton : I_Boton
    {
        public void Render(Form form)
        {
            Button btn = new Button();
            btn.BackColor = Color.Black;           // --btnBg
            btn.ForeColor = Color.White;           // --btnFontColor
            btn.Width = 100;
            btn.Height = 40;
            btn.Top = 100;
            btn.Left = 50;

            form.Controls.Add(btn);
            form.BackColor = Color.FromArgb(0, 255, 0);
        }
    }
}
