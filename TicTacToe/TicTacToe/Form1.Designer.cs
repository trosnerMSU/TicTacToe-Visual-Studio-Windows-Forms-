
namespace TicTacToe
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
            this.gameswonlabel = new System.Windows.Forms.Label();
            this.player1label = new System.Windows.Forms.Label();
            this.player1scorebox = new System.Windows.Forms.TextBox();
            this.player2scorebox = new System.Windows.Forms.TextBox();
            this.player2label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.playersturnlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameswonlabel
            // 
            this.gameswonlabel.AutoSize = true;
            this.gameswonlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.gameswonlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameswonlabel.Location = new System.Drawing.Point(757, 9);
            this.gameswonlabel.Name = "gameswonlabel";
            this.gameswonlabel.Size = new System.Drawing.Size(171, 32);
            this.gameswonlabel.TabIndex = 0;
            this.gameswonlabel.Text = "Games Won";
            // 
            // player1label
            // 
            this.player1label.AutoSize = true;
            this.player1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1label.Location = new System.Drawing.Point(797, 51);
            this.player1label.Name = "player1label";
            this.player1label.Size = new System.Drawing.Size(102, 17);
            this.player1label.TabIndex = 1;
            this.player1label.Text = "Player1 (X\'s)";
            // 
            // player1scorebox
            // 
            this.player1scorebox.Location = new System.Drawing.Point(799, 71);
            this.player1scorebox.Name = "player1scorebox";
            this.player1scorebox.ReadOnly = true;
            this.player1scorebox.Size = new System.Drawing.Size(100, 22);
            this.player1scorebox.TabIndex = 2;
            this.player1scorebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player2scorebox
            // 
            this.player2scorebox.Location = new System.Drawing.Point(799, 126);
            this.player2scorebox.Name = "player2scorebox";
            this.player2scorebox.ReadOnly = true;
            this.player2scorebox.Size = new System.Drawing.Size(100, 22);
            this.player2scorebox.TabIndex = 3;
            this.player2scorebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player2label
            // 
            this.player2label.AutoSize = true;
            this.player2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2label.Location = new System.Drawing.Point(797, 106);
            this.player2label.Name = "player2label";
            this.player2label.Size = new System.Drawing.Size(104, 17);
            this.player2label.TabIndex = 4;
            this.player2label.Text = "Player2 (O\'s)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(745, 510);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 140);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 140);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 140);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(56, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 140);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(279, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 140);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(503, 193);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 140);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(56, 365);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(184, 140);
            this.button7.TabIndex = 13;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(279, 365);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(184, 140);
            this.button8.TabIndex = 14;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(503, 365);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(184, 140);
            this.button9.TabIndex = 15;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(469, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 480);
            this.label2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(56, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(631, 25);
            this.label3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(56, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(631, 25);
            this.label4.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(246, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 480);
            this.label1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(774, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Rules:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(853, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "R Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(823, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Turn";
            // 
            // playersturnlabel
            // 
            this.playersturnlabel.AutoSize = true;
            this.playersturnlabel.Location = new System.Drawing.Point(824, 193);
            this.playersturnlabel.Name = "playersturnlabel";
            this.playersturnlabel.Size = new System.Drawing.Size(56, 17);
            this.playersturnlabel.TabIndex = 23;
            this.playersturnlabel.Text = "Player1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 528);
            this.Controls.Add(this.playersturnlabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player2label);
            this.Controls.Add(this.player2scorebox);
            this.Controls.Add(this.player1scorebox);
            this.Controls.Add(this.player1label);
            this.Controls.Add(this.gameswonlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameswonlabel;
        private System.Windows.Forms.Label player1label;
        private System.Windows.Forms.TextBox player1scorebox;
        private System.Windows.Forms.TextBox player2scorebox;
        private System.Windows.Forms.Label player2label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label playersturnlabel;
    }
}

