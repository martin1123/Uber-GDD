﻿namespace UberFrba.Abm_Rol
{
    partial class ABMRolForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.cerrarSesionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.chkListBoxFuncs = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.crearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.volverButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(116, 47);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(194, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(258, 282);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 2;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // cerrarSesionLinkLabel
            // 
            this.cerrarSesionLinkLabel.AutoSize = true;
            this.cerrarSesionLinkLabel.Location = new System.Drawing.Point(284, 8);
            this.cerrarSesionLinkLabel.Name = "cerrarSesionLinkLabel";
            this.cerrarSesionLinkLabel.Size = new System.Drawing.Size(67, 13);
            this.cerrarSesionLinkLabel.TabIndex = 3;
            this.cerrarSesionLinkLabel.TabStop = true;
            this.cerrarSesionLinkLabel.Text = "cerrar sesión";
            this.cerrarSesionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cerrarSesionLinkLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(316, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "*";
            // 
            // chkListBoxFuncs
            // 
            this.chkListBoxFuncs.FormattingEnabled = true;
            this.chkListBoxFuncs.Location = new System.Drawing.Point(30, 107);
            this.chkListBoxFuncs.Name = "chkListBoxFuncs";
            this.chkListBoxFuncs.Size = new System.Drawing.Size(280, 94);
            this.chkListBoxFuncs.TabIndex = 7;
            this.chkListBoxFuncs.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListBoxFuncs_ItemCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Funcionalidades: ";
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(144, 282);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 9;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(120, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(27, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "[*] : campos obligatorios";
            // 
            // crearButton
            // 
            this.crearButton.Location = new System.Drawing.Point(222, 192);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(100, 23);
            this.crearButton.TabIndex = 15;
            this.crearButton.Text = "Crear nuevo";
            this.crearButton.UseVisualStyleBackColor = true;
            this.crearButton.Click += new System.EventHandler(this.crearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crearButton);
            this.groupBox1.Location = new System.Drawing.Point(11, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 236);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo rol";
            // 
            // volverButton
            // 
            this.volverButton.Location = new System.Drawing.Point(29, 282);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(75, 23);
            this.volverButton.TabIndex = 17;
            this.volverButton.Text = "<< Volver";
            this.volverButton.UseVisualStyleBackColor = true;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ABMRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 322);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkListBoxFuncs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cerrarSesionLinkLabel);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ABMRolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Rol";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.LinkLabel cerrarSesionLinkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox chkListBoxFuncs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button crearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}