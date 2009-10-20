using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StringUtils
{
	public partial class frmMain : Form
	{
		private bool txtDirty = false;

		public frmMain()
		{
			InitializeComponent();
		}

		private void txtString_TextChanged(object sender, EventArgs e)
		{
			txtDirty = true;
			if (txtString.Text.Length < Properties.Settings.Default.AutoRefreshLengthLimit)
			{
				btnRefreshAll_Click(txtString, EventArgs.Empty);
			}
		}

		#region Multiple refresh button click handlers

		private void btnRefreshAll_Click(object sender, EventArgs e)
		{
			if (txtDirty)
			{
				btnRefreshGeneral_Click(sender, e);
			}
		}

		private void btnRefreshGeneral_Click(object sender, EventArgs e)
		{
			if (txtDirty)
			{
				btnRefreshLength_Click(sender, e);
				btnRefreshLengthBytes_Click(sender, e);
			}
		}

		#endregion

		#region Individual refresh button click handlers

		#region General section refresh button click handlers

		private void btnRefreshLength_Click(object sender, EventArgs e)
		{
			if (txtDirty)
			{
				txtLength.Text = txtString.Text.Length.ToString();
			}
		}

		private void btnRefreshLengthBytes_Click(object sender, EventArgs e)
		{
			if (txtDirty)
			{
				txtLengthBytes.Text = Encoding.ASCII.GetByteCount(txtString.Text).ToString();
			}
		}

		#endregion

		#endregion
	}
}