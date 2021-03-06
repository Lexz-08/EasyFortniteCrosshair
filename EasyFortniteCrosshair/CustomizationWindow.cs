using AMS.Profile;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Transitions;

namespace EasyFortniteCrosshair
{
	public struct ImageProperties
	{
		public readonly int
			Width,
			Height,
			X,
			Y;
		public readonly bool Resize;

		private static Ini imageSettings;

		public ImageProperties(int Width, int Height, int X, int Y, bool Resize)
		{
			this.Width = Width;
			this.Height = Height;
			this.X = X;
			this.Y = Y;
			this.Resize = Resize;
		}
		public ImageProperties(ImageProperties ExistingImage)
		{
			Width = ExistingImage.Width;
			Height = ExistingImage.Height;
			X = ExistingImage.X;
			Y = ExistingImage.Y;
			Resize = ExistingImage.Resize;
		}

		public static ImageProperties CreateNew(int Width, int Height, int X, int Y, bool Resize)
		{
			return new ImageProperties(Width, Height, X, Y, Resize);
		}
		public static ImageProperties CreateFromExisting(ImageProperties ExistingImage)
		{
			return CreateNew(
				ExistingImage.Width,
				ExistingImage.Height,
				ExistingImage.X,
				ExistingImage.Y,
				ExistingImage.Resize);
		}

		public void ChangeProperties(int NewWidth, int NewHeight, int NewX, int NewY, bool NewResize)
		{
			this = CreateNew(NewWidth, NewHeight, NewX, NewY, NewResize);
			imageSettings.SetValue("Image", "Width", NewWidth);
			imageSettings.SetValue("Image", "Height", NewHeight);
			imageSettings.SetValue("Image", "X", NewX);
			imageSettings.SetValue("Image", "Y", NewY);
			imageSettings.SetValue("Image", "Resize", NewResize);
		}
		public void ChangeWidth(int NewWidth)
		{
			ChangeProperties(NewWidth, Height, X, Y, Resize);
		}
		public void ChangeHeight(int NewHeight)
		{
			ChangeProperties(Width, NewHeight, X, Y, Resize);
		}
		public void ChangeX(int NewX)
		{
			ChangeProperties(Width, Height, NewX, Y, Resize);
		}
		public void ChangeY(int NewY)
		{
			ChangeProperties(Width, Height, X, NewY, Resize);
		}
		public void ChangeResize(bool NewResize)
		{
			ChangeProperties(Width, Height, X, Y, NewResize);
		}

		public static ImageProperties LoadFromSettings()
		{
			imageSettings = new Ini(Application.StartupPath + "\\Settings\\Settings.ini");

			return CreateNew(
				Convert.ToInt32((string)imageSettings.GetValue("Image", "Width")),
				Convert.ToInt32((string)imageSettings.GetValue("Image", "Height")),
				Convert.ToInt32((string)imageSettings.GetValue("Image", "X")),
				Convert.ToInt32((string)imageSettings.GetValue("Image", "Y")),
				Convert.ToBoolean((string)imageSettings.GetValue("Image", "Resize")));
		}
		public void SaveToSettings()
		{
			imageSettings = new Ini(Application.StartupPath + "\\Settings\\Settings.ini");
			imageSettings.SetValue("Image", "Width", Width);
			imageSettings.SetValue("Image", "Height", Height);
			imageSettings.SetValue("Image", "X", X);
			imageSettings.SetValue("Image", "Y", Y);
			imageSettings.SetValue("Image", "Resize", Resize.ToString().ToLower());
		}
	}
	public struct WindowProperties
	{
		public readonly string Title;
		public readonly bool
			TopMost,
			ShowInTaskbar,
			ShowIconInWindow;

		private static Ini windowSettings;

		public WindowProperties(string Title, bool TopMost, bool ShowInTaskbar, bool ShowIconInWindow)
		{
			this.Title = Title;
			this.TopMost = TopMost;
			this.ShowInTaskbar = ShowInTaskbar;
			this.ShowIconInWindow = ShowIconInWindow;
		}
		public WindowProperties(WindowProperties ExistingWindow)
		{
			Title = ExistingWindow.Title;
			TopMost = ExistingWindow.TopMost;
			ShowInTaskbar = ExistingWindow.ShowInTaskbar;
			ShowIconInWindow = ExistingWindow.ShowIconInWindow;
		}

		public static WindowProperties CreateNew(string Title, bool TopMost, bool ShowInTaskbar, bool ShowIconInWindow)
		{
			return new WindowProperties(Title, TopMost, ShowInTaskbar, ShowIconInWindow);
		}
		public static WindowProperties CreateFromExisting(WindowProperties ExistingWindow)
		{
			return CreateNew(
				ExistingWindow.Title,
				ExistingWindow.TopMost,
				ExistingWindow.ShowInTaskbar,
				ExistingWindow.ShowIconInWindow);
		}

