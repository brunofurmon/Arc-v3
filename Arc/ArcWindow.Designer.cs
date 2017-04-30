using System.Windows.Forms;

namespace Arc
{
    partial class ArcWindow
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
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InstructionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FilenameTitleLabel = new System.Windows.Forms.Label();
            this.LineCountTitleLabel = new System.Windows.Forms.Label();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.LineCountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FecharArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.FilenameFormatTitleLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Dsc4DigitsOptionButton = new System.Windows.Forms.RadioButton();
            this.Dsc5DigitsOptionButton = new System.Windows.Forms.RadioButton();
            this.RegexOptionButton = new System.Windows.Forms.RadioButton();
            this.StatusBar.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.HorizontalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 309);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(907, 22);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(43, 17);
            this.StatusLabel.Text = "Pronto";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(907, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FecharArquivoToolStripMenuItem,
            this.toolStripSeparator1,
            this.SairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InstructionsMenuItem,
            this.AboutMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // InstructionsMenuItem
            // 
            this.InstructionsMenuItem.Name = "InstructionsMenuItem";
            this.InstructionsMenuItem.Size = new System.Drawing.Size(167, 22);
            this.InstructionsMenuItem.Text = "Instruções de Uso";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(167, 22);
            this.AboutMenuItem.Text = "Sobre";
            this.AboutMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
            // 
            // HorizontalLayout
            // 
            this.HorizontalLayout.ColumnCount = 2;
            this.HorizontalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.74933F));
            this.HorizontalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.25067F));
            this.HorizontalLayout.Controls.Add(this.dataGridView, 0, 0);
            this.HorizontalLayout.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.HorizontalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HorizontalLayout.Location = new System.Drawing.Point(0, 24);
            this.HorizontalLayout.Name = "HorizontalLayout";
            this.HorizontalLayout.RowCount = 1;
            this.HorizontalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.HorizontalLayout.Size = new System.Drawing.Size(907, 285);
            this.HorizontalLayout.TabIndex = 5;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowDrop = true;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(445, 279);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(454, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.14695F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 279);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FilenameTitleLabel
            // 
            this.FilenameTitleLabel.AutoSize = true;
            this.FilenameTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.FilenameTitleLabel.Name = "FilenameTitleLabel";
            this.FilenameTitleLabel.Size = new System.Drawing.Size(46, 13);
            this.FilenameTitleLabel.TabIndex = 0;
            this.FilenameTitleLabel.Text = "Arquivo:";
            // 
            // LineCountTitleLabel
            // 
            this.LineCountTitleLabel.AutoSize = true;
            this.LineCountTitleLabel.Location = new System.Drawing.Point(3, 36);
            this.LineCountTitleLabel.Name = "LineCountTitleLabel";
            this.LineCountTitleLabel.Size = new System.Drawing.Size(93, 13);
            this.LineCountTitleLabel.TabIndex = 2;
            this.LineCountTitleLabel.Text = "Número de Linhas";
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.AutoSize = true;
            this.FilenameLabel.Location = new System.Drawing.Point(102, 0);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(0, 13);
            this.FilenameLabel.TabIndex = 1;
            // 
            // LineCountLabel
            // 
            this.LineCountLabel.AutoSize = true;
            this.LineCountLabel.Location = new System.Drawing.Point(102, 36);
            this.LineCountLabel.Name = "LineCountLabel";
            this.LineCountLabel.Size = new System.Drawing.Size(0, 13);
            this.LineCountLabel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.52252F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.47748F));
            this.tableLayoutPanel2.Controls.Add(this.LineCountLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.LineCountTitleLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.FilenameTitleLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.FilenameLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.92453F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.07547F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(444, 53);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // FecharArquivoToolStripMenuItem
            // 
            this.FecharArquivoToolStripMenuItem.Name = "FecharArquivoToolStripMenuItem";
            this.FecharArquivoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.FecharArquivoToolStripMenuItem.Text = "Fechar Arquivo";
            this.FecharArquivoToolStripMenuItem.Click += new System.EventHandler(this.FecharArquivoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.FilenameFormatTitleLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 62);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(444, 120);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // FilenameFormatTitleLabel
            // 
            this.FilenameFormatTitleLabel.AutoSize = true;
            this.FilenameFormatTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.FilenameFormatTitleLabel.Name = "FilenameFormatTitleLabel";
            this.FilenameFormatTitleLabel.Size = new System.Drawing.Size(48, 13);
            this.FilenameFormatTitleLabel.TabIndex = 0;
            this.FilenameFormatTitleLabel.Text = "Formato:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Dsc4DigitsOptionButton);
            this.flowLayoutPanel1.Controls.Add(this.Dsc5DigitsOptionButton);
            this.flowLayoutPanel1.Controls.Add(this.RegexOptionButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(438, 38);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Dsc4DigitsOptionButton
            // 
            this.Dsc4DigitsOptionButton.AutoSize = true;
            this.Dsc4DigitsOptionButton.Location = new System.Drawing.Point(3, 3);
            this.Dsc4DigitsOptionButton.Name = "Dsc4DigitsOptionButton";
            this.Dsc4DigitsOptionButton.Size = new System.Drawing.Size(75, 17);
            this.Dsc4DigitsOptionButton.TabIndex = 0;
            this.Dsc4DigitsOptionButton.TabStop = true;
            this.Dsc4DigitsOptionButton.Text = "DSCXXXX";
            this.Dsc4DigitsOptionButton.UseVisualStyleBackColor = true;
            // 
            // Dsc5DigitsOptionButton
            // 
            this.Dsc5DigitsOptionButton.AutoSize = true;
            this.Dsc5DigitsOptionButton.Checked = true;
            this.Dsc5DigitsOptionButton.Location = new System.Drawing.Point(84, 3);
            this.Dsc5DigitsOptionButton.Name = "Dsc5DigitsOptionButton";
            this.Dsc5DigitsOptionButton.Size = new System.Drawing.Size(82, 17);
            this.Dsc5DigitsOptionButton.TabIndex = 1;
            this.Dsc5DigitsOptionButton.TabStop = true;
            this.Dsc5DigitsOptionButton.Text = "DSCXXXXX";
            this.Dsc5DigitsOptionButton.UseVisualStyleBackColor = true;
            // 
            // RegexOptionButton
            // 
            this.RegexOptionButton.AutoSize = true;
            this.RegexOptionButton.Enabled = false;
            this.RegexOptionButton.Location = new System.Drawing.Point(172, 3);
            this.RegexOptionButton.Name = "RegexOptionButton";
            this.RegexOptionButton.Size = new System.Drawing.Size(85, 17);
            this.RegexOptionButton.TabIndex = 2;
            this.RegexOptionButton.Text = "Customizado";
            this.RegexOptionButton.UseVisualStyleBackColor = true;
            // 
            // ArcWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 331);
            this.Controls.Add(this.HorizontalLayout);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "ArcWindow";
            this.Text = "Arc v3";
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.HorizontalLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InstructionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.TableLayoutPanel HorizontalLayout;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label FilenameTitleLabel;
        private Label FilenameLabel;
        private Label LineCountTitleLabel;
        private Label LineCountLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private ToolStripMenuItem FecharArquivoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label FilenameFormatTitleLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton Dsc4DigitsOptionButton;
        private RadioButton Dsc5DigitsOptionButton;
        private RadioButton RegexOptionButton;
    }
}

