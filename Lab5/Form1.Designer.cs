﻿namespace Lab5
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
            this.label2 = new System.Windows.Forms.Label();
            this.firstDecimal = new System.Windows.Forms.TextBox();
            this.secondDecimal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.strResult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.strLength = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.compareStr = new System.Windows.Forms.Label();
            this.arrayList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sortArray = new System.Windows.Forms.ListBox();
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.sortOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перша десяткова стрічка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Друга десяткова стрічка";
            // 
            // firstDecimal
            // 
            this.firstDecimal.Location = new System.Drawing.Point(105, 89);
            this.firstDecimal.Name = "firstDecimal";
            this.firstDecimal.Size = new System.Drawing.Size(169, 22);
            this.firstDecimal.TabIndex = 2;
            // 
            // secondDecimal
            // 
            this.secondDecimal.Location = new System.Drawing.Point(105, 251);
            this.secondDecimal.Name = "secondDecimal";
            this.secondDecimal.Size = new System.Drawing.Size(165, 22);
            this.secondDecimal.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 117);
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
            this.strResult.Location = new System.Drawing.Point(167, 153);
            this.strResult.Name = "strResult";
            this.strResult.Size = new System.Drawing.Size(0, 16);
            this.strResult.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(164, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // strLength
            // 
            this.strLength.AutoSize = true;
            this.strLength.Location = new System.Drawing.Point(167, 183);
            this.strLength.Name = "strLength";
            this.strLength.Size = new System.Drawing.Size(0, 16);
            this.strLength.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Результат:";
            // 
            // compareStr
            // 
            this.compareStr.AutoSize = true;
            this.compareStr.Location = new System.Drawing.Point(102, 372);
            this.compareStr.Name = "compareStr";
            this.compareStr.Size = new System.Drawing.Size(0, 16);
            this.compareStr.TabIndex = 11;
            // 
            // arrayList
            // 
            this.arrayList.FormattingEnabled = true;
            this.arrayList.ItemHeight = 16;
            this.arrayList.Location = new System.Drawing.Point(336, 89);
            this.arrayList.Name = "arrayList";
            this.arrayList.Size = new System.Drawing.Size(234, 244);
            this.arrayList.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Початковий масив";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Відсортований масив";
            // 
            // sortArray
            // 
            this.sortArray.FormattingEnabled = true;
            this.sortArray.ItemHeight = 16;
            this.sortArray.Location = new System.Drawing.Point(597, 89);
            this.sortArray.Name = "sortArray";
            this.sortArray.Size = new System.Drawing.Size(211, 244);
            this.sortArray.TabIndex = 15;
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Location = new System.Drawing.Point(521, 354);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(160, 20);
            this.checkbox.TabIndex = 16;
            this.checkbox.Text = "У порядку спадання";
            this.checkbox.UseVisualStyleBackColor = true;
            // 
            // sortOrder
            // 
            this.sortOrder.Location = new System.Drawing.Point(545, 390);
            this.sortOrder.Name = "sortOrder";
            this.sortOrder.Size = new System.Drawing.Size(89, 31);
            this.sortOrder.TabIndex = 17;
            this.sortOrder.Text = "Sort";
            this.sortOrder.UseVisualStyleBackColor = true;
            this.sortOrder.Click += new System.EventHandler(this.sortOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.sortOrder);
            this.Controls.Add(this.checkbox);
            this.Controls.Add(this.sortArray);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrayList);
            this.Controls.Add(this.compareStr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.strLength);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.strResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondDecimal);
            this.Controls.Add(this.firstDecimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Лабораторна 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstDecimal;
        private System.Windows.Forms.TextBox secondDecimal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label strResult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label strLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label compareStr;
        private System.Windows.Forms.ListBox arrayList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox sortArray;
        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.Button sortOrder;
    }
}

