namespace domotica
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
            btnOpenDoor = new Button();
            btnCloseDoor = new Button();
            btnCloseWindow = new Button();
            btnOpenWindow = new Button();
            btnModalTemp = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox3 = new GroupBox();
            btnOpenAlarmModal = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenDoor
            // 
            btnOpenDoor.Location = new Point(21, 55);
            btnOpenDoor.Name = "btnOpenDoor";
            btnOpenDoor.Size = new Size(107, 34);
            btnOpenDoor.TabIndex = 0;
            btnOpenDoor.Text = "abrir puerta";
            btnOpenDoor.UseVisualStyleBackColor = true;
            btnOpenDoor.Click += button1_Click;
            // 
            // btnCloseDoor
            // 
            btnCloseDoor.Location = new Point(155, 55);
            btnCloseDoor.Name = "btnCloseDoor";
            btnCloseDoor.Size = new Size(125, 34);
            btnCloseDoor.TabIndex = 1;
            btnCloseDoor.Text = "cerrar puerta";
            btnCloseDoor.UseVisualStyleBackColor = true;
            btnCloseDoor.Click += btnCloseDoor_Click;
            // 
            // btnCloseWindow
            // 
            btnCloseWindow.Location = new Point(166, 55);
            btnCloseWindow.Name = "btnCloseWindow";
            btnCloseWindow.Size = new Size(125, 34);
            btnCloseWindow.TabIndex = 3;
            btnCloseWindow.Text = "cerrar ventana";
            btnCloseWindow.UseVisualStyleBackColor = true;
            btnCloseWindow.Click += btnCloseWindow_Click;
            // 
            // btnOpenWindow
            // 
            btnOpenWindow.Location = new Point(26, 55);
            btnOpenWindow.Name = "btnOpenWindow";
            btnOpenWindow.Size = new Size(107, 34);
            btnOpenWindow.TabIndex = 2;
            btnOpenWindow.Text = "abrir ventana";
            btnOpenWindow.UseVisualStyleBackColor = true;
            btnOpenWindow.Click += btnOpenWindow_Click;
            // 
            // btnModalTemp
            // 
            btnModalTemp.Location = new Point(555, 256);
            btnModalTemp.Name = "btnModalTemp";
            btnModalTemp.Size = new Size(234, 29);
            btnModalTemp.TabIndex = 4;
            btnModalTemp.Text = "Ver temperatura y humedad";
            btnModalTemp.UseVisualStyleBackColor = true;
            btnModalTemp.Click += button1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOpenDoor);
            groupBox1.Controls.Add(btnCloseDoor);
            groupBox1.Location = new Point(65, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 125);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control de puerta";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOpenWindow);
            groupBox2.Controls.Add(btnCloseWindow);
            groupBox2.Location = new Point(498, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 125);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control de ventana";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnOpenAlarmModal);
            groupBox3.Location = new Point(95, 208);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Alarma";
            // 
            // btnOpenAlarmModal
            // 
            btnOpenAlarmModal.Location = new Point(62, 58);
            btnOpenAlarmModal.Name = "btnOpenAlarmModal";
            btnOpenAlarmModal.Size = new Size(94, 29);
            btnOpenAlarmModal.TabIndex = 8;
            btnOpenAlarmModal.Text = "Activar alarma";
            btnOpenAlarmModal.UseVisualStyleBackColor = true;
            btnOpenAlarmModal.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 560);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnModalTemp);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenDoor;
        private Button btnCloseDoor;
        private Button btnCloseWindow;
        private Button btnOpenWindow;
        private Button btnModalTemp;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox3;
        private Button btnOpenAlarmModal;
    }
}
