
namespace GuessTheNumber
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_Min = new System.Windows.Forms.Label();
            this.lab_Max = new System.Windows.Forms.Label();
            this.tbx_PlrGes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Ges = new System.Windows.Forms.Button();
            this.lab_Ans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_Min
            // 
            this.lab_Min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_Min.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Min.Location = new System.Drawing.Point(35, 71);
            this.lab_Min.Name = "lab_Min";
            this.lab_Min.Size = new System.Drawing.Size(124, 70);
            this.lab_Min.TabIndex = 0;
            this.lab_Min.Text = "0";
            this.lab_Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Max
            // 
            this.lab_Max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_Max.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Max.Location = new System.Drawing.Point(418, 71);
            this.lab_Max.Name = "lab_Max";
            this.lab_Max.Size = new System.Drawing.Size(124, 70);
            this.lab_Max.TabIndex = 0;
            this.lab_Max.Text = "999";
            this.lab_Max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_PlrGes
            // 
            this.tbx_PlrGes.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_PlrGes.Location = new System.Drawing.Point(240, 83);
            this.tbx_PlrGes.MaxLength = 4;
            this.tbx_PlrGes.Name = "tbx_PlrGes";
            this.tbx_PlrGes.Size = new System.Drawing.Size(100, 46);
            this.tbx_PlrGes.TabIndex = 1;
            this.tbx_PlrGes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(170, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "<";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(353, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "<";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(47, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "最小值";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(430, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "最大值";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(240, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "玩家猜測值";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Reset.Location = new System.Drawing.Point(35, 184);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(124, 51);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "另啟新局";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Exit.Location = new System.Drawing.Point(418, 184);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(124, 51);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "結束遊戲";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Ges
            // 
            this.btn_Ges.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Ges.Location = new System.Drawing.Point(222, 178);
            this.btn_Ges.Name = "btn_Ges";
            this.btn_Ges.Size = new System.Drawing.Size(136, 63);
            this.btn_Ges.TabIndex = 4;
            this.btn_Ges.Text = "猜數字";
            this.btn_Ges.UseVisualStyleBackColor = true;
            this.btn_Ges.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Ges_MouseDown);
            // 
            // lab_Ans
            // 
            this.lab_Ans.AutoSize = true;
            this.lab_Ans.Location = new System.Drawing.Point(-1, 280);
            this.lab_Ans.Name = "lab_Ans";
            this.lab_Ans.Size = new System.Drawing.Size(43, 12);
            this.lab_Ans.TabIndex = 5;
            this.lab_Ans.Text = "lab_Ans";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 287);
            this.Controls.Add(this.lab_Ans);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Ges);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_PlrGes);
            this.Controls.Add(this.lab_Max);
            this.Controls.Add(this.lab_Min);
            this.Name = "MainForm";
            this.Text = "終極密碼";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Min;
        private System.Windows.Forms.Label lab_Max;
        private System.Windows.Forms.TextBox tbx_PlrGes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Ges;
        private System.Windows.Forms.Label lab_Ans;
    }
}

