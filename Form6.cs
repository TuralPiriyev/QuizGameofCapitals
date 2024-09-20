using Microsoft.VisualBasic.ApplicationServices;

namespace SALAAAM
{
    public class Form6: Form
    {
        System.Windows.Forms.Timer gameTimer;
        int remainingTime = 10; // Vaxt limiti 30 saniyə
        private Form1 parentForm;
        public Form6(Form1 form1)
        {
            InitializeComponent();

            // Timer obyektini yaratmaq
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000; // 1 saniyə
            gameTimer.Tick += gameTimer_Tick;

            parentForm = form1;
            labelTime.Text = remainingTime.ToString();
            gameTimer.Start(); // Timer-i işə salmaq
           
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            labelTime.Text = remainingTime.ToString(); // Vaxtı göstəririk

            if (remainingTime == 0)
            {
                gameTimer.Stop(); // Vaxt bitəndə Timer-i dayandırırıq
                MessageBox.Show("Vaxt bitdi! Təkrar oynayın.");
                this.Close(); // Oyunu bağlamaq və ya növbəti funksiya
            }
        }

        private void InitializeComponent()
        {
            label2 = new Label();
            labelTime = new Label();
            Baku = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 58);
            label2.Name = "label2";
            label2.Size = new Size(234, 20);
            label2.TabIndex = 0;
            label2.Text = "What is the Capital of Germany?";
            label2.Click += label2_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(150, 10);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(0, 20);
            labelTime.TabIndex = 1;
            // 
            // Baku
            // 
            Baku.Location = new Point(59, 117);
            Baku.Name = "Baku";
            Baku.Size = new Size(94, 29);
            Baku.TabIndex = 1;
            Baku.Text = "Berlin";
            Baku.UseVisualStyleBackColor = true;
            Baku.Click += Baku_Click;
            // 
            // button2
            // 
            button2.Location = new Point(179, 117);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Moscow";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(179, 204);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Tabriz";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(59, 204);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Ankara";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Form2
            // 
            ClientSize = new Size(362, 378);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Baku);
            Controls.Add(label2);
            Controls.Add(labelTime);
            Name = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelTime; // Vaxtı göstərmək üçün əlavə etdik
        private Label label2;
        private Button Baku;
        private Button button2;
        private Button button3;
        private Button button4;
        private System.ComponentModel.IContainer components;

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

           

            MessageBox.Show("Cavab yanlışdır!");

            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Cavab yanlışdır!");

            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Cavab yanlışdır!");

            this.Close();
        }

        private void Baku_Click(object sender, EventArgs e)
        {
            parentForm.score += 100;
            MessageBox.Show("Təbriklər! Cavab doğrudur! \n Toplam Xal:" + parentForm.score);
            gameTimer.Stop();

            this.Close();

         DialogResult result =   MessageBox.Show("Tebrikler siz bizim CapitalQuiz oyununu sehvsiz bitirdiniz! Eger yeniden Oynamag isteyirsinizse OK-a basmag kifayet edir");

            if(result == DialogResult.No)
            {
                parentForm.Close();
                this.Close();
            }
          
          
        }
    }
}
