namespace Lab5
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstDecimal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.strResult = new System.Windows.Forms.Label();
            this.strLength = new System.Windows.Forms.Label();
            this.arrayList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sortArray = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameCalc = new System.Windows.Forms.TextBox();
            this.val1 = new System.Windows.Forms.TextBox();
            this.val2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addBtnOp = new System.Windows.Forms.Button();
            this.SubstrBtnOp = new System.Windows.Forms.Button();
            this.resultCalc = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.multiBtn = new System.Windows.Forms.Button();
            this.dividBtn = new System.Windows.Forms.Button();
            this.saveToCollections = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перша десяткова стрічка";
            // 
            // firstDecimal
            // 
            this.firstDecimal.Location = new System.Drawing.Point(37, 89);
            this.firstDecimal.Name = "firstDecimal";
            this.firstDecimal.Size = new System.Drawing.Size(169, 22);
            this.firstDecimal.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ToString";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // strResult
            // 
            this.strResult.AutoSize = true;
            this.strResult.Location = new System.Drawing.Point(99, 153);
            this.strResult.Name = "strResult";
            this.strResult.Size = new System.Drawing.Size(0, 16);
            this.strResult.TabIndex = 5;
            // 
            // strLength
            // 
            this.strLength.AutoSize = true;
            this.strLength.Location = new System.Drawing.Point(167, 183);
            this.strLength.Name = "strLength";
            this.strLength.Size = new System.Drawing.Size(0, 16);
            this.strLength.TabIndex = 9;
            // 
            // arrayList
            // 
            this.arrayList.FormattingEnabled = true;
            this.arrayList.ItemHeight = 16;
            this.arrayList.Location = new System.Drawing.Point(228, 89);
            this.arrayList.Name = "arrayList";
            this.arrayList.Size = new System.Drawing.Size(234, 244);
            this.arrayList.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Початковий масив";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Відсортований масив";
            // 
            // sortArray
            // 
            this.sortArray.FormattingEnabled = true;
            this.sortArray.ItemHeight = 16;
            this.sortArray.Location = new System.Drawing.Point(489, 89);
            this.sortArray.Name = "sortArray";
            this.sortArray.Size = new System.Drawing.Size(211, 244);
            this.sortArray.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(765, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Інженерний калькулятор";
            // 
            // nameCalc
            // 
            this.nameCalc.Location = new System.Drawing.Point(768, 117);
            this.nameCalc.Name = "nameCalc";
            this.nameCalc.Size = new System.Drawing.Size(182, 22);
            this.nameCalc.TabIndex = 17;
            // 
            // val1
            // 
            this.val1.Location = new System.Drawing.Point(768, 180);
            this.val1.Name = "val1";
            this.val1.Size = new System.Drawing.Size(73, 22);
            this.val1.TabIndex = 18;
            // 
            // val2
            // 
            this.val2.Location = new System.Drawing.Point(870, 180);
            this.val2.Name = "val2";
            this.val2.Size = new System.Drawing.Size(80, 22);
            this.val2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(765, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Назва";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(799, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(897, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Y";
            // 
            // addBtnOp
            // 
            this.addBtnOp.Location = new System.Drawing.Point(768, 246);
            this.addBtnOp.Name = "addBtnOp";
            this.addBtnOp.Size = new System.Drawing.Size(96, 23);
            this.addBtnOp.TabIndex = 23;
            this.addBtnOp.Text = "Операція +";
            this.addBtnOp.UseVisualStyleBackColor = true;
            this.addBtnOp.Click += new System.EventHandler(this.addBtnOp_Click);
            // 
            // SubstrBtnOp
            // 
            this.SubstrBtnOp.Location = new System.Drawing.Point(873, 246);
            this.SubstrBtnOp.Name = "SubstrBtnOp";
            this.SubstrBtnOp.Size = new System.Drawing.Size(92, 23);
            this.SubstrBtnOp.TabIndex = 24;
            this.SubstrBtnOp.Text = "Операція -";
            this.SubstrBtnOp.UseVisualStyleBackColor = true;
            this.SubstrBtnOp.Click += new System.EventHandler(this.SubstrBtnOp_Click);
            // 
            // resultCalc
            // 
            this.resultCalc.AutoSize = true;
            this.resultCalc.Location = new System.Drawing.Point(765, 217);
            this.resultCalc.Name = "resultCalc";
            this.resultCalc.Size = new System.Drawing.Size(0, 16);
            this.resultCalc.TabIndex = 26;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1002, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 244);
            this.listBox1.TabIndex = 27;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(1177, 89);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(163, 244);
            this.listBox2.TabIndex = 28;
            // 
            // multiBtn
            // 
            this.multiBtn.Location = new System.Drawing.Point(768, 287);
            this.multiBtn.Name = "multiBtn";
            this.multiBtn.Size = new System.Drawing.Size(96, 23);
            this.multiBtn.TabIndex = 29;
            this.multiBtn.Text = "Операція *";
            this.multiBtn.UseVisualStyleBackColor = true;
            this.multiBtn.Click += new System.EventHandler(this.multiBtn_Click);
            // 
            // dividBtn
            // 
            this.dividBtn.Location = new System.Drawing.Point(873, 287);
            this.dividBtn.Name = "dividBtn";
            this.dividBtn.Size = new System.Drawing.Size(92, 23);
            this.dividBtn.TabIndex = 30;
            this.dividBtn.Text = "Операція /";
            this.dividBtn.UseVisualStyleBackColor = true;
            this.dividBtn.Click += new System.EventHandler(this.dividBtn_Click);
            // 
            // saveToCollections
            // 
            this.saveToCollections.Location = new System.Drawing.Point(828, 332);
            this.saveToCollections.Name = "saveToCollections";
            this.saveToCollections.Size = new System.Drawing.Size(85, 23);
            this.saveToCollections.TabIndex = 31;
            this.saveToCollections.Text = "Зберегти";
            this.saveToCollections.UseVisualStyleBackColor = true;
            this.saveToCollections.Click += new System.EventHandler(this.saveToCollections_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 394);
            this.Controls.Add(this.saveToCollections);
            this.Controls.Add(this.dividBtn);
            this.Controls.Add(this.multiBtn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.resultCalc);
            this.Controls.Add(this.SubstrBtnOp);
            this.Controls.Add(this.addBtnOp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.val2);
            this.Controls.Add(this.val1);
            this.Controls.Add(this.nameCalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortArray);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrayList);
            this.Controls.Add(this.strLength);
            this.Controls.Add(this.strResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstDecimal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Лабораторна 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstDecimal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label strResult;
        private System.Windows.Forms.Label strLength;
        private System.Windows.Forms.ListBox arrayList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox sortArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameCalc;
        private System.Windows.Forms.TextBox val1;
        private System.Windows.Forms.TextBox val2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addBtnOp;
        private System.Windows.Forms.Button SubstrBtnOp;
        private System.Windows.Forms.Label resultCalc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button multiBtn;
        private System.Windows.Forms.Button dividBtn;
        private System.Windows.Forms.Button saveToCollections;
    }
}

