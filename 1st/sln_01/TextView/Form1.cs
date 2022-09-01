using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextView
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string OrgStr = "";

		private void Form1_Load(object sender, EventArgs e)
		{
			OrgStr = this.lblResult.Text;
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (TextCheck() == true)
			{
				this.lblResult.Text = OrgStr + this.textEdit.Text;
			}
		}
		private void textEdit_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13) //엔터키를 누를 때
			{
				e.Handled = true; // 소리 없앰
				if (TextCheck() == true) { this.lblResult.Text = OrgStr + this.textEdit.Text; }
			}
		}
		private bool TextCheck()
		{
			if (this.textEdit.Text != "") return true;
			else
			{ 
				MessageBox.Show("텍스트를 입력하세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.textEdit.Focus(); 
				return false; 
			}
		}
	}
}
