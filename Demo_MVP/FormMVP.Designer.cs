namespace Demo_MVP
{
    partial class FormMVP
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
            this._farenheitBox = new System.Windows.Forms.TextBox();
            this._celsiusBox = new System.Windows.Forms.TextBox();
            this._inputBox = new System.Windows.Forms.TextBox();
            this._celsiusButton = new System.Windows.Forms.Button();
            this._farenheitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _farenheitBox
            // 
            this._farenheitBox.Location = new System.Drawing.Point(280, 22);
            this._farenheitBox.Name = "_farenheitBox";
            this._farenheitBox.ReadOnly = true;
            this._farenheitBox.Size = new System.Drawing.Size(66, 20);
            this._farenheitBox.TabIndex = 2;
            // 
            // _celsiusBox
            // 
            this._celsiusBox.Location = new System.Drawing.Point(280, 68);
            this._celsiusBox.Name = "_celsiusBox";
            this._celsiusBox.ReadOnly = true;
            this._celsiusBox.Size = new System.Drawing.Size(66, 20);
            this._celsiusBox.TabIndex = 3;
            // 
            // _inputBox
            // 
            this._inputBox.Location = new System.Drawing.Point(98, 22);
            this._inputBox.Name = "_inputBox";
            this._inputBox.Size = new System.Drawing.Size(66, 20);
            this._inputBox.TabIndex = 1;
            this._inputBox.Text = "0";
            // 
            // _celsiusButton
            // 
            this._celsiusButton.Location = new System.Drawing.Point(168, 130);
            this._celsiusButton.Name = "_celsiusButton";
            this._celsiusButton.Size = new System.Drawing.Size(75, 23);
            this._celsiusButton.TabIndex = 4;
            this._celsiusButton.Text = "celsius";
            this._celsiusButton.UseVisualStyleBackColor = true;
            this._celsiusButton.Click += new System.EventHandler(this._celsiusButton_Click);
            // 
            // _farenheitButton
            // 
            this._farenheitButton.Location = new System.Drawing.Point(271, 130);
            this._farenheitButton.Name = "_farenheitButton";
            this._farenheitButton.Size = new System.Drawing.Size(75, 23);
            this._farenheitButton.TabIndex = 5;
            this._farenheitButton.Text = "farenheit";
            this._farenheitButton.UseVisualStyleBackColor = true;
            this._farenheitButton.Click += new System.EventHandler(this._farenheitButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(205, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фаренгейт:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(205, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Цельсия:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Значение:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormMVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 183);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._farenheitButton);
            this.Controls.Add(this._celsiusButton);
            this.Controls.Add(this._inputBox);
            this.Controls.Add(this._celsiusBox);
            this.Controls.Add(this._farenheitBox);
            this.Name = "FormMVP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo MVP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _farenheitBox;
        private System.Windows.Forms.TextBox _celsiusBox;
        private System.Windows.Forms.TextBox _inputBox;
        private System.Windows.Forms.Button _celsiusButton;
        private System.Windows.Forms.Button _farenheitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

