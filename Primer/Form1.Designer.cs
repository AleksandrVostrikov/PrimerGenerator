namespace Primer
{
    partial class MainForm
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
            this.tbProblems = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.Task = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbAnswers = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rangeFrom = new System.Windows.Forms.NumericUpDown();
            this.rangeTo = new System.Windows.Forms.NumericUpDown();
            this.answerFrom = new System.Windows.Forms.NumericUpDown();
            this.answerTo = new System.Windows.Forms.NumericUpDown();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.Task.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProblems
            // 
            this.tbProblems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProblems.BackColor = System.Drawing.Color.White;
            this.tbProblems.Location = new System.Drawing.Point(3, 3);
            this.tbProblems.Multiline = true;
            this.tbProblems.Name = "tbProblems";
            this.tbProblems.ReadOnly = true;
            this.tbProblems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProblems.Size = new System.Drawing.Size(183, 280);
            this.tbProblems.TabIndex = 1;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(12, 45);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(108, 38);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Addition";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Task
            // 
            this.Task.Controls.Add(this.tabPage1);
            this.Task.Controls.Add(this.tabPage2);
            this.Task.Location = new System.Drawing.Point(12, 151);
            this.Task.Name = "Task";
            this.Task.SelectedIndex = 0;
            this.Task.Size = new System.Drawing.Size(200, 309);
            this.Task.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbProblems);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пример";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbAnswers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ответы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbAnswers
            // 
            this.tbAnswers.BackColor = System.Drawing.Color.White;
            this.tbAnswers.Location = new System.Drawing.Point(3, 3);
            this.tbAnswers.Multiline = true;
            this.tbAnswers.Name = "tbAnswers";
            this.tbAnswers.ReadOnly = true;
            this.tbAnswers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAnswers.Size = new System.Drawing.Size(183, 280);
            this.tbAnswers.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Subtraction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rangeFrom
            // 
            this.rangeFrom.Location = new System.Drawing.Point(136, 12);
            this.rangeFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rangeFrom.Name = "rangeFrom";
            this.rangeFrom.Size = new System.Drawing.Size(50, 20);
            this.rangeFrom.TabIndex = 5;
            // 
            // rangeTo
            // 
            this.rangeTo.Location = new System.Drawing.Point(136, 37);
            this.rangeTo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rangeTo.Name = "rangeTo";
            this.rangeTo.Size = new System.Drawing.Size(50, 20);
            this.rangeTo.TabIndex = 6;
            this.rangeTo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // answerFrom
            // 
            this.answerFrom.Location = new System.Drawing.Point(137, 64);
            this.answerFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.answerFrom.Name = "answerFrom";
            this.answerFrom.Size = new System.Drawing.Size(50, 20);
            this.answerFrom.TabIndex = 7;
            this.answerFrom.ValueChanged += new System.EventHandler(this.answerFrom_ValueChanged);
            // 
            // answerTo
            // 
            this.answerTo.Location = new System.Drawing.Point(136, 89);
            this.answerTo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.answerTo.Name = "answerTo";
            this.answerTo.Size = new System.Drawing.Size(50, 20);
            this.answerTo.TabIndex = 8;
            this.answerTo.ValueChanged += new System.EventHandler(this.answerTo_ValueChanged);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(12, 12);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(45, 20);
            this.quantity.TabIndex = 9;
            this.quantity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Primer.Properties.Resources.main_new_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(225, 472);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.answerTo);
            this.Controls.Add(this.answerFrom);
            this.Controls.Add(this.rangeTo);
            this.Controls.Add(this.rangeFrom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.generateButton);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Task.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbProblems;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TabControl Task;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbAnswers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown rangeFrom;
        private System.Windows.Forms.NumericUpDown rangeTo;
        private System.Windows.Forms.NumericUpDown answerFrom;
        private System.Windows.Forms.NumericUpDown answerTo;
        private System.Windows.Forms.NumericUpDown quantity;
    }
}

