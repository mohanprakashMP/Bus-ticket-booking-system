namespace Bus_ticket_bookijng_system.view
{
    partial class Add_bus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbusroute = new System.Windows.Forms.TextBox();
            this.txtbustype = new System.Windows.Forms.TextBox();
            this.txtbusdesc = new System.Windows.Forms.TextBox();
            this.txtbusno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bus Route";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "bus number ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "bus type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "bus description ";
            // 
            // txtbusroute
            // 
            this.txtbusroute.Location = new System.Drawing.Point(208, 77);
            this.txtbusroute.Name = "txtbusroute";
            this.txtbusroute.Size = new System.Drawing.Size(154, 22);
            this.txtbusroute.TabIndex = 4;
            // 
            // txtbustype
            // 
            this.txtbustype.Location = new System.Drawing.Point(208, 136);
            this.txtbustype.Name = "txtbustype";
            this.txtbustype.Size = new System.Drawing.Size(154, 22);
            this.txtbustype.TabIndex = 6;
            // 
            // txtbusdesc
            // 
            this.txtbusdesc.Location = new System.Drawing.Point(208, 209);
            this.txtbusdesc.Multiline = true;
            this.txtbusdesc.Name = "txtbusdesc";
            this.txtbusdesc.Size = new System.Drawing.Size(154, 66);
            this.txtbusdesc.TabIndex = 7;
            // 
            // txtbusno
            // 
            this.txtbusno.Location = new System.Drawing.Point(208, 31);
            this.txtbusno.Name = "txtbusno";
            this.txtbusno.Size = new System.Drawing.Size(154, 22);
            this.txtbusno.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = " CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Add_bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 370);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbusno);
            this.Controls.Add(this.txtbusdesc);
            this.Controls.Add(this.txtbustype);
            this.Controls.Add(this.txtbusroute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_bus";
            this.Text = "Add_bus";
            this.Load += new System.EventHandler(this.Add_bus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbusroute;
        private System.Windows.Forms.TextBox txtbustype;
        private System.Windows.Forms.TextBox txtbusdesc;
        private System.Windows.Forms.TextBox txtbusno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}