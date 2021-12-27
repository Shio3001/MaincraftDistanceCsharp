namespace MaincraftDistanceCsharp
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.text_x1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_x2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_z2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_z1 = new System.Windows.Forms.TextBox();
            this.Crun = new System.Windows.Forms.Button();
            this.movement_distance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.straight_distance = new System.Windows.Forms.TextBox();
            this.movement_copy = new System.Windows.Forms.Button();
            this.straight_copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_x1
            // 
            this.text_x1.Location = new System.Drawing.Point(44, 24);
            this.text_x1.Name = "text_x1";
            this.text_x1.Size = new System.Drawing.Size(100, 19);
            this.text_x1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "x2";
            // 
            // text_x2
            // 
            this.text_x2.Location = new System.Drawing.Point(44, 49);
            this.text_x2.Name = "text_x2";
            this.text_x2.Size = new System.Drawing.Size(100, 19);
            this.text_x2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "z2";
            // 
            // text_z2
            // 
            this.text_z2.Location = new System.Drawing.Point(184, 49);
            this.text_z2.Name = "text_z2";
            this.text_z2.Size = new System.Drawing.Size(100, 19);
            this.text_z2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "z1";
            // 
            // text_z1
            // 
            this.text_z1.Location = new System.Drawing.Point(184, 24);
            this.text_z1.Name = "text_z1";
            this.text_z1.Size = new System.Drawing.Size(100, 19);
            this.text_z1.TabIndex = 4;
            // 
            // Crun
            // 
            this.Crun.Location = new System.Drawing.Point(44, 74);
            this.Crun.Name = "Crun";
            this.Crun.Size = new System.Drawing.Size(75, 23);
            this.Crun.TabIndex = 8;
            this.Crun.Text = "計算する";
            this.Crun.UseVisualStyleBackColor = true;
            this.Crun.Click += new System.EventHandler(this.Crun_Click);
            // 
            // movement_distance
            // 
            this.movement_distance.Location = new System.Drawing.Point(23, 136);
            this.movement_distance.Name = "movement_distance";
            this.movement_distance.Size = new System.Drawing.Size(261, 19);
            this.movement_distance.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "道のり(スプレッドシート掲載用)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "直線距離(三平方の定理)";
            // 
            // straight_distance
            // 
            this.straight_distance.Location = new System.Drawing.Point(23, 181);
            this.straight_distance.Name = "straight_distance";
            this.straight_distance.Size = new System.Drawing.Size(261, 19);
            this.straight_distance.TabIndex = 11;
            // 
            // movement_copy
            // 
            this.movement_copy.Location = new System.Drawing.Point(291, 134);
            this.movement_copy.Name = "movement_copy";
            this.movement_copy.Size = new System.Drawing.Size(75, 23);
            this.movement_copy.TabIndex = 13;
            this.movement_copy.Text = "コピー";
            this.movement_copy.UseVisualStyleBackColor = true;
            this.movement_copy.Click += new System.EventHandler(this.movement_copy_Click);
            // 
            // straight_copy
            // 
            this.straight_copy.Location = new System.Drawing.Point(291, 179);
            this.straight_copy.Name = "straight_copy";
            this.straight_copy.Size = new System.Drawing.Size(75, 23);
            this.straight_copy.TabIndex = 14;
            this.straight_copy.Text = "コピー";
            this.straight_copy.UseVisualStyleBackColor = true;
            this.straight_copy.Click += new System.EventHandler(this.straight_copy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 222);
            this.Controls.Add(this.straight_copy);
            this.Controls.Add(this.movement_copy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.straight_distance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.movement_distance);
            this.Controls.Add(this.Crun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_z2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_z1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_x2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_x1);
            this.Name = "MainForm";
            this.Text = "MaincraftDistance";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_x1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_x2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_z2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_z1;
        private System.Windows.Forms.Button Crun;
        private System.Windows.Forms.TextBox movement_distance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox straight_distance;
        private System.Windows.Forms.Button movement_copy;
        private System.Windows.Forms.Button straight_copy;
    }
}

