namespace LUCKY_COFFEE_ORDER
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkstudent = new System.Windows.Forms.CheckBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdojuice = new System.Windows.Forms.RadioButton();
            this.rdotea = new System.Windows.Forms.RadioButton();
            this.rdocoffee = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.OrderList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbllucky = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkstudent);
            this.groupBox1.Controls.Add(this.txtquantity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(78)))), ((int)(((byte)(125)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // chkstudent
            // 
            this.chkstudent.AutoSize = true;
            this.chkstudent.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkstudent.ForeColor = System.Drawing.Color.Black;
            this.chkstudent.Location = new System.Drawing.Point(229, 283);
            this.chkstudent.Name = "chkstudent";
            this.chkstudent.Size = new System.Drawing.Size(220, 25);
            this.chkstudent.TabIndex = 6;
            this.chkstudent.Text = "Student Member (10% off)";
            this.chkstudent.UseVisualStyleBackColor = true;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(108, 283);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(100, 29);
            this.txtquantity.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "customer name:";
           
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(19, 69);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(307, 29);
            this.txtname.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdojuice);
            this.groupBox2.Controls.Add(this.rdotea);
            this.groupBox2.Controls.Add(this.rdocoffee);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(19, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 148);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drink Type";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdojuice
            // 
            this.rdojuice.AutoSize = true;
            this.rdojuice.ForeColor = System.Drawing.Color.Black;
            this.rdojuice.Location = new System.Drawing.Point(6, 90);
            this.rdojuice.Name = "rdojuice";
            this.rdojuice.Size = new System.Drawing.Size(101, 25);
            this.rdojuice.TabIndex = 6;
            this.rdojuice.Text = "Juice (3$)";
            this.rdojuice.UseVisualStyleBackColor = true;
            // 
            // rdotea
            // 
            this.rdotea.AutoSize = true;
            this.rdotea.Checked = true;
            this.rdotea.ForeColor = System.Drawing.Color.Black;
            this.rdotea.Location = new System.Drawing.Point(6, 28);
            this.rdotea.Name = "rdotea";
            this.rdotea.Size = new System.Drawing.Size(89, 25);
            this.rdotea.TabIndex = 4;
            this.rdotea.TabStop = true;
            this.rdotea.Text = "Tea (1$)";
            this.rdotea.UseVisualStyleBackColor = true;
            // 
            // rdocoffee
            // 
            this.rdocoffee.AutoSize = true;
            this.rdocoffee.ForeColor = System.Drawing.Color.Black;
            this.rdocoffee.Location = new System.Drawing.Point(6, 59);
            this.rdocoffee.Name = "rdocoffee";
            this.rdocoffee.Size = new System.Drawing.Size(112, 25);
            this.rdocoffee.TabIndex = 5;
            this.rdocoffee.Text = "Coffee (2$)";
            this.rdocoffee.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(37, 455);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(149, 36);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "calculate order";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(230, 455);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(149, 36);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "save to file";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(440, 455);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(149, 36);
            this.btnload.TabIndex = 3;
            this.btnload.Text = "load from file";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(639, 455);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(149, 36);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // OrderList
            // 
            this.OrderList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.OrderList.FormattingEnabled = true;
            this.OrderList.ItemHeight = 25;
            this.OrderList.Location = new System.Drawing.Point(527, 116);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(403, 279);
            this.OrderList.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbllucky);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Location = new System.Drawing.Point(21, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 94);
            this.panel1.TabIndex = 6;
            // 
            // lbllucky
            // 
            this.lbllucky.AutoSize = true;
            this.lbllucky.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllucky.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbllucky.Location = new System.Drawing.Point(8, 53);
            this.lbllucky.Name = "lbllucky";
            this.lbllucky.Size = new System.Drawing.Size(128, 21);
            this.lbllucky.TabIndex = 1;
            this.lbllucky.Text = "Lucky Message:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lbltotal.Location = new System.Drawing.Point(8, 15);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(129, 21);
            this.lbltotal.TabIndex = 0;
            this.lbltotal.Text = "Total Price: $0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.label5.Location = new System.Drawing.Point(25, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lucky Cafe Order";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 645);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdotea;
        private System.Windows.Forms.RadioButton rdocoffee;
        private System.Windows.Forms.RadioButton rdojuice;
        private System.Windows.Forms.CheckBox chkstudent;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ListBox OrderList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbllucky;
        private System.Windows.Forms.Label label5;
    }
}

