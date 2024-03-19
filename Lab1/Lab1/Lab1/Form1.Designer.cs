namespace Lab1
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
            this.buttonPush_Click = new System.Windows.Forms.Button();
            this.buttonPop_Click = new System.Windows.Forms.Button();
            this.buttonClear_Click = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelIsEmpty = new System.Windows.Forms.Label();
            this.textBoxCurrentElement = new System.Windows.Forms.TextBox();
            this.buttonShowItems_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPush_Click
            // 
            this.buttonPush_Click.Location = new System.Drawing.Point(14, 24);
            this.buttonPush_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPush_Click.Name = "buttonPush_Click";
            this.buttonPush_Click.Size = new System.Drawing.Size(147, 19);
            this.buttonPush_Click.TabIndex = 0;
            this.buttonPush_Click.Text = "Добавить элемент";
            this.buttonPush_Click.UseVisualStyleBackColor = true;
            this.buttonPush_Click.Click += new System.EventHandler(this.buttonPush_Click_Click);
            // 
            // buttonPop_Click
            // 
            this.buttonPop_Click.Location = new System.Drawing.Point(14, 59);
            this.buttonPop_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPop_Click.Name = "buttonPop_Click";
            this.buttonPop_Click.Size = new System.Drawing.Size(165, 19);
            this.buttonPop_Click.TabIndex = 1;
            this.buttonPop_Click.Text = "Удалить элемент из очереди";
            this.buttonPop_Click.UseVisualStyleBackColor = true;
            this.buttonPop_Click.Click += new System.EventHandler(this.buttonPop_Click_Click);
            // 
            // buttonClear_Click
            // 
            this.buttonClear_Click.Location = new System.Drawing.Point(310, 23);
            this.buttonClear_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear_Click.Name = "buttonClear_Click";
            this.buttonClear_Click.Size = new System.Drawing.Size(126, 19);
            this.buttonClear_Click.TabIndex = 2;
            this.buttonClear_Click.Text = "Очистить очередь";
            this.buttonClear_Click.UseVisualStyleBackColor = true;
            this.buttonClear_Click.Click += new System.EventHandler(this.buttonClear_Click_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(307, 65);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(57, 13);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "labelCount";
            // 
            // labelIsEmpty
            // 
            this.labelIsEmpty.AutoSize = true;
            this.labelIsEmpty.Location = new System.Drawing.Point(307, 92);
            this.labelIsEmpty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIsEmpty.Name = "labelIsEmpty";
            this.labelIsEmpty.Size = new System.Drawing.Size(66, 13);
            this.labelIsEmpty.TabIndex = 4;
            this.labelIsEmpty.Text = "labelIsEmpty";
            // 
            // textBoxCurrentElement
            // 
            this.textBoxCurrentElement.Location = new System.Drawing.Point(178, 23);
            this.textBoxCurrentElement.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCurrentElement.Name = "textBoxCurrentElement";
            this.textBoxCurrentElement.Size = new System.Drawing.Size(104, 20);
            this.textBoxCurrentElement.TabIndex = 5;
            // 
            // buttonShowItems_Click
            // 
            this.buttonShowItems_Click.Location = new System.Drawing.Point(11, 92);
            this.buttonShowItems_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowItems_Click.Name = "buttonShowItems_Click";
            this.buttonShowItems_Click.Size = new System.Drawing.Size(120, 28);
            this.buttonShowItems_Click.TabIndex = 6;
            this.buttonShowItems_Click.Text = "Все элементы";
            this.buttonShowItems_Click.UseVisualStyleBackColor = true;
            this.buttonShowItems_Click.Click += new System.EventHandler(this.buttonShowItems_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonShowItems_Click);
            this.Controls.Add(this.textBoxCurrentElement);
            this.Controls.Add(this.labelIsEmpty);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonClear_Click);
            this.Controls.Add(this.buttonPop_Click);
            this.Controls.Add(this.buttonPush_Click);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPush_Click;
        private System.Windows.Forms.Button buttonPop_Click;
        private System.Windows.Forms.Button buttonClear_Click;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelIsEmpty;
        private System.Windows.Forms.TextBox textBoxCurrentElement;
        private System.Windows.Forms.Button buttonShowItems_Click;
    }
}

