namespace Game_Hangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            labelWord = new Label();
            panel5 = new Panel();
            title = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            counterLife = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnRestartApp = new Button();
            panel3 = new Panel();
            resultGame = new Label();
            btnYA = new Button();
            btnYU = new Button();
            btnEA = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnSCH = new Button();
            btnSH = new Button();
            btnCH = new Button();
            btnC = new Button();
            btnH = new Button();
            btnF = new Button();
            btnU = new Button();
            btnT = new Button();
            btnS = new Button();
            btnR = new Button();
            btnP = new Button();
            btnO = new Button();
            btnN = new Button();
            btnM = new Button();
            btnL = new Button();
            btnK = new Button();
            btnYY = new Button();
            btnI = new Button();
            btnZ = new Button();
            btnZH = new Button();
            btnE = new Button();
            btnD = new Button();
            btnG = new Button();
            btnV = new Button();
            btnB = new Button();
            btnA = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelWord);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 110);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 58);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            label1.Visible = false;
            // 
            // labelWord
            // 
            labelWord.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelWord.Font = new Font("Tahoma", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelWord.Location = new Point(114, 39);
            labelWord.MaximumSize = new Size(700, 50);
            labelWord.MinimumSize = new Size(700, 50);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(700, 50);
            labelWord.TabIndex = 1;
            labelWord.Text = "СЛОВО";
            labelWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(title);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(894, 33);
            panel5.TabIndex = 0;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title.Location = new Point(400, 9);
            title.Name = "title";
            title.Size = new Size(141, 19);
            title.TabIndex = 0;
            title.Text = "Угадайте слово";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 340);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Controls.Add(counterLife);
            panel4.Controls.Add(pictureBox2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(357, 35);
            panel4.TabIndex = 1;
            // 
            // counterLife
            // 
            counterLife.AutoSize = true;
            counterLife.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            counterLife.Location = new Point(323, 3);
            counterLife.Name = "counterLife";
            counterLife.Size = new Size(28, 29);
            counterLife.TabIndex = 1;
            counterLife.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(273, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources._6;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnRestartApp
            // 
            btnRestartApp.Location = new Point(195, 58);
            btnRestartApp.Name = "btnRestartApp";
            btnRestartApp.Size = new Size(152, 23);
            btnRestartApp.TabIndex = 32;
            btnRestartApp.Text = "Играть снова";
            btnRestartApp.UseVisualStyleBackColor = true;
            btnRestartApp.Visible = false;
            btnRestartApp.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(btnRestartApp);
            panel3.Controls.Add(resultGame);
            panel3.Controls.Add(btnYA);
            panel3.Controls.Add(btnYU);
            panel3.Controls.Add(btnEA);
            panel3.Controls.Add(btn3);
            panel3.Controls.Add(btn2);
            panel3.Controls.Add(btn1);
            panel3.Controls.Add(btnSCH);
            panel3.Controls.Add(btnSH);
            panel3.Controls.Add(btnCH);
            panel3.Controls.Add(btnC);
            panel3.Controls.Add(btnH);
            panel3.Controls.Add(btnF);
            panel3.Controls.Add(btnU);
            panel3.Controls.Add(btnT);
            panel3.Controls.Add(btnS);
            panel3.Controls.Add(btnR);
            panel3.Controls.Add(btnP);
            panel3.Controls.Add(btnO);
            panel3.Controls.Add(btnN);
            panel3.Controls.Add(btnM);
            panel3.Controls.Add(btnL);
            panel3.Controls.Add(btnK);
            panel3.Controls.Add(btnYY);
            panel3.Controls.Add(btnI);
            panel3.Controls.Add(btnZ);
            panel3.Controls.Add(btnZH);
            panel3.Controls.Add(btnE);
            panel3.Controls.Add(btnD);
            panel3.Controls.Add(btnG);
            panel3.Controls.Add(btnV);
            panel3.Controls.Add(btnB);
            panel3.Controls.Add(btnA);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(357, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(537, 340);
            panel3.TabIndex = 2;
            // 
            // resultGame
            // 
            resultGame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultGame.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultGame.Location = new Point(3, 5);
            resultGame.Margin = new Padding(0);
            resultGame.MaximumSize = new Size(530, 50);
            resultGame.MinimumSize = new Size(530, 50);
            resultGame.Name = "resultGame";
            resultGame.Size = new Size(530, 50);
            resultGame.TabIndex = 31;
            resultGame.TextAlign = ContentAlignment.MiddleCenter;
            resultGame.Visible = false;
            // 
            // btnYA
            // 
            btnYA.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnYA.Location = new Point(454, 271);
            btnYA.Name = "btnYA";
            btnYA.Size = new Size(55, 52);
            btnYA.TabIndex = 26;
            btnYA.Text = "Я";
            btnYA.UseVisualStyleBackColor = true;
            btnYA.Click += btnYA_Click;
            // 
            // btnYU
            // 
            btnYU.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnYU.Location = new Point(393, 271);
            btnYU.Name = "btnYU";
            btnYU.Size = new Size(55, 52);
            btnYU.TabIndex = 30;
            btnYU.Text = "Ю";
            btnYU.UseVisualStyleBackColor = true;
            btnYU.Click += btnYU_Click;
            // 
            // btnEA
            // 
            btnEA.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnEA.Location = new Point(332, 271);
            btnEA.Name = "btnEA";
            btnEA.Size = new Size(55, 52);
            btnEA.TabIndex = 29;
            btnEA.Text = "Э";
            btnEA.UseVisualStyleBackColor = true;
            btnEA.Click += btnEA_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btn3.Location = new Point(271, 271);
            btn3.Name = "btn3";
            btn3.Size = new Size(55, 52);
            btn3.TabIndex = 28;
            btn3.Text = "Ь";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btn2.Location = new Point(210, 271);
            btn2.Name = "btn2";
            btn2.Size = new Size(55, 52);
            btn2.TabIndex = 27;
            btn2.Text = "Ы";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btn1.Location = new Point(149, 271);
            btn1.Name = "btn1";
            btn1.Size = new Size(55, 52);
            btn1.TabIndex = 25;
            btn1.Text = "Ъ";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnSCH
            // 
            btnSCH.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnSCH.Location = new Point(88, 271);
            btnSCH.Name = "btnSCH";
            btnSCH.Size = new Size(55, 52);
            btnSCH.TabIndex = 24;
            btnSCH.Text = "Щ";
            btnSCH.UseVisualStyleBackColor = true;
            btnSCH.Click += btnSCH_Click;
            // 
            // btnSH
            // 
            btnSH.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnSH.Location = new Point(27, 271);
            btnSH.Name = "btnSH";
            btnSH.Size = new Size(55, 52);
            btnSH.TabIndex = 23;
            btnSH.Text = "Ш";
            btnSH.UseVisualStyleBackColor = true;
            btnSH.Click += btnSH_Click;
            // 
            // btnCH
            // 
            btnCH.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnCH.Location = new Point(454, 213);
            btnCH.Name = "btnCH";
            btnCH.Size = new Size(55, 52);
            btnCH.TabIndex = 18;
            btnCH.Text = "Ч";
            btnCH.UseVisualStyleBackColor = true;
            btnCH.Click += btnCH_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnC.Location = new Point(393, 213);
            btnC.Name = "btnC";
            btnC.Size = new Size(55, 52);
            btnC.TabIndex = 22;
            btnC.Text = "Ц";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnH
            // 
            btnH.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnH.Location = new Point(332, 213);
            btnH.Name = "btnH";
            btnH.Size = new Size(55, 52);
            btnH.TabIndex = 21;
            btnH.Text = "Х";
            btnH.UseVisualStyleBackColor = true;
            btnH.Click += btnH_Click;
            // 
            // btnF
            // 
            btnF.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnF.Location = new Point(271, 213);
            btnF.Name = "btnF";
            btnF.Size = new Size(55, 52);
            btnF.TabIndex = 20;
            btnF.Text = "Ф";
            btnF.UseVisualStyleBackColor = true;
            btnF.Click += btnF_Click;
            // 
            // btnU
            // 
            btnU.BackColor = SystemColors.Window;
            btnU.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnU.Location = new Point(210, 213);
            btnU.Name = "btnU";
            btnU.Size = new Size(55, 52);
            btnU.TabIndex = 19;
            btnU.Text = "У";
            btnU.UseVisualStyleBackColor = false;
            btnU.Click += btnU_Click;
            // 
            // btnT
            // 
            btnT.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnT.Location = new Point(149, 213);
            btnT.Name = "btnT";
            btnT.Size = new Size(55, 52);
            btnT.TabIndex = 17;
            btnT.Text = "Т";
            btnT.UseVisualStyleBackColor = true;
            btnT.Click += btnT_Click;
            // 
            // btnS
            // 
            btnS.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnS.Location = new Point(88, 213);
            btnS.Name = "btnS";
            btnS.Size = new Size(55, 52);
            btnS.TabIndex = 16;
            btnS.Text = "С";
            btnS.UseVisualStyleBackColor = true;
            btnS.Click += btnS_Click;
            // 
            // btnR
            // 
            btnR.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnR.Location = new Point(27, 213);
            btnR.Name = "btnR";
            btnR.Size = new Size(55, 52);
            btnR.TabIndex = 15;
            btnR.Text = "Р";
            btnR.UseVisualStyleBackColor = true;
            btnR.Click += btnR_Click;
            // 
            // btnP
            // 
            btnP.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnP.Location = new Point(454, 155);
            btnP.Name = "btnP";
            btnP.Size = new Size(55, 52);
            btnP.TabIndex = 10;
            btnP.Text = "П";
            btnP.UseVisualStyleBackColor = true;
            btnP.Click += btnP_Click;
            // 
            // btnO
            // 
            btnO.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnO.Location = new Point(393, 155);
            btnO.Name = "btnO";
            btnO.Size = new Size(55, 52);
            btnO.TabIndex = 14;
            btnO.Text = "О";
            btnO.UseVisualStyleBackColor = true;
            btnO.Click += btnO_Click;
            // 
            // btnN
            // 
            btnN.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnN.Location = new Point(332, 155);
            btnN.Name = "btnN";
            btnN.Size = new Size(55, 52);
            btnN.TabIndex = 13;
            btnN.Text = "Н";
            btnN.UseVisualStyleBackColor = true;
            btnN.Click += btnN_Click;
            // 
            // btnM
            // 
            btnM.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnM.Location = new Point(271, 155);
            btnM.Name = "btnM";
            btnM.Size = new Size(55, 52);
            btnM.TabIndex = 12;
            btnM.Text = "М";
            btnM.UseVisualStyleBackColor = true;
            btnM.Click += btnM_Click;
            // 
            // btnL
            // 
            btnL.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnL.Location = new Point(210, 155);
            btnL.Name = "btnL";
            btnL.Size = new Size(55, 52);
            btnL.TabIndex = 11;
            btnL.Text = "Л";
            btnL.UseVisualStyleBackColor = true;
            btnL.Click += btnL_Click;
            // 
            // btnK
            // 
            btnK.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnK.Location = new Point(149, 155);
            btnK.Name = "btnK";
            btnK.Size = new Size(55, 52);
            btnK.TabIndex = 9;
            btnK.Text = "К";
            btnK.UseVisualStyleBackColor = true;
            btnK.Click += btnK_Click;
            // 
            // btnYY
            // 
            btnYY.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnYY.Location = new Point(88, 155);
            btnYY.Name = "btnYY";
            btnYY.Size = new Size(55, 52);
            btnYY.TabIndex = 8;
            btnYY.Text = "Й";
            btnYY.UseVisualStyleBackColor = true;
            btnYY.Click += btnYY_Click;
            // 
            // btnI
            // 
            btnI.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnI.Location = new Point(27, 155);
            btnI.Name = "btnI";
            btnI.Size = new Size(55, 52);
            btnI.TabIndex = 7;
            btnI.Text = "И";
            btnI.UseVisualStyleBackColor = true;
            btnI.Click += btnI_Click;
            // 
            // btnZ
            // 
            btnZ.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnZ.Location = new Point(454, 97);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(55, 52);
            btnZ.TabIndex = 3;
            btnZ.Text = "З";
            btnZ.UseVisualStyleBackColor = true;
            btnZ.Click += btnZ_Click;
            // 
            // btnZH
            // 
            btnZH.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnZH.Location = new Point(393, 97);
            btnZH.Name = "btnZH";
            btnZH.Size = new Size(55, 52);
            btnZH.TabIndex = 6;
            btnZH.Text = "Ж";
            btnZH.UseVisualStyleBackColor = true;
            btnZH.Click += btnZH_Click;
            // 
            // btnE
            // 
            btnE.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnE.Location = new Point(332, 97);
            btnE.Name = "btnE";
            btnE.Size = new Size(55, 52);
            btnE.TabIndex = 5;
            btnE.Text = "Е";
            btnE.UseVisualStyleBackColor = true;
            btnE.Click += btnE_Click;
            // 
            // btnD
            // 
            btnD.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnD.Location = new Point(271, 97);
            btnD.Name = "btnD";
            btnD.Size = new Size(55, 52);
            btnD.TabIndex = 4;
            btnD.Text = "Д";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // btnG
            // 
            btnG.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnG.Location = new Point(210, 97);
            btnG.Name = "btnG";
            btnG.Size = new Size(55, 52);
            btnG.TabIndex = 3;
            btnG.Text = "Г";
            btnG.UseVisualStyleBackColor = true;
            btnG.Click += btnG_Click;
            // 
            // btnV
            // 
            btnV.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnV.Location = new Point(149, 97);
            btnV.Name = "btnV";
            btnV.Size = new Size(55, 52);
            btnV.TabIndex = 2;
            btnV.Text = "В";
            btnV.UseVisualStyleBackColor = true;
            btnV.Click += btnV_Click;
            // 
            // btnB
            // 
            btnB.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnB.Location = new Point(88, 97);
            btnB.Name = "btnB";
            btnB.Size = new Size(55, 52);
            btnB.TabIndex = 1;
            btnB.Text = "Б";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnA
            // 
            btnA.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnA.Location = new Point(27, 97);
            btnA.Name = "btnA";
            btnA.Size = new Size(55, 52);
            btnA.TabIndex = 0;
            btnA.Text = "А";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btnZ;
        private Button btnZH;
        private Button btnE;
        private Button btnD;
        private Button btnG;
        private Button btnV;
        private Button btnB;
        private Button btnA;
        private Button btnYA;
        private Button btnYU;
        private Button btnEA;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnSCH;
        private Button btnSH;
        private Button btnCH;
        private Button btnC;
        private Button btnH;
        private Button btnF;
        private Button btnU;
        private Button btnT;
        private Button btnS;
        private Button btnR;
        private Button btnP;
        private Button btnO;
        private Button btnN;
        private Button btnM;
        private Button btnL;
        private Button btnK;
        private Button btnYY;
        private Button btnI;
        private PictureBox pictureBox2;
        private Label labelWord;
        private Panel panel5;
        private Label title;
        private Label counterLife;
        private Label label1;
        private Label resultGame;
        private Button btnRestartApp;
    }
}
