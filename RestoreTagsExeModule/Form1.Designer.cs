namespace RestoreTagsExeModule
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
          /*if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);*/
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRestoreTags = new System.Windows.Forms.Button();
            this.btnRestoreExe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestoreTags
            // 
            this.btnRestoreTags.Location = new System.Drawing.Point(13, 13);
            this.btnRestoreTags.Name = "btnRestoreTags";
            this.btnRestoreTags.Size = new System.Drawing.Size(259, 23);
            this.btnRestoreTags.TabIndex = 0;
            this.btnRestoreTags.Text = "Restore Tags.dat";
            this.btnRestoreTags.UseVisualStyleBackColor = true;
            this.btnRestoreTags.Click += new System.EventHandler(this.btnRestoreTags_Click);
            // 
            // btnRestoreExe
            // 
            this.btnRestoreExe.Location = new System.Drawing.Point(13, 42);
            this.btnRestoreExe.Name = "btnRestoreExe";
            this.btnRestoreExe.Size = new System.Drawing.Size(259, 23);
            this.btnRestoreExe.TabIndex = 1;
            this.btnRestoreExe.Text = "Restore Eldorado.exe";
            this.btnRestoreExe.UseVisualStyleBackColor = true;
            this.btnRestoreExe.Click += new System.EventHandler(this.btnRestoreExe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 75);
            this.Controls.Add(this.btnRestoreExe);
            this.Controls.Add(this.btnRestoreTags);
            this.Name = "Form1";
            this.Text = "Tags & Exe Restore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestoreTags;
        private System.Windows.Forms.Button btnRestoreExe;
    }
}

