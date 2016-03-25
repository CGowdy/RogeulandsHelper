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
            this.label1 = new System.Windows.Forms.Label();
            this.tcMainTabControl = new System.Windows.Forms.TabControl();
            this.tpPlayer0 = new System.Windows.Forms.TabPage();
            this.dgvPlayer0 = new System.Windows.Forms.DataGridView();
            this.tpPlayer1 = new System.Windows.Forms.TabPage();
            this.dgvPlayer1 = new System.Windows.Forms.DataGridView();
            this.tpPlayer2 = new System.Windows.Forms.TabPage();
            this.dgvPlayer2 = new System.Windows.Forms.DataGridView();
            this.tpPlayer3 = new System.Windows.Forms.TabPage();
            this.dgvPlayer3 = new System.Windows.Forms.DataGridView();
            this.tpPlayer4 = new System.Windows.Forms.TabPage();
            this.dgvPlayer4 = new System.Windows.Forms.DataGridView();
            this.tpPlayer5 = new System.Windows.Forms.TabPage();
            this.dgvPlayer5 = new System.Windows.Forms.DataGridView();
            this.tpStorage = new System.Windows.Forms.TabPage();
            this.dgvStorageChest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainView)).BeginInit();
            this.tcMainTabControl.SuspendLayout();
            this.tpPlayer0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer0)).BeginInit();
            this.tpPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer1)).BeginInit();
            this.tpPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer2)).BeginInit();
            this.tpPlayer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer3)).BeginInit();
            this.tpPlayer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer4)).BeginInit();
            this.tpPlayer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer5)).BeginInit();
            this.tpStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageChest)).BeginInit();
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
            this.dgvMainView.Location = new System.Drawing.Point(12, 83);
            this.dgvMainView.Name = "dgvMainView";
            this.dgvMainView.Size = new System.Drawing.Size(370, 514);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Prefs";
            // 
            // tcMainTabControl
            // 
            this.tcMainTabControl.Controls.Add(this.tpPlayer0);
            this.tcMainTabControl.Controls.Add(this.tpPlayer1);
            this.tcMainTabControl.Controls.Add(this.tpPlayer2);
            this.tcMainTabControl.Controls.Add(this.tpPlayer3);
            this.tcMainTabControl.Controls.Add(this.tpPlayer4);
            this.tcMainTabControl.Controls.Add(this.tpPlayer5);
            this.tcMainTabControl.Controls.Add(this.tpStorage);
            this.tcMainTabControl.Location = new System.Drawing.Point(400, 67);
            this.tcMainTabControl.Name = "tcMainTabControl";
            this.tcMainTabControl.SelectedIndex = 0;
            this.tcMainTabControl.Size = new System.Drawing.Size(562, 530);
            this.tcMainTabControl.TabIndex = 4;
            // 
            // tpPlayer0
            // 
            this.tpPlayer0.Controls.Add(this.dgvPlayer0);
            this.tpPlayer0.Location = new System.Drawing.Point(4, 22);
            this.tpPlayer0.Name = "tpPlayer0";
            this.tpPlayer0.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayer0.Size = new System.Drawing.Size(554, 504);
            this.tpPlayer0.TabIndex = 0;
            this.tpPlayer0.Text = "PlayerSlot1";
            this.tpPlayer0.UseVisualStyleBackColor = true;
            // 
            // dgvPlayer0
            // 
            this.dgvPlayer0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer0.Location = new System.Drawing.Point(6, 6);
            this.dgvPlayer0.Name = "dgvPlayer0";
            this.dgvPlayer0.Size = new System.Drawing.Size(542, 495);
            this.dgvPlayer0.TabIndex = 0;
            // 
            // tpPlayer1
            // 
            this.tpPlayer1.Controls.Add(this.dgvPlayer1);
            this.tpPlayer1.Location = new System.Drawing.Point(4, 22);
            this.tpPlayer1.Name = "tpPlayer1";
            this.tpPlayer1.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayer1.Size = new System.Drawing.Size(554, 504);
            this.tpPlayer1.TabIndex = 1;
            this.tpPlayer1.Text = "PlayerSlot2";
            this.tpPlayer1.UseVisualStyleBackColor = true;
            // 
            // dgvPlayer1
            // 
            this.dgvPlayer1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer1.Location = new System.Drawing.Point(6, 5);
            this.dgvPlayer1.Name = "dgvPlayer1";
            this.dgvPlayer1.Size = new System.Drawing.Size(542, 495);
            this.dgvPlayer1.TabIndex = 1;
            // 
            // tpPlayer2
            // 
            this.tpPlayer2.Controls.Add(this.dgvPlayer2);
            this.tpPlayer2.Location = new System.Drawing.Point(4, 22);
            this.tpPlayer2.Name = "tpPlayer2";
            this.tpPlayer2.Size = new System.Drawing.Size(554, 504);
            this.tpPlayer2.TabIndex = 2;
            this.tpPlayer2.Text = "PlayerSlot3";
            this.tpPlayer2.UseVisualStyleBackColor = true;
            // 
            // dgvPlayer2
            // 
            this.dgvPlayer2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer2.Location = new System.Drawing.Point(6, 5);
            this.dgvPlayer2.Name = "dgvPlayer2";
            this.dgvPlayer2.Size = new System.Drawing.Size(542, 495);
            this.dgvPlayer2.TabIndex = 1;
            // 
            // tpPlayer3
            // 
            this.tpPlayer3.Controls.Add(this.dgvPlayer3);
            this.tpPlayer3.Location = new System.Drawing.Point(4, 22);
            this.tpPlayer3.Name = "tpPlayer3";
            this.tpPlayer3.Size = new System.Drawing.Size(554, 504);
            this.tpPlayer3.TabIndex = 3;
            this.tpPlayer3.Text = "PlayerSlot4";
            this.tpPlayer3.UseVisualStyleBackColor = true;
            // 
            // dgvPlayer3
            // 
            this.dgvPlayer3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer3.Location = new System.Drawing.Point(6, 5);
            this.dgvPlayer3.Name = "dgvPlayer3";
            this.dgvPlayer3.Size = new System.Drawing.Size(542, 495);
            this.dgvPlayer3.TabIndex = 1;
            // 
            // tpPlayer4
            // 
            this.tpPlayer4.Controls.Add(this.dgvPlayer4);
            this.tpPlayer4.Location = new System.Drawing.Point(4, 22);
            this.tpPlayer4.Name = "tpPlayer4";
            this.tpPlayer4.Size = new System.Drawing.Size(554, 504);
            this.tpPlayer4.TabIndex = 4;
            this.tpPlayer4.Text = "PlayerSlot5";
            this.tpPlayer4.UseVisualStyleBackColor = true;
            // 
            // dgvPlayer4
            // 
            this.dgvPlayer4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer4.Location = new System.Drawing.Point(6, 5);
            this.dgvPlayer4.Name = "dgvPlayer4";
            this.dgvPlayer4.Size = new System.Drawing.Size(542, 495);
            this.dgvPlayer4.TabIndex = 1;
            // 
            // tpPlayer5
            // 
            this.tpPlayer5.Controls.Add(this.dgvPlayer5);
            this.tpPlayer5.Location = new System.Drawing.Point(4, 22);
            this.tpPlayer5.Name = "tpPlayer5";
            this.tpPlayer5.Size = new System.Drawing.Size(554, 504);
            this.tpPlayer5.TabIndex = 5;
            this.tpPlayer5.Text = "PlayerSlot6";
            this.tpPlayer5.UseVisualStyleBackColor = true;
            // 
            // dgvPlayer5
            // 
            this.dgvPlayer5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer5.Location = new System.Drawing.Point(6, 5);
            this.dgvPlayer5.Name = "dgvPlayer5";
            this.dgvPlayer5.Size = new System.Drawing.Size(542, 495);
            this.dgvPlayer5.TabIndex = 1;
            // 
            // tpStorage
            // 
            this.tpStorage.Controls.Add(this.dgvStorageChest);
            this.tpStorage.Location = new System.Drawing.Point(4, 22);
            this.tpStorage.Name = "tpStorage";
            this.tpStorage.Size = new System.Drawing.Size(554, 504);
            this.tpStorage.TabIndex = 6;
            this.tpStorage.Text = "StorageChest";
            this.tpStorage.UseVisualStyleBackColor = true;
            // 
            // dgvStorageChest
            // 
            this.dgvStorageChest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorageChest.Location = new System.Drawing.Point(6, 5);
            this.dgvStorageChest.Name = "dgvStorageChest";
            this.dgvStorageChest.Size = new System.Drawing.Size(542, 495);
            this.dgvStorageChest.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 641);
            this.Controls.Add(this.tcMainTabControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvMainView);
            this.Controls.Add(this.btnLoadPlayerPrefs);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainView)).EndInit();
            this.tcMainTabControl.ResumeLayout(false);
            this.tpPlayer0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer0)).EndInit();
            this.tpPlayer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer1)).EndInit();
            this.tpPlayer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer2)).EndInit();
            this.tpPlayer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer3)).EndInit();
            this.tpPlayer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer4)).EndInit();
            this.tpPlayer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer5)).EndInit();
            this.tpStorage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageChest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPlayerPrefs;
        private System.Windows.Forms.DataGridView dgvMainView;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcMainTabControl;
        private System.Windows.Forms.TabPage tpPlayer0;
        private System.Windows.Forms.TabPage tpPlayer1;
        private System.Windows.Forms.TabPage tpPlayer2;
        private System.Windows.Forms.TabPage tpPlayer3;
        private System.Windows.Forms.TabPage tpPlayer4;
        private System.Windows.Forms.TabPage tpPlayer5;
        private System.Windows.Forms.TabPage tpStorage;
        private System.Windows.Forms.DataGridView dgvPlayer0;
        private System.Windows.Forms.DataGridView dgvPlayer1;
        private System.Windows.Forms.DataGridView dgvPlayer2;
        private System.Windows.Forms.DataGridView dgvPlayer3;
        private System.Windows.Forms.DataGridView dgvPlayer4;
        private System.Windows.Forms.DataGridView dgvPlayer5;
        private System.Windows.Forms.DataGridView dgvStorageChest;
    }
}

