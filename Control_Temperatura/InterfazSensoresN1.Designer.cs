﻿namespace Control_Temperatura
{
    partial class InterfazSensoresN1
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
            this.components = new System.ComponentModel.Container();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.lblTemperatura1 = new System.Windows.Forms.Label();
            this.lblTemperatura2 = new System.Windows.Forms.Label();
            this.lblTemperatura3 = new System.Windows.Forms.Label();
            this.lblTemperatura4 = new System.Windows.Forms.Label();
            this.txtFoco1 = new System.Windows.Forms.TextBox();
            this.txtFoco2 = new System.Windows.Forms.TextBox();
            this.txtFoco3 = new System.Windows.Forms.TextBox();
            this.txtFoco4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtReloj = new System.Windows.Forms.TextBox();
            this.btnActivar1 = new System.Windows.Forms.Button();
            this.btnDesactivar1 = new System.Windows.Forms.Button();
            this.btnDesactivar2 = new System.Windows.Forms.Button();
            this.btnActivar2 = new System.Windows.Forms.Button();
            this.btnDesactivar3 = new System.Windows.Forms.Button();
            this.btnActivar3 = new System.Windows.Forms.Button();
            this.btnDesactivar4 = new System.Windows.Forms.Button();
            this.btnActivar4 = new System.Windows.Forms.Button();
            this.timerSensor1 = new System.Windows.Forms.Timer(this.components);
            this.timerSensor2 = new System.Windows.Forms.Timer(this.components);
            this.timerSensor3 = new System.Windows.Forms.Timer(this.components);
            this.timerSensor4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerReloj
            // 
            this.timerReloj.Enabled = true;
            this.timerReloj.Interval = 1000;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // lblTemperatura1
            // 
            this.lblTemperatura1.AutoSize = true;
            this.lblTemperatura1.Location = new System.Drawing.Point(75, 298);
            this.lblTemperatura1.Name = "lblTemperatura1";
            this.lblTemperatura1.Size = new System.Drawing.Size(20, 25);
            this.lblTemperatura1.TabIndex = 4;
            this.lblTemperatura1.Text = "°";
            // 
            // lblTemperatura2
            // 
            this.lblTemperatura2.AutoSize = true;
            this.lblTemperatura2.Location = new System.Drawing.Point(238, 298);
            this.lblTemperatura2.Name = "lblTemperatura2";
            this.lblTemperatura2.Size = new System.Drawing.Size(20, 25);
            this.lblTemperatura2.TabIndex = 5;
            this.lblTemperatura2.Text = "°";
            // 
            // lblTemperatura3
            // 
            this.lblTemperatura3.AutoSize = true;
            this.lblTemperatura3.Location = new System.Drawing.Point(392, 298);
            this.lblTemperatura3.Name = "lblTemperatura3";
            this.lblTemperatura3.Size = new System.Drawing.Size(20, 25);
            this.lblTemperatura3.TabIndex = 6;
            this.lblTemperatura3.Text = "°";
            // 
            // lblTemperatura4
            // 
            this.lblTemperatura4.AutoSize = true;
            this.lblTemperatura4.Location = new System.Drawing.Point(562, 298);
            this.lblTemperatura4.Name = "lblTemperatura4";
            this.lblTemperatura4.Size = new System.Drawing.Size(20, 25);
            this.lblTemperatura4.TabIndex = 7;
            this.lblTemperatura4.Text = "°";
            // 
            // txtFoco1
            // 
            this.txtFoco1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFoco1.Location = new System.Drawing.Point(49, 170);
            this.txtFoco1.Multiline = true;
            this.txtFoco1.Name = "txtFoco1";
            this.txtFoco1.ReadOnly = true;
            this.txtFoco1.Size = new System.Drawing.Size(70, 67);
            this.txtFoco1.TabIndex = 8;
            // 
            // txtFoco2
            // 
            this.txtFoco2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFoco2.Location = new System.Drawing.Point(211, 170);
            this.txtFoco2.Multiline = true;
            this.txtFoco2.Name = "txtFoco2";
            this.txtFoco2.ReadOnly = true;
            this.txtFoco2.Size = new System.Drawing.Size(70, 67);
            this.txtFoco2.TabIndex = 9;
            // 
            // txtFoco3
            // 
            this.txtFoco3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFoco3.Location = new System.Drawing.Point(371, 170);
            this.txtFoco3.Multiline = true;
            this.txtFoco3.Name = "txtFoco3";
            this.txtFoco3.ReadOnly = true;
            this.txtFoco3.Size = new System.Drawing.Size(70, 67);
            this.txtFoco3.TabIndex = 10;
            // 
            // txtFoco4
            // 
            this.txtFoco4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFoco4.Location = new System.Drawing.Point(536, 170);
            this.txtFoco4.Multiline = true;
            this.txtFoco4.Name = "txtFoco4";
            this.txtFoco4.ReadOnly = true;
            this.txtFoco4.Size = new System.Drawing.Size(70, 67);
            this.txtFoco4.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(718, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(445, 463);
            this.dataGridView1.TabIndex = 12;
            // 
            // txtReloj
            // 
            this.txtReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReloj.Location = new System.Drawing.Point(17, 9);
            this.txtReloj.Multiline = true;
            this.txtReloj.Name = "txtReloj";
            this.txtReloj.ReadOnly = true;
            this.txtReloj.Size = new System.Drawing.Size(160, 59);
            this.txtReloj.TabIndex = 13;
            this.txtReloj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnActivar1
            // 
            this.btnActivar1.Location = new System.Drawing.Point(49, 356);
            this.btnActivar1.Name = "btnActivar1";
            this.btnActivar1.Size = new System.Drawing.Size(82, 37);
            this.btnActivar1.TabIndex = 14;
            this.btnActivar1.Text = "Activar";
            this.btnActivar1.UseVisualStyleBackColor = true;
            this.btnActivar1.Click += new System.EventHandler(this.btnActivar1_Click);
            // 
            // btnDesactivar1
            // 
            this.btnDesactivar1.Location = new System.Drawing.Point(37, 411);
            this.btnDesactivar1.Name = "btnDesactivar1";
            this.btnDesactivar1.Size = new System.Drawing.Size(113, 37);
            this.btnDesactivar1.TabIndex = 18;
            this.btnDesactivar1.Text = "Desactivar";
            this.btnDesactivar1.UseVisualStyleBackColor = true;
            this.btnDesactivar1.Click += new System.EventHandler(this.btnDesactivar1_Click);
            // 
            // btnDesactivar2
            // 
            this.btnDesactivar2.Location = new System.Drawing.Point(199, 411);
            this.btnDesactivar2.Name = "btnDesactivar2";
            this.btnDesactivar2.Size = new System.Drawing.Size(113, 37);
            this.btnDesactivar2.TabIndex = 20;
            this.btnDesactivar2.Text = "Desactivar";
            this.btnDesactivar2.UseVisualStyleBackColor = true;
            this.btnDesactivar2.Click += new System.EventHandler(this.btnDesactivar2_Click);
            // 
            // btnActivar2
            // 
            this.btnActivar2.Location = new System.Drawing.Point(211, 356);
            this.btnActivar2.Name = "btnActivar2";
            this.btnActivar2.Size = new System.Drawing.Size(82, 37);
            this.btnActivar2.TabIndex = 19;
            this.btnActivar2.Text = "Activar";
            this.btnActivar2.UseVisualStyleBackColor = true;
            this.btnActivar2.Click += new System.EventHandler(this.btnActivar2_Click);
            // 
            // btnDesactivar3
            // 
            this.btnDesactivar3.Location = new System.Drawing.Point(362, 411);
            this.btnDesactivar3.Name = "btnDesactivar3";
            this.btnDesactivar3.Size = new System.Drawing.Size(113, 37);
            this.btnDesactivar3.TabIndex = 22;
            this.btnDesactivar3.Text = "Desactivar";
            this.btnDesactivar3.UseVisualStyleBackColor = true;
            this.btnDesactivar3.Click += new System.EventHandler(this.btnDesactivar3_Click);
            // 
            // btnActivar3
            // 
            this.btnActivar3.Location = new System.Drawing.Point(371, 356);
            this.btnActivar3.Name = "btnActivar3";
            this.btnActivar3.Size = new System.Drawing.Size(82, 37);
            this.btnActivar3.TabIndex = 21;
            this.btnActivar3.Text = "Activar";
            this.btnActivar3.UseVisualStyleBackColor = true;
            this.btnActivar3.Click += new System.EventHandler(this.btnActivar3_Click);
            // 
            // btnDesactivar4
            // 
            this.btnDesactivar4.Location = new System.Drawing.Point(523, 411);
            this.btnDesactivar4.Name = "btnDesactivar4";
            this.btnDesactivar4.Size = new System.Drawing.Size(113, 37);
            this.btnDesactivar4.TabIndex = 24;
            this.btnDesactivar4.Text = "Desactivar";
            this.btnDesactivar4.UseVisualStyleBackColor = true;
            this.btnDesactivar4.Click += new System.EventHandler(this.btnDesactivar4_Click);
            // 
            // btnActivar4
            // 
            this.btnActivar4.Location = new System.Drawing.Point(536, 356);
            this.btnActivar4.Name = "btnActivar4";
            this.btnActivar4.Size = new System.Drawing.Size(82, 37);
            this.btnActivar4.TabIndex = 23;
            this.btnActivar4.Text = "Activar";
            this.btnActivar4.UseVisualStyleBackColor = true;
            this.btnActivar4.Click += new System.EventHandler(this.btnActivar4_Click);
            // 
            // timerSensor1
            // 
            this.timerSensor1.Interval = 1000;
            this.timerSensor1.Tick += new System.EventHandler(this.timerSensor1_Tick);
            // 
            // timerSensor2
            // 
            this.timerSensor2.Interval = 1000;
            this.timerSensor2.Tick += new System.EventHandler(this.timerSensor2_Tick);
            // 
            // timerSensor3
            // 
            this.timerSensor3.Interval = 1000;
            this.timerSensor3.Tick += new System.EventHandler(this.timerSensor3_Tick);
            // 
            // timerSensor4
            // 
            this.timerSensor4.Interval = 1000;
            this.timerSensor4.Tick += new System.EventHandler(this.timerSensor4_Tick);
            // 
            // InterfazSensoresN1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 508);
            this.Controls.Add(this.btnDesactivar4);
            this.Controls.Add(this.btnActivar4);
            this.Controls.Add(this.btnDesactivar3);
            this.Controls.Add(this.btnActivar3);
            this.Controls.Add(this.btnDesactivar2);
            this.Controls.Add(this.btnActivar2);
            this.Controls.Add(this.btnDesactivar1);
            this.Controls.Add(this.btnActivar1);
            this.Controls.Add(this.txtReloj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFoco4);
            this.Controls.Add(this.txtFoco3);
            this.Controls.Add(this.txtFoco2);
            this.Controls.Add(this.txtFoco1);
            this.Controls.Add(this.lblTemperatura4);
            this.Controls.Add(this.lblTemperatura3);
            this.Controls.Add(this.lblTemperatura2);
            this.Controls.Add(this.lblTemperatura1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InterfazSensoresN1";
            this.Text = "InterfazSensores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.Label lblTemperatura1;
        private System.Windows.Forms.Label lblTemperatura2;
        private System.Windows.Forms.Label lblTemperatura3;
        private System.Windows.Forms.Label lblTemperatura4;
        private System.Windows.Forms.TextBox txtFoco1;
        private System.Windows.Forms.TextBox txtFoco2;
        private System.Windows.Forms.TextBox txtFoco3;
        private System.Windows.Forms.TextBox txtFoco4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtReloj;
        private System.Windows.Forms.Button btnActivar1;
        private System.Windows.Forms.Button btnDesactivar1;
        private System.Windows.Forms.Button btnDesactivar2;
        private System.Windows.Forms.Button btnActivar2;
        private System.Windows.Forms.Button btnDesactivar3;
        private System.Windows.Forms.Button btnActivar3;
        private System.Windows.Forms.Button btnDesactivar4;
        private System.Windows.Forms.Button btnActivar4;
        private System.Windows.Forms.Timer timerSensor1;
        private System.Windows.Forms.Timer timerSensor2;
        private System.Windows.Forms.Timer timerSensor3;
        private System.Windows.Forms.Timer timerSensor4;
    }
}