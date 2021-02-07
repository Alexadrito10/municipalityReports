
namespace munReport2
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
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.database = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(36, 29);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(115, 23);
            this.btn_SelectFile.TabIndex = 0;
            this.btn_SelectFile.Text = "Escoger Archivo";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // database
            // 
            this.database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.database.Location = new System.Drawing.Point(21, 94);
            this.database.Name = "database";
            this.database.RowTemplate.Height = 25;
            this.database.Size = new System.Drawing.Size(416, 217);
            this.database.TabIndex = 1;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbFilter.Location = new System.Drawing.Point(397, 29);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(40, 23);
            this.cbFilter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Busqueda por letra de municipio:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(444, 28);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(75, 23);
            this.filter.TabIndex = 4;
            this.filter.Text = "Filtrar";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.database);
            this.Controls.Add(this.btn_SelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.DataGridView database;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button filter;
    }
}

