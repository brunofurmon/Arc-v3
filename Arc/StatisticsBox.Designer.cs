namespace Arc
{
    partial class StatisticsBox
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StatisticsTitleLabel = new System.Windows.Forms.Label();
            this.SuccessTitleLabel = new System.Windows.Forms.Label();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.FailureTitleLabel = new System.Windows.Forms.Label();
            this.FailureLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ErrorTitleLabel = new System.Windows.Forms.Label();
            this.errorTable = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.StatisticsTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 238);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.36228F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.63772F));
            this.tableLayoutPanel2.Controls.Add(this.SuccessTitleLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SuccessLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.FailureTitleLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.FailureLabel, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(737, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // StatisticsTitleLabel
            // 
            this.StatisticsTitleLabel.AutoSize = true;
            this.StatisticsTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.StatisticsTitleLabel.Name = "StatisticsTitleLabel";
            this.StatisticsTitleLabel.Size = new System.Drawing.Size(63, 13);
            this.StatisticsTitleLabel.TabIndex = 1;
            this.StatisticsTitleLabel.Text = "Resultados:";
            // 
            // SuccessTitleLabel
            // 
            this.SuccessTitleLabel.AutoSize = true;
            this.SuccessTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.SuccessTitleLabel.Name = "SuccessTitleLabel";
            this.SuccessTitleLabel.Size = new System.Drawing.Size(56, 13);
            this.SuccessTitleLabel.TabIndex = 0;
            this.SuccessTitleLabel.Text = "Sucessos:";
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.Location = new System.Drawing.Point(72, 0);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(0, 13);
            this.SuccessLabel.TabIndex = 1;
            // 
            // FailureTitleLabel
            // 
            this.FailureTitleLabel.AutoSize = true;
            this.FailureTitleLabel.Location = new System.Drawing.Point(3, 22);
            this.FailureTitleLabel.Name = "FailureTitleLabel";
            this.FailureTitleLabel.Size = new System.Drawing.Size(41, 13);
            this.FailureTitleLabel.TabIndex = 2;
            this.FailureTitleLabel.Text = "Falhas:";
            // 
            // FailureLabel
            // 
            this.FailureLabel.AutoSize = true;
            this.FailureLabel.Location = new System.Drawing.Point(72, 22);
            this.FailureLabel.Name = "FailureLabel";
            this.FailureLabel.Size = new System.Drawing.Size(0, 13);
            this.FailureLabel.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.ErrorTitleLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.errorTable, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.94872F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.05128F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(737, 132);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // ErrorTitleLabel
            // 
            this.ErrorTitleLabel.AutoSize = true;
            this.ErrorTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.ErrorTitleLabel.Name = "ErrorTitleLabel";
            this.ErrorTitleLabel.Size = new System.Drawing.Size(34, 13);
            this.ErrorTitleLabel.TabIndex = 0;
            this.ErrorTitleLabel.Text = "Erros:";
            // 
            // errorTable
            // 
            this.errorTable.AllowUserToAddRows = false;
            this.errorTable.AllowUserToDeleteRows = false;
            this.errorTable.AllowUserToOrderColumns = true;
            this.errorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.errorTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorTable.Location = new System.Drawing.Point(3, 26);
            this.errorTable.Name = "errorTable";
            this.errorTable.ReadOnly = true;
            this.errorTable.Size = new System.Drawing.Size(731, 103);
            this.errorTable.TabIndex = 1;
            // 
            // StatisticsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 238);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StatisticsBox";
            this.Text = "Estatísticas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label SuccessTitleLabel;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Label FailureTitleLabel;
        private System.Windows.Forms.Label FailureLabel;
        private System.Windows.Forms.Label StatisticsTitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label ErrorTitleLabel;
        private System.Windows.Forms.DataGridView errorTable;
    }
}