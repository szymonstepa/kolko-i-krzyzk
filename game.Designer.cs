namespace kolko
{
    partial class game
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
            components = new System.ComponentModel.Container();
            pictureBoxPlayer1 = new PictureBox();
            labelNick1 = new Label();
            pictureBoxPlayer2 = new PictureBox();
            labelNick2 = new Label();
            labelWygraneGracz1 = new Label();
            labelWygraneGracz2 = new Label();
            pictureBox00 = new PictureBox();
            pictureBox01 = new PictureBox();
            pictureBox02 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox22 = new PictureBox();
            pictureBox21 = new PictureBox();
            pictureBox20 = new PictureBox();
            labelMove = new Label();
            labelBO = new Label();
            button1 = new Button();
            timerTura = new System.Windows.Forms.Timer(components);
            timerUpdateLabel = new System.Windows.Forms.Timer(components);
            labelTime = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox00).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox02).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPlayer1
            // 
            pictureBoxPlayer1.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPlayer1.Location = new Point(83, 60);
            pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            pictureBoxPlayer1.Size = new Size(165, 154);
            pictureBoxPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlayer1.TabIndex = 52;
            pictureBoxPlayer1.TabStop = false;
            // 
            // labelNick1
            // 
            labelNick1.AutoSize = true;
            labelNick1.Location = new Point(83, 226);
            labelNick1.Name = "labelNick1";
            labelNick1.Size = new Size(45, 15);
            labelNick1.TabIndex = 51;
            labelNick1.Text = "Gracz 1";
            // 
            // pictureBoxPlayer2
            // 
            pictureBoxPlayer2.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPlayer2.Location = new Point(854, 60);
            pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            pictureBoxPlayer2.Size = new Size(165, 154);
            pictureBoxPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlayer2.TabIndex = 55;
            pictureBoxPlayer2.TabStop = false;
            // 
            // labelNick2
            // 
            labelNick2.AutoSize = true;
            labelNick2.Location = new Point(854, 226);
            labelNick2.Name = "labelNick2";
            labelNick2.Size = new Size(45, 15);
            labelNick2.TabIndex = 54;
            labelNick2.Text = "Gracz 2";
            // 
            // labelWygraneGracz1
            // 
            labelWygraneGracz1.AutoSize = true;
            labelWygraneGracz1.Location = new Point(83, 258);
            labelWygraneGracz1.Name = "labelWygraneGracz1";
            labelWygraneGracz1.Size = new Size(66, 15);
            labelWygraneGracz1.TabIndex = 56;
            labelWygraneGracz1.Text = "Wygrane: 0";
            // 
            // labelWygraneGracz2
            // 
            labelWygraneGracz2.AutoSize = true;
            labelWygraneGracz2.Location = new Point(854, 258);
            labelWygraneGracz2.Name = "labelWygraneGracz2";
            labelWygraneGracz2.Size = new Size(66, 15);
            labelWygraneGracz2.TabIndex = 57;
            labelWygraneGracz2.Text = "Wygrane: 0";
            // 
            // pictureBox00
            // 
            pictureBox00.BorderStyle = BorderStyle.FixedSingle;
            pictureBox00.Location = new Point(445, 321);
            pictureBox00.Name = "pictureBox00";
            pictureBox00.Size = new Size(70, 63);
            pictureBox00.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox00.TabIndex = 58;
            pictureBox00.TabStop = false;
            pictureBox00.Click += pictureBox00_Click;
            // 
            // pictureBox01
            // 
            pictureBox01.BorderStyle = BorderStyle.FixedSingle;
            pictureBox01.Location = new Point(521, 321);
            pictureBox01.Name = "pictureBox01";
            pictureBox01.Size = new Size(70, 63);
            pictureBox01.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox01.TabIndex = 59;
            pictureBox01.TabStop = false;
            pictureBox01.Click += pictureBox01_Click;
            // 
            // pictureBox02
            // 
            pictureBox02.BorderStyle = BorderStyle.FixedSingle;
            pictureBox02.Location = new Point(597, 321);
            pictureBox02.Name = "pictureBox02";
            pictureBox02.Size = new Size(70, 63);
            pictureBox02.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox02.TabIndex = 60;
            pictureBox02.TabStop = false;
            pictureBox02.Click += pictureBox02_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.BorderStyle = BorderStyle.FixedSingle;
            pictureBox10.Location = new Point(445, 390);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(70, 63);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 61;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.BorderStyle = BorderStyle.FixedSingle;
            pictureBox11.Location = new Point(521, 390);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(70, 63);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 62;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.BorderStyle = BorderStyle.FixedSingle;
            pictureBox12.Location = new Point(597, 390);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(70, 63);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 63;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox12_Click;
            // 
            // pictureBox22
            // 
            pictureBox22.BorderStyle = BorderStyle.FixedSingle;
            pictureBox22.Location = new Point(597, 459);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(70, 63);
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox22.TabIndex = 64;
            pictureBox22.TabStop = false;
            pictureBox22.Click += pictureBox22_Click;
            // 
            // pictureBox21
            // 
            pictureBox21.BorderStyle = BorderStyle.FixedSingle;
            pictureBox21.Location = new Point(521, 459);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(70, 63);
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox21.TabIndex = 65;
            pictureBox21.TabStop = false;
            pictureBox21.Click += pictureBox21_Click;
            // 
            // pictureBox20
            // 
            pictureBox20.BorderStyle = BorderStyle.FixedSingle;
            pictureBox20.Location = new Point(445, 459);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(70, 63);
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox20.TabIndex = 66;
            pictureBox20.TabStop = false;
            pictureBox20.Click += pictureBox20_Click;
            // 
            // labelMove
            // 
            labelMove.AutoSize = true;
            labelMove.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelMove.Location = new Point(458, 258);
            labelMove.Name = "labelMove";
            labelMove.Size = new Size(82, 37);
            labelMove.TabIndex = 67;
            labelMove.Text = "Tura: ";
            // 
            // labelBO
            // 
            labelBO.AutoSize = true;
            labelBO.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelBO.Location = new Point(445, 88);
            labelBO.Name = "labelBO";
            labelBO.Size = new Size(180, 54);
            labelBO.TabIndex = 68;
            labelBO.Text = "BEST OF ";
            // 
            // button1
            // 
            button1.Location = new Point(1060, 12);
            button1.Name = "button1";
            button1.Size = new Size(30, 25);
            button1.TabIndex = 69;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timerTura
            // 
            timerTura.Tick += timerTura_Tick;
            // 
            // timerUpdateLabel
            // 
            timerUpdateLabel.Tick += timerUpdateLabel_Tick;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.Location = new Point(36, 504);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(76, 28);
            labelTime.TabIndex = 70;
            labelTime.Text = "Czas:  0";
            // 
            // game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1102, 600);
            Controls.Add(labelTime);
            Controls.Add(button1);
            Controls.Add(labelBO);
            Controls.Add(labelMove);
            Controls.Add(pictureBox20);
            Controls.Add(pictureBox21);
            Controls.Add(pictureBox22);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox02);
            Controls.Add(pictureBox01);
            Controls.Add(pictureBox00);
            Controls.Add(labelWygraneGracz2);
            Controls.Add(labelWygraneGracz1);
            Controls.Add(pictureBoxPlayer2);
            Controls.Add(labelNick2);
            Controls.Add(pictureBoxPlayer1);
            Controls.Add(labelNick1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gra";
            Load += game_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox00).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox01).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox02).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPlayer1;
        private Label labelNick1;
        private PictureBox pictureBoxPlayer2;
        private Label labelNick2;
        private Label labelWygraneGracz1;
        private Label labelWygraneGracz2;
        private PictureBox pictureBox00;
        private PictureBox pictureBox01;
        private PictureBox pictureBox02;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox22;
        private PictureBox pictureBox21;
        private PictureBox pictureBox20;
        private Label labelMove;
        private Label labelBO;
        private Button button1;
        private System.Windows.Forms.Timer timerTura;
        private System.Windows.Forms.Timer timerUpdateLabel;
        private Label labelTime;
    }
}