
namespace Lab1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTask = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.status = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.canvas = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelXIncline = new System.Windows.Forms.Label();
			this.labelYIncline = new System.Windows.Forms.Label();
			this.labelZIncline = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelXScaling = new System.Windows.Forms.Label();
			this.labelYScaling = new System.Windows.Forms.Label();
			this.labelZScaling = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.labelXTransfer = new System.Windows.Forms.Label();
			this.labelYTransfer = new System.Windows.Forms.Label();
			this.labelZTransfer = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItemFile
			// 
			this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTask});
			this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
			this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
			this.toolStripMenuItemFile.Text = "File";
			// 
			// toolStripMenuItemTask
			// 
			this.toolStripMenuItemTask.Name = "toolStripMenuItemTask";
			this.toolStripMenuItemTask.Size = new System.Drawing.Size(96, 22);
			this.toolStripMenuItemTask.Text = "Task";
			// 
			// toolStripMenuItemHelp
			// 
			this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
			this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
			this.toolStripMenuItemHelp.Text = "Help";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
			this.statusStrip1.Location = new System.Drawing.Point(0, 593);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// status
			// 
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(78, 17);
			this.status.Text = "status default";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.canvas, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 569);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// canvas
			// 
			this.canvas.BackColor = System.Drawing.Color.White;
			this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.canvas.Location = new System.Drawing.Point(3, 130);
			this.canvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.canvas.Name = "canvas";
			this.canvas.Size = new System.Drawing.Size(794, 437);
			this.canvas.TabIndex = 0;
			this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 2);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(794, 124);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "TaskBar";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.groupBox3, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.groupBox4, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 104);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.labelZTransfer);
			this.groupBox2.Controls.Add(this.labelYTransfer);
			this.groupBox2.Controls.Add(this.labelXTransfer);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(4, 3);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(255, 98);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Перемещение";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.labelZScaling);
			this.groupBox3.Controls.Add(this.labelYScaling);
			this.groupBox3.Controls.Add(this.labelXScaling);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(266, 3);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Size = new System.Drawing.Size(255, 98);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Масштабирование";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.labelZIncline);
			this.groupBox4.Controls.Add(this.labelYIncline);
			this.groupBox4.Controls.Add(this.labelXIncline);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(528, 3);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox4.Size = new System.Drawing.Size(256, 98);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Вращение";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Угол наклона по Х:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Угол наклона по Y:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Угол наклона по Z:";
			// 
			// labelXIncline
			// 
			this.labelXIncline.AutoSize = true;
			this.labelXIncline.Location = new System.Drawing.Point(125, 22);
			this.labelXIncline.Name = "labelXIncline";
			this.labelXIncline.Size = new System.Drawing.Size(38, 15);
			this.labelXIncline.TabIndex = 3;
			this.labelXIncline.Text = "label4";
			// 
			// labelYIncline
			// 
			this.labelYIncline.AutoSize = true;
			this.labelYIncline.Location = new System.Drawing.Point(125, 37);
			this.labelYIncline.Name = "labelYIncline";
			this.labelYIncline.Size = new System.Drawing.Size(38, 15);
			this.labelYIncline.TabIndex = 4;
			this.labelYIncline.Text = "label5";
			// 
			// labelZIncline
			// 
			this.labelZIncline.AutoSize = true;
			this.labelZIncline.Location = new System.Drawing.Point(125, 52);
			this.labelZIncline.Name = "labelZIncline";
			this.labelZIncline.Size = new System.Drawing.Size(38, 15);
			this.labelZIncline.TabIndex = 5;
			this.labelZIncline.Text = "label6";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "Увеличение по Х:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 15);
			this.label5.TabIndex = 1;
			this.label5.Text = "Увеличение по Y:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 52);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 15);
			this.label6.TabIndex = 2;
			this.label6.Text = "Увеличение по Z:";
			// 
			// labelXScaling
			// 
			this.labelXScaling.AutoSize = true;
			this.labelXScaling.Location = new System.Drawing.Point(116, 22);
			this.labelXScaling.Name = "labelXScaling";
			this.labelXScaling.Size = new System.Drawing.Size(38, 15);
			this.labelXScaling.TabIndex = 3;
			this.labelXScaling.Text = "label7";
			// 
			// labelYScaling
			// 
			this.labelYScaling.AutoSize = true;
			this.labelYScaling.Location = new System.Drawing.Point(116, 37);
			this.labelYScaling.Name = "labelYScaling";
			this.labelYScaling.Size = new System.Drawing.Size(38, 15);
			this.labelYScaling.TabIndex = 4;
			this.labelYScaling.Text = "label8";
			// 
			// labelZScaling
			// 
			this.labelZScaling.AutoSize = true;
			this.labelZScaling.Location = new System.Drawing.Point(116, 52);
			this.labelZScaling.Name = "labelZScaling";
			this.labelZScaling.Size = new System.Drawing.Size(38, 15);
			this.labelZScaling.TabIndex = 5;
			this.labelZScaling.Text = "label9";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 37);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(14, 15);
			this.label8.TabIndex = 1;
			this.label8.Text = "Y";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 52);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(97, 15);
			this.label9.TabIndex = 2;
			this.label9.Text = "Смещение по Х:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 15);
			this.label7.TabIndex = 0;
			this.label7.Text = "Смещение по Х:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 37);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(97, 15);
			this.label10.TabIndex = 1;
			this.label10.Text = "Смещение по Y:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 52);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(97, 15);
			this.label11.TabIndex = 2;
			this.label11.Text = "Смещение по Z:";
			// 
			// labelXTransfer
			// 
			this.labelXTransfer.AutoSize = true;
			this.labelXTransfer.Location = new System.Drawing.Point(110, 22);
			this.labelXTransfer.Name = "labelXTransfer";
			this.labelXTransfer.Size = new System.Drawing.Size(44, 15);
			this.labelXTransfer.TabIndex = 3;
			this.labelXTransfer.Text = "label12";
			// 
			// labelYTransfer
			// 
			this.labelYTransfer.AutoSize = true;
			this.labelYTransfer.Location = new System.Drawing.Point(110, 37);
			this.labelYTransfer.Name = "labelYTransfer";
			this.labelYTransfer.Size = new System.Drawing.Size(44, 15);
			this.labelYTransfer.TabIndex = 4;
			this.labelYTransfer.Text = "label13";
			// 
			// labelZTransfer
			// 
			this.labelZTransfer.AutoSize = true;
			this.labelZTransfer.Location = new System.Drawing.Point(109, 52);
			this.labelZTransfer.Name = "labelZTransfer";
			this.labelZTransfer.Size = new System.Drawing.Size(44, 15);
			this.labelZTransfer.TabIndex = 5;
			this.labelZTransfer.Text = "label14";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 615);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTask;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel status;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel canvas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label labelZTransfer;
		private System.Windows.Forms.Label labelYTransfer;
		private System.Windows.Forms.Label labelXTransfer;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label labelZScaling;
		private System.Windows.Forms.Label labelYScaling;
		private System.Windows.Forms.Label labelXScaling;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelZIncline;
		private System.Windows.Forms.Label labelYIncline;
		private System.Windows.Forms.Label labelXIncline;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
	}
}

