
namespace Number_Guessing_Game
{
    partial class numguessgame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(numguessgame));
            this.label1 = new System.Windows.Forms.Label();
            this.startbut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numbox = new System.Windows.Forms.TextBox();
            this.lowbut = new System.Windows.Forms.Button();
            this.highbut = new System.Windows.Forms.Button();
            this.yesbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Think Of A Number Between 1 and 10";
          
            // 
            // startbut
            // 
            this.startbut.Location = new System.Drawing.Point(313, 78);
            this.startbut.Name = "startbut";
            this.startbut.Size = new System.Drawing.Size(152, 53);
            this.startbut.TabIndex = 1;
            this.startbut.Text = "Start";
            this.startbut.UseVisualStyleBackColor = true;
            this.startbut.Click += new System.EventHandler(this.startbut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(211, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Is your number                                           ?";
            // 
            // numbox
            // 
            this.numbox.Location = new System.Drawing.Point(449, 178);
            this.numbox.Name = "numbox";
            this.numbox.Size = new System.Drawing.Size(100, 23);
            this.numbox.TabIndex = 3;
            this.numbox.TextChanged += new System.EventHandler(this.lowbut_Click);
            // 
            // lowbut
            // 
            this.lowbut.Location = new System.Drawing.Point(190, 260);
            this.lowbut.Name = "lowbut";
            this.lowbut.Size = new System.Drawing.Size(152, 51);
            this.lowbut.TabIndex = 4;
            this.lowbut.Text = "No, it is lower.";
            this.lowbut.UseVisualStyleBackColor = true;
            this.lowbut.Click += new System.EventHandler(this.lowbut_Click);
            // 
            // highbut
            // 
            this.highbut.Location = new System.Drawing.Point(449, 260);
            this.highbut.Name = "highbut";
            this.highbut.Size = new System.Drawing.Size(152, 53);
            this.highbut.TabIndex = 5;
            this.highbut.Text = "No, it is higher";
            this.highbut.UseVisualStyleBackColor = true;
            this.highbut.Click += new System.EventHandler(this.highbut_Click);
            // 
            // yesbut
            // 
            this.yesbut.Location = new System.Drawing.Point(313, 360);
            this.yesbut.Name = "yesbut";
            this.yesbut.Size = new System.Drawing.Size(152, 53);
            this.yesbut.TabIndex = 7;
            this.yesbut.Text = "Yes!";
            this.yesbut.UseVisualStyleBackColor = true;
            this.yesbut.Click += new System.EventHandler(this.yesbut_Click);
            // 
            // numguessgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yesbut);
            this.Controls.Add(this.highbut);
            this.Controls.Add(this.lowbut);
            this.Controls.Add(this.numbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startbut);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "numguessgame";
            this.Text = "Number Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startbut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numbox;
        private System.Windows.Forms.Button lowbut;
        private System.Windows.Forms.Button highbut;
        private System.Windows.Forms.Button yesbut;
    }
}

