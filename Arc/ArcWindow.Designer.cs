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
            this.FecharArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InstructionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LineCountLabel = new System.Windows.Forms.Label();
            this.LineCountTitleLabel = new System.Windows.Forms.Label();
            this.FilenameTitleLabel = new System.Windows.Forms.Label();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PrefixTitleLabel = new System.Windows.Forms.Label();
            this.RadioButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NoSuffixOption = new System.Windows.Forms.CheckBox();
            this.FourDigitsOption = new System.Windows.Forms.CheckBox();
            this.FiveDigitsOption = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DscOption = new System.Windows.Forms.CheckBox();
            this._DscOption = new System.Windows.Forms.CheckBox();
            this.DscsOption = new System.Windows.Forms.CheckBox();
            this.x768SuffixOption = new System.Windows.Forms.CheckBox();
            this.SuffixTitleLabel = new System.Windows.Forms.Label();
            this.RenameButton = new System.Windows.Forms.Button();
            this.DigitsTitleLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.x683SuffixOption = new System.Windows.Forms.CheckBox();
            this.NoPreffixOption = new System.Windows.Forms.CheckBox();
            this.StatusBar.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.HorizontalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.RadioButtonsPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 452);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1012, 22);
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
            this.MainMenu.Size = new System.Drawing.Size(1012, 24);
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
            this.HorizontalLayout.Size = new System.Drawing.Size(1012, 428);
            this.HorizontalLayout.TabIndex = 5;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowDrop = true;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(497, 422);
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
            this.tableLayoutPanel1.Controls.Add(this.RenameButton, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(506, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.48341F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.00474F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 422);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(497, 72);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // LineCountLabel
            // 
            this.LineCountLabel.AutoSize = true;
            this.LineCountLabel.Location = new System.Drawing.Point(114, 45);
            this.LineCountLabel.Name = "LineCountLabel";
            this.LineCountLabel.Size = new System.Drawing.Size(0, 13);
            this.LineCountLabel.TabIndex = 0;
            // 
            // LineCountTitleLabel
            // 
            this.LineCountTitleLabel.AutoSize = true;
            this.LineCountTitleLabel.Location = new System.Drawing.Point(3, 45);
            this.LineCountTitleLabel.Name = "LineCountTitleLabel";
            this.LineCountTitleLabel.Size = new System.Drawing.Size(93, 13);
            this.LineCountTitleLabel.TabIndex = 2;
            this.LineCountTitleLabel.Text = "Número de Linhas";
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
            // FilenameLabel
            // 
            this.FilenameLabel.AutoSize = true;
            this.FilenameLabel.Location = new System.Drawing.Point(114, 0);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(0, 13);
            this.FilenameLabel.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.PrefixTitleLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.RadioButtonsPanel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.DigitsTitleLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.SuffixTitleLabel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 81);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894737F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.34156F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.761317F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.75309F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.995885F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.97531F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(497, 243);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // PrefixTitleLabel
            // 
            this.PrefixTitleLabel.AutoSize = true;
            this.PrefixTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.PrefixTitleLabel.Name = "PrefixTitleLabel";
            this.PrefixTitleLabel.Size = new System.Drawing.Size(39, 13);
            this.PrefixTitleLabel.TabIndex = 0;
            this.PrefixTitleLabel.Text = "Prefixo";
            // 
            // RadioButtonsPanel
            // 
            this.RadioButtonsPanel.Controls.Add(this.FourDigitsOption);
            this.RadioButtonsPanel.Controls.Add(this.FiveDigitsOption);
            this.RadioButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadioButtonsPanel.Location = new System.Drawing.Point(3, 80);
            this.RadioButtonsPanel.Name = "RadioButtonsPanel";
            this.RadioButtonsPanel.Size = new System.Drawing.Size(491, 41);
            this.RadioButtonsPanel.TabIndex = 1;
            // 
            // NoSuffixOption
            // 
            this.NoSuffixOption.AutoSize = true;
            this.NoSuffixOption.Location = new System.Drawing.Point(3, 3);
            this.NoSuffixOption.Name = "NoSuffixOption";
            this.NoSuffixOption.Size = new System.Drawing.Size(66, 17);
            this.NoSuffixOption.TabIndex = 5;
            this.NoSuffixOption.Text = "Nenhum";
            this.NoSuffixOption.UseVisualStyleBackColor = true;
            // 
            // FourDigitsOption
            // 
            this.FourDigitsOption.AutoSize = true;
            this.FourDigitsOption.Location = new System.Drawing.Point(3, 3);
            this.FourDigitsOption.Name = "FourDigitsOption";
            this.FourDigitsOption.Size = new System.Drawing.Size(69, 17);
            this.FourDigitsOption.TabIndex = 6;
            this.FourDigitsOption.Text = "4 Dígitos";
            this.FourDigitsOption.UseVisualStyleBackColor = true;
            // 
            // FiveDigitsOption
            // 
            this.FiveDigitsOption.AutoSize = true;
            this.FiveDigitsOption.Location = new System.Drawing.Point(78, 3);
            this.FiveDigitsOption.Name = "FiveDigitsOption";
            this.FiveDigitsOption.Size = new System.Drawing.Size(69, 17);
            this.FiveDigitsOption.TabIndex = 7;
            this.FiveDigitsOption.Text = "5 Dígitos";
            this.FiveDigitsOption.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NoPreffixOption);
            this.flowLayoutPanel1.Controls.Add(this.DscOption);
            this.flowLayoutPanel1.Controls.Add(this._DscOption);
            this.flowLayoutPanel1.Controls.Add(this.DscsOption);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(491, 40);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // DscOption
            // 
            this.DscOption.AutoSize = true;
            this.DscOption.Location = new System.Drawing.Point(75, 3);
            this.DscOption.Name = "DscOption";
            this.DscOption.Size = new System.Drawing.Size(48, 17);
            this.DscOption.TabIndex = 0;
            this.DscOption.Text = "DSC";
            this.DscOption.UseVisualStyleBackColor = true;
            // 
            // _DscOption
            // 
            this._DscOption.AutoSize = true;
            this._DscOption.Location = new System.Drawing.Point(129, 3);
            this._DscOption.Name = "_DscOption";
            this._DscOption.Size = new System.Drawing.Size(54, 17);
            this._DscOption.TabIndex = 1;
            this._DscOption.Text = "_DSC";
            this._DscOption.UseVisualStyleBackColor = true;
            // 
            // DscsOption
            // 
            this.DscsOption.AutoSize = true;
            this.DscsOption.Location = new System.Drawing.Point(189, 3);
            this.DscsOption.Name = "DscsOption";
            this.DscsOption.Size = new System.Drawing.Size(55, 17);
            this.DscsOption.TabIndex = 2;
            this.DscsOption.Text = "DSCS";
            this.DscsOption.UseVisualStyleBackColor = true;
            // 
            // x768SuffixOption
            // 
            this.x768SuffixOption.AutoSize = true;
            this.x768SuffixOption.Location = new System.Drawing.Point(75, 3);
            this.x768SuffixOption.Name = "x768SuffixOption";
            this.x768SuffixOption.Size = new System.Drawing.Size(85, 17);
            this.x768SuffixOption.TabIndex = 3;
            this.x768SuffixOption.Text = "_(1024x768)";
            this.x768SuffixOption.UseVisualStyleBackColor = true;
            // 
            // SuffixTitleLabel
            // 
            this.SuffixTitleLabel.AutoSize = true;
            this.SuffixTitleLabel.Location = new System.Drawing.Point(3, 124);
            this.SuffixTitleLabel.Name = "SuffixTitleLabel";
            this.SuffixTitleLabel.Size = new System.Drawing.Size(36, 13);
            this.SuffixTitleLabel.TabIndex = 3;
            this.SuffixTitleLabel.Text = "Sufixo";
            // 
            // RenameButton
            // 
            this.RenameButton.Enabled = false;
            this.RenameButton.Location = new System.Drawing.Point(3, 330);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(75, 23);
            this.RenameButton.TabIndex = 3;
            this.RenameButton.Text = "Renomear";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // DigitsTitleLabel
            // 
            this.DigitsTitleLabel.AutoSize = true;
            this.DigitsTitleLabel.Location = new System.Drawing.Point(3, 64);
            this.DigitsTitleLabel.Name = "DigitsTitleLabel";
            this.DigitsTitleLabel.Size = new System.Drawing.Size(94, 13);
            this.DigitsTitleLabel.TabIndex = 4;
            this.DigitsTitleLabel.Text = "Dígitos Numéricos";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.NoSuffixOption);
            this.flowLayoutPanel2.Controls.Add(this.x768SuffixOption);
            this.flowLayoutPanel2.Controls.Add(this.x683SuffixOption);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 143);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(491, 97);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // x683SuffixOption
            // 
            this.x683SuffixOption.AutoSize = true;
            this.x683SuffixOption.Location = new System.Drawing.Point(166, 3);
            this.x683SuffixOption.Name = "x683SuffixOption";
            this.x683SuffixOption.Size = new System.Drawing.Size(85, 17);
            this.x683SuffixOption.TabIndex = 3;
            this.x683SuffixOption.Text = "_(1024x683)";
            this.x683SuffixOption.UseVisualStyleBackColor = true;
            // 
            // NoPreffixOption
            // 
            this.NoPreffixOption.AutoSize = true;
            this.NoPreffixOption.Location = new System.Drawing.Point(3, 3);
            this.NoPreffixOption.Name = "NoPreffixOption";
            this.NoPreffixOption.Size = new System.Drawing.Size(66, 17);
            this.NoPreffixOption.TabIndex = 2;
            this.NoPreffixOption.Text = "Nenhum";
            this.NoPreffixOption.UseVisualStyleBackColor = true;
            // 
            // ArcWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 474);
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
            this.RadioButtonsPanel.ResumeLayout(false);
            this.RadioButtonsPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
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
        private Label PrefixTitleLabel;
        private FlowLayoutPanel RadioButtonsPanel;
        private Button RenameButton;
        private CheckBox NoSuffixOption;
        private CheckBox FourDigitsOption;
        private CheckBox FiveDigitsOption;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox DscOption;
        private CheckBox _DscOption;
        private CheckBox DscsOption;
        private CheckBox x768SuffixOption;
        private Label SuffixTitleLabel;
        private Label DigitsTitleLabel;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox NoPreffixOption;
        private CheckBox x683SuffixOption;
    }
}

