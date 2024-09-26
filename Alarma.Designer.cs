namespace domotica
{
    partial class Alarma
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
            btnAcceptAlarmaModal = new Button();
            btnCloseAlarmaModal = new Button();
            txtPassword = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAcceptAlarmaModal
            // 
            btnAcceptAlarmaModal.Location = new Point(272, 254);
            btnAcceptAlarmaModal.Name = "btnAcceptAlarmaModal";
            btnAcceptAlarmaModal.Size = new Size(94, 29);
            btnAcceptAlarmaModal.TabIndex = 0;
            btnAcceptAlarmaModal.Text = "Aceptar";
            btnAcceptAlarmaModal.UseVisualStyleBackColor = true;
            btnAcceptAlarmaModal.Click += btnAcceptAlarmaModal_Click;
            // 
            // btnCloseAlarmaModal
            // 
            btnCloseAlarmaModal.Location = new Point(407, 254);
            btnCloseAlarmaModal.Name = "btnCloseAlarmaModal";
            btnCloseAlarmaModal.Size = new Size(94, 29);
            btnCloseAlarmaModal.TabIndex = 1;
            btnCloseAlarmaModal.Text = "Cancelar";
            btnCloseAlarmaModal.UseVisualStyleBackColor = true;
            btnCloseAlarmaModal.Click += btnCloseAlarmaModal_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(61, 124);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(149, 27);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 84);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese la contraseña";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Location = new Point(114, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 181);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Activar/desactivar alarma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 43);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 4;
            label2.Text = "Estado actual de la alarma: ";
            label2.Click += label2_Click;
            // 
            // Alarma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 307);
            Controls.Add(groupBox1);
            Controls.Add(btnCloseAlarmaModal);
            Controls.Add(btnAcceptAlarmaModal);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Alarma";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alarma";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAcceptAlarmaModal;
        private Button btnCloseAlarmaModal;
        private TextBox txtPassword;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
    }
}