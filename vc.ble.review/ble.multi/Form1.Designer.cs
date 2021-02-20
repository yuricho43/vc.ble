
namespace ble.multi
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
            this.checkBle1 = new System.Windows.Forms.CheckBox();
            this.checkBle2 = new System.Windows.Forms.CheckBox();
            this.checkBle3 = new System.Windows.Forms.CheckBox();
            this.checkBle4 = new System.Windows.Forms.CheckBox();
            this.listBle1 = new System.Windows.Forms.ListBox();
            this.listBle2 = new System.Windows.Forms.ListBox();
            this.listBle3 = new System.Windows.Forms.ListBox();
            this.listBle4 = new System.Windows.Forms.ListBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonScan = new System.Windows.Forms.Button();
            this.textBle1 = new System.Windows.Forms.TextBox();
            this.textBle2 = new System.Windows.Forms.TextBox();
            this.textBle3 = new System.Windows.Forms.TextBox();
            this.textBle4 = new System.Windows.Forms.TextBox();
            this.buttonBle1FromList = new System.Windows.Forms.Button();
            this.buttonBle2FromList = new System.Windows.Forms.Button();
            this.buttonBle3FromList = new System.Windows.Forms.Button();
            this.buttonBle4FromList = new System.Windows.Forms.Button();
            this.listDevice = new System.Windows.Forms.ListBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textScanTime = new System.Windows.Forms.TextBox();
            this.labelScanTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBle1
            // 
            this.checkBle1.AutoSize = true;
            this.checkBle1.Location = new System.Drawing.Point(260, 74);
            this.checkBle1.Name = "checkBle1";
            this.checkBle1.Size = new System.Drawing.Size(73, 19);
            this.checkBle1.TabIndex = 0;
            this.checkBle1.Text = "Enable";
            this.checkBle1.UseVisualStyleBackColor = true;
            this.checkBle1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBle2
            // 
            this.checkBle2.AutoSize = true;
            this.checkBle2.Location = new System.Drawing.Point(646, 74);
            this.checkBle2.Name = "checkBle2";
            this.checkBle2.Size = new System.Drawing.Size(73, 19);
            this.checkBle2.TabIndex = 1;
            this.checkBle2.Text = "Enable";
            this.checkBle2.UseVisualStyleBackColor = true;
            // 
            // checkBle3
            // 
            this.checkBle3.AutoSize = true;
            this.checkBle3.Location = new System.Drawing.Point(1036, 74);
            this.checkBle3.Name = "checkBle3";
            this.checkBle3.Size = new System.Drawing.Size(73, 19);
            this.checkBle3.TabIndex = 2;
            this.checkBle3.Text = "Enable";
            this.checkBle3.UseVisualStyleBackColor = true;
            // 
            // checkBle4
            // 
            this.checkBle4.AutoSize = true;
            this.checkBle4.Location = new System.Drawing.Point(1424, 74);
            this.checkBle4.Name = "checkBle4";
            this.checkBle4.Size = new System.Drawing.Size(73, 19);
            this.checkBle4.TabIndex = 3;
            this.checkBle4.Text = "Enable";
            this.checkBle4.UseVisualStyleBackColor = true;
            // 
            // listBle1
            // 
            this.listBle1.FormattingEnabled = true;
            this.listBle1.HorizontalScrollbar = true;
            this.listBle1.ItemHeight = 15;
            this.listBle1.Location = new System.Drawing.Point(260, 99);
            this.listBle1.Name = "listBle1";
            this.listBle1.Size = new System.Drawing.Size(380, 424);
            this.listBle1.TabIndex = 4;
            // 
            // listBle2
            // 
            this.listBle2.FormattingEnabled = true;
            this.listBle2.HorizontalScrollbar = true;
            this.listBle2.ItemHeight = 15;
            this.listBle2.Location = new System.Drawing.Point(646, 99);
            this.listBle2.Name = "listBle2";
            this.listBle2.Size = new System.Drawing.Size(384, 424);
            this.listBle2.TabIndex = 5;
            // 
            // listBle3
            // 
            this.listBle3.FormattingEnabled = true;
            this.listBle3.HorizontalScrollbar = true;
            this.listBle3.ItemHeight = 15;
            this.listBle3.Location = new System.Drawing.Point(1036, 99);
            this.listBle3.Name = "listBle3";
            this.listBle3.Size = new System.Drawing.Size(382, 424);
            this.listBle3.TabIndex = 6;
            // 
            // listBle4
            // 
            this.listBle4.FormattingEnabled = true;
            this.listBle4.HorizontalScrollbar = true;
            this.listBle4.ItemHeight = 15;
            this.listBle4.Location = new System.Drawing.Point(1424, 99);
            this.listBle4.Name = "listBle4";
            this.listBle4.Size = new System.Drawing.Size(383, 424);
            this.listBle4.TabIndex = 7;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(285, 554);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(168, 37);
            this.buttonRun.TabIndex = 9;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(23, 25);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(212, 37);
            this.buttonScan.TabIndex = 10;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // textBle1
            // 
            this.textBle1.Location = new System.Drawing.Point(339, 68);
            this.textBle1.Name = "textBle1";
            this.textBle1.Size = new System.Drawing.Size(301, 25);
            this.textBle1.TabIndex = 11;
            // 
            // textBle2
            // 
            this.textBle2.Location = new System.Drawing.Point(725, 68);
            this.textBle2.Name = "textBle2";
            this.textBle2.Size = new System.Drawing.Size(305, 25);
            this.textBle2.TabIndex = 12;
            // 
            // textBle3
            // 
            this.textBle3.Location = new System.Drawing.Point(1115, 68);
            this.textBle3.Name = "textBle3";
            this.textBle3.Size = new System.Drawing.Size(303, 25);
            this.textBle3.TabIndex = 13;
            // 
            // textBle4
            // 
            this.textBle4.Location = new System.Drawing.Point(1503, 68);
            this.textBle4.Name = "textBle4";
            this.textBle4.Size = new System.Drawing.Size(304, 25);
            this.textBle4.TabIndex = 14;
            // 
            // buttonBle1FromList
            // 
            this.buttonBle1FromList.Location = new System.Drawing.Point(260, 25);
            this.buttonBle1FromList.Name = "buttonBle1FromList";
            this.buttonBle1FromList.Size = new System.Drawing.Size(380, 37);
            this.buttonBle1FromList.TabIndex = 15;
            this.buttonBle1FromList.Text = "Select from List";
            this.buttonBle1FromList.UseVisualStyleBackColor = true;
            this.buttonBle1FromList.Click += new System.EventHandler(this.buttonBle1FromList_Click);
            // 
            // buttonBle2FromList
            // 
            this.buttonBle2FromList.Location = new System.Drawing.Point(646, 25);
            this.buttonBle2FromList.Name = "buttonBle2FromList";
            this.buttonBle2FromList.Size = new System.Drawing.Size(384, 37);
            this.buttonBle2FromList.TabIndex = 16;
            this.buttonBle2FromList.Text = "Select from List";
            this.buttonBle2FromList.UseVisualStyleBackColor = true;
            this.buttonBle2FromList.Click += new System.EventHandler(this.buttonBle2FromList_Click);
            // 
            // buttonBle3FromList
            // 
            this.buttonBle3FromList.Location = new System.Drawing.Point(1036, 25);
            this.buttonBle3FromList.Name = "buttonBle3FromList";
            this.buttonBle3FromList.Size = new System.Drawing.Size(382, 37);
            this.buttonBle3FromList.TabIndex = 17;
            this.buttonBle3FromList.Text = "Select from List";
            this.buttonBle3FromList.UseVisualStyleBackColor = true;
            this.buttonBle3FromList.Click += new System.EventHandler(this.buttonBle3FromList_Click);
            // 
            // buttonBle4FromList
            // 
            this.buttonBle4FromList.Location = new System.Drawing.Point(1424, 25);
            this.buttonBle4FromList.Name = "buttonBle4FromList";
            this.buttonBle4FromList.Size = new System.Drawing.Size(383, 37);
            this.buttonBle4FromList.TabIndex = 18;
            this.buttonBle4FromList.Text = "Select from List";
            this.buttonBle4FromList.UseVisualStyleBackColor = true;
            this.buttonBle4FromList.Click += new System.EventHandler(this.buttonBle4FromList_Click);
            // 
            // listDevice
            // 
            this.listDevice.FormattingEnabled = true;
            this.listDevice.ItemHeight = 15;
            this.listDevice.Location = new System.Drawing.Point(23, 107);
            this.listDevice.Name = "listDevice";
            this.listDevice.Size = new System.Drawing.Size(212, 409);
            this.listDevice.TabIndex = 19;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(550, 554);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(168, 37);
            this.buttonStop.TabIndex = 20;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textScanTime
            // 
            this.textScanTime.Location = new System.Drawing.Point(163, 72);
            this.textScanTime.Name = "textScanTime";
            this.textScanTime.Size = new System.Drawing.Size(72, 25);
            this.textScanTime.TabIndex = 21;
            this.textScanTime.Text = "3";
            this.textScanTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelScanTime
            // 
            this.labelScanTime.AutoSize = true;
            this.labelScanTime.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelScanTime.Location = new System.Drawing.Point(20, 76);
            this.labelScanTime.Name = "labelScanTime";
            this.labelScanTime.Size = new System.Drawing.Size(124, 17);
            this.labelScanTime.TabIndex = 22;
            this.labelScanTime.Text = "Scan Time(Sec)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1865, 781);
            this.Controls.Add(this.labelScanTime);
            this.Controls.Add(this.textScanTime);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.listDevice);
            this.Controls.Add(this.buttonBle4FromList);
            this.Controls.Add(this.buttonBle3FromList);
            this.Controls.Add(this.buttonBle2FromList);
            this.Controls.Add(this.buttonBle1FromList);
            this.Controls.Add(this.textBle4);
            this.Controls.Add(this.textBle3);
            this.Controls.Add(this.textBle2);
            this.Controls.Add(this.textBle1);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.listBle4);
            this.Controls.Add(this.listBle3);
            this.Controls.Add(this.listBle2);
            this.Controls.Add(this.listBle1);
            this.Controls.Add(this.checkBle4);
            this.Controls.Add(this.checkBle3);
            this.Controls.Add(this.checkBle2);
            this.Controls.Add(this.checkBle1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBle1;
        private System.Windows.Forms.CheckBox checkBle2;
        private System.Windows.Forms.CheckBox checkBle3;
        private System.Windows.Forms.CheckBox checkBle4;
        private System.Windows.Forms.ListBox listBle1;
        private System.Windows.Forms.ListBox listBle2;
        private System.Windows.Forms.ListBox listBle3;
        private System.Windows.Forms.ListBox listBle4;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.TextBox textBle1;
        private System.Windows.Forms.TextBox textBle2;
        private System.Windows.Forms.TextBox textBle3;
        private System.Windows.Forms.TextBox textBle4;
        private System.Windows.Forms.Button buttonBle1FromList;
        private System.Windows.Forms.Button buttonBle2FromList;
        private System.Windows.Forms.Button buttonBle3FromList;
        private System.Windows.Forms.Button buttonBle4FromList;
        private System.Windows.Forms.ListBox listDevice;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textScanTime;
        private System.Windows.Forms.Label labelScanTime;
    }
}

