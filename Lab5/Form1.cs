using System;
using System.Collections;
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
        private EngineeringСalculator engineeringСalculator = null;
        private DecimalStringCollection decimalStringsCollection = new DecimalStringCollection();
        private EngineCalcCollection engineeringСalculators= new EngineCalcCollection();

        public Form1() {
            InitializeComponent();
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
                decimalStringsCollection.AddToGenericCollection(decimalString);
                decimalStringsCollection.AddToNonGenericCollection(decimalString);
                updateLists();
            } else {
                TextBoxError("Заповніть десяткову стрічку!");
            }
        }

        private void updateLists () {
            arrayList.Items.Clear();
            sortArray.Items.Clear();
            IEnumerator entry = decimalStringsCollection.GetEnumerator();
            while (entry.MoveNext()) {
                DecimalString obj = entry.Current as DecimalString;
                if (obj.ToString().Equals("")) {
                    arrayList.Items.Add("Пусто");
                } else {
                    arrayList.Items.Add(obj.ToString());
                }
            }
            foreach (DecimalString e in decimalStringsCollection) {
                if (e.ToString().Equals("")) {
                    sortArray.Items.Add("Пусто");
                }
                else {
                    sortArray.Items.Add(e.ToString());
                }
            }
        }

        private void TextBoxError(string message) {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, "Помилка валідації!", buttons);
        }

        private bool isCorrectNumber (String value) {
            double number;
            if (value.Length > 0) {
               if (double.TryParse(value, out number)) {
                    return true;
                } else {
                    TextBoxError("Введіть коректні дійсні числа!");
                }
            } else {
               TextBoxError("Введіть значення x, y! ");
            }
            return false;
        }

        private void addBtnOp_Click(object sender, EventArgs e) {
            if (isCorrectNumber(val1.Text.ToString()) && isCorrectNumber(val2.Text.ToString())) {
                if (nameCalc.Text.Length > 0) {
                    if (engineeringСalculator == null) {
                        engineeringСalculator = new EngineeringСalculator(nameCalc.Text.ToString());
                    }
                    double a = Convert.ToDouble(val1.Text.ToString());
                    double b = Convert.ToDouble(val2.Text.ToString());
                    resultCalc.Text = val1.Text.ToString() + " + " + val2.Text.ToString() + " = " + engineeringСalculator.Add(a, b).ToString();
                } else {
                    TextBoxError("Вкажіть ім'я калькулятора!");
                }
            }
        }

        private void updateEngLists () {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            IEnumerator entry = engineeringСalculators.GetEnumerator();
            while (entry.MoveNext()) {
                EngineeringСalculator obj = entry.Current as EngineeringСalculator;
                listBox1.Items.Add(obj.Name);
                listBox1.Items.Add("Історія:");
                IEnumerator history = obj.GetOperationsEnumerator();
                while (history.MoveNext()) {
                    String data = history.Current as String;
                    listBox1.Items.Add(data);
                }
            }
            foreach (EngineeringСalculator obj in engineeringСalculators) {
                listBox2.Items.Add(obj.Name);
                listBox2.Items.Add("Історія:");
                IEnumerator history = obj.GetOperationsEnumerator();
                while (history.MoveNext()) {
                    String data = history.Current as String;
                    listBox2.Items.Add(data);
                }
            }
        }

        private void saveCollections () {
            int key1 = engineeringСalculators.GetLastGenereticKey();
            int key2 = engineeringСalculators.GetLastNonGenereticKey();
            engineeringСalculators.AddToGenericCollection(key1 + 1, engineeringСalculator);
            engineeringСalculators.AddToNonGenericCollection(key2 + 1, engineeringСalculator);
            engineeringСalculator = null;
            updateEngLists();
        }
        private void saveToCollections_Click(object sender, EventArgs e) {
            if (engineeringСalculator != null) {
                val1.Text = "";
                val2.Text = "";
                saveCollections();
            } else {
                if (nameCalc.Text.Length > 0) {
                    engineeringСalculator = new EngineeringСalculator(nameCalc.Text.ToString());
                    val1.Text = "";
                    val2.Text = "";
                    resultCalc.Text = "";
                    saveCollections();
                } else {
                    TextBoxError("Вкажіть ім'я калькулятора!");
                }
            }
        }

        private void SubstrBtnOp_Click(object sender, EventArgs e) {
            if (isCorrectNumber(val1.Text.ToString()) && isCorrectNumber(val2.Text.ToString())) {
                if (nameCalc.Text.Length > 0) {
                    if (engineeringСalculator == null) {
                        engineeringСalculator = new EngineeringСalculator(nameCalc.Text.ToString());
                    }
                    double a = Convert.ToDouble(val1.Text.ToString());
                    double b = Convert.ToDouble(val2.Text.ToString());
                    resultCalc.Text = val1.Text.ToString() + " - " + val2.Text.ToString() + " = " + engineeringСalculator.Subtract(a, b).ToString();
                }
                else {
                    TextBoxError("Вкажіть ім'я калькулятора!");
                }
            }
        }

        private void multiBtn_Click(object sender, EventArgs e) {
            if (isCorrectNumber(val1.Text.ToString()) && isCorrectNumber(val2.Text.ToString())) {
                if (nameCalc.Text.Length > 0) {
                    if (engineeringСalculator == null) {
                        engineeringСalculator = new EngineeringСalculator(nameCalc.Text.ToString());
                    }
                    double a = Convert.ToDouble(val1.Text.ToString());
                    double b = Convert.ToDouble(val2.Text.ToString());
                    resultCalc.Text = val1.Text.ToString() + " * " + val2.Text.ToString() + " = " + engineeringСalculator.Multiply(a, b).ToString();
                }
                else {
                    TextBoxError("Вкажіть ім'я калькулятора!");
                }
            }
        }

        private void dividBtn_Click(object sender, EventArgs e) {
            if (isCorrectNumber(val1.Text.ToString()) && isCorrectNumber(val2.Text.ToString())) {
                if (nameCalc.Text.Length > 0) {
                    if (engineeringСalculator == null) {
                        engineeringСalculator = new EngineeringСalculator(nameCalc.Text.ToString());
                    }
                    double a = Convert.ToDouble(val1.Text.ToString());
                    double b = Convert.ToDouble(val2.Text.ToString());
                    resultCalc.Text = val1.Text.ToString() + " / " + val2.Text.ToString() + " = " + engineeringСalculator.Divide(a, b).ToString();
                }
                else {
                    TextBoxError("Вкажіть ім'я калькулятора!");
                }
            }
        }
    }
}
