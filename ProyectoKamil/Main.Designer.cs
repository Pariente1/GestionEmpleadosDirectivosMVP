﻿namespace ProyectoKamil
{
    partial class Main
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            addWorker = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            conexionesToolStripMenuItem = new ToolStripMenuItem();
            conectarABaseDeDatosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            UpdateButton = new Button();
            DeleteButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(222, 51);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 1;
            label1.Text = "Menú de opciones de Kamil";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(addWorker);
            groupBox1.Location = new Point(11, 95);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(184, 212);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empleados";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(51, 53);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(81, 22);
            button2.TabIndex = 1;
            button2.Text = "Ver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += frmViewEmployees_Click;
            // 
            // addWorker
            // 
            addWorker.Location = new Point(51, 29);
            addWorker.Margin = new Padding(2, 1, 2, 1);
            addWorker.Name = "addWorker";
            addWorker.Size = new Size(81, 22);
            addWorker.TabIndex = 0;
            addWorker.Text = "Agregar ";
            addWorker.UseVisualStyleBackColor = true;
            addWorker.Click += btnAddWorker;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(214, 95);
            groupBox2.Margin = new Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 1, 2, 1);
            groupBox2.Size = new Size(193, 212);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Directores";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button4
            // 
            button4.Location = new Point(48, 53);
            button4.Margin = new Padding(2, 1, 2, 1);
            button4.Name = "button4";
            button4.Size = new Size(81, 22);
            button4.TabIndex = 1;
            button4.Text = "Ver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += frmViewDirectors_Click;
            // 
            // button3
            // 
            button3.Location = new Point(48, 29);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(81, 22);
            button3.TabIndex = 0;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += frmAddDirectors_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DeleteButton);
            groupBox3.Controls.Add(UpdateButton);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button5);
            groupBox3.Location = new Point(425, 95);
            groupBox3.Margin = new Padding(2, 1, 2, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 1, 2, 1);
            groupBox3.Size = new Size(193, 212);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Centros";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // button6
            // 
            button6.Location = new Point(50, 53);
            button6.Margin = new Padding(2, 1, 2, 1);
            button6.Name = "button6";
            button6.Size = new Size(81, 22);
            button6.TabIndex = 1;
            button6.Text = "Ver";
            button6.UseVisualStyleBackColor = true;
            button6.Click += frmViewWorkCenter_Click;
            // 
            // button5
            // 
            button5.Location = new Point(50, 29);
            button5.Margin = new Padding(2, 1, 2, 1);
            button5.Name = "button5";
            button5.Size = new Size(81, 22);
            button5.TabIndex = 0;
            button5.Text = "Agregar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += frmAddWorkCenter_Click;
            // 
            // conexionesToolStripMenuItem
            // 
            conexionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conectarABaseDeDatosToolStripMenuItem });
            conexionesToolStripMenuItem.Name = "conexionesToolStripMenuItem";
            conexionesToolStripMenuItem.Size = new Size(80, 22);
            conexionesToolStripMenuItem.Text = "Conexiones";
            // 
            // conectarABaseDeDatosToolStripMenuItem
            // 
            conectarABaseDeDatosToolStripMenuItem.Name = "conectarABaseDeDatosToolStripMenuItem";
            conectarABaseDeDatosToolStripMenuItem.Size = new Size(207, 22);
            conectarABaseDeDatosToolStripMenuItem.Text = "Conectar a Base de Datos";
            conectarABaseDeDatosToolStripMenuItem.Click += conectarABaseDeDatosToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { conexionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(632, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(50, 78);
            UpdateButton.Margin = new Padding(2, 1, 2, 1);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(81, 22);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "Modificar";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(50, 102);
            DeleteButton.Margin = new Padding(2, 1, 2, 1);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(81, 22);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Eliminar";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 342);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Main";
            Text = "Proyecto Kamil";
            Load += Main_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button2;
        private Button addWorker;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button button5;
        private ToolStripMenuItem conexionesToolStripMenuItem;
        private ToolStripMenuItem conectarABaseDeDatosToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button UpdateButton;
        private Button DeleteButton;
    }
}
