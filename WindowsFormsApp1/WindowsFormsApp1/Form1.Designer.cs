namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Canvas = new System.Windows.Forms.Panel();
            this.EnemyBall = new System.Windows.Forms.PictureBox();
            this.PlayerBall = new System.Windows.Forms.PictureBox();
            this.Canvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBall)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Canvas
            // 
            this.Canvas.Controls.Add(this.PlayerBall);
            this.Canvas.Controls.Add(this.EnemyBall);
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1644, 895);
            this.Canvas.TabIndex = 0;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // EnemyBall
            // 
            this.EnemyBall.BackColor = System.Drawing.Color.Black;
            this.EnemyBall.Location = new System.Drawing.Point(823, 238);
            this.EnemyBall.Name = "EnemyBall";
            this.EnemyBall.Size = new System.Drawing.Size(50, 50);
            this.EnemyBall.TabIndex = 0;
            this.EnemyBall.TabStop = false;
            // 
            // PlayerBall
            // 
            this.PlayerBall.BackColor = System.Drawing.SystemColors.Highlight;
            this.PlayerBall.Location = new System.Drawing.Point(622, 399);
            this.PlayerBall.Name = "PlayerBall";
            this.PlayerBall.Size = new System.Drawing.Size(50, 50);
            this.PlayerBall.TabIndex = 1;
            this.PlayerBall.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 895);
            this.Controls.Add(this.Canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Canvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.PictureBox PlayerBall;
        private System.Windows.Forms.PictureBox EnemyBall;
    }
}

