
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
            this.lblFirstValue = new System.Windows.Forms.Label();
            this.btnMerge = new System.Windows.Forms.Button();
            this.lblSecondValue = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbValue1 = new System.Windows.Forms.RichTextBox();
            this.tbValue2 = new System.Windows.Forms.RichTextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.btnMerge.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.ForeColor = System.Drawing.SystemColors.InfoText;
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
            this.tbResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult.Location = new System.Drawing.Point(12, 272);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(1206, 124);
            this.tbResult.TabIndex = 5;
            // 
            // tbValue1
            // 
            this.tbValue1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbValue1.Location = new System.Drawing.Point(12, 24);
            this.tbValue1.Name = "tbValue1";
            this.tbValue1.Size = new System.Drawing.Size(601, 213);
            this.tbValue1.TabIndex = 6;
            this.tbValue1.Text = "";
            // 
            // tbValue2
            // 
            this.tbValue2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbValue2.Location = new System.Drawing.Point(619, 24);
            this.tbValue2.Name = "tbValue2";
            this.tbValue2.Size = new System.Drawing.Size(601, 213);
            this.tbValue2.TabIndex = 7;
            this.tbValue2.Text = "";
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopy.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCopy.Location = new System.Drawing.Point(555, 402);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(135, 23);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "COPY CLIPBOARD";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 435);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tbValue2);
            this.Controls.Add(this.tbValue1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblSecondValue);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.lblFirstValue);
            this.Name = "Form1";
            this.Text = "Merge Metadata From Creatio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFirstValue;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Label lblSecondValue;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.RichTextBox tbValue1;
        private System.Windows.Forms.RichTextBox tbValue2;
        private System.Windows.Forms.Button btnCopy;
    }
}

