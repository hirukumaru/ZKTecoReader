namespace CodesLankaZKTecoReader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridalldata = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtdeviceinfo = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbconnection = new System.Windows.Forms.ProgressBar();
            this.lastatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridalldata)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buConnect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tport);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tip);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 72);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(607, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 46);
            this.button5.TabIndex = 8;
            this.button5.Text = "Get All Logs";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(671, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 46);
            this.button4.TabIndex = 7;
            this.button4.Text = "Get All Users";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(735, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ping Device";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(799, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Beep Device";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buConnect
            // 
            this.buConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buConnect.Location = new System.Drawing.Point(174, 12);
            this.buConnect.Name = "buConnect";
            this.buConnect.Size = new System.Drawing.Size(58, 46);
            this.buConnect.TabIndex = 4;
            this.buConnect.Text = "Connect";
            this.buConnect.UseVisualStyleBackColor = true;
            this.buConnect.Click += new System.EventHandler(this.buConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port :";
            // 
            // tport
            // 
            this.tport.Location = new System.Drawing.Point(48, 38);
            this.tport.Name = "tport";
            this.tport.Size = new System.Drawing.Size(120, 20);
            this.tport.TabIndex = 2;
            this.tport.Text = "4370";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP :";
            // 
            // tip
            // 
            this.tip.Location = new System.Drawing.Point(48, 12);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(120, 20);
            this.tip.TabIndex = 0;
            this.tip.Text = "192.168.1.2";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gridalldata);
            this.panel2.Location = new System.Drawing.Point(12, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 405);
            this.panel2.TabIndex = 1;
            // 
            // gridalldata
            // 
            this.gridalldata.AllowUserToAddRows = false;
            this.gridalldata.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.gridalldata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.gridalldata.BackgroundColor = System.Drawing.Color.Silver;
            this.gridalldata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridalldata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridalldata.DefaultCellStyle = dataGridViewCellStyle22;
            this.gridalldata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridalldata.Location = new System.Drawing.Point(3, 3);
            this.gridalldata.Name = "gridalldata";
            this.gridalldata.ReadOnly = true;
            this.gridalldata.Size = new System.Drawing.Size(862, 397);
            this.gridalldata.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lastatus);
            this.panel3.Controls.Add(this.pbconnection);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.rtdeviceinfo);
            this.panel3.Location = new System.Drawing.Point(12, 501);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 72);
            this.panel3.TabIndex = 2;
            // 
            // rtdeviceinfo
            // 
            this.rtdeviceinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtdeviceinfo.Location = new System.Drawing.Point(13, 15);
            this.rtdeviceinfo.Name = "rtdeviceinfo";
            this.rtdeviceinfo.Size = new System.Drawing.Size(346, 43);
            this.rtdeviceinfo.TabIndex = 0;
            this.rtdeviceinfo.Text = "";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(799, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pbconnection
            // 
            this.pbconnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbconnection.Location = new System.Drawing.Point(607, 12);
            this.pbconnection.Name = "pbconnection";
            this.pbconnection.Size = new System.Drawing.Size(186, 46);
            this.pbconnection.TabIndex = 10;
            // 
            // lastatus
            // 
            this.lastatus.BackColor = System.Drawing.Color.Transparent;
            this.lastatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastatus.ForeColor = System.Drawing.Color.Maroon;
            this.lastatus.Location = new System.Drawing.Point(617, 19);
            this.lastatus.Name = "lastatus";
            this.lastatus.Size = new System.Drawing.Size(165, 31);
            this.lastatus.TabIndex = 11;
            this.lastatus.Text = "Device Offline";
            this.lastatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 585);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codes Lanka - ZKTeco Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridalldata)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tip;
        private System.Windows.Forms.Button buConnect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView gridalldata;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtdeviceinfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar pbconnection;
        private System.Windows.Forms.Label lastatus;
    }
}

