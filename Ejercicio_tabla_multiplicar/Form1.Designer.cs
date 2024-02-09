namespace Ejercicio_tabla_multiplicar
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
            txt_Numero = new TextBox();
            lst_Multiplicar = new ListBox();
            label1 = new Label();
            btn_Mostrar = new Button();
            btn_Salir = new Button();
            btn_Limpiar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txt_Numero
            // 
            txt_Numero.Location = new Point(456, 140);
            txt_Numero.Name = "txt_Numero";
            txt_Numero.Size = new Size(170, 27);
            txt_Numero.TabIndex = 0;
            // 
            // lst_Multiplicar
            // 
            lst_Multiplicar.FormattingEnabled = true;
            lst_Multiplicar.ItemHeight = 20;
            lst_Multiplicar.Location = new Point(146, 140);
            lst_Multiplicar.Name = "lst_Multiplicar";
            lst_Multiplicar.Size = new Size(274, 164);
            lst_Multiplicar.TabIndex = 1;
            lst_Multiplicar.SelectedIndexChanged += btn_Mostrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(262, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 38);
            label1.TabIndex = 2;
            label1.Text = "Tablas de Multiplicar";
            // 
            // btn_Mostrar
            // 
            btn_Mostrar.Location = new Point(656, 178);
            btn_Mostrar.Name = "btn_Mostrar";
            btn_Mostrar.Size = new Size(94, 29);
            btn_Mostrar.TabIndex = 3;
            btn_Mostrar.Text = "Mostrar";
            btn_Mostrar.UseVisualStyleBackColor = true;
            btn_Mostrar.Click += btn_Mostrar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(656, 309);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(94, 29);
            btn_Salir.TabIndex = 4;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Location = new Point(656, 243);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(94, 29);
            btn_Limpiar.TabIndex = 5;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 140);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 6;
            label2.Text = "Multiplicar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Mostrar);
            Controls.Add(label1);
            Controls.Add(lst_Multiplicar);
            Controls.Add(txt_Numero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Numero;
        private ListBox lst_Multiplicar;
        private Label label1;
        private Button btn_Mostrar;
        private Button btn_Salir;
        private Button btn_Limpiar;
        private Label label2;
    }
}