namespace Roguelands_Helper
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
            this.btnLoadPlayerPrefs = new System.Windows.Forms.Button();
            this.dgvMainView = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadPlayerPrefs
            // 
            this.btnLoadPlayerPrefs.Location = new System.Drawing.Point(39, 32);
            this.btnLoadPlayerPrefs.Name = "btnLoadPlayerPrefs";
            this.btnLoadPlayerPrefs.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPlayerPrefs.TabIndex = 0;
            this.btnLoadPlayerPrefs.Text = "Load PlayerPrefs";
            this.btnLoadPlayerPrefs.UseVisualStyleBackColor = true;
            this.btnLoadPlayerPrefs.Click += new System.EventHandler(this.btnLoadPlayerPrefs_Click);
            // 
            // dgvMainView
            // 
            this.dgvMainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainView.Location = new System.Drawing.Point(104, 89);
            this.dgvMainView.Name = "dgvMainView";
            this.dgvMainView.Size = new System.Drawing.Size(969, 460);
            this.dgvMainView.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(120, 32);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 606);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvMainView);
            this.Controls.Add(this.btnLoadPlayerPrefs);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPlayerPrefs;
        private System.Windows.Forms.DataGridView dgvMainView;
        private System.Windows.Forms.Button btnExport;
    }
}

