namespace KPO4311.ddi.Lib.source
{
    partial class FrmBook
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
            this.txtboxNameBook = new System.Windows.Forms.TextBox();
            this.txtBoxAuthorBook = new System.Windows.Forms.TextBox();
            this.txtBoxDataVBook = new System.Windows.Forms.TextBox();
            this.txtBoxGroupBook = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxNameBook
            // 
            this.txtboxNameBook.Location = new System.Drawing.Point(210, 24);
            this.txtboxNameBook.Name = "txtboxNameBook";
            this.txtboxNameBook.Size = new System.Drawing.Size(192, 20);
            this.txtboxNameBook.TabIndex = 0;
            this.txtboxNameBook.TextChanged += new System.EventHandler(this.txtboxNameBook_TextChanged);
            // 
            // txtBoxAuthorBook
            // 
            this.txtBoxAuthorBook.Location = new System.Drawing.Point(12, 24);
            this.txtBoxAuthorBook.Name = "txtBoxAuthorBook";
            this.txtBoxAuthorBook.Size = new System.Drawing.Size(192, 20);
            this.txtBoxAuthorBook.TabIndex = 1;
            // 
            // txtBoxDataVBook
            // 
            this.txtBoxDataVBook.Location = new System.Drawing.Point(417, 24);
            this.txtBoxDataVBook.Name = "txtBoxDataVBook";
            this.txtBoxDataVBook.Size = new System.Drawing.Size(182, 20);
            this.txtBoxDataVBook.TabIndex = 2;
            // 
            // txtBoxGroupBook
            // 
            this.txtBoxGroupBook.Location = new System.Drawing.Point(605, 24);
            this.txtBoxGroupBook.Name = "txtBoxGroupBook";
            this.txtBoxGroupBook.Size = new System.Drawing.Size(182, 20);
            this.txtBoxGroupBook.TabIndex = 3;
            // 
            // FrmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxGroupBook);
            this.Controls.Add(this.txtBoxDataVBook);
            this.Controls.Add(this.txtBoxAuthorBook);
            this.Controls.Add(this.txtboxNameBook);
            this.Name = "FrmBook";
            this.Text = "FrmBook";
            this.Load += new System.EventHandler(this.FrmBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxNameBook;
        private System.Windows.Forms.TextBox txtBoxAuthorBook;
        private System.Windows.Forms.TextBox txtBoxDataVBook;
        private System.Windows.Forms.TextBox txtBoxGroupBook;
    }
}