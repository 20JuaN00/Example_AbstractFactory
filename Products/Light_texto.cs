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
    public class Light_texto : I_Texto
    {
        public void Render(Form form)
        {
            TextBox txt = new TextBox();
            txt.Text = "Light Text";
            txt.BackColor = Color.FromArgb(0, 255, 0);  // mismo fondo
            txt.ForeColor = Color.Black;                // --fontColor
            txt.Top = 50;
            txt.Left = 50;
            form.Controls.Add(txt);
        }
    }
}
