namespace SimpleCalculator
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
            this.FirstValue = new System.Windows.Forms.Label();
            this.SecondValue = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Operators = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.RadioButton();
            this.SubtractionButton = new System.Windows.Forms.RadioButton();
            this.MultiplicationButton = new System.Windows.Forms.RadioButton();
            this.DivisionButton = new System.Windows.Forms.RadioButton();
            this.Operators.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstValue
            // 
            this.FirstValue.AutoSize = true;
            this.FirstValue.Location = new System.Drawing.Point(33, 24);
            this.FirstValue.Name = "FirstValue";
            this.FirstValue.Size = new System.Drawing.Size(53, 13);
            this.FirstValue.TabIndex = 0;
            this.FirstValue.Text = "FirstValue";
            // 
            // SecondValue
            // 
            this.SecondValue.AutoSize = true;
            this.SecondValue.Location = new System.Drawing.Point(33, 160);
            this.SecondValue.Name = "SecondValue";
            this.SecondValue.Size = new System.Drawing.Size(71, 13);
            this.SecondValue.TabIndex = 1;
            this.SecondValue.Text = "SecondValue";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 3;
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location = new System.Drawing.Point(182, 313);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(100, 20);
            this.AnswerBox.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(197, 252);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Operators
            // 
            this.Operators.Controls.Add(this.DivisionButton);
            this.Operators.Controls.Add(this.MultiplicationButton);
            this.Operators.Controls.Add(this.SubtractionButton);
            this.Operators.Controls.Add(this.AddButton);
            this.Operators.Location = new System.Drawing.Point(247, 50);
            this.Operators.Name = "Operators";
            this.Operators.Size = new System.Drawing.Size(200, 179);
            this.Operators.TabIndex = 7;
            this.Operators.TabStop = false;
            this.Operators.Text = "Operators";
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Location = new System.Drawing.Point(19, 31);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(44, 17);
            this.AddButton.TabIndex = 0;
            this.AddButton.TabStop = true;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.AutoSize = true;
            this.SubtractionButton.Location = new System.Drawing.Point(19, 71);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(65, 17);
            this.SubtractionButton.TabIndex = 1;
            this.SubtractionButton.TabStop = true;
            this.SubtractionButton.Text = "Subtract";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.AutoSize = true;
            this.MultiplicationButton.Location = new System.Drawing.Point(19, 106);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(60, 17);
            this.MultiplicationButton.TabIndex = 2;
            this.MultiplicationButton.TabStop = true;
            this.MultiplicationButton.Text = "Multiply";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            // 
            // DivisionButton
            // 
            this.DivisionButton.AutoSize = true;
            this.DivisionButton.Location = new System.Drawing.Point(19, 140);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(55, 17);
            this.DivisionButton.TabIndex = 3;
            this.DivisionButton.TabStop = true;
            this.DivisionButton.Text = "Divide";
            this.DivisionButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 362);
            this.Controls.Add(this.Operators);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SecondValue);
            this.Controls.Add(this.FirstValue);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Operators.ResumeLayout(false);
            this.Operators.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstValue;
        private System.Windows.Forms.Label SecondValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.GroupBox Operators;
        private System.Windows.Forms.RadioButton DivisionButton;
        private System.Windows.Forms.RadioButton MultiplicationButton;
        private System.Windows.Forms.RadioButton SubtractionButton;
        private System.Windows.Forms.RadioButton AddButton;
    }
}

