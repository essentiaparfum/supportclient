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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
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
            buttonRun.Location = new Point(184, 674);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(111, 54);
            buttonRun.TabIndex = 0;
            buttonRun.Text = "Futtatás";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewProducts.GridColor = SystemColors.MenuText;
            dataGridViewProducts.Location = new Point(12, 157);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.White;
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewProducts.RowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewProducts.Size = new Size(767, 481);
            dataGridViewProducts.TabIndex = 1;
            dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
            // 
            // buttonSaveRelated
            // 
            buttonSaveRelated.Location = new Point(323, 674);
            buttonSaveRelated.Name = "buttonSaveRelated";
            buttonSaveRelated.Size = new Size(108, 54);
            buttonSaveRelated.TabIndex = 2;
            buttonSaveRelated.Text = "Mentés";
            buttonSaveRelated.UseVisualStyleBackColor = true;
            buttonSaveRelated.Click += buttonSaveRelated_Click;
            // 
            // dataGridViewRelated
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridViewRelated.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewRelated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dataGridViewRelated.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewRelated.Location = new Point(938, 280);
            dataGridViewRelated.Name = "dataGridViewRelated";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dataGridViewRelated.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewRelated.Size = new Size(444, 191);
            dataGridViewRelated.TabIndex = 3;
            // 
            // buttonGenerateAllRelated
            // 
            buttonGenerateAllRelated.Location = new Point(464, 674);
            buttonGenerateAllRelated.Name = "buttonGenerateAllRelated";
            buttonGenerateAllRelated.Size = new Size(109, 54);
            buttonGenerateAllRelated.TabIndex = 4;
            buttonGenerateAllRelated.Text = "Összes mentése";
            buttonGenerateAllRelated.UseVisualStyleBackColor = true;
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
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 763);
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
