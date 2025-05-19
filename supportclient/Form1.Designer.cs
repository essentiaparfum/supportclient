namespace supportclient
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            buttonRun = new Button();
            dataGridViewProducts = new DataGridView();
            buttonSaveRelated = new Button();
            dataGridViewRelated = new DataGridView();
            buttonGenerateAllRelated = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRelated).BeginInit();
            SuspendLayout();
            // 
            // buttonRun
            // 
            buttonRun.BackColor = Color.FromArgb(206, 71, 96);
            buttonRun.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRun.ForeColor = SystemColors.ButtonHighlight;
            buttonRun.Location = new Point(184, 674);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(111, 54);
            buttonRun.TabIndex = 0;
            buttonRun.Text = "Futtatás";
            buttonRun.UseVisualStyleBackColor = false;
            buttonRun.Click += buttonRun_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(211, 211, 253);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(201, 71, 96);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProducts.GridColor = SystemColors.MenuText;
            dataGridViewProducts.Location = new Point(12, 157);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewProducts.Size = new Size(767, 481);
            dataGridViewProducts.TabIndex = 1;
            dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
            // 
            // buttonSaveRelated
            // 
            buttonSaveRelated.BackColor = Color.FromArgb(206, 71, 96);
            buttonSaveRelated.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSaveRelated.ForeColor = SystemColors.ButtonHighlight;
            buttonSaveRelated.Location = new Point(323, 674);
            buttonSaveRelated.Name = "buttonSaveRelated";
            buttonSaveRelated.Size = new Size(108, 54);
            buttonSaveRelated.TabIndex = 2;
            buttonSaveRelated.Text = "Mentés";
            buttonSaveRelated.UseVisualStyleBackColor = false;
            buttonSaveRelated.Click += buttonSaveRelated_Click;
            // 
            // dataGridViewRelated
            // 
            dataGridViewRelated.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(211, 211, 253);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewRelated.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewRelated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewRelated.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewRelated.Location = new Point(938, 280);
            dataGridViewRelated.Name = "dataGridViewRelated";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewRelated.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewRelated.Size = new Size(444, 191);
            dataGridViewRelated.TabIndex = 3;
            // 
            // buttonGenerateAllRelated
            // 
            buttonGenerateAllRelated.BackColor = Color.FromArgb(206, 71, 96);
            buttonGenerateAllRelated.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGenerateAllRelated.ForeColor = SystemColors.ButtonHighlight;
            buttonGenerateAllRelated.Location = new Point(464, 674);
            buttonGenerateAllRelated.Name = "buttonGenerateAllRelated";
            buttonGenerateAllRelated.Size = new Size(109, 54);
            buttonGenerateAllRelated.TabIndex = 4;
            buttonGenerateAllRelated.Text = "Összes mentése";
            buttonGenerateAllRelated.UseVisualStyleBackColor = false;
            buttonGenerateAllRelated.Click += buttonGenerateAllRelated_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(587, 19);
            label1.Name = "label1";
            label1.Size = new Size(263, 32);
            label1.TabIndex = 5;
            label1.Text = "Essentia termékajánló";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 115);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 6;
            label2.Text = "Termékek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(962, 222);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 7;
            label3.Text = "Ajánlott termékek";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(209, 113);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(352, 23);
            textBoxSearch.TabIndex = 8;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 763);
            Controls.Add(textBoxSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonGenerateAllRelated);
            Controls.Add(dataGridViewRelated);
            Controls.Add(buttonSaveRelated);
            Controls.Add(dataGridViewProducts);
            Controls.Add(buttonRun);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRelated).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRun;
        private DataGridView dataGridViewProducts;
        private Button buttonSaveRelated;
        private DataGridView dataGridViewRelated;
        private Button buttonGenerateAllRelated;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxSearch;
    }
}
