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
            buttonRun = new Button();
            dataGridViewProducts = new DataGridView();
            buttonSaveRelated = new Button();
            dataGridViewRelated = new DataGridView();
            buttonGenerateAllRelated = new Button();
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
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(12, 77);
            dataGridViewProducts.Name = "dataGridViewProducts";
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
            dataGridViewRelated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRelated.Location = new Point(933, 77);
            dataGridViewRelated.Name = "dataGridViewRelated";
            dataGridViewRelated.Size = new Size(467, 481);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 763);
            Controls.Add(buttonGenerateAllRelated);
            Controls.Add(dataGridViewRelated);
            Controls.Add(buttonSaveRelated);
            Controls.Add(dataGridViewProducts);
            Controls.Add(buttonRun);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRelated).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRun;
        private DataGridView dataGridViewProducts;
        private Button buttonSaveRelated;
        private DataGridView dataGridViewRelated;
        private Button buttonGenerateAllRelated;
    }
}
