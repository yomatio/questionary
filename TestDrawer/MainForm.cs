/*
 * Created by SharpDevelop.
 * User: Артем
 * Date: 30.08.2018
 * Time: 17:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TestDrawer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private readonly IList<ICommandProvider> commandProviders = new List<ICommandProvider>();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

		}
		void PictureBoxPaint(object sender, PaintEventArgs e)
		{
		    foreach (var commandProvider in commandProviders)
			{
		    	commandProvider.GetDrawCommand(e.Graphics).Execute();
			}
		}
		void ClearButtonClick(object sender, EventArgs e)
		{
			commandProviders.Clear();			
			PictureBox.Invalidate();
		}

		void DrawButtonClick(object sender, EventArgs e)
		{
		
			switch (ShapeTypeComboBox.Text)
			{
				case "Круг":
					commandProviders.Add(new CommandProvider<Circle>(new Circle(Convert.ToInt32(this.X1UpDown.Value), Convert.ToInt32(this.Y1UpDown.Value), Convert.ToInt32(this.X2UpDown.Value))));
					break;
				case "Квадрат":
					commandProviders.Add(new CommandProvider<Square>(new Square(Convert.ToInt32(this.X1UpDown.Value), Convert.ToInt32(this.Y1UpDown.Value), Convert.ToInt32(this.X2UpDown.Value))));
					break;
				case "Треугольник":
					commandProviders.Add(new CommandProvider<Triangle>(new Triangle(Convert.ToInt32(this.X1UpDown.Value), Convert.ToInt32(this.Y1UpDown.Value), Convert.ToInt32(this.X2UpDown.Value), Convert.ToInt32(this.Y2UpDown.Value), Convert.ToInt32(this.X3UpDown.Value), Convert.ToInt32(this.Y3UpDown.Value))));
					break;
				case "Прямоугольник":
					commandProviders.Add(new CommandProvider<Polygon>(new Polygon(Convert.ToInt32(this.X1UpDown.Value), Convert.ToInt32(this.Y1UpDown.Value), Convert.ToInt32(this.X3UpDown.Value), Convert.ToInt32(this.Y3UpDown.Value))));
					break;
			}
			PictureBox.Invalidate();
		}
	}
}
