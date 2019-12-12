namespace JogoQuimica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lTitle = new System.Windows.Forms.Label();
            this.tEq1 = new System.Windows.Forms.TextBox();
            this.lArrow = new System.Windows.Forms.Label();
            this.tEq2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timerBar = new System.Windows.Forms.PictureBox();
            this.lTimer = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.bReset = new System.Windows.Forms.Button();
            this.bConfirm = new System.Windows.Forms.Button();
            this.bPlay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timerBar)).BeginInit();
            this.gbGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lTitle.Location = new System.Drawing.Point(12, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(402, 30);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "JOGO DO BALANÇEAMENTO LOKO!!!";
            // 
            // tEq1
            // 
            this.tEq1.Enabled = false;
            this.tEq1.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEq1.Location = new System.Drawing.Point(16, 26);
            this.tEq1.Name = "tEq1";
            this.tEq1.Size = new System.Drawing.Size(130, 26);
            this.tEq1.TabIndex = 1;
            this.tEq1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tEq1.TextChanged += new System.EventHandler(this.TEq1_TextChanged);
            // 
            // lArrow
            // 
            this.lArrow.AutoSize = true;
            this.lArrow.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lArrow.Location = new System.Drawing.Point(152, 33);
            this.lArrow.Name = "lArrow";
            this.lArrow.Size = new System.Drawing.Size(19, 12);
            this.lArrow.TabIndex = 2;
            this.lArrow.Text = "->";
            // 
            // tEq2
            // 
            this.tEq2.Enabled = false;
            this.tEq2.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEq2.Location = new System.Drawing.Point(177, 26);
            this.tEq2.Name = "tEq2";
            this.tEq2.Size = new System.Drawing.Size(130, 26);
            this.tEq2.TabIndex = 3;
            this.tEq2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tEq2.TextChanged += new System.EventHandler(this.TEq2_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.richTextBox1.Location = new System.Drawing.Point(125, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(185, 18);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "O objetivo desse jogo é balançear";
            // 
            // timerBar
            // 
            this.timerBar.BackColor = System.Drawing.Color.LightGreen;
            this.timerBar.Location = new System.Drawing.Point(85, 66);
            this.timerBar.Name = "timerBar";
            this.timerBar.Size = new System.Drawing.Size(160, 17);
            this.timerBar.TabIndex = 5;
            this.timerBar.TabStop = false;
            // 
            // lTimer
            // 
            this.lTimer.AutoSize = true;
            this.lTimer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lTimer.Location = new System.Drawing.Point(132, 86);
            this.lTimer.Name = "lTimer";
            this.lTimer.Size = new System.Drawing.Size(72, 13);
            this.lTimer.TabIndex = 6;
            this.lTimer.Text = "Timer: (02:40)";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.richTextBox2.Location = new System.Drawing.Point(117, 53);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(184, 18);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "o maior número de equações possíveis";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.richTextBox3.Location = new System.Drawing.Point(145, 67);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(123, 18);
            this.richTextBox3.TabIndex = 8;
            this.richTextBox3.Text = "antes que o timer acabe.";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.richTextBox4.Location = new System.Drawing.Point(102, 83);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(228, 18);
            this.richTextBox4.TabIndex = 9;
            this.richTextBox4.Text = "Ao obter uma resposta certa você ganha +30s";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.richTextBox5.Location = new System.Drawing.Point(172, 97);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(61, 18);
            this.richTextBox5.TabIndex = 10;
            this.richTextBox5.Text = "Boa sorte!!!";
            // 
            // gbGame
            // 
            this.gbGame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbGame.Controls.Add(this.bReset);
            this.gbGame.Controls.Add(this.bConfirm);
            this.gbGame.Controls.Add(this.bPlay);
            this.gbGame.Controls.Add(this.lTimer);
            this.gbGame.Controls.Add(this.tEq1);
            this.gbGame.Controls.Add(this.lArrow);
            this.gbGame.Controls.Add(this.timerBar);
            this.gbGame.Controls.Add(this.tEq2);
            this.gbGame.Location = new System.Drawing.Point(43, 120);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(333, 157);
            this.gbGame.TabIndex = 11;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Pontos: 0";
            // 
            // bReset
            // 
            this.bReset.Enabled = false;
            this.bReset.Location = new System.Drawing.Point(40, 128);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 9;
            this.bReset.Text = "Reiniciar";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.BReset_Click);
            // 
            // bConfirm
            // 
            this.bConfirm.Enabled = false;
            this.bConfirm.Location = new System.Drawing.Point(16, 102);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(130, 23);
            this.bConfirm.TabIndex = 8;
            this.bConfirm.Text = "Confirmar resposta";
            this.bConfirm.UseVisualStyleBackColor = true;
            this.bConfirm.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bPlay
            // 
            this.bPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.bPlay.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPlay.Location = new System.Drawing.Point(214, 116);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(93, 27);
            this.bPlay.TabIndex = 7;
            this.bPlay.Text = "JOGAR!";
            this.bPlay.UseVisualStyleBackColor = false;
            this.bPlay.Click += new System.EventHandler(this.BPlay_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 287);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.gbGame);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "JBL - O jogo";
            ((System.ComponentModel.ISupportInitialize)(this.timerBar)).EndInit();
            this.gbGame.ResumeLayout(false);
            this.gbGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.TextBox tEq1;
        private System.Windows.Forms.Label lArrow;
        private System.Windows.Forms.TextBox tEq2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox timerBar;
        private System.Windows.Forms.Label lTimer;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Button bConfirm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bReset;
    }
}

