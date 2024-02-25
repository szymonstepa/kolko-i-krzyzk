namespace kolko
{
    partial class main
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
            buttonPoprzedni1 = new Button();
            buttonNastepny1 = new Button();
            buttonPoprzedni2 = new Button();
            buttonNastepny2 = new Button();
            groupBoxCzas = new GroupBox();
            radioButtonCzasNL = new RadioButton();
            radioButtonCzas60 = new RadioButton();
            radioButtonCzas30 = new RadioButton();
            radioButtonCzas10 = new RadioButton();
            groupBoxUstawienia = new GroupBox();
            radioButtonRunda7 = new RadioButton();
            radioButtonRunda5 = new RadioButton();
            radioButtonRunda3 = new RadioButton();
            radioButtonRunda1 = new RadioButton();
            buttonPlay = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBoxPlayer2 = new PictureBox();
            pictureBoxPlayer1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            textBoxNick2 = new TextBox();
            textBoxNick1 = new TextBox();
            groupBoxCzas.SuspendLayout();
            groupBoxUstawienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1).BeginInit();
            SuspendLayout();
            // 
            // buttonPoprzedni1
            // 
            buttonPoprzedni1.Location = new Point(90, 155);
            buttonPoprzedni1.Name = "buttonPoprzedni1";
            buttonPoprzedni1.Size = new Size(20, 23);
            buttonPoprzedni1.TabIndex = 59;
            buttonPoprzedni1.Text = "<";
            buttonPoprzedni1.UseVisualStyleBackColor = true;
            buttonPoprzedni1.Click += buttonPoprzedni1_Click;
            // 
            // buttonNastepny1
            // 
            buttonNastepny1.Location = new Point(249, 155);
            buttonNastepny1.Name = "buttonNastepny1";
            buttonNastepny1.Size = new Size(20, 23);
            buttonNastepny1.TabIndex = 58;
            buttonNastepny1.Text = ">";
            buttonNastepny1.UseVisualStyleBackColor = true;
            buttonNastepny1.Click += buttonNastepny1_Click;
            // 
            // buttonPoprzedni2
            // 
            buttonPoprzedni2.Location = new Point(762, 155);
            buttonPoprzedni2.Name = "buttonPoprzedni2";
            buttonPoprzedni2.Size = new Size(20, 23);
            buttonPoprzedni2.TabIndex = 57;
            buttonPoprzedni2.Text = "<";
            buttonPoprzedni2.UseVisualStyleBackColor = true;
            buttonPoprzedni2.Click += buttonPoprzedni2_Click;
            // 
            // buttonNastepny2
            // 
            buttonNastepny2.Location = new Point(921, 155);
            buttonNastepny2.Name = "buttonNastepny2";
            buttonNastepny2.Size = new Size(20, 23);
            buttonNastepny2.TabIndex = 56;
            buttonNastepny2.Text = ">";
            buttonNastepny2.UseVisualStyleBackColor = true;
            buttonNastepny2.Click += buttonNastepny2_Click;
            // 
            // groupBoxCzas
            // 
            groupBoxCzas.Controls.Add(radioButtonCzasNL);
            groupBoxCzas.Controls.Add(radioButtonCzas60);
            groupBoxCzas.Controls.Add(radioButtonCzas30);
            groupBoxCzas.Controls.Add(radioButtonCzas10);
            groupBoxCzas.Location = new Point(337, 217);
            groupBoxCzas.Name = "groupBoxCzas";
            groupBoxCzas.Size = new Size(364, 54);
            groupBoxCzas.TabIndex = 55;
            groupBoxCzas.TabStop = false;
            groupBoxCzas.Text = "Czas na ruch";
            // 
            // radioButtonCzasNL
            // 
            radioButtonCzasNL.AutoSize = true;
            radioButtonCzasNL.Checked = true;
            radioButtonCzasNL.Location = new Point(281, 22);
            radioButtonCzasNL.Name = "radioButtonCzasNL";
            radioButtonCzasNL.Size = new Size(77, 19);
            radioButtonCzasNL.TabIndex = 3;
            radioButtonCzasNL.TabStop = true;
            radioButtonCzasNL.Text = "bez limitu";
            radioButtonCzasNL.UseVisualStyleBackColor = true;
            // 
            // radioButtonCzas60
            // 
            radioButtonCzas60.AutoSize = true;
            radioButtonCzas60.Location = new Point(203, 22);
            radioButtonCzas60.Name = "radioButtonCzas60";
            radioButtonCzas60.Size = new Size(42, 19);
            radioButtonCzas60.TabIndex = 2;
            radioButtonCzas60.Text = "60s";
            radioButtonCzas60.UseVisualStyleBackColor = true;
            // 
            // radioButtonCzas30
            // 
            radioButtonCzas30.AutoSize = true;
            radioButtonCzas30.Location = new Point(103, 22);
            radioButtonCzas30.Name = "radioButtonCzas30";
            radioButtonCzas30.Size = new Size(42, 19);
            radioButtonCzas30.TabIndex = 1;
            radioButtonCzas30.Text = "30s";
            radioButtonCzas30.UseVisualStyleBackColor = true;
            // 
            // radioButtonCzas10
            // 
            radioButtonCzas10.AutoSize = true;
            radioButtonCzas10.Location = new Point(16, 22);
            radioButtonCzas10.Name = "radioButtonCzas10";
            radioButtonCzas10.Size = new Size(42, 19);
            radioButtonCzas10.TabIndex = 0;
            radioButtonCzas10.Text = "10s";
            radioButtonCzas10.UseVisualStyleBackColor = true;
            // 
            // groupBoxUstawienia
            // 
            groupBoxUstawienia.Controls.Add(radioButtonRunda7);
            groupBoxUstawienia.Controls.Add(radioButtonRunda5);
            groupBoxUstawienia.Controls.Add(radioButtonRunda3);
            groupBoxUstawienia.Controls.Add(radioButtonRunda1);
            groupBoxUstawienia.Location = new Point(337, 149);
            groupBoxUstawienia.Name = "groupBoxUstawienia";
            groupBoxUstawienia.Size = new Size(364, 54);
            groupBoxUstawienia.TabIndex = 54;
            groupBoxUstawienia.TabStop = false;
            groupBoxUstawienia.Text = "Ilość Rund";
            // 
            // radioButtonRunda7
            // 
            radioButtonRunda7.AutoSize = true;
            radioButtonRunda7.Location = new Point(281, 22);
            radioButtonRunda7.Name = "radioButtonRunda7";
            radioButtonRunda7.Size = new Size(31, 19);
            radioButtonRunda7.TabIndex = 3;
            radioButtonRunda7.Text = "7";
            radioButtonRunda7.UseVisualStyleBackColor = true;
            // 
            // radioButtonRunda5
            // 
            radioButtonRunda5.AutoSize = true;
            radioButtonRunda5.Location = new Point(203, 22);
            radioButtonRunda5.Name = "radioButtonRunda5";
            radioButtonRunda5.Size = new Size(31, 19);
            radioButtonRunda5.TabIndex = 2;
            radioButtonRunda5.Text = "5";
            radioButtonRunda5.UseVisualStyleBackColor = true;
            // 
            // radioButtonRunda3
            // 
            radioButtonRunda3.AutoSize = true;
            radioButtonRunda3.Location = new Point(103, 22);
            radioButtonRunda3.Name = "radioButtonRunda3";
            radioButtonRunda3.Size = new Size(31, 19);
            radioButtonRunda3.TabIndex = 1;
            radioButtonRunda3.Text = "3";
            radioButtonRunda3.UseVisualStyleBackColor = true;
            // 
            // radioButtonRunda1
            // 
            radioButtonRunda1.AutoSize = true;
            radioButtonRunda1.Checked = true;
            radioButtonRunda1.Location = new Point(16, 22);
            radioButtonRunda1.Name = "radioButtonRunda1";
            radioButtonRunda1.Size = new Size(31, 19);
            radioButtonRunda1.TabIndex = 0;
            radioButtonRunda1.TabStop = true;
            radioButtonRunda1.Text = "1";
            radioButtonRunda1.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            buttonPlay.Location = new Point(440, 403);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(142, 37);
            buttonPlay.TabIndex = 53;
            buttonPlay.Text = "Graj!";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(461, 110);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 52;
            label4.Text = "Ustawienia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(353, 22);
            label3.Name = "label3";
            label3.Size = new Size(337, 54);
            label3.TabIndex = 51;
            label3.Text = "KÓŁKO I KRZYŻYK";
            label3.Click += label3_Click;
            // 
            // pictureBoxPlayer2
            // 
            pictureBoxPlayer2.Image = Properties.Resources.pic1;
            pictureBoxPlayer2.Location = new Point(788, 110);
            pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            pictureBoxPlayer2.Size = new Size(127, 112);
            pictureBoxPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlayer2.TabIndex = 50;
            pictureBoxPlayer2.TabStop = false;
            // 
            // pictureBoxPlayer1
            // 
            pictureBoxPlayer1.Image = Properties.Resources.pic1;
            pictureBoxPlayer1.Location = new Point(116, 110);
            pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            pictureBoxPlayer1.Size = new Size(127, 112);
            pictureBoxPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlayer1.TabIndex = 49;
            pictureBoxPlayer1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(832, 53);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 48;
            label2.Text = "Gracz 2:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 53);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 47;
            label1.Text = "Gracz 1:";
            // 
            // textBoxNick2
            // 
            textBoxNick2.Location = new Point(750, 252);
            textBoxNick2.Name = "textBoxNick2";
            textBoxNick2.Size = new Size(201, 23);
            textBoxNick2.TabIndex = 46;
            // 
            // textBoxNick1
            // 
            textBoxNick1.Location = new Point(84, 252);
            textBoxNick1.Name = "textBoxNick1";
            textBoxNick1.Size = new Size(201, 23);
            textBoxNick1.TabIndex = 45;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1026, 511);
            Controls.Add(buttonPoprzedni1);
            Controls.Add(buttonNastepny1);
            Controls.Add(buttonPoprzedni2);
            Controls.Add(buttonNastepny2);
            Controls.Add(groupBoxCzas);
            Controls.Add(groupBoxUstawienia);
            Controls.Add(buttonPlay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBoxPlayer2);
            Controls.Add(pictureBoxPlayer1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNick2);
            Controls.Add(textBoxNick1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += main_Load_1;
            VisibleChanged += main_VisibleChanged;
            groupBoxCzas.ResumeLayout(false);
            groupBoxCzas.PerformLayout();
            groupBoxUstawienia.ResumeLayout(false);
            groupBoxUstawienia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPoprzedni1;
        private Button buttonNastepny1;
        private Button buttonPoprzedni2;
        private Button buttonNastepny2;
        private GroupBox groupBoxCzas;
        private RadioButton radioButtonCzasNL;
        private RadioButton radioButtonCzas60;
        private RadioButton radioButtonCzas30;
        private RadioButton radioButtonCzas10;
        private GroupBox groupBoxUstawienia;
        private RadioButton radioButtonRunda7;
        private RadioButton radioButtonRunda5;
        private RadioButton radioButtonRunda3;
        private RadioButton radioButtonRunda1;
        private Button buttonPlay;
        private Label label4;
        private Label label3;
        private PictureBox pictureBoxPlayer2;
        private PictureBox pictureBoxPlayer1;
        private Label label2;
        private Label label1;
        private TextBox textBoxNick2;
        private TextBox textBoxNick1;
    }
}