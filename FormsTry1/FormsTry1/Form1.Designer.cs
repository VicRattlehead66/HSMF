﻿namespace FormsTry1
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dupeCheckBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFileCmpr = new System.Windows.Forms.TabPage();
            this.browseBtn2 = new System.Windows.Forms.Button();
            this.browseBtn1 = new System.Windows.Forms.Button();
            this.tabTree = new System.Windows.Forms.TabPage();
            this.treeView1 = new Aga.Controls.Tree.TreeViewAdv();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nameColumn = new Aga.Controls.Tree.TreeColumn();
            this.valueColumn = new Aga.Controls.Tree.TreeColumn();
            this.tabControl1.SuspendLayout();
            this.tabFileCmpr.SuspendLayout();
            this.tabTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(63, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 31);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(63, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 31);
            this.textBox2.TabIndex = 1;
            // 
            // dupeCheckBtn
            // 
            this.dupeCheckBtn.BackColor = System.Drawing.Color.DarkGray;
            this.dupeCheckBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dupeCheckBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dupeCheckBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dupeCheckBtn.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dupeCheckBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.dupeCheckBtn.Location = new System.Drawing.Point(3, 174);
            this.dupeCheckBtn.Name = "dupeCheckBtn";
            this.dupeCheckBtn.Size = new System.Drawing.Size(475, 186);
            this.dupeCheckBtn.TabIndex = 2;
            this.dupeCheckBtn.Text = "EQUALITY CHECK";
            this.dupeCheckBtn.UseVisualStyleBackColor = false;
            this.dupeCheckBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "File 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "File 2:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFileCmpr);
            this.tabControl1.Controls.Add(this.tabTree);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(489, 389);
            this.tabControl1.TabIndex = 5;
            // 
            // tabFileCmpr
            // 
            this.tabFileCmpr.Controls.Add(this.browseBtn2);
            this.tabFileCmpr.Controls.Add(this.browseBtn1);
            this.tabFileCmpr.Controls.Add(this.textBox1);
            this.tabFileCmpr.Controls.Add(this.dupeCheckBtn);
            this.tabFileCmpr.Controls.Add(this.label2);
            this.tabFileCmpr.Controls.Add(this.textBox2);
            this.tabFileCmpr.Controls.Add(this.label1);
            this.tabFileCmpr.Location = new System.Drawing.Point(4, 22);
            this.tabFileCmpr.Name = "tabFileCmpr";
            this.tabFileCmpr.Padding = new System.Windows.Forms.Padding(3);
            this.tabFileCmpr.Size = new System.Drawing.Size(481, 363);
            this.tabFileCmpr.TabIndex = 0;
            this.tabFileCmpr.Text = "File Comparison";
            this.tabFileCmpr.UseVisualStyleBackColor = true;
            // 
            // browseBtn2
            // 
            this.browseBtn2.Location = new System.Drawing.Point(394, 42);
            this.browseBtn2.Name = "browseBtn2";
            this.browseBtn2.Size = new System.Drawing.Size(77, 29);
            this.browseBtn2.TabIndex = 6;
            this.browseBtn2.Text = "Browse";
            this.browseBtn2.UseVisualStyleBackColor = true;
            this.browseBtn2.Click += new System.EventHandler(this.button3_Click);
            // 
            // browseBtn1
            // 
            this.browseBtn1.Location = new System.Drawing.Point(394, 7);
            this.browseBtn1.Name = "browseBtn1";
            this.browseBtn1.Size = new System.Drawing.Size(77, 31);
            this.browseBtn1.TabIndex = 5;
            this.browseBtn1.Text = "Browse";
            this.browseBtn1.UseVisualStyleBackColor = true;
            this.browseBtn1.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabTree
            // 
            this.tabTree.Controls.Add(this.treeView1);
            this.tabTree.Location = new System.Drawing.Point(4, 22);
            this.tabTree.Name = "tabTree";
            this.tabTree.Padding = new System.Windows.Forms.Padding(3);
            this.tabTree.Size = new System.Drawing.Size(481, 363);
            this.tabTree.TabIndex = 1;
            this.tabTree.Text = "tabPage2";
            this.tabTree.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Window;
            this.treeView1.Columns.Add(this.nameColumn);
            this.treeView1.Columns.Add(this.valueColumn);
            this.treeView1.DefaultToolTipProvider = null;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.DragDropMarkColor = System.Drawing.Color.Black;
            this.treeView1.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Model = null;
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedNode = null;
            this.treeView1.Size = new System.Drawing.Size(475, 357);
            this.treeView1.TabIndex = 0;
            this.treeView1.UseColumns = true;
            // 
            // nameColumn
            // 
            this.nameColumn.Header = "Name";
            this.nameColumn.Sortable = true;
            this.nameColumn.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.nameColumn.TooltipText = null;
            // 
            // valueColumn
            // 
            this.valueColumn.Header = "Value";
            this.valueColumn.Sortable = true;
            this.valueColumn.SortOrder = System.Windows.Forms.SortOrder.None;
            this.valueColumn.TooltipText = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 389);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabFileCmpr.ResumeLayout(false);
            this.tabFileCmpr.PerformLayout();
            this.tabTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button dupeCheckBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFileCmpr;
        private System.Windows.Forms.Button browseBtn1;
        private System.Windows.Forms.TabPage tabTree;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browseBtn2;
        private Aga.Controls.Tree.TreeViewAdv treeView1;
        private Aga.Controls.Tree.TreeColumn nameColumn;
        private Aga.Controls.Tree.TreeColumn valueColumn;
    }
}

