
namespace SPP_1_final_version_with_graphics_
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
            this.button1 = new System.Windows.Forms.Button();
            this.SortFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "OpenFile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenFile_click);
            // 
            // SortFile
            // 
            this.SortFile.Location = new System.Drawing.Point(224, 23);
            this.SortFile.Name = "SortFile";
            this.SortFile.Size = new System.Drawing.Size(162, 69);
            this.SortFile.TabIndex = 1;
            this.SortFile.Text = "SortFile";
            this.SortFile.UseVisualStyleBackColor = true;
            this.SortFile.Click += new System.EventHandler(this.SortFile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "GenerateFile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GenerateFile_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(230, 129);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(156, 26);
            this.textBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 187);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SortFile);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SortFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox;
    }
}

