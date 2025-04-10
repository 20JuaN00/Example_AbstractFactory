
namespace Theme_FactoryAbstract
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboFactoryAbstract = new ComboBox();
            buttonGenerate = new Button();
            SuspendLayout();
            // 
            // comboFactoryAbstract
            // 
            comboFactoryAbstract.FormattingEnabled = true;
            comboFactoryAbstract.Items.AddRange(new object[] { "Light", "Dark" });
            comboFactoryAbstract.Location = new Point(273, 160);
            comboFactoryAbstract.Name = "comboFactoryAbstract";
            comboFactoryAbstract.Size = new Size(226, 28);
            comboFactoryAbstract.TabIndex = 0;
            comboFactoryAbstract.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboFactoryAbstract.Click += buttonGenerate_Click;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(341, 241);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(94, 56);
            buttonGenerate.TabIndex = 1;
            buttonGenerate.Text = "Cambiar Tema";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGenerate);
            Controls.Add(comboFactoryAbstract);
            Name = "Form1";
            Text = "Form1";
            Click += comboBox1_SelectedIndexChanged;
            ResumeLayout(false);
        }


        #endregion

        private ComboBox comboFactoryAbstract;
        private Button buttonGenerate;
    }
}
