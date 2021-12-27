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
            this.label2 = new System.Windows.Forms.Label();
            this.text_x = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_z = new System.Windows.Forms.TextBox();
            this.Crun = new System.Windows.Forms.Button();
            this.movement_distance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.straight_distance = new System.Windows.Forms.TextBox();
            this.movement_copy = new System.Windows.Forms.Button();
            this.straight_copy = new System.Windows.Forms.Button();
            this.position_new = new System.Windows.Forms.Button();
            this.position_delete = new System.Windows.Forms.Button();
            this.PositionDataViewList = new System.Windows.Forms.ListView();
            this.position_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "x座標";
            // 
            // text_x
            // 
            this.text_x.Location = new System.Drawing.Point(508, 18);
            this.text_x.Name = "text_x";
            this.text_x.Size = new System.Drawing.Size(100, 19);
            this.text_x.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "z座標";
            // 
            // text_z
            // 
            this.text_z.Location = new System.Drawing.Point(654, 18);
            this.text_z.Name = "text_z";
            this.text_z.Size = new System.Drawing.Size(100, 19);
            this.text_z.TabIndex = 6;
            // 
            // Crun
            // 
            this.Crun.Location = new System.Drawing.Point(469, 81);
            this.Crun.Name = "Crun";
            this.Crun.Size = new System.Drawing.Size(343, 23);
            this.Crun.TabIndex = 8;
            this.Crun.Text = "計算する";
            this.Crun.UseVisualStyleBackColor = true;
            this.Crun.Click += new System.EventHandler(this.Crun_Click);
            // 
            // movement_distance
            // 
            this.movement_distance.Location = new System.Drawing.Point(469, 132);
            this.movement_distance.Name = "movement_distance";
            this.movement_distance.Size = new System.Drawing.Size(261, 19);
            this.movement_distance.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "道のり(スプレッドシート掲載用)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "直線距離(三平方の定理)";
            // 
            // straight_distance
            // 
            this.straight_distance.Location = new System.Drawing.Point(469, 177);
            this.straight_distance.Name = "straight_distance";
            this.straight_distance.Size = new System.Drawing.Size(261, 19);
            this.straight_distance.TabIndex = 11;
            // 
            // movement_copy
            // 
            this.movement_copy.Location = new System.Drawing.Point(737, 130);
            this.movement_copy.Name = "movement_copy";
            this.movement_copy.Size = new System.Drawing.Size(75, 23);
            this.movement_copy.TabIndex = 13;
            this.movement_copy.Text = "コピー";
            this.movement_copy.UseVisualStyleBackColor = true;
            this.movement_copy.Click += new System.EventHandler(this.movement_copy_Click);
            // 
            // straight_copy
            // 
            this.straight_copy.Location = new System.Drawing.Point(737, 175);
            this.straight_copy.Name = "straight_copy";
            this.straight_copy.Size = new System.Drawing.Size(75, 23);
            this.straight_copy.TabIndex = 14;
            this.straight_copy.Text = "コピー";
            this.straight_copy.UseVisualStyleBackColor = true;
            this.straight_copy.Click += new System.EventHandler(this.straight_copy_Click);
            // 
            // position_new
            // 
            this.position_new.Location = new System.Drawing.Point(469, 43);
            this.position_new.Name = "position_new";
            this.position_new.Size = new System.Drawing.Size(179, 23);
            this.position_new.TabIndex = 16;
            this.position_new.Text = "新規";
            this.position_new.UseVisualStyleBackColor = true;
            this.position_new.Click += new System.EventHandler(this.position_new_Click);
            // 
            // position_delete
            // 
            this.position_delete.Location = new System.Drawing.Point(737, 43);
            this.position_delete.Name = "position_delete";
            this.position_delete.Size = new System.Drawing.Size(75, 23);
            this.position_delete.TabIndex = 17;
            this.position_delete.Text = "削除";
            this.position_delete.UseVisualStyleBackColor = true;
            this.position_delete.Click += new System.EventHandler(this.position_delete_Click);
            // 
            // PositionDataViewList
            // 
            this.PositionDataViewList.HideSelection = false;
            this.PositionDataViewList.Location = new System.Drawing.Point(12, 18);
            this.PositionDataViewList.Name = "PositionDataViewList";
            this.PositionDataViewList.Size = new System.Drawing.Size(432, 178);
            this.PositionDataViewList.TabIndex = 18;
            this.PositionDataViewList.UseCompatibleStateImageBehavior = false;
            this.PositionDataViewList.SelectedIndexChanged += new System.EventHandler(this.PositionDataViewList_SelectedIndexChanged);
            // 
            // position_change
            // 
            this.position_change.Location = new System.Drawing.Point(656, 43);
            this.position_change.Name = "position_change";
            this.position_change.Size = new System.Drawing.Size(75, 23);
            this.position_change.TabIndex = 19;
            this.position_change.Text = "変更";
            this.position_change.UseVisualStyleBackColor = true;
            this.position_change.Click += new System.EventHandler(this.position_change_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 209);
            this.Controls.Add(this.position_change);
            this.Controls.Add(this.PositionDataViewList);
            this.Controls.Add(this.position_delete);
            this.Controls.Add(this.position_new);
            this.Controls.Add(this.straight_copy);
            this.Controls.Add(this.movement_copy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.straight_distance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.movement_distance);
            this.Controls.Add(this.Crun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_z);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_x);
            this.Name = "MainForm";
            this.Text = "MaincraftDistance";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_z;
        private System.Windows.Forms.Button Crun;
        private System.Windows.Forms.TextBox movement_distance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox straight_distance;
        private System.Windows.Forms.Button movement_copy;
        private System.Windows.Forms.Button straight_copy;
        private System.Windows.Forms.Button position_new;
        private System.Windows.Forms.Button position_delete;
        private System.Windows.Forms.ListView PositionDataViewList;
        private System.Windows.Forms.Button position_change;
    }
}

