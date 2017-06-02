namespace Singleton
{
    partial class FormOne
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNewForm = new System.Windows.Forms.Button();
            this.buttonMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewForm
            // 
            this.buttonNewForm.Location = new System.Drawing.Point(123, 34);
            this.buttonNewForm.Name = "buttonNewForm";
            this.buttonNewForm.Size = new System.Drawing.Size(128, 44);
            this.buttonNewForm.TabIndex = 0;
            this.buttonNewForm.Text = "New Form";
            this.buttonNewForm.UseVisualStyleBackColor = true;
            this.buttonNewForm.Click += new System.EventHandler(this.buttonNewForm_Click);
            // 
            // buttonMessage
            // 
            this.buttonMessage.Location = new System.Drawing.Point(123, 95);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(128, 44);
            this.buttonMessage.TabIndex = 1;
            this.buttonMessage.Text = "Close";
            this.buttonMessage.UseVisualStyleBackColor = true;
            this.buttonMessage.Click += new System.EventHandler(this.buttonMessage_Click);
            // 
            // FormOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 176);
            this.Controls.Add(this.buttonMessage);
            this.Controls.Add(this.buttonNewForm);
            this.Name = "FormOne";
            this.Text = "Форма";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOne_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewForm;
        private System.Windows.Forms.Button buttonMessage;
    }
}

