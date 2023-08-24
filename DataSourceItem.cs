using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportWizardPrototype
{
	public partial class DataSourceItem : UserControl
	{
		private Color _defaultColor = Color.FromArgb(241, 241, 241);

		public event EventHandler OnClick;
		public DataSourceItem()
		{
			InitializeComponent();
			SetChildrenHandlers();
		}
		private void RaisePlateAction(MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;
			OnClick?.Invoke(this, EventArgs.Empty);
		}

		#region Event Handlers Override

		protected override void OnMouseEnter(EventArgs e)
		{
			base.BackColor = HoverColor;
			base.OnMouseEnter(e);
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.BackColor = _defaultColor;
			base.OnMouseLeave(e);
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			RaisePlateAction(e);
			base.OnMouseUp(e);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left) return;
			base.OnMouseDown(e);
		}

		protected override void OnGotFocus(EventArgs e)
		{
			Refresh();
			base.OnGotFocus(e);
		}

		protected override void OnLostFocus(EventArgs e)
		{
			Refresh();
			base.OnLostFocus(e);
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
			if (Focused)
				DrawBorder(e.Graphics);
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			//for multiline description label
			_titleLabel.MaximumSize = new System.Drawing.Size(Width - _iconBox.Width - 10, 0);
		}

		protected override bool ProcessMnemonic(char charCode)
		{
			if (!IsMnemonic(charCode, Title))
				return base.ProcessMnemonic(charCode);

			RaisePlateAction(new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
			return true;
		}

		#endregion


		public override Color BackColor
		{
			get { return base.BackColor; }
			set { base.BackColor = value; _defaultColor = value; }
		}

		public Color FocusBorderColor { get; set; } = SystemColors.ControlDark; //Color.FromArgb(128, 128, 128);
		public Color HoverColor { get; set; } = SystemColors.Control; //Color.FromArgb(201, 201, 201);

		[Category("Data")]
		public Image Icon
		{
			get
			{
				return _iconBox.Image;
			}
			set
			{
				_iconBox.Image = value;
			}
		}


		[Category("Data")]
		[DefaultValue("Title")]
		public string Title
		{
			get
			{
				return _titleLabel.Text;
			}
			set
			{
				_titleLabel.Text = value;
			}
		}



		private void SetChildrenHandlers()
		{
			foreach (Control child in Controls)
			{
				child.MouseUp += (_, e) => RaisePlateAction(e);
				child.MouseEnter += (_, e) => OnMouseEnter(e);
				child.MouseLeave += (_, e) => OnMouseLeave(e);
				child.MouseDown += (_, e) => OnMouseDown(e);
			}
		}

		private void DrawBorder(Graphics g)
		{
			using (var pen = new Pen(FocusBorderColor, 2) { DashStyle = DashStyle.Solid })
				g.DrawRectangle(pen, ClientRectangle);
		}

	}
}