		public void ChangeProperties(string NewTitle, bool NewTopMost, bool NewShowInTaskbar, bool NewShowIconInWindow)
		{
			this = new WindowProperties(NewTitle, NewTopMost, NewShowInTaskbar, NewShowIconInWindow);
			windowSettings.SetValue("Window", "Title", NewTitle);
			windowSettings.SetValue("Window", "TopMost", NewTopMost);
			windowSettings.SetValue("Window", "ShowInTaskbar", NewShowInTaskbar);
			windowSettings.SetValue("Window", "ShowIconInWindow", NewShowIconInWindow);
		}
		public void ChangeTitle(string NewTitle)
		{
			ChangeProperties(NewTitle, TopMost, ShowInTaskbar, ShowIconInWindow);
		}
		public void ChangeTopMost(bool NewTopMost)
		{
			ChangeProperties(Title, NewTopMost, ShowInTaskbar, ShowIconInWindow);
		}
		public void ChangeShowInTaskbar(bool NewShowInTaskbar)
		{
			ChangeProperties(Title, TopMost, NewShowInTaskbar, ShowIconInWindow);
		}
		public void ChangeShowIconInWindow(bool NewShowIconInWindow)
		{
			ChangeProperties(Title, TopMost, ShowInTaskbar, NewShowIconInWindow);
		}

		public static WindowProperties LoadFromSettings()
		{
			windowSettings = new Ini(Application.StartupPath + "\\Settings\\Settings.ini");

			return CreateNew(
				(string)windowSettings.GetValue("Window", "Title"),
				Convert.ToBoolean((string)windowSettings.GetValue("Window", "TopMost")),
				Convert.ToBoolean((string)windowSettings.GetValue("Window", "ShowInTaskbar")),
				Convert.ToBoolean((string)windowSettings.GetValue("Window", "ShowIconInWindow")));
		}
		public void SaveToSettings()
		{
			windowSettings = new Ini(Application.StartupPath + "\\Settings\\Settings.ini");
			windowSettings.SetValue("Window", "Title", Title);
			windowSettings.SetValue("Window", "TopMost", TopMost.ToString().ToLower());
			windowSettings.SetValue("Window", "ShowInTaskbar", ShowInTaskbar.ToString().ToLower());
			windowSettings.SetValue("Window", "ShowIconInWindow", ShowIconInWindow.ToString().ToLower());
		}
	}

	public partial class CustomizationWindow : Form
	{
		[DllImport("gdi32")]
		private static extern IntPtr CreateRoundRectRgn(
			int nLeft,
			int nTop,
			int nRight,
			int nBottom,
			int nWidthEllipse,
			int nHeightEllipse);

		public CustomizationWindow()
		{
			InitializeComponent();
			DoubleBuffered = true;

			settings = new Ini(Application.StartupPath + "\\Settings\\Settings.ini");
			imageProperties = ImageProperties.LoadFromSettings();
			LoadSettings();

			imageWidth.ValueChanged += SaveSettings;
			imageHeight.ValueChanged += SaveSettings;
			imageX.ValueChanged += SaveSettings;
			imageY.ValueChanged += SaveSettings;
			imageResize.CheckedChanged += SaveSettings;

			windowTitle.TextChanged += SaveSettings;
			windowTopMost.CheckedChanged += SaveSettings;
			windowShowInTaskbar.CheckedChanged += SaveSettings;
			windowShowIconInWindow.CheckedChanged += SaveSettings;

			panel_minimize.Region = CreateRoundRgn(panel_minimize);
			panel_close.Region = CreateRoundRgn(panel_close);
		}

		private Region CreateRoundRgn(Control control)
		{
			return Region.FromHrgn(CreateRoundRectRgn(
				0, 0,
				control.Width + 1,
				control.Height + 1,
				3, 3));
		}

		private Ini settings;
		private static ImageProperties imageProperties;


