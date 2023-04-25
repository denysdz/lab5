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
using Lab5.classes.Class1;
using Lab5.classes.Class2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab5
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
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
    }
}
