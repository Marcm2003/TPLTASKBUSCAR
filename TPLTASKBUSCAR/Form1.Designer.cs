﻿using System;
using System.Windows.Forms;

namespace TPLTASKBUSCAR
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.chkLast = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkCountry = new System.Windows.Forms.CheckBox();
            this.chkIP = new System.Windows.Forms.CheckBox();
            this.chkid = new System.Windows.Forms.CheckBox();
            this.chkFirst = new System.Windows.Forms.CheckBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkLast
            // 
            this.chkLast.AutoSize = true;
            this.chkLast.Location = new System.Drawing.Point(182, 38);
            this.chkLast.Name = "chkLast";
            this.chkLast.Size = new System.Drawing.Size(77, 17);
            this.chkLast.TabIndex = 0;
            this.chkLast.Text = "Last Name";
            this.chkLast.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(265, 38);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(51, 17);
            this.chkEmail.TabIndex = 1;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkCountry
            // 
            this.chkCountry.AutoSize = true;
            this.chkCountry.Location = new System.Drawing.Point(322, 38);
            this.chkCountry.Name = "chkCountry";
            this.chkCountry.Size = new System.Drawing.Size(62, 17);
            this.chkCountry.TabIndex = 2;
            this.chkCountry.Text = "Country";
            this.chkCountry.UseVisualStyleBackColor = true;
            // 
            // chkIP
            // 
            this.chkIP.AutoSize = true;
            this.chkIP.Location = new System.Drawing.Point(390, 38);
            this.chkIP.Name = "chkIP";
            this.chkIP.Size = new System.Drawing.Size(36, 17);
            this.chkIP.TabIndex = 3;
            this.chkIP.Text = "IP";
            this.chkIP.UseVisualStyleBackColor = true;
            // 
            // chkid
            // 
            this.chkid.AutoSize = true;
            this.chkid.Location = new System.Drawing.Point(57, 38);
            this.chkid.Name = "chkid";
            this.chkid.Size = new System.Drawing.Size(37, 17);
            this.chkid.TabIndex = 4;
            this.chkid.Text = "ID";
            this.chkid.UseVisualStyleBackColor = true;
            // 
            // chkFirst
            // 
            this.chkFirst.AutoSize = true;
            this.chkFirst.Location = new System.Drawing.Point(100, 38);
            this.chkFirst.Name = "chkFirst";
            this.chkFirst.Size = new System.Drawing.Size(76, 17);
            this.chkFirst.TabIndex = 5;
            this.chkFirst.Text = "First Name";
            this.chkFirst.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(12, 12);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(369, 20);
            this.txtbuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(388, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 61);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(447, 188);
            this.txtResult.TabIndex = 8;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 254);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(215, 20);
            this.textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 280);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.chkFirst);
            this.Controls.Add(this.chkid);
            this.Controls.Add(this.chkIP);
            this.Controls.Add(this.chkCountry);
            this.Controls.Add(this.chkEmail);
            this.Controls.Add(this.chkLast);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLast;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkCountry;
        private System.Windows.Forms.CheckBox chkIP;
        private System.Windows.Forms.CheckBox chkid;
        private System.Windows.Forms.CheckBox chkFirst;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

