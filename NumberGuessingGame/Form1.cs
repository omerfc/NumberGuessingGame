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
        int predictionNumberComputer; //bilgisayarın tahmin ettiği sayı
        int[] computerArray = new int[4];//bilgisayarın tuttuğu sayı
        int counterSameDigit;
        int counterDifferentDigit;
        int counterComputerPrediction = 0;
        int counterUserPrediction = 0;
        List<int> AllNumber = new List<int>();
        List<int> digit0 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> digitfirst = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
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
            int[] numberArray = new int[4] {10,10,10,10};
            Random rnd = new Random();
            int number, bit0;
            bit0 = rnd.Next(digit0.Count);
            numberArray[0] = digit0[bit0];
            digitfirst.Remove(digit0[bit0]);
            for (int i = 1; i < 4; i++)
            {
                number = rnd.Next(digitfirst.Count);
                for (int j = 0; j < 4; j++)
                {
                    if (numberArray[j] == digitfirst[number])
                    {
                        number = rnd.Next(digitfirst.Count);
                        j = 0;
                    }
                }
                numberArray[i] = digitfirst[number];
                digitfirst.Remove(number);
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
                int[] predictionNumberUser = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    predictionNumberUser[i] = textBoxPrediction.Text[i] - '0';
                }
                if (!ControlNumber(predictionNumberUser))
                {
                    MessageBox.Show("Lütfen rakamları birbirinden farklı 4 basamaklı bir sayı giriniz!");
                }
                else
                {
                    counterUserPrediction++;
                    CompareArrays(predictionNumberUser, computerArray);
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
                    CreateAllNumber();
                    Random rnd = new Random();
                    predictionNumberComputer = AllNumber[rnd.Next(AllNumber.Count)];
                    AllNumber.Remove(predictionNumberComputer);
                    label3.Text = predictionNumberComputer.ToString();
                    listBoxComputerPrediction.Items.Add(new { Sıra= counterComputerPrediction, Sayı = label3.Text});
                    comboBoxSameOrder.Enabled = true;
                    comboBoxDifOrder.Enabled = true;
                }
                else
                {
                    predictionNumberComputer = ChangeNumber(predictionNumberComputer, Int32.Parse(SameOrder), -Int32.Parse(DifOrder));
                    label3.Text = predictionNumberComputer.ToString();
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
        private void CreateAllNumber()
        {
            int digit0, digit1, digit2, digit3;
            for(int i = 1023; i <= 9876; i++)
            {
                digit0 = i / 1000;
                digit1 = (i / 100) % 10;
                digit2 = (i / 10) % 10;
                digit3 = i % 10;
                if(digit0==digit1 || digit0==digit2 || digit0== digit3 || digit1==digit2 || digit1==digit3 || digit2 == digit3)
                {
                    continue;
                }
                else
                {
                    AllNumber.Add(i);
                }
            }
        }
        private int ChangeNumber(int number, int same, int dif)
        {
            List<int> a = new List<int>();
            for(int i = 0; i < AllNumber.Count; i++)
            {
                int cs = 0, cd = 0;
                //1.basamak
                if (AllNumber[i] / 1000 == number / 1000)
                {
                    cs++;
                }
                else if((AllNumber[i]/100) % 10 == number/1000 || (AllNumber[i]/10) % 10== number/1000 || (AllNumber[i] % 10 == number / 1000))
                {
                    cd++;
                }
                //2.basamak
                if((AllNumber[i]/100) % 10 == (number / 100) % 10)
                {
                    cs++;
                }
                else if(AllNumber[i]/1000 == (number / 100) % 10 || (AllNumber[i] / 10) % 10 == (number / 100) % 10 || AllNumber[i] % 10 == (number / 100) % 10)
                {
                    cd++;
                }
                //3.basamak
                if ((AllNumber[i] / 10) % 10 == (number / 10) % 10)
                {
                    cs++;
                }
                else if(AllNumber[i] / 1000 == (number / 10) % 10 || (AllNumber[i] / 100) % 10 == (number / 10) % 10 || (AllNumber[i] % 10) == (number / 10) % 10)
                {
                    cd++;
                }
                //4.basamak
                if (AllNumber[i] % 10 == number % 10)
                {
                    cs++;
                }
                else if (AllNumber[i] / 1000 == number % 10 || (AllNumber[i] / 100) % 10 == number % 10 || (AllNumber[i] / 10) % 10 == number % 10)
                {
                    cd++;
                }
                if((cs!=same) || (cd != dif))
                {
                    a.Add(AllNumber[i]);
                }
            }
            for(int i = 0; i < a.Count; i++)
            {
                AllNumber.Remove(a[i]);
            }
            Random rnd = new Random();
            return AllNumber[rnd.Next(AllNumber.Count)];            
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
