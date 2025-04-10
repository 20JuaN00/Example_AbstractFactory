using System;
using System.Windows.Forms;
using Theme_FactoryAbstract.Factories;
using Theme_FactoryAbstract.Products;

namespace Theme_FactoryAbstract
{
    //Todo debe ir dentro de la herencia del fomulario
    public partial class Form1 : Form
    {
        private Iui_Factory factory;
        public Form1()
        {
            InitializeComponent();
            comboFactoryAbstract.SelectedIndex = 0;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {



            //Limpiar ui//

            if (comboFactoryAbstract.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccioná un tema.");
                return;
            }

            // uso de operador ternario si la comparacion es verdadera se ejecuta "?" si no ":"
            // para hacer eleccion de la fabrica
            factory = comboFactoryAbstract.SelectedItem.ToString() == "Dark"
                ? new Dark_fabrica()
                : new LightFabrica();

            //Creacion de los productos haciendo referencia a cada fabrica
            I_Boton button = factory.CreateButton();
            I_Texto TextBox = factory.CreateText();
            button.Render(this);
            TextBox.Render(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            
        }
    }
}
