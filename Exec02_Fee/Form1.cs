using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec02_Fee
{
	public partial class Title : Form
	{
		public Title()
		{
			InitializeComponent();
			//根據客戶性別及年齡計算應付車資, 規則如下:
			//嬰 <= 3 零元
			//男 >= 70, 男, 2元
			//女 >= 60, 女, 3元
			//其他 全票, 15元
			
			LabeGenderT.Visible = false;

		}

		private void ButtonCustomer_Click(object sender, EventArgs e)
		{

			int enphant = 0;
			int oldMan = 2;
			int oldWoman = 3;
			int adault = 15;

			string en = "因為在三歲以下";
			string oM = "因為是大於70歲男性";
			string oW = "因為是大於60歲女性";
			string ad = "因為非優待票";



			//input verified
			int input;
			string enter = TextBoxCustomer.Text;
			bool verified = string.IsNullOrEmpty(enter);
			bool verifiedN = int.TryParse(enter,out input);
			
			if (verified == true || verifiedN == false)
			{
				MessageBox.Show("請輸入年齡，並選擇性別");
				return;
			}
		

			if (Convert.ToInt32(enter)<0 )
			{
				MessageBox.Show("請輸入正確的年齡");
				return;
			}
			
			if((RadioButtonF.Checked =false) && (RadioButtonM.Checked= false))
			{
				LabeGenderT.Visible = true;
				return;

			}

			input = Convert.ToInt32(enter);


			//按照radio button 和輸入年齡顯示結果
			if (input >= 70 && RadioButtonM.Checked)
			{
				LabelFeeR.Text = $"車資是{oldMan}元";
				LabelReasonR.Text = oM;
			}
			else
				if (input >= 60 && RadioButtonF.Checked)
			{
				LabelFeeR.Text = $"車資是{oldWoman}元";
				LabelReasonR.Text = oW;
			}
			else
					if (input <= 3 && input >= 0)
			{
				LabelFeeR.Text = $"車資是{enphant}元";
				LabelReasonR.Text = en;
			}
			else
			{
				LabelFeeR.Text = $"車資是{adault}元";
				LabelReasonR.Text = ad;
			}

			

		}

		private void RadioButtonM_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void LabeGenderT_Click(object sender, EventArgs e)
		{

		}
	}
}
