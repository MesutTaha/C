namespace HW_14._26
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.boldChechkBox = new System.Windows.Forms.CheckBox();
            this.italicChcekBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boldChechkBox
            // 
            this.boldChechkBox.AutoSize = true;
            this.boldChechkBox.Location = new System.Drawing.Point(219, 177);
            this.boldChechkBox.Name = "boldChechkBox";
            this.boldChechkBox.Size = new System.Drawing.Size(47, 17);
            this.boldChechkBox.TabIndex = 0;
            this.boldChechkBox.Text = "Bold";
            this.boldChechkBox.UseVisualStyleBackColor = true;
            this.boldChechkBox.CheckedChanged += new System.EventHandler(this.boldChechkBox_CheckedChanged);
            // 
            // italicChcekBox
            // 
            this.italicChcekBox.AutoSize = true;
            this.italicChcekBox.Location = new System.Drawing.Point(312, 177);
            this.italicChcekBox.Name = "italicChcekBox";
            this.italicChcekBox.Size = new System.Drawing.Size(48, 17);
            this.italicChcekBox.TabIndex = 1;
            this.italicChcekBox.Text = "Italic";
            this.italicChcekBox.UseVisualStyleBackColor = true;
            this.italicChcekBox.CheckedChanged += new System.EventHandler(this.italicChcekBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Watch the font style change";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.italicChcekBox);
            this.Controls.Add(this.boldChechkBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox boldChechkBox;
        private System.Windows.Forms.CheckBox italicChcekBox;
        private System.Windows.Forms.Label label1;
    }
}

