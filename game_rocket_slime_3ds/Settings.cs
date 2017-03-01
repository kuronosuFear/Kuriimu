﻿using System;
using System.Drawing;
using System.Windows.Forms;
using game_rocket_slime_3ds.Properties;
using KuriimuContract;

namespace game_rocket_slime_3ds
{
	public partial class frmSettings : Form
	{
		#region Properties

		public bool HasChanges { get; set; } = false;

		#endregion

		public frmSettings(Icon icon)
		{
			InitializeComponent();

			Icon = icon;
		}

		private void EntryProperties_Load(object sender, EventArgs e)
		{
			txtPlayerName.Text = Settings.Default.PlayerName;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (Settings.Default.PlayerName != txtPlayerName.Text)
				HasChanges = true;

			if (HasChanges)
			{
				Settings.Default.PlayerName = txtPlayerName.Text;
				Settings.Default.Save();
			}

			DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}