
namespace MergeMetadataForCreatio
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
            this.tbValue1 = new System.Windows.Forms.TextBox();
            this.tbValue2 = new System.Windows.Forms.TextBox();
            this.lblFirstValue = new System.Windows.Forms.Label();
            this.btnMerge = new System.Windows.Forms.Button();
            this.lblSecondValue = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbValue1
            // 
            this.tbValue1.Location = new System.Drawing.Point(13, 24);
            this.tbValue1.Multiline = true;
            this.tbValue1.Name = "tbValue1";
            this.tbValue1.Size = new System.Drawing.Size(600, 213);
            this.tbValue1.TabIndex = 0;
            // 
            // tbValue2
            // 
            this.tbValue2.Location = new System.Drawing.Point(619, 24);
            this.tbValue2.Multiline = true;
            this.tbValue2.Name = "tbValue2";
            this.tbValue2.Size = new System.Drawing.Size(600, 213);
            this.tbValue2.TabIndex = 1;
            // 
            // lblFirstValue
            // 
            this.lblFirstValue.AutoSize = true;
            this.lblFirstValue.Location = new System.Drawing.Point(12, 9);
            this.lblFirstValue.Name = "lblFirstValue";
            this.lblFirstValue.Size = new System.Drawing.Size(56, 13);
            this.lblFirstValue.TabIndex = 2;
            this.lblFirstValue.Text = "First Value";
            // 
            // btnMerge
            // 
            this.btnMerge.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMerge.Location = new System.Drawing.Point(576, 243);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 23);
            this.btnMerge.TabIndex = 3;
            this.btnMerge.Text = "MERGE";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // lblSecondValue
            // 
            this.lblSecondValue.AutoSize = true;
            this.lblSecondValue.Location = new System.Drawing.Point(616, 8);
            this.lblSecondValue.Name = "lblSecondValue";
            this.lblSecondValue.Size = new System.Drawing.Size(74, 13);
            this.lblSecondValue.TabIndex = 4;
            this.lblSecondValue.Text = "Second Value";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 272);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(1206, 124);
            this.tbResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 495);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblSecondValue);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.lblFirstValue);
            this.Controls.Add(this.tbValue2);
            this.Controls.Add(this.tbValue1);
            this.Name = "Form1";
            this.Text = "Merge Metadata From Creatio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValue1;
        private System.Windows.Forms.TextBox tbValue2;
        private System.Windows.Forms.Label lblFirstValue;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Label lblSecondValue;
        private System.Windows.Forms.TextBox tbResult;
    }
}

