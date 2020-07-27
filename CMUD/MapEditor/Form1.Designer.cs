namespace MapEditor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.브러시ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.물ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.산ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.평지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.브러시ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장ToolStripMenuItem,
            this.불러오기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.파일ToolStripMenuItem.Text = "파일...";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            // 
            // 브러시ToolStripMenuItem
            // 
            this.브러시ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.물ToolStripMenuItem,
            this.산ToolStripMenuItem,
            this.평지ToolStripMenuItem});
            this.브러시ToolStripMenuItem.Name = "브러시ToolStripMenuItem";
            this.브러시ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.브러시ToolStripMenuItem.Text = "브러시";
            // 
            // 물ToolStripMenuItem
            // 
            this.물ToolStripMenuItem.Checked = true;
            this.물ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.물ToolStripMenuItem.Name = "물ToolStripMenuItem";
            this.물ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.물ToolStripMenuItem.Text = "물";
            this.물ToolStripMenuItem.Click += new System.EventHandler(this.물ToolStripMenuItem_Click);
            // 
            // 산ToolStripMenuItem
            // 
            this.산ToolStripMenuItem.Name = "산ToolStripMenuItem";
            this.산ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.산ToolStripMenuItem.Text = "산";
            this.산ToolStripMenuItem.Click += new System.EventHandler(this.산ToolStripMenuItem_Click);
            // 
            // 평지ToolStripMenuItem
            // 
            this.평지ToolStripMenuItem.Name = "평지ToolStripMenuItem";
            this.평지ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.평지ToolStripMenuItem.Text = "평지";
            this.평지ToolStripMenuItem.Click += new System.EventHandler(this.평지ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 브러시ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 물ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 산ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 평지ToolStripMenuItem;
    }
}

