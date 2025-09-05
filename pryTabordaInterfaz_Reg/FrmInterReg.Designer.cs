namespace pryTabordaInterfaz_Reg
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
            button1 = new Button();
            btnGrabar = new Button();
            lblContacto = new Label();
            lblTelefono = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            chklstResultado = new CheckedListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(828, 380);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(200, 211);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(86, 45);
            btnGrabar.TabIndex = 1;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(58, 98);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(69, 20);
            lblContacto.TabIndex = 2;
            lblContacto.Text = "Contacto";
            lblContacto.Click += label1_Click;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(58, 154);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 31);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 4;
            label3.Text = "Registrar Contacto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(161, 155);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 6;
            // 
            // chklstResultado
            // 
            chklstResultado.FormattingEnabled = true;
            chklstResultado.Location = new Point(78, 285);
            chklstResultado.Name = "chklstResultado";
            chklstResultado.Size = new Size(183, 76);
            chklstResultado.TabIndex = 7;
            chklstResultado.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 373);
            Controls.Add(chklstResultado);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(lblTelefono);
            Controls.Add(lblContacto);
            Controls.Add(btnGrabar);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Registrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnGrabar;
        private Label lblContacto;
        private Label lblTelefono;
        private Label label3;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private CheckedListBox chklstResultado;
    }
}
