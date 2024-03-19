namespace Calisma_vt_777
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
            this.dgwFilmler = new System.Windows.Forms.DataGridView();
            this.btnElestiriForm = new System.Windows.Forms.Button();
            this.btnFilmElestiri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFilmler
            // 
            this.dgwFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilmler.Location = new System.Drawing.Point(13, 239);
            this.dgwFilmler.Name = "dgwFilmler";
            this.dgwFilmler.Size = new System.Drawing.Size(785, 199);
            this.dgwFilmler.TabIndex = 0;
            // 
            // btnElestiriForm
            // 
            this.btnElestiriForm.Location = new System.Drawing.Point(12, 77);
            this.btnElestiriForm.Name = "btnElestiriForm";
            this.btnElestiriForm.Size = new System.Drawing.Size(127, 43);
            this.btnElestiriForm.TabIndex = 1;
            this.btnElestiriForm.Text = "Eleştiriler";
            this.btnElestiriForm.UseVisualStyleBackColor = true;
            this.btnElestiriForm.Click += new System.EventHandler(this.btnElestiriForm_Click);
            // 
            // btnFilmElestiri
            // 
            this.btnFilmElestiri.Location = new System.Drawing.Point(172, 77);
            this.btnFilmElestiri.Name = "btnFilmElestiri";
            this.btnFilmElestiri.Size = new System.Drawing.Size(130, 43);
            this.btnFilmElestiri.TabIndex = 2;
            this.btnFilmElestiri.Text = "Film Eleştiri";
            this.btnFilmElestiri.UseVisualStyleBackColor = true;
            this.btnFilmElestiri.Click += new System.EventHandler(this.btnFilmElestiri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.btnFilmElestiri);
            this.Controls.Add(this.btnElestiriForm);
            this.Controls.Add(this.dgwFilmler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilmler;
        private System.Windows.Forms.Button btnElestiriForm;
        private System.Windows.Forms.Button btnFilmElestiri;
    }
}

