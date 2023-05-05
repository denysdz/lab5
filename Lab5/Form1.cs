using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5.classes;
using Lab5.classes.Class1;
using Lab5.classes.Class2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab5
{
    public partial class Form1 : Form {

        private static readonly Random rnd = new Random();
        private DecimalStringCollection decimalStringsCollection = new DecimalStringCollection();
        DecimalString[] decimalStrings = new DecimalString[10];

        public Form1() {
            InitializeComponent();

            for (int i = 0; i < 5; i++) {
                decimalStrings[i] = new DecimalString(GetRandom());
            }
            for (int i=5; i<10; i++) {
                decimalStrings[i] = decimalStrings[i - 5].Clone();
            }
            foreach (DecimalString decimalString in decimalStrings)
            {
                arrayList.Items.Add(decimalString.ToString());
            }
        }

        private int GetRandom() {
            int value = rnd.Next(-100, 100);
            return value;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (firstDecimal.Text.Length > 0)
            {
                DecimalString decimalString = new DecimalString(firstDecimal.Text.ToString());
                string strDec = decimalString.ToString();
                if (strDec.Length == 0)
                    strResult.Text = "Пусто";
                else
                    strResult.Text = decimalString.ToString();
                strLength.Text = decimalString.Length.ToString();
            } else {
                TextBoxError("Заповніть першу десяткову стрічку!");
            }
        }


        private void TextBoxError(string message) {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, "Помилка валідації!", buttons);
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (secondDecimal.Text.Length > 0 && firstDecimal.Text.Length > 0) {
                DecimalString firstArg = new DecimalString(firstDecimal.Text.ToString());
                DecimalString secondArg = new DecimalString(secondDecimal.Text.ToString());
                if (firstArg.Length == 0 || secondArg.Length == 0) {
                    StringBase firstBase = new StringBase(firstDecimal.Text.ToString());
                    StringBase secondBase = new StringBase(secondDecimal.Text.ToString());
                    if (firstBase < secondBase)
                    {
                        compareStr.Text = "Перша стрічка менша другої";
                    }
                    else
                    {
                        compareStr.Text = "Перша стрічка більша або рівна другій";
                    }
                } else {
                    if (firstArg < secondArg)
                        compareStr.Text = "Перша стрічка менша другої";
                    else
                        compareStr.Text = "Перша стрічка більша або рівна другій";
                }
            } else {
                TextBoxError("Заповніть обидві десяткові стрічки стрічки!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (secondDecimal.Text.Length > 0 && firstDecimal.Text.Length > 0) {
                DecimalString firString = new DecimalString(firstDecimal.Text.ToString());
                DecimalString secString = new DecimalString(secondDecimal.Text.ToString());
                try
                {
                    compareStr.Text = "Різниця стрічок: " + firString.Difference(secString).ToString();
                } catch (ArgumentException ex)
                {
                    compareStr.Text = ex.Message;
                }
            } else {
                TextBoxError("Заповніть обидві десяткові стрічки стрічки!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (secondDecimal.Text.Length > 0 && firstDecimal.Text.Length > 0) {


                DecimalString firstArg = new DecimalString(firstDecimal.Text.ToString());
                DecimalString secondArg = new DecimalString(secondDecimal.Text.ToString());
                if (firstArg.Length == 0 || secondArg.Length == 0)
                {
                    StringBase firstBase = new StringBase(firstDecimal.Text.ToString());
                    StringBase secondBase = new StringBase(secondDecimal.Text.ToString());
                    if (firstBase > secondBase)
                    {
                        compareStr.Text = "Перша стрічка більша другої";
                    }
                    else
                    {
                        compareStr.Text = "Перша стрічка менша або рівна другій";
                    }
                }
                else
                {
                    if (firstArg < secondArg)
                        compareStr.Text = "Перша стрічка менша другої";
                    else
                        compareStr.Text = "Перша стрічка більша або рівна другій";
                }

            } else {
                TextBoxError("Заповніть обидві десяткові стрічки стрічки!");
            }
        }

        private void sortOrder_Click(object sender, EventArgs e) {
            sortArray.Items.Clear();
            if (checkbox.Checked) {
                Array.Sort<DecimalString>(decimalStrings, new Comparison<DecimalString>(
                     (i1, i2) => i2.CompareTo(i1)));
            } else {
                Array.Sort<DecimalString>(decimalStrings, new Comparison<DecimalString>(
                    (i1, i2) => i1.CompareTo(i2)));
            }
            foreach (DecimalString decimalString in decimalStrings)
            {
                sortArray.Items.Add(decimalString.ToString());
            }
        }
    }
}
