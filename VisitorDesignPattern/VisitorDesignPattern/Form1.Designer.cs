namespace VisitorDesignPattern
{
	partial class Form1
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnyogurt = new System.Windows.Forms.Button();
			this.btnmilk = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnbanana = new System.Windows.Forms.Button();
			this.btnorng = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btntomate = new System.Windows.Forms.Button();
			this.btncucumber = new System.Windows.Forms.Button();
			this.btndiscount = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(414, 37);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(190, 212);
			this.listBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(55, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Dairy";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(57, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Fruit";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(221, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Veg";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
			this.panel1.Controls.Add(this.btnyogurt);
			this.panel1.Controls.Add(this.btnmilk);
			this.panel1.Location = new System.Drawing.Point(17, 55);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(139, 100);
			this.panel1.TabIndex = 4;
			// 
			// btnyogurt
			// 
			this.btnyogurt.Location = new System.Drawing.Point(29, 41);
			this.btnyogurt.Name = "btnyogurt";
			this.btnyogurt.Size = new System.Drawing.Size(75, 23);
			this.btnyogurt.TabIndex = 8;
			this.btnyogurt.Text = "Yogurt";
			this.btnyogurt.UseVisualStyleBackColor = true;
			this.btnyogurt.Click += new System.EventHandler(this.btnyogurt_Click);
			// 
			// btnmilk
			// 
			this.btnmilk.Location = new System.Drawing.Point(29, 12);
			this.btnmilk.Name = "btnmilk";
			this.btnmilk.Size = new System.Drawing.Size(75, 23);
			this.btnmilk.TabIndex = 7;
			this.btnmilk.Text = "Milk";
			this.btnmilk.UseVisualStyleBackColor = true;
			this.btnmilk.Click += new System.EventHandler(this.btnmilk_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.PaleVioletRed;
			this.panel2.Controls.Add(this.btnbanana);
			this.panel2.Controls.Add(this.btnorng);
			this.panel2.Location = new System.Drawing.Point(22, 203);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(134, 100);
			this.panel2.TabIndex = 5;
			// 
			// btnbanana
			// 
			this.btnbanana.Location = new System.Drawing.Point(27, 41);
			this.btnbanana.Name = "btnbanana";
			this.btnbanana.Size = new System.Drawing.Size(75, 23);
			this.btnbanana.TabIndex = 10;
			this.btnbanana.Text = "Banana";
			this.btnbanana.UseVisualStyleBackColor = true;
			this.btnbanana.Click += new System.EventHandler(this.btnbanana_Click);
			// 
			// btnorng
			// 
			this.btnorng.Location = new System.Drawing.Point(27, 12);
			this.btnorng.Name = "btnorng";
			this.btnorng.Size = new System.Drawing.Size(75, 23);
			this.btnorng.TabIndex = 9;
			this.btnorng.Text = "Orange";
			this.btnorng.UseVisualStyleBackColor = true;
			this.btnorng.Click += new System.EventHandler(this.btnorng_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.PaleGreen;
			this.panel3.Controls.Add(this.btntomate);
			this.panel3.Controls.Add(this.btncucumber);
			this.panel3.Location = new System.Drawing.Point(186, 55);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(139, 100);
			this.panel3.TabIndex = 6;
			// 
			// btntomate
			// 
			this.btntomate.Location = new System.Drawing.Point(28, 41);
			this.btntomate.Name = "btntomate";
			this.btntomate.Size = new System.Drawing.Size(75, 23);
			this.btntomate.TabIndex = 12;
			this.btntomate.Text = "Tomato";
			this.btntomate.UseVisualStyleBackColor = true;
			this.btntomate.Click += new System.EventHandler(this.btntomate_Click);
			// 
			// btncucumber
			// 
			this.btncucumber.Location = new System.Drawing.Point(28, 12);
			this.btncucumber.Name = "btncucumber";
			this.btncucumber.Size = new System.Drawing.Size(75, 23);
			this.btncucumber.TabIndex = 11;
			this.btncucumber.Text = "Cucumber";
			this.btncucumber.UseVisualStyleBackColor = true;
			this.btncucumber.Click += new System.EventHandler(this.btncucumber_Click);
			// 
			// btndiscount
			// 
			this.btndiscount.Location = new System.Drawing.Point(35, 58);
			this.btndiscount.Name = "btndiscount";
			this.btndiscount.Size = new System.Drawing.Size(129, 39);
			this.btndiscount.TabIndex = 7;
			this.btndiscount.Text = "Show Discount";
			this.btndiscount.UseVisualStyleBackColor = true;
			this.btndiscount.Click += new System.EventHandler(this.btndiscount_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(3, 20);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(96, 17);
			this.radioButton1.TabIndex = 8;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Sales Discount";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(105, 20);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(106, 17);
			this.radioButton2.TabIndex = 9;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Golden Customer";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(441, 264);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 39);
			this.button1.TabIndex = 10;
			this.button1.Text = "Clear";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel4.Controls.Add(this.btndiscount);
			this.panel4.Controls.Add(this.radioButton1);
			this.panel4.Controls.Add(this.radioButton2);
			this.panel4.Location = new System.Drawing.Point(177, 190);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(216, 113);
			this.panel4.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 324);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnyogurt;
		private System.Windows.Forms.Button btnmilk;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnbanana;
		private System.Windows.Forms.Button btnorng;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btntomate;
		private System.Windows.Forms.Button btncucumber;
		private System.Windows.Forms.Button btndiscount;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel4;
	}
}

