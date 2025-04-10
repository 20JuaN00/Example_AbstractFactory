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
    public class Dark_texto : I_Texto
    {
        public void Render(Form form)
        {
            TextBox txt = new TextBox();
            txt.Text = "Dark Text";
            txt.BackColor = Color.Black;
            txt.ForeColor = Color.FromArgb(0, 255, 0); // --fontColor (verde)
            txt.Top = 50;
            txt.Left = 50;

            form.Controls.Add(txt);
        }

    }
}
