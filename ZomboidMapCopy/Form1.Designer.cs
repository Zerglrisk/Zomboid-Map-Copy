namespace ZomboidMapCopy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudXFrom = new System.Windows.Forms.NumericUpDown();
            this.nudXTo = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.nudYFrom = new System.Windows.Forms.NumericUpDown();
            this.nudYTo = new System.Windows.Forms.NumericUpDown();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnFrom = new System.Windows.Forms.Button();
            this.btnTo = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtBackup = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXTo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYTo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "X Range";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudXFrom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudXTo, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 45);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "~";
            // 
            // nudXFrom
            // 
            this.nudXFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudXFrom.Location = new System.Drawing.Point(3, 12);
            this.nudXFrom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudXFrom.Name = "nudXFrom";
            this.nudXFrom.Size = new System.Drawing.Size(138, 21);
            this.nudXFrom.TabIndex = 2;
            // 
            // nudXTo
            // 
            this.nudXTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudXTo.Location = new System.Drawing.Point(167, 12);
            this.nudXTo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudXTo.Name = "nudXTo";
            this.nudXTo.Size = new System.Drawing.Size(139, 21);
            this.nudXTo.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 65);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Y Range";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudYFrom, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudYTo, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(309, 45);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "~";
            // 
            // nudYFrom
            // 
            this.nudYFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudYFrom.Location = new System.Drawing.Point(3, 12);
            this.nudYFrom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudYFrom.Name = "nudYFrom";
            this.nudYFrom.Size = new System.Drawing.Size(138, 21);
            this.nudYFrom.TabIndex = 2;
            // 
            // nudYTo
            // 
            this.nudYTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudYTo.Location = new System.Drawing.Point(167, 12);
            this.nudYTo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudYTo.Name = "nudYTo";
            this.nudYTo.Size = new System.Drawing.Size(139, 21);
            this.nudYTo.TabIndex = 3;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(93, 13);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ReadOnly = true;
            this.txtFrom.Size = new System.Drawing.Size(400, 21);
            this.txtFrom.TabIndex = 6;
            // 
            // btnFrom
            // 
            this.btnFrom.Location = new System.Drawing.Point(12, 11);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(75, 23);
            this.btnFrom.TabIndex = 7;
            this.btnFrom.Text = "Select...";
            this.btnFrom.UseVisualStyleBackColor = true;
            this.btnFrom.Click += new System.EventHandler(this.btnFrom_Click);
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(12, 40);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(75, 23);
            this.btnTo.TabIndex = 9;
            this.btnTo.Text = "To...";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(93, 42);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(400, 21);
            this.txtTo.TabIndex = 8;
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(333, 84);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(160, 136);
            this.txtBackup.TabIndex = 10;
            this.txtBackup.Text = "Copy";
            this.txtBackup.UseVisualStyleBackColor = true;
            this.txtBackup.Click += new System.EventHandler(this.txtBackup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 232);
            this.Controls.Add(this.txtBackup);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.btnFrom);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Zomboid Map Copy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXTo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudXFrom;
        private System.Windows.Forms.NumericUpDown nudXTo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudYFrom;
        private System.Windows.Forms.NumericUpDown nudYTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button btnFrom;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button txtBackup;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

