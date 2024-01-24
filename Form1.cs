// Разработчик Калинин Михаил
using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace Game_Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] words = ["колокольня", "леденец", "караван", "астронавт", "яблоко", "чемпион", "крыша", "компютер", "клавиатура", "мышь", "процессор", "видеокарта", "наушники", "микрофон", "монитор", "стол", "стул", "кабинет", "время", "диплом"];
        private void btnA_Click(object sender, EventArgs e)
        {
            test('а', (Button)sender);

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            counterLife.Text = "5";
            label1.Text = words[new Random().Next(0, words.Length)];
            labelWord.Text = "";

            foreach (char c in label1.Text)
            {
                labelWord.Text += "*";
            }
        }

        public void test(char symbol, Button sender)
        {
            int life = Int32.Parse(counterLife.Text);
            int counter = 0;
            if (life != 0 && resultGame.Text == "")
            {
                string tempWord = "";
                for (int i = 0; i < label1.Text.Length; i++)
                {
                    if (symbol == label1.Text[i])
                    {
                        tempWord += label1.Text[i].ToString();
                        sender.BackColor = Color.Green;
                        sender.Enabled = false;
                        counter++;
                    }
                    else
                    {
                        tempWord += labelWord.Text[i].ToString();
                        if (sender.BackColor != Color.Green) sender.BackColor = Color.Red;
                        sender.Enabled = false;

                    }
                }
                if (counter == 0)
                {
                    --life;
                    counterLife.Text = life.ToString();
                    switch (life)
                    {
                        case 4:
                            pictureBox1.Image = Properties.Resources._1;
                            break;
                        case 3:
                            pictureBox1.Image = Properties.Resources._2;
                            break;
                        case 2:
                            pictureBox1.Image = Properties.Resources._3;
                            break;
                        case 1:
                            pictureBox1.Image = Properties.Resources._4;
                            break;
                        case 0:
                            pictureBox1.Image = Properties.Resources._5;
                            break;
                    }
                }
                labelWord.Text = "";
                labelWord.Text = tempWord;
                tempWord = "";

                if (label1.Text == labelWord.Text)
                {
                    btnRestartApp.Visible = true;
                    resultGame.Visible = true;
                    resultGame.Text = "Поздравляю! Вы угадали слово!";

                }
                else if (life == 0)
                {
                    resultGame.Visible = true;
                    btnRestartApp.Visible = true;
                    resultGame.Text = "Вы проиграли(";
                }
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            test('б', (Button)sender);
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            test('в', (Button)sender);
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            test('г', (Button)sender);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            test('д', (Button)sender);
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            test('е', (Button)sender);
        }

        private void btnZH_Click(object sender, EventArgs e)
        {
            test('ж', (Button)sender);
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            test('з', (Button)sender);
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            test('и', (Button)sender);
        }

        private void btnYY_Click(object sender, EventArgs e)
        {
            test('й', (Button)sender);
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            test('к', (Button)sender);
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            test('л', (Button)sender);
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            test('м', (Button)sender);
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            test('н', (Button)sender);
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            test('о', (Button)sender);
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            test('п', (Button)sender);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            test('р', (Button)sender);
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            test('с', (Button)sender);
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            test('т', (Button)sender);
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            test('у', (Button)sender);
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            test('ф', (Button)sender);
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            test('х', (Button)sender);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            test('ц', (Button)sender);
        }

        private void btnCH_Click(object sender, EventArgs e)
        {
            test('ч', (Button)sender);
        }

        private void btnSH_Click(object sender, EventArgs e)
        {
            test('ш', (Button)sender);
        }

        private void btnSCH_Click(object sender, EventArgs e)
        {
            test('щ', (Button)sender);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            test('ъ', (Button)sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            test('ы', (Button)sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            test('ь', (Button)sender);
        }

        private void btnEA_Click(object sender, EventArgs e)
        {
            test('э', (Button)sender);
        }

        private void btnYU_Click(object sender, EventArgs e)
        {
            test('ю', (Button)sender);
        }

        private void btnYA_Click(object sender, EventArgs e)
        {
            test('я', (Button)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
    }
}
