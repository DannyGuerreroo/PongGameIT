namespace PongGameIT
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.PongBall = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopBorder = new System.Windows.Forms.PictureBox();
            this.BottomBorder = new System.Windows.Forms.PictureBox();
            this.P1Goal = new System.Windows.Forms.PictureBox();
            this.P2Goal = new System.Windows.Forms.PictureBox();
            this.P1UpButton = new System.Windows.Forms.Button();
            this.P1DownButton = new System.Windows.Forms.Button();
            this.P2UpButton = new System.Windows.Forms.Button();
            this.P2DownButton = new System.Windows.Forms.Button();
            this.P1Score = new System.Windows.Forms.Label();
            this.P2Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PongBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1Goal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2Goal)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Blue;
            this.Player1.Location = new System.Drawing.Point(33, 171);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(41, 126);
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // PongBall
            // 
            this.PongBall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PongBall.Location = new System.Drawing.Point(394, 231);
            this.PongBall.Name = "PongBall";
            this.PongBall.Size = new System.Drawing.Size(27, 24);
            this.PongBall.TabIndex = 1;
            this.PongBall.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.Red;
            this.Player2.Location = new System.Drawing.Point(729, 171);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(41, 126);
            this.Player2.TabIndex = 2;
            this.Player2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TopBorder.Location = new System.Drawing.Point(-3, -62);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(807, 72);
            this.TopBorder.TabIndex = 4;
            this.TopBorder.TabStop = false;
            // 
            // BottomBorder
            // 
            this.BottomBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BottomBorder.Location = new System.Drawing.Point(-3, 440);
            this.BottomBorder.Name = "BottomBorder";
            this.BottomBorder.Size = new System.Drawing.Size(807, 84);
            this.BottomBorder.TabIndex = 5;
            this.BottomBorder.TabStop = false;
            // 
            // P1Goal
            // 
            this.P1Goal.BackColor = System.Drawing.Color.Cyan;
            this.P1Goal.Location = new System.Drawing.Point(-96, -3);
            this.P1Goal.Name = "P1Goal";
            this.P1Goal.Size = new System.Drawing.Size(103, 455);
            this.P1Goal.TabIndex = 6;
            this.P1Goal.TabStop = false;
            // 
            // P2Goal
            // 
            this.P2Goal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.P2Goal.Location = new System.Drawing.Point(794, -3);
            this.P2Goal.Name = "P2Goal";
            this.P2Goal.Size = new System.Drawing.Size(113, 455);
            this.P2Goal.TabIndex = 7;
            this.P2Goal.TabStop = false;
            // 
            // P1UpButton
            // 
            this.P1UpButton.Location = new System.Drawing.Point(90, 45);
            this.P1UpButton.Name = "P1UpButton";
            this.P1UpButton.Size = new System.Drawing.Size(59, 39);
            this.P1UpButton.TabIndex = 8;
            this.P1UpButton.Text = "^";
            this.P1UpButton.UseVisualStyleBackColor = true;
            this.P1UpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P1UpButton_MouseDown);
            this.P1UpButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P1UpButton_MouseUp);
            // 
            // P1DownButton
            // 
            this.P1DownButton.Location = new System.Drawing.Point(90, 380);
            this.P1DownButton.Name = "P1DownButton";
            this.P1DownButton.Size = new System.Drawing.Size(59, 36);
            this.P1DownButton.TabIndex = 9;
            this.P1DownButton.Text = "V";
            this.P1DownButton.UseVisualStyleBackColor = true;
            this.P1DownButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P1DownButton_MouseDown);
            this.P1DownButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P1DownButton_MouseUp);
            // 
            // P2UpButton
            // 
            this.P2UpButton.Location = new System.Drawing.Point(648, 45);
            this.P2UpButton.Name = "P2UpButton";
            this.P2UpButton.Size = new System.Drawing.Size(62, 39);
            this.P2UpButton.TabIndex = 10;
            this.P2UpButton.Text = "^";
            this.P2UpButton.UseVisualStyleBackColor = true;
            this.P2UpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P2UpButton_MouseDown);
            this.P2UpButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P2UpButton_MouseUp);
            // 
            // P2DownButton
            // 
            this.P2DownButton.Location = new System.Drawing.Point(648, 380);
            this.P2DownButton.Name = "P2DownButton";
            this.P2DownButton.Size = new System.Drawing.Size(62, 36);
            this.P2DownButton.TabIndex = 11;
            this.P2DownButton.Text = "V";
            this.P2DownButton.UseVisualStyleBackColor = true;
            this.P2DownButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P2DownButton_MouseDown);
            this.P2DownButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P2DownButton_MouseUp);
            // 
            // P1Score
            // 
            this.P1Score.AutoSize = true;
            this.P1Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.P1Score.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P1Score.ForeColor = System.Drawing.Color.White;
            this.P1Score.Location = new System.Drawing.Point(205, 31);
            this.P1Score.Name = "P1Score";
            this.P1Score.Size = new System.Drawing.Size(32, 37);
            this.P1Score.TabIndex = 12;
            this.P1Score.Text = "0";
            // 
            // P2Score
            // 
            this.P2Score.AutoSize = true;
            this.P2Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.P2Score.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P2Score.ForeColor = System.Drawing.Color.White;
            this.P2Score.Location = new System.Drawing.Point(557, 31);
            this.P2Score.Name = "P2Score";
            this.P2Score.Size = new System.Drawing.Size(32, 37);
            this.P2Score.TabIndex = 13;
            this.P2Score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.P2Score);
            this.Controls.Add(this.P1Score);
            this.Controls.Add(this.P2DownButton);
            this.Controls.Add(this.P2UpButton);
            this.Controls.Add(this.P1UpButton);
            this.Controls.Add(this.P1DownButton);
            this.Controls.Add(this.BottomBorder);
            this.Controls.Add(this.TopBorder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.PongBall);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.P1Goal);
            this.Controls.Add(this.P2Goal);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PongBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1Goal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2Goal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox Player1;
        private PictureBox PongBall;
        private PictureBox Player2;
        private Label label1;
        private PictureBox TopBorder;
        private PictureBox BottomBorder;
        private PictureBox P1Goal;
        private PictureBox P2Goal;
        private Button P1UpButton;
        private Button P1DownButton;
        private Button P2UpButton;
        private Button P2DownButton;
        private Label P1Score;
        private Label P2Score;
    }
}