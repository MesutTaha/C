namespace HW_14._20
{
    partial class LabelTextBoxButtonTest
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
            this.displayPasswordButton = new System.Windows.Forms.Button();
            this.displayPasswordLabel = new System.Windows.Forms.Label();
            this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayPasswordButton
            // 
            this.displayPasswordButton.Location = new System.Drawing.Point(341, 242);
            this.displayPasswordButton.Name = "displayPasswordButton";
            this.displayPasswordButton.Size = new System.Drawing.Size(75, 23);
            this.displayPasswordButton.TabIndex = 0;
            this.displayPasswordButton.Text = "Show Me";
            this.displayPasswordButton.UseVisualStyleBackColor = true;
            this.displayPasswordButton.Click += new System.EventHandler(this.displayPasswordButton_Click);
            // 
            // displayPasswordLabel
            // 
            this.displayPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayPasswordLabel.Location = new System.Drawing.Point(323, 183);
            this.displayPasswordLabel.Name = "displayPasswordLabel";
            this.displayPasswordLabel.Size = new System.Drawing.Size(109, 33);
            this.displayPasswordLabel.TabIndex = 1;
            this.displayPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputPasswordTextBox
            // 
            this.inputPasswordTextBox.Location = new System.Drawing.Point(276, 144);
            this.inputPasswordTextBox.Name = "inputPasswordTextBox";
            this.inputPasswordTextBox.Size = new System.Drawing.Size(214, 20);
            this.inputPasswordTextBox.TabIndex = 2;
            this.inputPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LabelTextBoxButtonTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputPasswordTextBox);
            this.Controls.Add(this.displayPasswordLabel);
            this.Controls.Add(this.displayPasswordButton);
            this.Name = "LabelTextBoxButtonTest";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayPasswordButton;
        private System.Windows.Forms.Label displayPasswordLabel;
        private System.Windows.Forms.TextBox inputPasswordTextBox;
    }
}

