
namespace CSharp.Capitulo01.Sintaxe
{
    partial class VariaveisForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritmeticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduzidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incrementaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booleanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.logicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ternariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aritmeticasToolStripMenuItem,
            this.reduzidasToolStripMenuItem,
            this.incrementaisToolStripMenuItem,
            this.logicaToolStripMenuItem,
            this.ternariasToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operaçõesToolStripMenuItem.Text = "&Operações";
            // 
            // aritmeticasToolStripMenuItem
            // 
            this.aritmeticasToolStripMenuItem.Name = "aritmeticasToolStripMenuItem";
            this.aritmeticasToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.aritmeticasToolStripMenuItem.Text = "&Aritméticas";
            this.aritmeticasToolStripMenuItem.Click += new System.EventHandler(this.aritméticasToolStripMenuItem_Click);
            // 
            // reduzidasToolStripMenuItem
            // 
            this.reduzidasToolStripMenuItem.Name = "reduzidasToolStripMenuItem";
            this.reduzidasToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.reduzidasToolStripMenuItem.Text = "&Reduzidas";
            this.reduzidasToolStripMenuItem.Click += new System.EventHandler(this.reduzidasToolStripMenuItem_Click);
            // 
            // incrementaisToolStripMenuItem
            // 
            this.incrementaisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booleanasToolStripMenuItem});
            this.incrementaisToolStripMenuItem.Name = "incrementaisToolStripMenuItem";
            this.incrementaisToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.incrementaisToolStripMenuItem.Text = "&Incrementais/Decrementais";
            this.incrementaisToolStripMenuItem.Click += new System.EventHandler(this.incrementaisToolStripMenuItem_Click);
            // 
            // booleanasToolStripMenuItem
            // 
            this.booleanasToolStripMenuItem.Name = "booleanasToolStripMenuItem";
            this.booleanasToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.booleanasToolStripMenuItem.Text = "&Booleanas";
            this.booleanasToolStripMenuItem.Click += new System.EventHandler(this.booleanasToolStripMenuItem_Click);
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.Location = new System.Drawing.Point(0, 24);
            this.resultadoListBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(804, 393);
            this.resultadoListBox.TabIndex = 1;
            this.resultadoListBox.SelectedIndexChanged += new System.EventHandler(this.resultadoListBox_SelectedIndexChanged);
            // 
            // logicaToolStripMenuItem
            // 
            this.logicaToolStripMenuItem.Name = "logicaToolStripMenuItem";
            this.logicaToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.logicaToolStripMenuItem.Text = "&Logica";
            this.logicaToolStripMenuItem.Click += new System.EventHandler(this.logicaToolStripMenuItem_Click);
            // 
            // ternariasToolStripMenuItem
            // 
            this.ternariasToolStripMenuItem.Name = "ternariasToolStripMenuItem";
            this.ternariasToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.ternariasToolStripMenuItem.Text = "&Ternárias";
            this.ternariasToolStripMenuItem.Click += new System.EventHandler(this.ternariasToolStripMenuItem_Click);
            // 
            // VariaveisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 417);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VariaveisForm";
            this.Text = "Variáveis e Operações";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritmeticasToolStripMenuItem;
        private System.Windows.Forms.ListBox resultadoListBox;
        private System.Windows.Forms.ToolStripMenuItem reduzidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incrementaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booleanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ternariasToolStripMenuItem;
    }
}

