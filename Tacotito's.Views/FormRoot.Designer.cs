namespace Tacotito_s.Views
{
	partial class FormRoot
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnTaco = new Button();
			button2 = new Button();
			button4 = new Button();
			button5 = new Button();
			menuStrip1 = new MenuStrip();
			menuToolStripMenuItem = new ToolStripMenuItem();
			venderToolStripMenuItem = new ToolStripMenuItem();
			crearToolStripMenuItem = new ToolStripMenuItem();
			configurarToolStripMenuItem = new ToolStripMenuItem();
			panel1 = new Panel();
			panel2 = new Panel();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// btnTaco
			// 
			btnTaco.Location = new Point(12, 53);
			btnTaco.Name = "btnTaco";
			btnTaco.Size = new Size(146, 29);
			btnTaco.TabIndex = 7;
			btnTaco.Text = "Crear Taco";
			btnTaco.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(12, 88);
			button2.Name = "button2";
			button2.Size = new Size(146, 29);
			button2.TabIndex = 8;
			button2.Text = "Crear Ingrediente";
			button2.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Location = new Point(12, 123);
			button4.Name = "button4";
			button4.Size = new Size(146, 29);
			button4.TabIndex = 10;
			button4.Text = "Mostrar Pedido";
			button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			button5.Location = new Point(12, 158);
			button5.Name = "button5";
			button5.Size = new Size(146, 29);
			button5.TabIndex = 11;
			button5.Text = "button5";
			button5.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(731, 28);
			menuStrip1.TabIndex = 12;
			menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { venderToolStripMenuItem, crearToolStripMenuItem, configurarToolStripMenuItem });
			menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			menuToolStripMenuItem.Size = new Size(60, 24);
			menuToolStripMenuItem.Text = "Menu";
			// 
			// venderToolStripMenuItem
			// 
			venderToolStripMenuItem.Name = "venderToolStripMenuItem";
			venderToolStripMenuItem.Size = new Size(224, 26);
			venderToolStripMenuItem.Text = "Vender";
			venderToolStripMenuItem.Click += venderToolStripMenuItem_Click;
			// 
			// crearToolStripMenuItem
			// 
			crearToolStripMenuItem.Name = "crearToolStripMenuItem";
			crearToolStripMenuItem.Size = new Size(224, 26);
			crearToolStripMenuItem.Text = "Crear";
			// 
			// configurarToolStripMenuItem
			// 
			configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
			configurarToolStripMenuItem.Size = new Size(224, 26);
			configurarToolStripMenuItem.Text = "Configurar";
			// 
			// panel1
			// 
			panel1.Location = new Point(189, 31);
			panel1.Name = "panel1";
			panel1.Size = new Size(529, 188);
			panel1.TabIndex = 13;
			// 
			// panel2
			// 
			panel2.Location = new Point(12, 235);
			panel2.Name = "panel2";
			panel2.Size = new Size(706, 205);
			panel2.TabIndex = 14;
			// 
			// FormRoot
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(731, 450);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button2);
			Controls.Add(btnTaco);
			Controls.Add(menuStrip1);
			Name = "FormRoot";
			Text = "Home";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnTaco;
		private Button button2;
		private Button button4;
		private Button button5;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem menuToolStripMenuItem;
		private ToolStripMenuItem venderToolStripMenuItem;
		private ToolStripMenuItem crearToolStripMenuItem;
		private ToolStripMenuItem configurarToolStripMenuItem;
		private Panel panel1;
		private Panel panel2;
	}
}