		private void LoadSettings()
		{
			// load window things
			Icon = Resources.accuracy_ico;
			captionbar_icon.Image = Resources.accuracy_png;
			captionbar_title.Text = (string)settings.GetValue("Window", "Title");

			// load window properties
			WindowProperties windowProperties = WindowProperties.LoadFromSettings();
			Text = windowProperties.Title;
			TopMost = windowProperties.TopMost;
			ShowInTaskbar = windowProperties.ShowInTaskbar;
			ShowIcon = windowProperties.ShowIconInWindow;
			captionbar_icon.Visible = windowProperties.ShowIconInWindow;
			if (windowProperties.ShowIconInWindow)
			{
				captionbar_title.Location = new Point(34, 8);
			}
			else
			{
				int x = captionbar_title.Location.X;
				int y = captionbar_title.Location.Y;
				int xx = captionbar_icon.Location.X;

				int xxx = x + xx + captionbar_icon.Width;
				int xxxx = xxx - xx - (captionbar_icon.Width * 2) + 2;

				captionbar_title.Location = new Point(xxxx, y);
				captionbar_icon.Visible = false;
			}

			// load image settings stuffs into customizer
			imageWidth.Value = imageProperties.Width;
			imageHeight.Value = imageProperties.Height;
			imageX.Value = imageProperties.X;
			imageY.Value = imageProperties.Y;
			imageResize.Checked = imageProperties.Resize;

			// load window settings stuffs into customizer
			windowTitle.Text = windowProperties.Title;
			windowTopMost.Checked = windowProperties.TopMost;
			windowShowInTaskbar.Checked = windowProperties.ShowInTaskbar;
			windowShowIconInWindow.Checked = windowProperties.ShowIconInWindow;
		}
		private void SaveSettings(object sender, EventArgs e)
		{
			ImageProperties imgProps = GetImageProperties();
			imgProps.ChangeWidth((int)imageWidth.Value);
			imgProps.ChangeHeight((int)imageHeight.Value);
			imgProps.ChangeX((int)imageX.Value);
			imgProps.ChangeY((int)imageY.Value);
			imgProps.ChangeResize(imageResize.Checked);
			imgProps.SaveToSettings();
			imageProperties = imgProps;

			WindowProperties windowProperties = WindowProperties.LoadFromSettings();
			windowProperties.ChangeTitle(windowTitle.Text);
			captionbar_title.Text = windowTitle.Text;
			Text = windowTitle.Text;
			windowProperties.ChangeTopMost(windowTopMost.Checked);
			TopMost = windowTopMost.Checked;
			windowProperties.ChangeShowInTaskbar(windowShowInTaskbar.Checked);
			ShowInTaskbar = windowShowInTaskbar.Checked;
			windowProperties.ChangeShowIconInWindow(windowShowIconInWindow.Checked);
			if (windowProperties.ShowIconInWindow)
			{
				captionbar_title.Location = new Point(34, 8);
				captionbar_icon.Visible = true;
			}
			else
			{
				int x = captionbar_title.Location.X;
				int y = captionbar_title.Location.Y;
				int xx = captionbar_icon.Location.X;

				int xxx = x + xx + captionbar_icon.Width;
				int xxxx = xxx - xx - (captionbar_icon.Width * 2) + 2;

				captionbar_title.Location = new Point(xxxx, y);
				captionbar_icon.Visible = false;
			}
			windowProperties.SaveToSettings();
			
		}

		public static ImageProperties GetImageProperties()
		{
			return imageProperties;
		}

		private void lbl_minimize_MouseEnter(object sender, System.EventArgs e)
		{
			Transition.run(lbl_minimize, "BackColor", Color.FromArgb(200, 200, 200), new TransitionType_Linear(50));
		}
		private void lbl_minimize_MouseLeave(object sender, System.EventArgs e)
		{
			Transition.run(lbl_minimize, "BackColor", Color.FromArgb(170, 170, 170), new TransitionType_Linear(50));
		}
		private void lbl_close_MouseEnter(object sender, System.EventArgs e)
		{
			Transition.run(lbl_close, "BackColor", Color.FromArgb(255, 100, 100), new TransitionType_Linear(50));
		}
		private void lbl_close_MouseLeave(object sender, System.EventArgs e)
		{
			Transition.run(lbl_close, "BackColor", Color.FromArgb(255, 70, 70), new TransitionType_Linear(50));
		}

		private void lbl_minimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		private void lbl_close_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		[DllImport("user32")]
		private static extern bool ReleaseCapture();

		[DllImport("user32")]
		private static extern int SendMessage(IntPtr handle, int msg, int wp, int lp);

		private void DragForm(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(Handle, 161, 2, 0);
		}

		private void systrayico_ExitApp_Click(object sender, EventArgs e)
		{
			systemTrayIcon.Visible = false;
			Environment.Exit(0);
		}

		[DllImport("user32")]
		private static extern IntPtr GetDC(IntPtr hWnd);

		private void DrawCrosshair()
		{
			try
			{
				while (true)
				{
					using (Graphics gfx = Graphics.FromHdc(GetDC(IntPtr.Zero)))
					{
						ImageProperties imageProperties = GetImageProperties();

						int width = imageProperties.Width;
						int height = imageProperties.Height;
						int x = imageProperties.X;
						int y = imageProperties.Y;
						bool resize = imageProperties.Resize;
						
						if (resize)
						{
							Rectangle scaledRect = new Rectangle(x, y, width, height);
							Rectangle borderRect = new Rectangle(x - 1, y - 1, width + 2, height + 2);

							gfx.FillRectangle(Brushes.Black, borderRect);
							gfx.FillRectangle(Brushes.White, scaledRect);
						}
						else
						{
							Rectangle unscaledRect = new Rectangle(x, y, 4, 4);
							Rectangle borderRect = new Rectangle(x - 1, y - 1, 2, 2);

							gfx.FillRectangle(Brushes.Black, borderRect);
							gfx.FillRectangle(Brushes.White, unscaledRect);
						}
					}
				}
			}
			catch
			{
				DrawCrosshair();
			}
		}
		private void confirmationSettings_Click(object sender, EventArgs e)
		{
			Visible = false;
			new Thread(new ThreadStart(DrawCrosshair)).Start();
		}
	}
}
