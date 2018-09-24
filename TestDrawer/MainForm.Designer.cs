/*
 * Created by SharpDevelop.
 * User: Артем
 * Date: 30.08.2018
 * Time: 17:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TestDrawer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button DrawButton;
		private System.Windows.Forms.GroupBox groupBox1;
		
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		private System.Windows.Forms.PictureBox PictureBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox ShapeTypeComboBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown Y4UpDown;
		private System.Windows.Forms.NumericUpDown X4UpDown;
		private System.Windows.Forms.NumericUpDown Y3UpDown;
		private System.Windows.Forms.NumericUpDown X3UpDown;
		private System.Windows.Forms.NumericUpDown Y2UpDown;
		private System.Windows.Forms.NumericUpDown X2UpDown;
		private System.Windows.Forms.NumericUpDown Y1UpDown;
		private System.Windows.Forms.NumericUpDown X1UpDown;
		
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
		
		public void InitializeComponent()
		{
			this.ClearButton = new System.Windows.Forms.Button();
			this.DrawButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Y4UpDown = new System.Windows.Forms.NumericUpDown();
			this.X4UpDown = new System.Windows.Forms.NumericUpDown();
			this.Y3UpDown = new System.Windows.Forms.NumericUpDown();
			this.X3UpDown = new System.Windows.Forms.NumericUpDown();
			this.Y2UpDown = new System.Windows.Forms.NumericUpDown();
			this.X2UpDown = new System.Windows.Forms.NumericUpDown();
			this.Y1UpDown = new System.Windows.Forms.NumericUpDown();
			this.X1UpDown = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ShapeTypeComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.PictureBox = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Y4UpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.X4UpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Y3UpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.X3UpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Y2UpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.X2UpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Y1UpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.X1UpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ClearButton
			// 
			this.ClearButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ClearButton.Location = new System.Drawing.Point(3, 184);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(145, 22);
			this.ClearButton.TabIndex = 0;
			this.ClearButton.Text = "Очистить";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// DrawButton
			// 
			this.DrawButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.DrawButton.Location = new System.Drawing.Point(3, 16);
			this.DrawButton.Name = "DrawButton";
			this.DrawButton.Size = new System.Drawing.Size(145, 23);
			this.DrawButton.TabIndex = 1;
			this.DrawButton.Text = "Нарисовать";
			this.DrawButton.UseVisualStyleBackColor = true;
			this.DrawButton.Click += new System.EventHandler(this.DrawButtonClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Y4UpDown);
			this.groupBox1.Controls.Add(this.X4UpDown);
			this.groupBox1.Controls.Add(this.Y3UpDown);
			this.groupBox1.Controls.Add(this.X3UpDown);
			this.groupBox1.Controls.Add(this.Y2UpDown);
			this.groupBox1.Controls.Add(this.X2UpDown);
			this.groupBox1.Controls.Add(this.Y1UpDown);
			this.groupBox1.Controls.Add(this.X1UpDown);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.ShapeTypeComboBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.ClearButton);
			this.groupBox1.Controls.Add(this.DrawButton);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(151, 209);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Панель рисования";
			// 
			// Y4UpDown
			// 
			this.Y4UpDown.Location = new System.Drawing.Point(100, 154);
			this.Y4UpDown.Name = "Y4UpDown";
			this.Y4UpDown.Size = new System.Drawing.Size(44, 20);
			this.Y4UpDown.TabIndex = 29;
			// 
			// X4UpDown
			// 
			this.X4UpDown.Location = new System.Drawing.Point(25, 154);
			this.X4UpDown.Name = "X4UpDown";
			this.X4UpDown.Size = new System.Drawing.Size(41, 20);
			this.X4UpDown.TabIndex = 28;
			// 
			// Y3UpDown
			// 
			this.Y3UpDown.Location = new System.Drawing.Point(100, 128);
			this.Y3UpDown.Name = "Y3UpDown";
			this.Y3UpDown.Size = new System.Drawing.Size(44, 20);
			this.Y3UpDown.TabIndex = 27;
			// 
			// X3UpDown
			// 
			this.X3UpDown.Location = new System.Drawing.Point(25, 128);
			this.X3UpDown.Name = "X3UpDown";
			this.X3UpDown.Size = new System.Drawing.Size(41, 20);
			this.X3UpDown.TabIndex = 26;
			// 
			// Y2UpDown
			// 
			this.Y2UpDown.Location = new System.Drawing.Point(100, 101);
			this.Y2UpDown.Name = "Y2UpDown";
			this.Y2UpDown.Size = new System.Drawing.Size(44, 20);
			this.Y2UpDown.TabIndex = 25;
			// 
			// X2UpDown
			// 
			this.X2UpDown.Location = new System.Drawing.Point(25, 102);
			this.X2UpDown.Name = "X2UpDown";
			this.X2UpDown.Size = new System.Drawing.Size(41, 20);
			this.X2UpDown.TabIndex = 24;
			// 
			// Y1UpDown
			// 
			this.Y1UpDown.Location = new System.Drawing.Point(100, 75);
			this.Y1UpDown.Name = "Y1UpDown";
			this.Y1UpDown.Size = new System.Drawing.Size(44, 20);
			this.Y1UpDown.TabIndex = 23;
			// 
			// X1UpDown
			// 
			this.X1UpDown.Location = new System.Drawing.Point(25, 75);
			this.X1UpDown.Name = "X1UpDown";
			this.X1UpDown.Size = new System.Drawing.Size(41, 20);
			this.X1UpDown.TabIndex = 22;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(81, 154);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(20, 20);
			this.label8.TabIndex = 20;
			this.label8.Text = "Y4";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 154);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(22, 20);
			this.label7.TabIndex = 18;
			this.label7.Text = "X4";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(81, 128);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(20, 20);
			this.label6.TabIndex = 16;
			this.label6.Text = "Y3";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(22, 20);
			this.label5.TabIndex = 14;
			this.label5.Text = "X3";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(81, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 21);
			this.label4.TabIndex = 12;
			this.label4.Text = "Y2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "X2";
			// 
			// ShapeTypeComboBox
			// 
			this.ShapeTypeComboBox.FormattingEnabled = true;
			this.ShapeTypeComboBox.Items.AddRange(new object[] {
			"Круг",
			"Квадрат",
			"Треугольник",
			"Прямоугольник"});
			this.ShapeTypeComboBox.Location = new System.Drawing.Point(6, 48);
			this.ShapeTypeComboBox.Name = "ShapeTypeComboBox";
			this.ShapeTypeComboBox.Size = new System.Drawing.Size(138, 21);
			this.ShapeTypeComboBox.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(81, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 24);
			this.label2.TabIndex = 7;
			this.label2.Text = "Y1";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 18);
			this.label1.TabIndex = 6;
			this.label1.Text = "X1";
			// 
			// PictureBox
			// 
			this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PictureBox.Location = new System.Drawing.Point(151, 0);
			this.PictureBox.Name = "PictureBox";
			this.PictureBox.Size = new System.Drawing.Size(494, 209);
			this.PictureBox.TabIndex = 8;
			this.PictureBox.TabStop = false;
			this.PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxPaint);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 209);
			this.Controls.Add(this.PictureBox);
			this.Controls.Add(this.groupBox1);
			this.MinimumSize = new System.Drawing.Size(653, 236);
			this.Name = "MainForm";
			this.Text = "TestDrawer";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Y4UpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.X4UpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Y3UpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.X3UpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Y2UpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.X2UpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Y1UpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.X1UpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
