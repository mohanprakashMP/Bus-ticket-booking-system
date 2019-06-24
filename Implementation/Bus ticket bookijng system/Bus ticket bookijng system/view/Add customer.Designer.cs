namespace Bus_ticket_bookijng_system.view
{
    partial class Add_customer
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
            this.txtcuname = new System.Windows.Forms.TextBox();
            this.txtcuaddress = new System.Windows.Forms.TextBox();
            this.txtcuphone = new System.Windows.Forms.TextBox();
            this.txtcuemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcuname
            // 
            this.txtcuname.Location = new System.Drawing.Point(294, 42);
            this.txtcuname.Name = "txtcuname";
            this.txtcuname.Size = new System.Drawing.Size(176, 22);
            this.txtcuname.TabIndex = 1;
            // 
            // txtcuaddress
            // 
            this.txtcuaddress.Location = new System.Drawing.Point(294, 105);
            this.txtcuaddress.Name = "txtcuaddress";
            this.txtcuaddress.Size = new System.Drawing.Size(176, 22);
            this.txtcuaddress.TabIndex = 2;
            // 
            // txtcuphone
            // 
            this.txtcuphone.Location = new System.Drawing.Point(294, 187);
            this.txtcuphone.Name = "txtcuphone";
            this.txtcuphone.Size = new System.Drawing.Size(176, 22);
            this.txtcuphone.TabIndex = 3;
            // 
            // txtcuemail
            // 
            this.txtcuemail.Location = new System.Drawing.Point(294, 267);
            this.txtcuemail.Name = "txtcuemail";
            this.txtcuemail.Size = new System.Drawing.Size(176, 22);
            this.txtcuemail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "customer name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "customer address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "customer phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "customer email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = " SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = " CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Add_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 416);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcuemail);
            this.Controls.Add(this.txtcuphone);
            this.Controls.Add(this.txtcuaddress);
            this.Controls.Add(this.txtcuname);
            this.Name = "Add_customer";
            this.Text = "Add_customer";
            this.Load += new System.EventHandler(this.Add_customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcuname;
        private System.Windows.Forms.TextBox txtcuaddress;
        private System.Windows.Forms.TextBox txtcuphone;
        private System.Windows.Forms.TextBox txtcuemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}