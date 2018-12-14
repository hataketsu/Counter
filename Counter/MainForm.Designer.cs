/*
 * Created by SharpDevelop.
 * User: Worker
 * Date: 11/16/2018
 * Time: 11:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Counter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button connect2;
		private System.Windows.Forms.ComboBox portsBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox portsBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button led2;
		private System.Windows.Forms.Button led1;
		private System.Windows.Forms.RichTextBox logger;
		private System.Windows.Forms.Label counter;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.IO.Ports.SerialPort serialPort1;
		private System.IO.Ports.SerialPort serialPort2;
		private System.Windows.Forms.Button connect1;
		
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
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.connect1 = new System.Windows.Forms.Button();
			this.led2 = new System.Windows.Forms.Button();
			this.led1 = new System.Windows.Forms.Button();
			this.portsBox2 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.connect2 = new System.Windows.Forms.Button();
			this.portsBox1 = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.logger = new System.Windows.Forms.RichTextBox();
			this.counter = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(1014, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Mã số sinh viên: 0xxxxxxxx";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1014, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Sinh viên thực hiện: Nguyễn Văn A";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(132, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(704, 117);
			this.label1.TabIndex = 8;
			this.label1.Text = "QUẢN LÝ NHÂN SỰ TRONG PHÒNG THÔNG QUA THẺ RFID KẾT NỐI MÁY TÍNH";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.connect1);
			this.groupBox3.Controls.Add(this.led2);
			this.groupBox3.Controls.Add(this.led1);
			this.groupBox3.Controls.Add(this.portsBox2);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.connect2);
			this.groupBox3.Controls.Add(this.portsBox1);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(502, 170);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(495, 292);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Kết nối";
			// 
			// connect1
			// 
			this.connect1.Location = new System.Drawing.Point(6, 99);
			this.connect1.Name = "connect1";
			this.connect1.Size = new System.Drawing.Size(483, 40);
			this.connect1.TabIndex = 14;
			this.connect1.Text = "Kết nối";
			this.connect1.UseVisualStyleBackColor = true;
			this.connect1.Click += new System.EventHandler(this.Connect1Click);
			// 
			// led2
			// 
			this.led2.BackColor = System.Drawing.Color.Lime;
			this.led2.Location = new System.Drawing.Point(147, 161);
			this.led2.Name = "led2";
			this.led2.Size = new System.Drawing.Size(51, 28);
			this.led2.TabIndex = 13;
			this.led2.UseVisualStyleBackColor = false;
			// 
			// led1
			// 
			this.led1.BackColor = System.Drawing.Color.Lime;
			this.led1.Location = new System.Drawing.Point(147, 26);
			this.led1.Name = "led1";
			this.led1.Size = new System.Drawing.Size(51, 28);
			this.led1.TabIndex = 12;
			this.led1.UseVisualStyleBackColor = false;
			// 
			// portsBox2
			// 
			this.portsBox2.FormattingEnabled = true;
			this.portsBox2.Location = new System.Drawing.Point(6, 195);
			this.portsBox2.Name = "portsBox2";
			this.portsBox2.Size = new System.Drawing.Size(483, 33);
			this.portsBox2.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(192, 31);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tên cổng 2";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// connect2
			// 
			this.connect2.Location = new System.Drawing.Point(6, 234);
			this.connect2.Name = "connect2";
			this.connect2.Size = new System.Drawing.Size(483, 40);
			this.connect2.TabIndex = 2;
			this.connect2.Text = "Kết nối";
			this.connect2.UseVisualStyleBackColor = true;
			this.connect2.Click += new System.EventHandler(this.Connect2Click);
			// 
			// portsBox1
			// 
			this.portsBox1.FormattingEnabled = true;
			this.portsBox1.Location = new System.Drawing.Point(6, 60);
			this.portsBox1.Name = "portsBox1";
			this.portsBox1.Size = new System.Drawing.Size(483, 33);
			this.portsBox1.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(6, 27);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(192, 31);
			this.label9.TabIndex = 0;
			this.label9.Text = "Tên cổng 1";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// logger
			// 
			this.logger.Location = new System.Drawing.Point(6, 30);
			this.logger.Name = "logger";
			this.logger.Size = new System.Drawing.Size(352, 206);
			this.logger.TabIndex = 12;
			this.logger.Text = "";
			// 
			// counter
			// 
			this.counter.Location = new System.Drawing.Point(6, 242);
			this.counter.Name = "counter";
			this.counter.Size = new System.Drawing.Size(339, 30);
			this.counter.TabIndex = 13;
			this.counter.Text = "Số người trong phòng:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.logger);
			this.groupBox1.Controls.Add(this.counter);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(70, 187);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(371, 275);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thẻ trong phòng ";
			// 
			// serialPort1
			// 
			this.serialPort1.ReadBufferSize = 10000;
			this.serialPort1.WriteBufferSize = 10000;
			// 
			// serialPort2
			// 
			this.serialPort2.ReadBufferSize = 10000;
			this.serialPort2.WriteBufferSize = 10000;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1033, 493);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "QUẢN LÝ NHÂN SỰ TRONG PHÒNG THÔNG QUA THẺ RFID KẾT NỐI MÁY TÍNH";
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
