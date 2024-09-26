namespace domotica
{
    partial class Temperatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            modalOpenTemp = new Button();
            modalCloseTemp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 35);
            label1.Name = "label1";
            label1.Size = new Size(224, 20);
            label1.TabIndex = 0;
            label1.Text = "Temperatura y Humedad DHT11";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 90);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 90);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // modalOpenTemp
            // 
            modalOpenTemp.Location = new Point(276, 215);
            modalOpenTemp.Name = "modalOpenTemp";
            modalOpenTemp.Size = new Size(94, 29);
            modalOpenTemp.TabIndex = 3;
            modalOpenTemp.Text = "aceptar";
            modalOpenTemp.UseVisualStyleBackColor = true;
            modalOpenTemp.Click += button1_Click;
            // 
            // modalCloseTemp
            // 
            modalCloseTemp.Location = new Point(410, 215);
            modalCloseTemp.Name = "modalCloseTemp";
            modalCloseTemp.Size = new Size(94, 29);
            modalCloseTemp.TabIndex = 4;
            modalCloseTemp.Text = "cancelar";
            modalCloseTemp.UseVisualStyleBackColor = true;
            modalCloseTemp.Click += modalCloseTemp_Click;
            // 
            // Temperatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 307);
            Controls.Add(modalCloseTemp);
            Controls.Add(modalOpenTemp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Temperatura";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modal de temperatura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button modalOpenTemp;
        private Button modalCloseTemp;
    }
}