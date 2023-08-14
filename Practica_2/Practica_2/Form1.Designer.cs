namespace Practica_2
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
            label1 = new Label();
            textboxMonto = new TextBox();
            textboxPorcentaje = new TextBox();
            label2 = new Label();
            calcularButton = new Button();
            mostrarResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(226, 24);
            label1.Name = "label1";
            label1.Size = new Size(317, 24);
            label1.TabIndex = 0;
            label1.Text = "INGRESE EL MONTO INICIAL:";
            // 
            // textboxMonto
            // 
            textboxMonto.Location = new Point(315, 66);
            textboxMonto.Multiline = true;
            textboxMonto.Name = "textboxMonto";
            textboxMonto.Size = new Size(142, 23);
            textboxMonto.TabIndex = 1;
            // 
            // textboxPorcentaje
            // 
            textboxPorcentaje.Location = new Point(315, 173);
            textboxPorcentaje.Name = "textboxPorcentaje";
            textboxPorcentaje.Size = new Size(142, 23);
            textboxPorcentaje.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(237, 129);
            label2.Name = "label2";
            label2.Size = new Size(297, 24);
            label2.TabIndex = 3;
            label2.Text = "INGRESE EL PORCENTAJE:";
            // 
            // calcularButton
            // 
            calcularButton.BackColor = Color.Chocolate;
            calcularButton.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            calcularButton.Location = new Point(315, 236);
            calcularButton.Name = "calcularButton";
            calcularButton.Size = new Size(142, 52);
            calcularButton.TabIndex = 4;
            calcularButton.Text = "Calcular";
            calcularButton.UseVisualStyleBackColor = false;
            calcularButton.Click += calcularButton_Click;
            // 
            // mostrarResultado
            // 
            mostrarResultado.AutoSize = true;
            mostrarResultado.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            mostrarResultado.Location = new Point(237, 313);
            mostrarResultado.Name = "mostrarResultado";
            mostrarResultado.Size = new Size(0, 24);
            mostrarResultado.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(800, 450);
            Controls.Add(mostrarResultado);
            Controls.Add(calcularButton);
            Controls.Add(label2);
            Controls.Add(textboxPorcentaje);
            Controls.Add(textboxMonto);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textboxMonto;
        private TextBox textboxPorcentaje;
        private Label label2;
        private Button calcularButton;
        private Label mostrarResultado;
    }
}