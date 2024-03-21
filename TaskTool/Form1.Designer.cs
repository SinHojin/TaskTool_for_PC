namespace TaskTool
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timerNowtime = new System.Windows.Forms.Timer(this.components);
            this.panelside = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelclose = new System.Windows.Forms.Panel();
            this.checkclose = new System.Windows.Forms.CheckBox();
            this.timerSideTime = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelside.SuspendLayout();
            this.panelclose.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(108, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "metroLabel1";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerNowtime
            // 
            this.timerNowtime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelside.Controls.Add(this.panelMenu);
            this.panelside.Controls.Add(this.panelclose);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(20, 60);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(50, 575);
            this.panelside.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(50, 525);
            this.panelMenu.TabIndex = 3;
            // 
            // panelclose
            // 
            this.panelclose.Controls.Add(this.checkclose);
            this.panelclose.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelclose.Location = new System.Drawing.Point(0, 0);
            this.panelclose.Name = "panelclose";
            this.panelclose.Size = new System.Drawing.Size(50, 50);
            this.panelclose.TabIndex = 0;
            // 
            // checkclose
            // 
            this.checkclose.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkclose.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkclose.ForeColor = System.Drawing.Color.White;
            this.checkclose.Location = new System.Drawing.Point(0, 0);
            this.checkclose.Name = "checkclose";
            this.checkclose.Size = new System.Drawing.Size(50, 50);
            this.checkclose.TabIndex = 0;
            this.checkclose.Text = ">";
            this.checkclose.UseVisualStyleBackColor = true;
            this.checkclose.CheckedChanged += new System.EventHandler(this.checkclose_CheckedChanged);
            // 
            // timerSideTime
            // 
            this.timerSideTime.Interval = 10;
            this.timerSideTime.Tick += new System.EventHandler(this.timerSideTime_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "🖥️";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelside.ResumeLayout(false);
            this.panelclose.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer timerNowtime;
        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Panel panelclose;
        private System.Windows.Forms.CheckBox checkclose;
        private System.Windows.Forms.Timer timerSideTime;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button1;
    }
}

