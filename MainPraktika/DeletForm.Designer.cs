
namespace MainPraktika
{
    partial class DeletForm
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
            this.LbId = new System.Windows.Forms.Label();
            this.BtnDel = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbId
            // 
            this.LbId.AutoSize = true;
            this.LbId.Location = new System.Drawing.Point(12, 9);
            this.LbId.Name = "LbId";
            this.LbId.Size = new System.Drawing.Size(222, 13);
            this.LbId.TabIndex = 13;
            this.LbId.Text = "Введите Id отчета который хотите удалить";
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(51, 62);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(137, 30);
            this.BtnDel.TabIndex = 12;
            this.BtnDel.Text = "Удалить";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(26, 25);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(187, 31);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 102);
            this.Controls.Add(this.LbId);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.textBox5);
            this.Name = "DeletForm";
            this.Text = "DeletForm";
            this.Load += new System.EventHandler(this.DeletForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbId;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.TextBox textBox5;
    }
}