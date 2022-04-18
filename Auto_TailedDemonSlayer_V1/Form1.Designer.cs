
namespace Auto_TailedDemonSlayer_V1
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
            this._btnStart = new System.Windows.Forms.Button();
            this._btnStop = new System.Windows.Forms.Button();
            this._lbDeviceId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._ckbAllowTraining = new System.Windows.Forms.CheckBox();
            this._ckbAllowRush = new System.Windows.Forms.CheckBox();
            this._ckbAllowReturn = new System.Windows.Forms.CheckBox();
            this._ckbAllowGoldDungeon = new System.Windows.Forms.CheckBox();
            this._ckbAllowGemDungeon = new System.Windows.Forms.CheckBox();
            this._ckbAllowEquipDungeon = new System.Windows.Forms.CheckBox();
            this._ckbAllowEquipLevelDungeon = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._lbTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnStart
            // 
            this._btnStart.Location = new System.Drawing.Point(12, 224);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(143, 23);
            this._btnStart.TabIndex = 0;
            this._btnStart.Text = "Start";
            this._btnStart.UseVisualStyleBackColor = true;
            this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
            // 
            // _btnStop
            // 
            this._btnStop.Location = new System.Drawing.Point(163, 224);
            this._btnStop.Name = "_btnStop";
            this._btnStop.Size = new System.Drawing.Size(143, 23);
            this._btnStop.TabIndex = 1;
            this._btnStop.Text = "Stop";
            this._btnStop.UseVisualStyleBackColor = true;
            this._btnStop.Click += new System.EventHandler(this._btnStop_Click);
            // 
            // _lbDeviceId
            // 
            this._lbDeviceId.AutoSize = true;
            this._lbDeviceId.Location = new System.Drawing.Point(76, 260);
            this._lbDeviceId.Name = "_lbDeviceId";
            this._lbDeviceId.Size = new System.Drawing.Size(35, 13);
            this._lbDeviceId.TabIndex = 2;
            this._lbDeviceId.Text = "####";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._ckbAllowEquipLevelDungeon);
            this.groupBox1.Controls.Add(this._ckbAllowEquipDungeon);
            this.groupBox1.Controls.Add(this._ckbAllowGemDungeon);
            this.groupBox1.Controls.Add(this._ckbAllowGoldDungeon);
            this.groupBox1.Controls.Add(this._ckbAllowReturn);
            this.groupBox1.Controls.Add(this._ckbAllowRush);
            this.groupBox1.Controls.Add(this._ckbAllowTraining);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 206);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài Đặt";
            // 
            // _ckbAllowTraining
            // 
            this._ckbAllowTraining.AutoSize = true;
            this._ckbAllowTraining.Location = new System.Drawing.Point(24, 31);
            this._ckbAllowTraining.Name = "_ckbAllowTraining";
            this._ckbAllowTraining.Size = new System.Drawing.Size(153, 17);
            this._ckbAllowTraining.TabIndex = 4;
            this._ckbAllowTraining.Text = "Tự động tăng level training";
            this._ckbAllowTraining.UseVisualStyleBackColor = true;
            // 
            // _ckbAllowRush
            // 
            this._ckbAllowRush.AutoSize = true;
            this._ckbAllowRush.Location = new System.Drawing.Point(24, 54);
            this._ckbAllowRush.Name = "_ckbAllowRush";
            this._ckbAllowRush.Size = new System.Drawing.Size(90, 17);
            this._ckbAllowRush.TabIndex = 5;
            this._ckbAllowRush.Text = "Tự động rush";
            this._ckbAllowRush.UseVisualStyleBackColor = true;
            // 
            // _ckbAllowReturn
            // 
            this._ckbAllowReturn.AutoSize = true;
            this._ckbAllowReturn.Location = new System.Drawing.Point(24, 77);
            this._ckbAllowReturn.Name = "_ckbAllowReturn";
            this._ckbAllowReturn.Size = new System.Drawing.Size(97, 17);
            this._ckbAllowReturn.TabIndex = 6;
            this._ckbAllowReturn.Text = "Tự động return";
            this._ckbAllowReturn.UseVisualStyleBackColor = true;
            // 
            // _ckbAllowGoldDungeon
            // 
            this._ckbAllowGoldDungeon.AutoSize = true;
            this._ckbAllowGoldDungeon.Location = new System.Drawing.Point(24, 100);
            this._ckbAllowGoldDungeon.Name = "_ckbAllowGoldDungeon";
            this._ckbAllowGoldDungeon.Size = new System.Drawing.Size(161, 17);
            this._ckbAllowGoldDungeon.TabIndex = 7;
            this._ckbAllowGoldDungeon.Text = "Tự động chạy gold dungeon";
            this._ckbAllowGoldDungeon.UseVisualStyleBackColor = true;
            // 
            // _ckbAllowGemDungeon
            // 
            this._ckbAllowGemDungeon.AutoSize = true;
            this._ckbAllowGemDungeon.Location = new System.Drawing.Point(24, 123);
            this._ckbAllowGemDungeon.Name = "_ckbAllowGemDungeon";
            this._ckbAllowGemDungeon.Size = new System.Drawing.Size(161, 17);
            this._ckbAllowGemDungeon.TabIndex = 8;
            this._ckbAllowGemDungeon.Text = "Tự động chạy gem dungeon";
            this._ckbAllowGemDungeon.UseVisualStyleBackColor = true;
            // 
            // _ckbAllowEquipDungeon
            // 
            this._ckbAllowEquipDungeon.AutoSize = true;
            this._ckbAllowEquipDungeon.Location = new System.Drawing.Point(24, 146);
            this._ckbAllowEquipDungeon.Name = "_ckbAllowEquipDungeon";
            this._ckbAllowEquipDungeon.Size = new System.Drawing.Size(190, 17);
            this._ckbAllowEquipDungeon.TabIndex = 9;
            this._ckbAllowEquipDungeon.Text = "Tự động chạy equipment dungeon";
            this._ckbAllowEquipDungeon.UseVisualStyleBackColor = true;
            // 
            // _ckbAllowEquipLevelDungeon
            // 
            this._ckbAllowEquipLevelDungeon.AutoSize = true;
            this._ckbAllowEquipLevelDungeon.Location = new System.Drawing.Point(24, 169);
            this._ckbAllowEquipLevelDungeon.Name = "_ckbAllowEquipLevelDungeon";
            this._ckbAllowEquipLevelDungeon.Size = new System.Drawing.Size(257, 17);
            this._ckbAllowEquipLevelDungeon.TabIndex = 10;
            this._ckbAllowEquipLevelDungeon.Text = "Tự động chạy equipment level up scroll dungeon";
            this._ckbAllowEquipLevelDungeon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Device Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thời gian:";
            // 
            // _lbTime
            // 
            this._lbTime.AutoSize = true;
            this._lbTime.Location = new System.Drawing.Point(76, 281);
            this._lbTime.Name = "_lbTime";
            this._lbTime.Size = new System.Drawing.Size(35, 13);
            this._lbTime.TabIndex = 6;
            this._lbTime.Tag = "####";
            this._lbTime.Text = "####";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 317);
            this.Controls.Add(this._lbTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._lbDeviceId);
            this.Controls.Add(this._btnStop);
            this.Controls.Add(this._btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Auto Tailed Demon Slayer - V1 - Write By: Nguyễn Công Đạt - 0898798962";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnStart;
        private System.Windows.Forms.Button _btnStop;
        private System.Windows.Forms.Label _lbDeviceId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox _ckbAllowReturn;
        private System.Windows.Forms.CheckBox _ckbAllowRush;
        private System.Windows.Forms.CheckBox _ckbAllowTraining;
        private System.Windows.Forms.CheckBox _ckbAllowGemDungeon;
        private System.Windows.Forms.CheckBox _ckbAllowGoldDungeon;
        private System.Windows.Forms.CheckBox _ckbAllowEquipLevelDungeon;
        private System.Windows.Forms.CheckBox _ckbAllowEquipDungeon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lbTime;
    }
}

