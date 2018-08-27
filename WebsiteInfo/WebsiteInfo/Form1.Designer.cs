namespace WebsiteInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblshowinfo = new System.Windows.Forms.Label();
            this.lblenterurl = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblhtmlcode = new System.Windows.Forms.Label();
            this.lbldomain = new System.Windows.Forms.Label();
            this.lblip = new System.Windows.Forms.Label();
            this.lbldomaintxt = new System.Windows.Forms.Label();
            this.lbliptxt = new System.Windows.Forms.Label();
            this.lblipanddomain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblshowinfo
            // 
            this.lblshowinfo.AutoSize = true;
            this.lblshowinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowinfo.Location = new System.Drawing.Point(309, 9);
            this.lblshowinfo.Name = "lblshowinfo";
            this.lblshowinfo.Size = new System.Drawing.Size(171, 16);
            this.lblshowinfo.TabIndex = 0;
            this.lblshowinfo.Text = "Get information of a website";
            // 
            // lblenterurl
            // 
            this.lblenterurl.AutoSize = true;
            this.lblenterurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenterurl.Location = new System.Drawing.Point(253, 33);
            this.lblenterurl.Name = "lblenterurl";
            this.lblenterurl.Size = new System.Drawing.Size(282, 16);
            this.lblenterurl.TabIndex = 1;
            this.lblenterurl.Text = "Enter the URL of a website with HTTP/HTTPS:";
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(357, 64);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(100, 20);
            this.txturl.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.Location = new System.Drawing.Point(357, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "**Get info**";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 119);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 319);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // lblhtmlcode
            // 
            this.lblhtmlcode.AutoSize = true;
            this.lblhtmlcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblhtmlcode.Location = new System.Drawing.Point(12, 100);
            this.lblhtmlcode.Name = "lblhtmlcode";
            this.lblhtmlcode.Size = new System.Drawing.Size(48, 16);
            this.lblhtmlcode.TabIndex = 5;
            this.lblhtmlcode.Text = "HTML:";
            // 
            // lbldomain
            // 
            this.lbldomain.AutoSize = true;
            this.lbldomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbldomain.Location = new System.Drawing.Point(76, 68);
            this.lbldomain.Name = "lbldomain";
            this.lbldomain.Size = new System.Drawing.Size(227, 16);
            this.lbldomain.TabIndex = 6;
            this.lbldomain.Text = "Enter the URL and click on the button.";
            // 
            // lblip
            // 
            this.lblip.AutoSize = true;
            this.lblip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblip.Location = new System.Drawing.Point(76, 52);
            this.lblip.Name = "lblip";
            this.lblip.Size = new System.Drawing.Size(227, 16);
            this.lblip.TabIndex = 7;
            this.lblip.Text = "Enter the URL and click on the button.";
            // 
            // lbldomaintxt
            // 
            this.lbldomaintxt.AutoSize = true;
            this.lbldomaintxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbldomaintxt.Location = new System.Drawing.Point(12, 68);
            this.lbldomaintxt.Name = "lbldomaintxt";
            this.lbldomaintxt.Size = new System.Drawing.Size(58, 16);
            this.lbldomaintxt.TabIndex = 8;
            this.lbldomaintxt.Text = "Domain:";
            // 
            // lbliptxt
            // 
            this.lbliptxt.AutoSize = true;
            this.lbliptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbliptxt.Location = new System.Drawing.Point(47, 52);
            this.lbliptxt.Name = "lbliptxt";
            this.lbliptxt.Size = new System.Drawing.Size(23, 16);
            this.lbliptxt.TabIndex = 9;
            this.lbliptxt.Text = "IP:";
            // 
            // lblipanddomain
            // 
            this.lblipanddomain.AutoSize = true;
            this.lblipanddomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblipanddomain.Location = new System.Drawing.Point(12, 23);
            this.lblipanddomain.Name = "lblipanddomain";
            this.lblipanddomain.Size = new System.Drawing.Size(96, 16);
            this.lblipanddomain.TabIndex = 10;
            this.lblipanddomain.Text = "Domain and IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblipanddomain);
            this.Controls.Add(this.lbliptxt);
            this.Controls.Add(this.lbldomaintxt);
            this.Controls.Add(this.lblip);
            this.Controls.Add(this.lbldomain);
            this.Controls.Add(this.lblhtmlcode);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.lblenterurl);
            this.Controls.Add(this.lblshowinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Website Info With C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblshowinfo;
        private System.Windows.Forms.Label lblenterurl;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblhtmlcode;
        private System.Windows.Forms.Label lbldomain;
        private System.Windows.Forms.Label lblip;
        private System.Windows.Forms.Label lbldomaintxt;
        private System.Windows.Forms.Label lbliptxt;
        private System.Windows.Forms.Label lblipanddomain;
    }
}

