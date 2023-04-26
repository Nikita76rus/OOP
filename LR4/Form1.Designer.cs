namespace LR4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputArr = new System.Windows.Forms.TextBox();
            this.outputArr = new System.Windows.Forms.TextBox();
            this.fill = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный массив";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(188, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Полученный массив";
            // 
            // inputArr
            // 
            this.inputArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputArr.Location = new System.Drawing.Point(12, 32);
            this.inputArr.Multiline = true;
            this.inputArr.Name = "inputArr";
            this.inputArr.Size = new System.Drawing.Size(162, 311);
            this.inputArr.TabIndex = 2;
            // 
            // outputArr
            // 
            this.outputArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputArr.Location = new System.Drawing.Point(192, 32);
            this.outputArr.Multiline = true;
            this.outputArr.Name = "outputArr";
            this.outputArr.Size = new System.Drawing.Size(162, 311);
            this.outputArr.TabIndex = 3;
            // 
            // fill
            // 
            this.fill.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.fill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fill.Location = new System.Drawing.Point(12, 364);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(162, 40);
            this.fill.TabIndex = 4;
            this.fill.Text = "Заполнить";
            this.fill.UseVisualStyleBackColor = false;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.SpringGreen;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(192, 364);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(162, 40);
            this.start.TabIndex = 5;
            this.start.Text = "Пуск";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.start);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.outputArr);
            this.Controls.Add(this.inputArr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LR4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputArr;
        private System.Windows.Forms.TextBox outputArr;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.Button start;
    }
}

