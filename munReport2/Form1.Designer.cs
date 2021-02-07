
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
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(38, 32);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.database);
            this.Controls.Add(this.btn_SelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.DataGridView database;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

