using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class NumberGuessingGame : Form
    {
        int[,] allPredictionNumber = new int[100,4];
        int[] predictionNumberComputer = new int[4]; //bilgisayarın tahmin ettiği sayı
        int[] computerArray = new int[4];//bilgisayarın tuttuğu sayı
        int counterSameDigit;
        int counterDifferentDigit;
        int counterComputerPrediction = 0;
        int counterUserPrediction = 0;
        public NumberGuessingGame()
        {
            InitializeComponent();
            comboBoxDifOrder.SelectedIndex = 0;
            comboBoxDifOrder.Enabled = false;
            comboBoxSameOrder.SelectedIndex = 0;
            comboBoxSameOrder.Enabled = false;
            groupBoxUser.Enabled = false;
            label4.Text = "Sıra bilgisayarda";
        }
        private int[] CreateNumber()
        {
            // Bu method rakamları birbirinden farklı sayılar oluşturmak için çağrılır.
            int[] numberArray = new int[4];
            Random rnd = new Random();
            int number;
            while (numberArray[0] == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    number = rnd.Next(10);
                    for (int j = 0; j < 4; j++)
                    {
                        if (numberArray[j] == number)
                        {
                            number = rnd.Next(10);
                            j = 0;
                        }
                    }
                    numberArray[i] = number;
                }
            }
            return numberArray;
        }
        private void CompareArrays(int[] predictionNumber, int[] computerArray)
        {
            // Bu method kullanıcının tahmin ettiği sayı ile bilgisayarın oluşturduğu sayıyı karşılaştırmak için çağrılır.
            if(!(predictionNumber.SequenceEqual(computerArray)))
            {
                for(int i = 0; i < 4; i++)
                {
                    for(int j = 0; j < 4; j++)
                    {
                        if((predictionNumber[i]== computerArray[j]) && i == j)
                        {
                            counterSameDigit++;
                        }
                        if((predictionNumber[i] == computerArray[j]) && i != j)
                        {
                            counterDifferentDigit++;
                        }
                    }
                }
                if (counterSameDigit == 0)
                {
                    labelSame.Text = ""+ counterSameDigit;
                }
                else
                {
                    labelSame.Text = "+" + counterSameDigit;
                }
                if (counterDifferentDigit == 0)
                {
                    labelDif.Text = ""+ counterDifferentDigit;
                }
                else
                {
                    labelDif.Text = "-" + counterDifferentDigit;
                }
                listBoxUserPrediction.Items.Add(new { Sıra = counterUserPrediction, Sayı = PrintNumber(predictionNumber), Same = counterSameDigit, Dif = counterDifferentDigit });
                LabelUserNumber.Text = PrintNumber(predictionNumber);
            }
            else
            {
                listBoxUserPrediction.Items.Add(new { Sıra = counterUserPrediction, Sayı = PrintNumber(predictionNumber), Same = 4, Dif = 0 });
                MessageBox.Show("Doğru Tahmin, Oyun bitti!", "Kullanıcı kazandı.");
            }
        }
        private void buttonPredictNumberUser_Click(object sender, EventArgs e)
        {
            // Kullanıcı sayı tahmin etmek için butona tıkladığında bu method kullanılır.
            if (counterUserPrediction == 0)
            {
                computerArray = CreateNumber();
            }           
            counterSameDigit = 0;
            counterDifferentDigit = 0;
            if (textBoxPrediction.TextLength != 4)
            {
                MessageBox.Show("Lütfen 4 basamaklı bir sayı giriniz!");
            }
            else
            {
                int[] predictionNumber = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    predictionNumber[i] = textBoxPrediction.Text[i] - '0';
                }
                if (!ControlNumber(predictionNumber))
                {
                    MessageBox.Show("Lütfen rakamları birbirinden farklı 4 basamaklı bir sayı giriniz!");
                }
                else
                {
                    counterUserPrediction++;
                    CompareArrays(predictionNumber, computerArray);
                    groupBoxComputer.Enabled = true;
                    groupBoxUser.Enabled = false;
                    label5.Visible = false;
                    label4.Visible = true;
                    label4.Text = "Sıra bilgisayarda";
                }
            }           
        }
        private Boolean ControlNumber(int[] array)
        {
            //Girilen sayıların rakamlarının birbirinden farklı olup olmadığını belirlemek için çağrılır.
            for(int i = 0; i < 4; i++)
            {
                for(int j=0; j < 4; j++)
                {
                    if (array[i] == array[j])
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private string PrintNumber(int[] number)
        {
            //Sayıları ekrandaki label, listbox'lara eklemek için çağrılır.
            string s="";
            for(int i = 0; i < 4; i++)
            {
                s += number[i];
            }
            return s;
        }
        private void buttonPredictNumberComputer_Click(object sender, EventArgs e)
        {
            /*
             * İlk çalıştığında bilgisayarın 4 basamaklı sayı tahmin etmesi için kullanılır. 
            Daha sonra ise kullanıcının geri bildirimlerini iletmek ve yeni sayıların tahmin edilmesi için kullanılır.
            */
            string SameOrder, DifOrder;
            SameOrder = comboBoxSameOrder.Text;
            DifOrder = comboBoxDifOrder.Text;
            if (SameOrder.Length == 2)
            {
                SameOrder.Substring(1);
            }
            if (DifOrder.Length == 2)
            {
                DifOrder.Substring(1);
            }
            int p = Int32.Parse(SameOrder) - Int32.Parse(DifOrder);
            if(Int32.Parse(SameOrder)==4 && Int32.Parse(DifOrder) == 0)
            {
                MessageBox.Show("Doğru Tahmin, oyun bitti!", "Bilgisayar kazandı.");
            }
            if (p >= 5)
            {
                MessageBox.Show("+ ve - değerlerin toplamı 4'den büyük olamaz. Lütfen geçerli bir değer giriniz!");
            }
            else
            {
                if (counterComputerPrediction == 0)
                {
                    predictionNumberComputer = CreateNumber();
                    label3.Text = PrintNumber(predictionNumberComputer);
                    listBoxComputerPrediction.Items.Add(new { Sıra= counterComputerPrediction, Sayı = label3.Text});
                    for (int i = 0; i < 4; i++)
                    {
                        allPredictionNumber[0, i] = predictionNumberComputer[i];
                    }
                    comboBoxSameOrder.Enabled = true;
                    comboBoxDifOrder.Enabled = true;
                }
                else
                {
                    label3.Text = PrintNumber(ChangeNumber(predictionNumberComputer, Int32.Parse(SameOrder), -Int32.Parse(DifOrder)));
                    listBoxComputerPrediction.Items.Add(new { Sıra= counterComputerPrediction, Sayı = label3.Text, Same = comboBoxSameOrder.Text, Dif = comboBoxDifOrder.Text });
                }
                counterComputerPrediction++;
            }
            groupBoxComputer.Enabled = false;
            groupBoxUser.Enabled = true;
            label4.Visible = false;
            label5.Visible = true;
            label5.Text = "Sıra kullanıcıda";
            buttonPredictNumberComputer.Text = "Gönder";
        }
        private int[] ChangeNumber(int[] array, int same, int dif)
        {
            /*
             * Bilgisayarın tahmin ettiği sayının yanlış olması durumunda,
             * kullanıcının da geri bildirimlerini kullanarak yeni 4 basamaklı sayı oluşturmak için çağrılır.
             */
            int number, digit;
            Random rnd = new Random();
            do
            {
                if (dif > 0)
                {
                    for (int i = 0; i < dif; i++)
                    {
                        digit = rnd.Next(4);
                        int digitSecond = rnd.Next(4);
                        while (digit==digitSecond)
                        {
                            digitSecond = rnd.Next(4);
                        }
                        if ((array[digit] == 0 && digitSecond == 0) || (array[digitSecond] == 0 && digit == 0))
                        {
                            i = 0;
                        }
                        else
                        {
                            number = array[digit];
                            array[digit] = array[digitSecond];
                            array[digitSecond] = number;
                        }
                    }
                }
                for (int i = 0; i < 4 - (same + dif); i++)
                {
                    digit = rnd.Next(4);
                    if (digit == 0)
                    {
                        number = rnd.Next(1, 10);
                        for (int j = 0; j < 4; j++)
                        {
                            if (array[j] == number)
                            {
                                number = rnd.Next(1, 10);
                                j = 0;
                            }
                        }
                        array[digit] = number;
                    }
                    else
                    {
                        number = rnd.Next(10);
                        for (int j = 0; j < 4; j++)
                        {
                            if (array[j] == number)
                            {
                                number = rnd.Next(10);
                                j = 0;
                            }
                        }
                        array[digit] = number;
                    }
                }
            } while (!ControlNumber(array) || !CompareComputerPrediction(array,allPredictionNumber));
            for (int i = 0; i < 4; i++) 
            {
                allPredictionNumber[counterComputerPrediction, i] = array[i];
            }
            return array;
        }
        private Boolean CompareComputerPrediction(int[] prediction, int[,] allPredictionNumber)
        {
            /*
             Bilgisayarın tahmin edeceği sayının, önceden tahmin ettiği sayılardan farklı olmasını sağlamak için çağrılır.
              */
            for (int i = 0; i < counterComputerPrediction; i++) {
                if(prediction[0]==allPredictionNumber[i,0] && prediction[1] == allPredictionNumber[i, 1] &&
                        prediction[2] == allPredictionNumber[i, 2] && prediction[3] == allPredictionNumber[i, 3])
                {
                    return false;
                }
            }
            return true;
        }
        private void textBoxPrediction_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Textbox'a sadece rakamların girilmesini sağlar
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void pictureBoxInformation_Click(object sender, EventArgs e)
        {
            //Oyun kurallarını gösteren formu açar
            FormInformation info = new FormInformation();
            info.Show();
            this.Hide();
        }
        private void pictureBoxRestart_Click(object sender, EventArgs e)
        {
            //Oyunu yeniden başlatır.
            if(MessageBox.Show("Oyun yeniden başlatılsın mı?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else
            {
                this.Show();
            }
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //Oyunu kapatır.
            if (MessageBox.Show("Oyun kapatılsın mı?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
