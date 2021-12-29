
namespace MainPraktika
{
    partial class AddForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LbFioStudenta = new System.Windows.Forms.Label();
            this.LbFioPrepodav = new System.Windows.Forms.Label();
            this.LbOchenka = new System.Windows.Forms.Label();
            this.LbDisciplina = new System.Windows.Forms.Label();
            this.LbData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(198, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 54);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 31);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(198, 91);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 31);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(198, 128);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 31);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(198, 165);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 31);
            this.textBox5.TabIndex = 4;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(112, 206);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(137, 30);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LbFioStudenta
            // 
            this.LbFioStudenta.AutoSize = true;
            this.LbFioStudenta.Location = new System.Drawing.Point(44, 20);
            this.LbFioStudenta.Name = "LbFioStudenta";
            this.LbFioStudenta.Size = new System.Drawing.Size(82, 13);
            this.LbFioStudenta.TabIndex = 6;
            this.LbFioStudenta.Text = "ФИО студента";
            // 
            // LbFioPrepodav
            // 
            this.LbFioPrepodav.AutoSize = true;
            this.LbFioPrepodav.Location = new System.Drawing.Point(31, 57);
            this.LbFioPrepodav.Name = "LbFioPrepodav";
            this.LbFioPrepodav.Size = new System.Drawing.Size(114, 13);
            this.LbFioPrepodav.TabIndex = 7;
            this.LbFioPrepodav.Text = "ФИО преподавателя";
            // 
            // LbOchenka
            // 
            this.LbOchenka.AutoSize = true;
            this.LbOchenka.Location = new System.Drawing.Point(56, 91);
            this.LbOchenka.Name = "LbOchenka";
            this.LbOchenka.Size = new System.Drawing.Size(45, 13);
            this.LbOchenka.TabIndex = 8;
            this.LbOchenka.Text = "Оценка";
            // 
            // LbDisciplina
            // 
            this.LbDisciplina.AutoSize = true;
            this.LbDisciplina.Location = new System.Drawing.Point(44, 128);
            this.LbDisciplina.Name = "LbDisciplina";
            this.LbDisciplina.Size = new System.Drawing.Size(70, 13);
            this.LbDisciplina.TabIndex = 9;
            this.LbDisciplina.Text = "Дисциплина";
            // 
            // LbData
            // 
            this.LbData.AutoSize = true;
            this.LbData.Location = new System.Drawing.Point(65, 168);
            this.LbData.Name = "LbData";
            this.LbData.Size = new System.Drawing.Size(33, 13);
            this.LbData.TabIndex = 10;
            this.LbData.Text = "Дата";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 248);
            this.Controls.Add(this.LbData);
            this.Controls.Add(this.LbDisciplina);
            this.Controls.Add(this.LbOchenka);
            this.Controls.Add(this.LbFioPrepodav);
            this.Controls.Add(this.LbFioStudenta);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LbFioStudenta;
        private System.Windows.Forms.Label LbFioPrepodav;
        private System.Windows.Forms.Label LbOchenka;
        private System.Windows.Forms.Label LbDisciplina;
        private System.Windows.Forms.Label LbData;
    }
}