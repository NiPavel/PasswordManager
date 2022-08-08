namespace PasswordManager
{
    partial class AddPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPassword));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.IncorrectLink = new System.Windows.Forms.Label();
            this.IncorrectPass = new System.Windows.Forms.Label();
            this.user1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.IncorrectUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(238, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add password";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(40, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(115, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Link";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(112, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(238, 41);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(219, 20);
            this.link.TabIndex = 8;
            this.link.TextChanged += new System.EventHandler(this.link_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(238, 155);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(219, 20);
            this.pass.TabIndex = 9;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 49);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IncorrectLink
            // 
            this.IncorrectLink.BackColor = System.Drawing.Color.Transparent;
            this.IncorrectLink.Location = new System.Drawing.Point(238, 62);
            this.IncorrectLink.Name = "IncorrectLink";
            this.IncorrectLink.Size = new System.Drawing.Size(222, 32);
            this.IncorrectLink.TabIndex = 11;
            // 
            // IncorrectPass
            // 
            this.IncorrectPass.BackColor = System.Drawing.Color.Transparent;
            this.IncorrectPass.Location = new System.Drawing.Point(235, 178);
            this.IncorrectPass.Name = "IncorrectPass";
            this.IncorrectPass.Size = new System.Drawing.Size(222, 32);
            this.IncorrectPass.TabIndex = 12;
            // 
            // user1
            // 
            this.user1.BackColor = System.Drawing.Color.Transparent;
            this.user1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.user1.Location = new System.Drawing.Point(112, 93);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(117, 24);
            this.user1.TabIndex = 13;
            this.user1.Text = "Username";
            this.user1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(238, 97);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(219, 20);
            this.user.TabIndex = 14;
            // 
            // IncorrectUser
            // 
            this.IncorrectUser.BackColor = System.Drawing.Color.Transparent;
            this.IncorrectUser.Location = new System.Drawing.Point(235, 120);
            this.IncorrectUser.Name = "IncorrectUser";
            this.IncorrectUser.Size = new System.Drawing.Size(222, 32);
            this.IncorrectUser.TabIndex = 15;
            // 
            // AddPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 333);
            this.Controls.Add(this.IncorrectUser);
            this.Controls.Add(this.user);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.IncorrectPass);
            this.Controls.Add(this.IncorrectLink);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "AddPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label IncorrectLink;
        private System.Windows.Forms.Label IncorrectPass;
        private System.Windows.Forms.Label user1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label IncorrectUser;
    }
}
