namespace Day7
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
            this.count = new System.Windows.Forms.Label();
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(29, 70);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(36, 13);
            this.count.TabIndex = 0;
            this.count.Text = "Skaits";
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(94, 70);
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(100, 20);
            this.inputNumber.TabIndex = 1;
            this.inputNumber.Text = "1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(32, 97);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(162, 28);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Pieskaitīt";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(32, 143);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(162, 29);
            this.buttonMinus.TabIndex = 3;
            this.buttonMinus.Text = "Atņemt";
            this.buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(32, 191);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(162, 29);
            this.buttonClean.TabIndex = 4;
            this.buttonClean.Text = "Notīrīt";
            this.buttonClean.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 263);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.count);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label count;
        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonClean;
    }
}

