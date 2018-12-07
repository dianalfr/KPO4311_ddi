namespace KPO4311_ddi.Main
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.nmSave_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenBook = new System.Windows.Forms.ToolStripMenuItem();
            this.SStatus = new System.Windows.Forms.StatusStrip();
            this.dgvMyBook = new System.Windows.Forms.DataGridView();
            this.MMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyBook)).BeginInit();
            this.SuspendLayout();
            // 
            // MMenu
            // 
            this.MMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mnBook});
            this.MMenu.Location = new System.Drawing.Point(0, 0);
            this.MMenu.Name = "MMenu";
            this.MMenu.Size = new System.Drawing.Size(800, 24);
            this.MMenu.TabIndex = 0;
            this.MMenu.Text = "menuStrip1";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit,
            this.mnOpen,
            this.nmSave_Click});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(57, 20);
            this.mmFile.Text = "1&.Файл";
            this.mmFile.Click += new System.EventHandler(this.mmFile_Click);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(132, 22);
            this.mnExit.Text = "Выход";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(132, 22);
            this.mnOpen.Text = "Открыть";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // nmSave_Click
            // 
            this.nmSave_Click.Name = "nmSave_Click";
            this.nmSave_Click.Size = new System.Drawing.Size(132, 22);
            this.nmSave_Click.Text = "Сохранить";
            this.nmSave_Click.Click += new System.EventHandler(this.nmSave_Click_Click);
            // 
            // mnBook
            // 
            this.mnBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpenBook});
            this.mnBook.Name = "mnBook";
            this.mnBook.Size = new System.Drawing.Size(60, 20);
            this.mnBook.Text = "2.Книга";
            // 
            // mnOpenBook
            // 
            this.mnOpenBook.Name = "mnOpenBook";
            this.mnOpenBook.Size = new System.Drawing.Size(200, 22);
            this.mnOpenBook.Text = "Открыть данные книги";
            this.mnOpenBook.Click += new System.EventHandler(this.mnOpenBook_Click);
            // 
            // SStatus
            // 
            this.SStatus.Location = new System.Drawing.Point(0, 428);
            this.SStatus.Name = "SStatus";
            this.SStatus.Size = new System.Drawing.Size(800, 22);
            this.SStatus.TabIndex = 1;
            this.SStatus.Text = "statusStrip1";
            // 
            // dgvMyBook
            // 
            this.dgvMyBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyBook.Location = new System.Drawing.Point(36, 39);
            this.dgvMyBook.Name = "dgvMyBook";
            this.dgvMyBook.Size = new System.Drawing.Size(721, 364);
            this.dgvMyBook.TabIndex = 2;
            this.dgvMyBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMockEmployeeList_CellContentClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMyBook);
            this.Controls.Add(this.SStatus);
            this.Controls.Add(this.MMenu);
            this.MainMenuStrip = this.MMenu;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MMenu.ResumeLayout(false);
            this.MMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MMenu;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.StatusStrip SStatus;
        private System.Windows.Forms.DataGridView dgvMyBook;
        private System.Windows.Forms.ToolStripMenuItem mnBook;
        private System.Windows.Forms.ToolStripMenuItem mnOpenBook;
        private System.Windows.Forms.ToolStripMenuItem nmSave_Click;
    }
}

