namespace Exec02_Fee
{
	partial class Title
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
			this.ButtonCustomer = new System.Windows.Forms.Button();
			this.LabelGender = new System.Windows.Forms.Label();
			this.TextBoxCustomer = new System.Windows.Forms.TextBox();
			this.RadioButtonM = new System.Windows.Forms.RadioButton();
			this.LabelCustomer = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.LabelFee = new System.Windows.Forms.Label();
			this.LabelReason = new System.Windows.Forms.Label();
			this.RadioButtonF = new System.Windows.Forms.RadioButton();
			this.GroupInfo = new System.Windows.Forms.GroupBox();
			this.GroupResult = new System.Windows.Forms.GroupBox();
			this.LabelFeeR = new System.Windows.Forms.Label();
			this.LabelReasonR = new System.Windows.Forms.Label();
			this.LabeGenderT = new System.Windows.Forms.Label();
			this.GroupInfo.SuspendLayout();
			this.GroupResult.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonCustomer
			// 
			this.ButtonCustomer.Location = new System.Drawing.Point(40, 108);
			this.ButtonCustomer.Name = "ButtonCustomer";
			this.ButtonCustomer.Size = new System.Drawing.Size(75, 23);
			this.ButtonCustomer.TabIndex = 0;
			this.ButtonCustomer.Text = "計算";
			this.ButtonCustomer.UseVisualStyleBackColor = true;
			this.ButtonCustomer.Click += new System.EventHandler(this.ButtonCustomer_Click);
			// 
			// LabelGender
			// 
			this.LabelGender.AutoSize = true;
			this.LabelGender.Location = new System.Drawing.Point(216, 51);
			this.LabelGender.Name = "LabelGender";
			this.LabelGender.Size = new System.Drawing.Size(29, 12);
			this.LabelGender.TabIndex = 1;
			this.LabelGender.Text = "性別";
			// 
			// TextBoxCustomer
			// 
			this.TextBoxCustomer.Location = new System.Drawing.Point(40, 51);
			this.TextBoxCustomer.Name = "TextBoxCustomer";
			this.TextBoxCustomer.Size = new System.Drawing.Size(100, 22);
			this.TextBoxCustomer.TabIndex = 2;
			// 
			// RadioButtonM
			// 
			this.RadioButtonM.AutoSize = true;
			this.RadioButtonM.Location = new System.Drawing.Point(243, 86);
			this.RadioButtonM.Name = "RadioButtonM";
			this.RadioButtonM.Size = new System.Drawing.Size(35, 16);
			this.RadioButtonM.TabIndex = 3;
			this.RadioButtonM.TabStop = true;
			this.RadioButtonM.Text = "男";
			this.RadioButtonM.UseVisualStyleBackColor = true;
			this.RadioButtonM.CheckedChanged += new System.EventHandler(this.RadioButtonM_CheckedChanged);
			// 
			// LabelCustomer
			// 
			this.LabelCustomer.AutoSize = true;
			this.LabelCustomer.Location = new System.Drawing.Point(1, 54);
			this.LabelCustomer.Name = "LabelCustomer";
			this.LabelCustomer.Size = new System.Drawing.Size(29, 12);
			this.LabelCustomer.TabIndex = 1;
			this.LabelCustomer.Text = "年齡";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(-349, -83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 12);
			this.label4.TabIndex = 1;
			this.label4.Text = "label1";
			// 
			// LabelFee
			// 
			this.LabelFee.AutoSize = true;
			this.LabelFee.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.LabelFee.Location = new System.Drawing.Point(39, 252);
			this.LabelFee.Name = "LabelFee";
			this.LabelFee.Size = new System.Drawing.Size(62, 31);
			this.LabelFee.TabIndex = 1;
			this.LabelFee.Text = "車資";
			// 
			// LabelReason
			// 
			this.LabelReason.AutoSize = true;
			this.LabelReason.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.LabelReason.Location = new System.Drawing.Point(39, 284);
			this.LabelReason.Name = "LabelReason";
			this.LabelReason.Size = new System.Drawing.Size(62, 31);
			this.LabelReason.TabIndex = 1;
			this.LabelReason.Text = "原因";
			// 
			// RadioButtonF
			// 
			this.RadioButtonF.AutoSize = true;
			this.RadioButtonF.Location = new System.Drawing.Point(349, 86);
			this.RadioButtonF.Name = "RadioButtonF";
			this.RadioButtonF.Size = new System.Drawing.Size(35, 16);
			this.RadioButtonF.TabIndex = 3;
			this.RadioButtonF.TabStop = true;
			this.RadioButtonF.Text = "女";
			this.RadioButtonF.UseVisualStyleBackColor = true;
			// 
			// GroupInfo
			// 
			this.GroupInfo.Controls.Add(this.LabeGenderT);
			this.GroupInfo.Controls.Add(this.RadioButtonF);
			this.GroupInfo.Controls.Add(this.RadioButtonM);
			this.GroupInfo.Controls.Add(this.ButtonCustomer);
			this.GroupInfo.Controls.Add(this.TextBoxCustomer);
			this.GroupInfo.Controls.Add(this.LabelGender);
			this.GroupInfo.Controls.Add(this.LabelCustomer);
			this.GroupInfo.Location = new System.Drawing.Point(9, 4);
			this.GroupInfo.Name = "GroupInfo";
			this.GroupInfo.Size = new System.Drawing.Size(431, 190);
			this.GroupInfo.TabIndex = 4;
			this.GroupInfo.TabStop = false;
			this.GroupInfo.Text = "客戶資訊";
			// 
			// GroupResult
			// 
			this.GroupResult.Controls.Add(this.LabelFeeR);
			this.GroupResult.Controls.Add(this.LabelReasonR);
			this.GroupResult.Location = new System.Drawing.Point(9, 215);
			this.GroupResult.Name = "GroupResult";
			this.GroupResult.Size = new System.Drawing.Size(431, 165);
			this.GroupResult.TabIndex = 4;
			this.GroupResult.TabStop = false;
			this.GroupResult.Text = "計算結果";
			// 
			// LabelFeeR
			// 
			this.LabelFeeR.AutoSize = true;
			this.LabelFeeR.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.LabelFeeR.Location = new System.Drawing.Point(111, 34);
			this.LabelFeeR.Name = "LabelFeeR";
			this.LabelFeeR.Size = new System.Drawing.Size(110, 31);
			this.LabelFeeR.TabIndex = 1;
			this.LabelFeeR.Text = "顯示結果";
			// 
			// LabelReasonR
			// 
			this.LabelReasonR.AutoSize = true;
			this.LabelReasonR.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.LabelReasonR.Location = new System.Drawing.Point(111, 69);
			this.LabelReasonR.Name = "LabelReasonR";
			this.LabelReasonR.Size = new System.Drawing.Size(110, 31);
			this.LabelReasonR.TabIndex = 1;
			this.LabelReasonR.Text = "顯示原因";
			// 
			// LabeGenderT
			// 
			this.LabeGenderT.AutoSize = true;
			this.LabeGenderT.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.LabeGenderT.Location = new System.Drawing.Point(250, 132);
			this.LabeGenderT.Name = "LabeGenderT";
			this.LabeGenderT.Size = new System.Drawing.Size(134, 31);
			this.LabeGenderT.TabIndex = 1;
			this.LabeGenderT.Text = "請選擇性別";
			this.LabeGenderT.Click += new System.EventHandler(this.LabeGenderT_Click);
			// 
			// Title
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 398);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.LabelReason);
			this.Controls.Add(this.LabelFee);
			this.Controls.Add(this.GroupInfo);
			this.Controls.Add(this.GroupResult);
			this.Name = "Title";
			this.Text = "Form1";
			this.GroupInfo.ResumeLayout(false);
			this.GroupInfo.PerformLayout();
			this.GroupResult.ResumeLayout(false);
			this.GroupResult.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonCustomer;
		private System.Windows.Forms.Label LabelGender;
		private System.Windows.Forms.TextBox TextBoxCustomer;
		private System.Windows.Forms.RadioButton RadioButtonM;
		private System.Windows.Forms.Label LabelCustomer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label LabelFee;
		private System.Windows.Forms.Label LabelReason;
		private System.Windows.Forms.RadioButton RadioButtonF;
		private System.Windows.Forms.GroupBox GroupInfo;
		private System.Windows.Forms.GroupBox GroupResult;
		private System.Windows.Forms.Label LabelFeeR;
		private System.Windows.Forms.Label LabelReasonR;
		private System.Windows.Forms.Label LabeGenderT;
	}
}

