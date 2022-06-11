using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace IroNote
{
	public partial class MainForm : Form
	{
		class theme {
			public Color bg;
			public Color fg;
			public Color ac;
		}

		FontConverter fcv = new FontConverter();
		string settings_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "set.txt");
		MainForm.theme myt = new MainForm.theme {
			bg = Color.White,
			fg = Color.Fuchsia,
			ac = Color.Red
		};

		ContextMenuStrip appm = new ContextMenuStrip();
		ContextMenuStrip filem = new ContextMenuStrip();

		public MainForm() {
			InitializeComponent();
			InitContextMenus();
			tbox.Text = "";
			Dark(null, null);
			LoadSettings();
		}

		void LoadSettings() {
			if (File.Exists(settings_file)) {
				string s = File.ReadAllText(settings_file);
				string[] array = s.Split(new []{'\n'});
				for (int j = 0; j < array.Length; j++) {
					string i = array[j];
					if (i.Length >= 1) {
						string[] kv = i.Split(new []{'='}, 2);
						string[] xx = kv[1].Split(new []{','});
						if (kv[0] == "theme") {
							myt = new MainForm.theme {
								bg = ColorTranslator.FromHtml(xx[0]),
								fg = ColorTranslator.FromHtml(xx[1]),
								ac = ColorTranslator.FromHtml(xx[2])
							};
							ApplyChanges();
						}
						if (kv[0] == "font") {
							tbox.Font = (Font)fcv.ConvertFromString(kv[1]);
						}
						if (kv[0] == "size") {
							int w, h;
							int.TryParse(xx[0], out w);
							int.TryParse(xx[1], out h);
							base.Height = h;
							base.Width = w;
						}
						if (kv[0] == "pos") {
							int x, y;
							int.TryParse(xx[0], out x);
							int.TryParse(xx[1], out y);
							base.Location = new Point(x, y);
						}
					}
				}
			}
		}

		string GenEntry(string key, string value) {
			return GenEntry(key, new string[]{ value });
		}

		string GenEntry(string key, string[] values) {
			string s = key + "=";
			for (int i = 0; i != values.Length; i++) {
				s = s + values[i] + ((i + 1 == values.Length) ? "" : ",");
			}
			return s + "\n";
		}

		void SaveSettings() {
			string s = GenEntry("theme", new string[] {
				ColorTranslator.ToHtml(myt.bg),
				ColorTranslator.ToHtml(myt.fg),
				ColorTranslator.ToHtml(myt.ac)
			});
			s += GenEntry("font", fcv.ConvertToString(tbox.Font));
			s += GenEntry("size", new string[] {
				base.Width.ToString(),
				base.Height.ToString()
			});
			s += GenEntry("pos", new string[] {
				base.Location.X.ToString(),
				base.Location.Y.ToString()
			});
			File.WriteAllText(settings_file, s);
		}

		void InitContextMenus() {
			appm.RenderMode = ToolStripRenderMode.System;
			appm.Items.Add("Dark", null, new EventHandler(Dark));
			appm.Items.Add("Light", null, new EventHandler(Light));
			appm.Items.Add("Custom", null, new EventHandler(Custom));
			appm.Items.Add("Font", null, new EventHandler(FontSelect));
			appm.Closing += (_, __) => {
				blook.BackColor = DarkenColor(myt.bg);
				if (myt.ac == myt.fg) {
					blook.ForeColor = myt.fg;
				}
			};
			filem.RenderMode = ToolStripRenderMode.System;
			filem.Items.Add("Save", null, new EventHandler(Save));
			filem.Items.Add("Exit", null, (_, __) => {
               	SaveSettings();
				Application.Exit();
			});
			filem.Closing += (_, __) => {
				bfile.BackColor = DarkenColor(myt.bg);
				if (myt.ac == myt.fg) {
					bfile.ForeColor = myt.fg;
				}
			};
		}

		void Save(object sender, EventArgs e) {
			SaveFileDialog fsd = new SaveFileDialog();
			fsd.DefaultExt = "txt";
			fsd.Filter = "txt (*.txt)|*.txt|ini (*.ini)|*.ini|Any (*.*)|*.*";
			fsd.FileName = "no name";
			if (fsd.ShowDialog() == DialogResult.OK) {
				File.WriteAllText(fsd.FileName, tbox.Text, Encoding.UTF8);
			}
		}

		void FontSelect(object sender, EventArgs e) {
			FontDialog fd = new FontDialog();
			fd.Font = tbox.Font;
			if (fd.ShowDialog() == DialogResult.OK) {
				tbox.Font = fd.Font;
			}
		}

		void Dark(object sender, EventArgs e) {
			myt = new MainForm.theme {
				bg = Color.Black,
				fg = Color.YellowGreen,
				ac = Color.YellowGreen
			};
			ApplyChanges();
		}

		void Light(object sender, EventArgs e) {
			myt = new MainForm.theme {
				bg = Color.White,
				fg = Color.Black,
				ac = Color.Red
			};
			ApplyChanges();
		}

		void Custom(object sender, EventArgs e) {
			Color a = myt.bg;
			Color b = myt.fg;
			Color c = myt.ac;
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == DialogResult.OK) {
				a = cd.Color;
			} else return;
			if (cd.ShowDialog() == DialogResult.OK) {
				b = cd.Color;
			} else return;
			if (cd.ShowDialog() == DialogResult.OK) {
				c = cd.Color;
			} else return;
			myt = new MainForm.theme {
				bg = a, fg = b, ac = c
			};
			ApplyChanges();
		}

		Color DarkenColor(Color c) {
			int i = ColorTranslator.ToWin32(c);
			int r = (i & 255) - 25;
			int g = (i >> 8 & 255) - 25;
			int b = (i >> 16 & 255) - 25;
			if (r < 0) r = 0;
			if (g < 0) g = 0;
			if (b < 0) b = 0;
			if (r == 0 && g == 0 && b == 0) {
				r = g = b = 25;
			}
			return Color.FromArgb(255, r, g, b);
		}

		void ApplyChanges() {
			BackColor = tbox.BackColor = appm.BackColor = filem.BackColor = myt.bg;
			tbox.ForeColor = ForeColor = pstat.ForeColor = appm.ForeColor = filem.ForeColor = myt.fg;
			pmenu.BackColor = pstat.BackColor = DarkenColor(myt.bg);
			foreach (Control c in pmenu.Controls) {
				if (c.Name.StartsWith("lsep") || c.Name.StartsWith("lvsep")) {
					c.BackColor = myt.ac;
				}
				else if (c.Name.StartsWith("b")) {
					c.BackColor = pstat.BackColor;
					c.ForeColor = myt.fg;
				}
			}
			foreach (Control c in pstat.Controls) {
				if (c.Name.StartsWith("lsep") || c.Name.StartsWith("lvsep")) {
					c.BackColor = myt.ac;
				}
				else if (c.Name.StartsWith("b")) {
					c.BackColor = pstat.BackColor;
					c.ForeColor = myt.fg;
				}
			}
		}

		void MainFormSizeChanged(object sender, EventArgs e) {
			tbox.Width = pmenu.Width = pstat.Width = lvsep.Width = lvsep2.Width = base.Width;
			tbox.Height = base.Height - pstat.Height - pmenu.Height - 
				(base.Height - base.RectangleToScreen(base.ClientRectangle).Height) + 3;
			pstat.Top = tbox.Height + pmenu.Height;
		}

		void BlookClick(object sender, EventArgs e) {
			blook.BackColor = myt.ac;
			if (myt.ac == myt.fg) {
				blook.ForeColor = Color.White;
			}
			appm.Show(Cursor.Position);
		}

		void TboxTextChanged(object sender, EventArgs e) {
			lline.Text = "Lines: " + tbox.Lines.Length;
			lchar.Text = "Chars: " + tbox.Text.Replace("\r", "").Length;
			int ist = tbox.GetFirstCharIndexFromLine(tbox.GetLineFromCharIndex(tbox.SelectionStart));
			lpos.Text = "Position: " + checked(tbox.SelectionStart - ist);
		}

		void BfileClick(object sender, EventArgs e) {
			bfile.BackColor = myt.ac;
			if (myt.ac == myt.fg) {
				bfile.ForeColor = Color.White;
			}
			filem.Show(Cursor.Position);
		}

		void MainFormFormClosing(object sender, FormClosingEventArgs e) {
			SaveSettings();
		}
	}
}
