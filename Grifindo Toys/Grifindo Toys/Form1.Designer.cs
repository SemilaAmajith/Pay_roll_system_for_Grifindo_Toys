namespace Programming_Asses
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_log = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_clear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_log
            // 
            this.btn_log.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_log.BorderRadius = 0;
            this.btn_log.ButtonText = "Login";
            this.btn_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_log.DisabledColor = System.Drawing.Color.Gray;
            this.btn_log.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_log.Iconimage = null;
            this.btn_log.Iconimage_right = null;
            this.btn_log.Iconimage_right_Selected = null;
            this.btn_log.Iconimage_Selected = null;
            this.btn_log.IconMarginLeft = 0;
            this.btn_log.IconMarginRight = 0;
            this.btn_log.IconRightVisible = true;
            this.btn_log.IconRightZoom = 0D;
            this.btn_log.IconVisible = true;
            this.btn_log.IconZoom = 90D;
            this.btn_log.IsTab = false;
            this.btn_log.Location = new System.Drawing.Point(596, 475);
            this.btn_log.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_log.Name = "btn_log";
            this.btn_log.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_log.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_log.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_log.selected = false;
            this.btn_log.Size = new System.Drawing.Size(123, 41);
            this.btn_log.TabIndex = 8;
            this.btn_log.Text = "Login";
            this.btn_log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_log.Textcolor = System.Drawing.Color.White;
            this.btn_log.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.BorderRadius = 0;
            this.btn_clear.ButtonText = "Clear";
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.DisabledColor = System.Drawing.Color.Gray;
            this.btn_clear.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_clear.Iconimage = null;
            this.btn_clear.Iconimage_right = null;
            this.btn_clear.Iconimage_right_Selected = null;
            this.btn_clear.Iconimage_Selected = null;
            this.btn_clear.IconMarginLeft = 0;
            this.btn_clear.IconMarginRight = 0;
            this.btn_clear.IconRightVisible = true;
            this.btn_clear.IconRightZoom = 0D;
            this.btn_clear.IconVisible = true;
            this.btn_clear.IconZoom = 90D;
            this.btn_clear.IsTab = false;
            this.btn_clear.Location = new System.Drawing.Point(848, 475);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_clear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_clear.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_clear.selected = false;
            this.btn_clear.Size = new System.Drawing.Size(123, 41);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clear.Textcolor = System.Drawing.Color.White;
            this.btn_clear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.SystemColors.Window;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_user.ForeColor = System.Drawing.Color.Black;
            this.txt_user.HintForeColor = System.Drawing.Color.Empty;
            this.txt_user.HintText = "";
            this.txt_user.isPassword = false;
            this.txt_user.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_user.LineIdleColor = System.Drawing.Color.Red;
            this.txt_user.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_user.LineThickness = 3;
            this.txt_user.Location = new System.Drawing.Point(711, 288);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(338, 45);
            this.txt_user.TabIndex = 9;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_pass
            // 
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_pass.ForeColor = System.Drawing.Color.Black;
            this.txt_pass.HintForeColor = System.Drawing.Color.Empty;
            this.txt_pass.HintText = "";
            this.txt_pass.isPassword = true;
            this.txt_pass.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_pass.LineIdleColor = System.Drawing.Color.Red;
            this.txt_pass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_pass.LineThickness = 3;
            this.txt_pass.Location = new System.Drawing.Point(711, 385);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(338, 45);
            this.txt_pass.TabIndex = 10;
            this.txt_pass.Text = "000000000";
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(543, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 307);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 78);
            this.label1.TabIndex = 12;
            this.label1.Text = "Grifindo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 78);
            this.label4.TabIndex = 13;
            this.label4.Text = "Toys";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 598);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_log;
        private Bunifu.Framework.UI.BunifuFlatButton btn_clear;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_pass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

