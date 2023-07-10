namespace Tacotito_s.Views
{
	partial class FormCreateTaco
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
			btnAgregar = new Button();
			label2 = new Label();
			label1 = new Label();
			lblTacoCreated = new Label();
			comboBox1 = new ComboBox();
			comboBox2 = new ComboBox();
			SuspendLayout();
			// 
			// btnAgregar
			// 
			btnAgregar.Location = new Point(455, 120);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(94, 29);
			btnAgregar.TabIndex = 8;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(49, 87);
			label2.Name = "label2";
			label2.Size = new Size(85, 20);
			label2.TabIndex = 7;
			label2.Text = "Ingrediente";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(32, 61);
			label1.Name = "label1";
			label1.Size = new Size(119, 20);
			label1.TabIndex = 6;
			label1.Text = "Tipo Ingrediente";
			// 
			// lblTacoCreated
			// 
			lblTacoCreated.AutoSize = true;
			lblTacoCreated.Location = new Point(32, 161);
			lblTacoCreated.Name = "lblTacoCreated";
			lblTacoCreated.Size = new Size(65, 20);
			lblTacoCreated.TabIndex = 11;
			lblTacoCreated.Text = "Creaste: ";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Tortilla", "Relleno", "Salsa" });
			comboBox1.Location = new Point(170, 52);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(379, 28);
			comboBox1.TabIndex = 12;
			comboBox1.SelectedIndex = 0;
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(170, 84);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(379, 28);
			comboBox2.TabIndex = 13;
			// 
			// FormCreateTaco
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 212);
			Controls.Add(comboBox2);
			Controls.Add(comboBox1);
			Controls.Add(lblTacoCreated);
			Controls.Add(btnAgregar);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FormCreateTaco";
			Text = "FormCreateTaco";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox2;
		private TextBox textBox1;
		private Button btnAgregar;
		private Label label2;
		private Label label1;
		private Label lblTacoCreated;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
	}
}