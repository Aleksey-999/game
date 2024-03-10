namespace SeaWar
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlRobots = new System.Windows.Forms.Panel();
            this.pnlYou = new System.Windows.Forms.Panel();
            this.lblRobots = new System.Windows.Forms.Label();
            this.lblYou = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblItog1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblItog2 = new System.Windows.Forms.Label();
            this.btnAnew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(554, 376);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // pnlRobots
            // 
            this.pnlRobots.BackColor = System.Drawing.Color.Aqua;
            this.pnlRobots.ForeColor = System.Drawing.Color.White;
            this.pnlRobots.Location = new System.Drawing.Point(12, 32);
            this.pnlRobots.Name = "pnlRobots";
            this.pnlRobots.Size = new System.Drawing.Size(302, 298);
            this.pnlRobots.TabIndex = 1;
            this.pnlRobots.Click += new System.EventHandler(this.PnlRobots_Click);
            // 
            // pnlYou
            // 
            this.pnlYou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlYou.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnlYou.Location = new System.Drawing.Point(356, 32);
            this.pnlYou.Name = "pnlYou";
            this.pnlYou.Size = new System.Drawing.Size(302, 298);
            this.pnlYou.TabIndex = 2;
            this.pnlYou.Click += new System.EventHandler(this.pnlYou_Click);
            // 
            // lblRobots
            // 
            this.lblRobots.AutoSize = true;
            this.lblRobots.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRobots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRobots.ForeColor = System.Drawing.Color.Black;
            this.lblRobots.Location = new System.Drawing.Point(82, 9);
            this.lblRobots.Name = "lblRobots";
            this.lblRobots.Size = new System.Drawing.Size(123, 16);
            this.lblRobots.TabIndex = 3;
            this.lblRobots.Text = "Поле противника";
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYou.ForeColor = System.Drawing.Color.Black;
            this.lblYou.Location = new System.Drawing.Point(474, 9);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(77, 16);
            this.lblYou.TabIndex = 4;
            this.lblYou.Text = "Ваше поле";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(222, 368);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 29);
            this.lbl3.TabIndex = 5;
            this.lbl3.Visible = false;
            this.lbl3.Click += new System.EventHandler(this.Lbl3_Click);
            // 
            // lblItog1
            // 
            this.lblItog1.AutoSize = true;
            this.lblItog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblItog1.ForeColor = System.Drawing.Color.Black;
            this.lblItog1.Location = new System.Drawing.Point(669, 91);
            this.lblItog1.Name = "lblItog1";
            this.lblItog1.Size = new System.Drawing.Size(0, 16);
            this.lblItog1.TabIndex = 6;
            this.lblItog1.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(687, 91);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 16);
            this.lbl1.TabIndex = 7;
            this.lbl1.Visible = false;
            // 
            // lblItog2
            // 
            this.lblItog2.AutoSize = true;
            this.lblItog2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblItog2.ForeColor = System.Drawing.Color.Black;
            this.lblItog2.Location = new System.Drawing.Point(705, 91);
            this.lblItog2.Name = "lblItog2";
            this.lblItog2.Size = new System.Drawing.Size(0, 16);
            this.lblItog2.TabIndex = 8;
            this.lblItog2.Visible = false;
            this.lblItog2.Click += new System.EventHandler(this.LblItog2_Click);
            // 
            // btnAnew
            // 
            this.btnAnew.ForeColor = System.Drawing.Color.Black;
            this.btnAnew.Location = new System.Drawing.Point(537, 424);
            this.btnAnew.Name = "btnAnew";
            this.btnAnew.Size = new System.Drawing.Size(104, 25);
            this.btnAnew.TabIndex = 9;
            this.btnAnew.Text = "Начать заново";
            this.btnAnew.UseVisualStyleBackColor = true;
            this.btnAnew.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::SeaWar.Properties.Resources.krest;
            this.ClientSize = new System.Drawing.Size(724, 482);
            this.Controls.Add(this.btnAnew);
            this.Controls.Add(this.lblItog2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblItog1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblYou);
            this.Controls.Add(this.lblRobots);
            this.Controls.Add(this.pnlYou);
            this.Controls.Add(this.pnlRobots);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морской бой";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlRobots;
        private System.Windows.Forms.Panel pnlYou;
        private System.Windows.Forms.Label lblRobots;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblItog1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblItog2;
        private System.Windows.Forms.Button btnAnew;
    }
}

