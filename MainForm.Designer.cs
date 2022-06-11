
namespace IroNote
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		System.ComponentModel.IContainer components = null;
		System.Windows.Forms.TextBox tbox;
		System.Windows.Forms.Panel pmenu;
		System.Windows.Forms.Panel pstat;
		System.Windows.Forms.Label lsep;
		System.Windows.Forms.Button blook;
		System.Windows.Forms.Button bfile;
		System.Windows.Forms.Button bset;
		System.Windows.Forms.Label lsep2;
		System.Windows.Forms.Label lline;
		System.Windows.Forms.Label lchar;
		System.Windows.Forms.Label lsep6;
		System.Windows.Forms.Label lpos;
		System.Windows.Forms.Label lsep4;
		System.Windows.Forms.Label lsep3;
		System.Windows.Forms.Label lvsep2;
		System.Windows.Forms.Label lvsep;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load method if it was changed manually.
		/// </summary>
		void InitializeComponent()
		{
			tbox = new System.Windows.Forms.TextBox();
			pmenu = new System.Windows.Forms.Panel();
			lvsep2 = new System.Windows.Forms.Label();
			lsep6 = new System.Windows.Forms.Label();
			bset = new System.Windows.Forms.Button();
			lsep2 = new System.Windows.Forms.Label();
			blook = new System.Windows.Forms.Button();
			lsep = new System.Windows.Forms.Label();
			bfile = new System.Windows.Forms.Button();
			pstat = new System.Windows.Forms.Panel();
			lvsep = new System.Windows.Forms.Label();
			lpos = new System.Windows.Forms.Label();
			lsep4 = new System.Windows.Forms.Label();
			lchar = new System.Windows.Forms.Label();
			lsep3 = new System.Windows.Forms.Label();
			lline = new System.Windows.Forms.Label();
			pmenu.SuspendLayout();
			pstat.SuspendLayout();
			SuspendLayout();
			// 
			// tbox
			// 
			tbox.BackColor = System.Drawing.Color.Coral;
			tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			tbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			tbox.Location = new System.Drawing.Point(-2, 22);
			tbox.MaxLength = 999999999;
			tbox.Multiline = true;
			tbox.Name = "tbox";
			tbox.Size = new System.Drawing.Size(641, 420);
			tbox.TabIndex = 2;
			tbox.TextChanged += new System.EventHandler(TboxTextChanged);
			// 
			// pmenu
			// 
			pmenu.Controls.Add(lvsep2);
			pmenu.Controls.Add(lsep6);
			pmenu.Controls.Add(bset);
			pmenu.Controls.Add(lsep2);
			pmenu.Controls.Add(blook);
			pmenu.Controls.Add(lsep);
			pmenu.Controls.Add(bfile);
			pmenu.Location = new System.Drawing.Point(0, 0);
			pmenu.Name = "pmenu";
			pmenu.Size = new System.Drawing.Size(641, 22);
			pmenu.TabIndex = 3;
			// 
			// lvsep2
			// 
			lvsep2.BackColor = System.Drawing.SystemColors.HotTrack;
			lvsep2.Location = new System.Drawing.Point(0, 21);
			lvsep2.Name = "lvsep2";
			lvsep2.Size = new System.Drawing.Size(641, 1);
			lvsep2.TabIndex = 12;
			// 
			// lsep6
			// 
			lsep6.BackColor = System.Drawing.SystemColors.MenuHighlight;
			lsep6.Dock = System.Windows.Forms.DockStyle.Left;
			lsep6.Location = new System.Drawing.Point(186, 0);
			lsep6.Name = "lsep6";
			lsep6.Size = new System.Drawing.Size(1, 22);
			lsep6.TabIndex = 7;
			lsep6.Text = "label1";
			// 
			// bset
			// 
			bset.AutoSize = true;
			bset.Dock = System.Windows.Forms.DockStyle.Left;
			bset.FlatAppearance.BorderSize = 0;
			bset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			bset.Location = new System.Drawing.Point(111, 0);
			bset.Name = "bset";
			bset.Size = new System.Drawing.Size(75, 22);
			bset.TabIndex = 6;
			bset.Text = "Settings";
			bset.UseVisualStyleBackColor = true;
			// 
			// lsep2
			// 
			lsep2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			lsep2.Dock = System.Windows.Forms.DockStyle.Left;
			lsep2.Location = new System.Drawing.Point(110, 0);
			lsep2.Name = "lsep2";
			lsep2.Size = new System.Drawing.Size(1, 22);
			lsep2.TabIndex = 5;
			lsep2.Text = "label1";
			// 
			// blook
			// 
			blook.AutoSize = true;
			blook.BackColor = System.Drawing.SystemColors.Control;
			blook.Dock = System.Windows.Forms.DockStyle.Left;
			blook.FlatAppearance.BorderSize = 0;
			blook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			blook.Location = new System.Drawing.Point(35, 0);
			blook.Name = "blook";
			blook.Size = new System.Drawing.Size(75, 22);
			blook.TabIndex = 4;
			blook.Text = "Appearance";
			blook.UseVisualStyleBackColor = false;
			blook.Click += new System.EventHandler(BlookClick);
			// 
			// lsep
			// 
			lsep.BackColor = System.Drawing.SystemColors.MenuHighlight;
			lsep.Dock = System.Windows.Forms.DockStyle.Left;
			lsep.Location = new System.Drawing.Point(34, 0);
			lsep.Name = "lsep";
			lsep.Size = new System.Drawing.Size(1, 22);
			lsep.TabIndex = 1;
			lsep.Text = "label1";
			// 
			// bfile
			// 
			bfile.AutoSize = true;
			bfile.Dock = System.Windows.Forms.DockStyle.Left;
			bfile.FlatAppearance.BorderSize = 0;
			bfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			bfile.Location = new System.Drawing.Point(0, 0);
			bfile.Name = "bfile";
			bfile.Size = new System.Drawing.Size(34, 22);
			bfile.TabIndex = 0;
			bfile.Text = "File";
			bfile.UseVisualStyleBackColor = true;
			bfile.Click += new System.EventHandler(BfileClick);
			// 
			// pstat
			// 
			pstat.Controls.Add(lvsep);
			pstat.Controls.Add(lpos);
			pstat.Controls.Add(lsep4);
			pstat.Controls.Add(lchar);
			pstat.Controls.Add(lsep3);
			pstat.Controls.Add(lline);
			pstat.Location = new System.Drawing.Point(0, 442);
			pstat.Name = "pstat";
			pstat.Size = new System.Drawing.Size(641, 24);
			pstat.TabIndex = 4;
			// 
			// lvsep
			// 
			lvsep.BackColor = System.Drawing.SystemColors.HotTrack;
			lvsep.Location = new System.Drawing.Point(0, 0);
			lvsep.Name = "lvsep";
			lvsep.Size = new System.Drawing.Size(641, 1);
			lvsep.TabIndex = 11;
			// 
			// lpos
			// 
			lpos.AutoSize = true;
			lpos.Dock = System.Windows.Forms.DockStyle.Left;
			lpos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lpos.Location = new System.Drawing.Point(119, 0);
			lpos.Name = "lpos";
			lpos.Size = new System.Drawing.Size(76, 20);
			lpos.TabIndex = 10;
			lpos.Text = "Position: 0";
			// 
			// lsep4
			// 
			lsep4.BackColor = System.Drawing.SystemColors.MenuHighlight;
			lsep4.Dock = System.Windows.Forms.DockStyle.Left;
			lsep4.Location = new System.Drawing.Point(118, 0);
			lsep4.Name = "lsep4";
			lsep4.Size = new System.Drawing.Size(1, 24);
			lsep4.TabIndex = 9;
			lsep4.Text = "label1";
			// 
			// lchar
			// 
			lchar.AutoSize = true;
			lchar.Dock = System.Windows.Forms.DockStyle.Left;
			lchar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lchar.Location = new System.Drawing.Point(58, 0);
			lchar.Name = "lchar";
			lchar.Size = new System.Drawing.Size(60, 20);
			lchar.TabIndex = 8;
			lchar.Text = "Chars: 0";
			// 
			// lsep3
			// 
			lsep3.BackColor = System.Drawing.SystemColors.MenuHighlight;
			lsep3.Dock = System.Windows.Forms.DockStyle.Left;
			lsep3.Location = new System.Drawing.Point(57, 0);
			lsep3.Name = "lsep3";
			lsep3.Size = new System.Drawing.Size(1, 24);
			lsep3.TabIndex = 7;
			lsep3.Text = "label1";
			// 
			// lline
			// 
			lline.AutoSize = true;
			lline.Dock = System.Windows.Forms.DockStyle.Left;
			lline.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lline.Location = new System.Drawing.Point(0, 0);
			lline.Name = "lline";
			lline.Size = new System.Drawing.Size(57, 20);
			lline.TabIndex = 5;
			lline.Text = "Lines: 1";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(641, 463);
			Controls.Add(tbox);
			Controls.Add(pstat);
			Controls.Add(pmenu);
			Name = "MainForm";
			ShowIcon = false;
			Text = "IroNote";
			FormClosing += new System.Windows.Forms.FormClosingEventHandler(MainFormFormClosing);
			SizeChanged += new System.EventHandler(MainFormSizeChanged);
			pmenu.ResumeLayout(false);
			pmenu.PerformLayout();
			pstat.ResumeLayout(false);
			pstat.PerformLayout();
			ResumeLayout(false);
			PerformLayout();

		}
	}
}
