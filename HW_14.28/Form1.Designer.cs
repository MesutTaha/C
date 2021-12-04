namespace HW_14._28
{
    partial class RadioButtonsTest
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
            this.buttonType = new System.Windows.Forms.GroupBox();
            this.RCradioButton = new System.Windows.Forms.RadioButton();
            this.YNradioButton = new System.Windows.Forms.RadioButton();
            this.YNCradioButton = new System.Windows.Forms.RadioButton();
            this.ARIradioButton = new System.Windows.Forms.RadioButton();
            this.OKCancelRadioButton = new System.Windows.Forms.RadioButton();
            this.OKRadioButton = new System.Windows.Forms.RadioButton();
            this.displayButton = new System.Windows.Forms.Button();
            this.iconType = new System.Windows.Forms.GroupBox();
            this.warningRadioButton = new System.Windows.Forms.RadioButton();
            this.stopRadioButton = new System.Windows.Forms.RadioButton();
            this.questionRadioButton = new System.Windows.Forms.RadioButton();
            this.informationRadioButton = new System.Windows.Forms.RadioButton();
            this.handRadioButton = new System.Windows.Forms.RadioButton();
            this.exclamationRadioButton = new System.Windows.Forms.RadioButton();
            this.errorRadioButton = new System.Windows.Forms.RadioButton();
            this.asteriksRadioButton = new System.Windows.Forms.RadioButton();
            this.displayLabel = new System.Windows.Forms.Label();
            this.buttonType.SuspendLayout();
            this.iconType.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonType
            // 
            this.buttonType.Controls.Add(this.RCradioButton);
            this.buttonType.Controls.Add(this.YNradioButton);
            this.buttonType.Controls.Add(this.YNCradioButton);
            this.buttonType.Controls.Add(this.ARIradioButton);
            this.buttonType.Controls.Add(this.OKCancelRadioButton);
            this.buttonType.Controls.Add(this.OKRadioButton);
            this.buttonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonType.Location = new System.Drawing.Point(62, 27);
            this.buttonType.Name = "buttonType";
            this.buttonType.Size = new System.Drawing.Size(200, 169);
            this.buttonType.TabIndex = 0;
            this.buttonType.TabStop = false;
            this.buttonType.Text = "Button Type";
           
            // 
            // RCradioButton
            // 
            this.RCradioButton.AutoSize = true;
            this.RCradioButton.Location = new System.Drawing.Point(6, 143);
            this.RCradioButton.Name = "RCradioButton";
            this.RCradioButton.Size = new System.Drawing.Size(103, 21);
            this.RCradioButton.TabIndex = 5;
            this.RCradioButton.TabStop = true;
            this.RCradioButton.Text = "RetryCancel";
            this.RCradioButton.UseVisualStyleBackColor = true;
            // 
            // YNradioButton
            // 
            this.YNradioButton.AutoSize = true;
            this.YNradioButton.Location = new System.Drawing.Point(6, 120);
            this.YNradioButton.Name = "YNradioButton";
            this.YNradioButton.Size = new System.Drawing.Size(68, 21);
            this.YNradioButton.TabIndex = 4;
            this.YNradioButton.TabStop = true;
            this.YNradioButton.Text = "YesNo";
            this.YNradioButton.UseVisualStyleBackColor = true;
            // 
            // YNCradioButton
            // 
            this.YNCradioButton.AutoSize = true;
            this.YNCradioButton.Location = new System.Drawing.Point(6, 97);
            this.YNCradioButton.Name = "YNCradioButton";
            this.YNCradioButton.Size = new System.Drawing.Size(111, 21);
            this.YNCradioButton.TabIndex = 3;
            this.YNCradioButton.TabStop = true;
            this.YNCradioButton.Text = "YesNoCancel";
            this.YNCradioButton.UseVisualStyleBackColor = true;
            // 
            // ARIradioButton
            // 
            this.ARIradioButton.AutoSize = true;
            this.ARIradioButton.Location = new System.Drawing.Point(6, 74);
            this.ARIradioButton.Name = "ARIradioButton";
            this.ARIradioButton.Size = new System.Drawing.Size(134, 21);
            this.ARIradioButton.TabIndex = 2;
            this.ARIradioButton.TabStop = true;
            this.ARIradioButton.Text = "AbortRetryIgnore";
            this.ARIradioButton.UseVisualStyleBackColor = true;
            // 
            // OKCancelRadioButton
            // 
            this.OKCancelRadioButton.AutoSize = true;
            this.OKCancelRadioButton.Location = new System.Drawing.Point(6, 51);
            this.OKCancelRadioButton.Name = "OKCancelRadioButton";
            this.OKCancelRadioButton.Size = new System.Drawing.Size(89, 21);
            this.OKCancelRadioButton.TabIndex = 1;
            this.OKCancelRadioButton.TabStop = true;
            this.OKCancelRadioButton.Text = "OKCancel";
            this.OKCancelRadioButton.UseVisualStyleBackColor = true;
            // 
            // OKRadioButton
            // 
            this.OKRadioButton.AutoSize = true;
            this.OKRadioButton.Location = new System.Drawing.Point(6, 28);
            this.OKRadioButton.Name = "OKRadioButton";
            this.OKRadioButton.Size = new System.Drawing.Size(46, 21);
            this.OKRadioButton.TabIndex = 0;
            this.OKRadioButton.TabStop = true;
            this.OKRadioButton.Text = "OK";
            this.OKRadioButton.UseVisualStyleBackColor = true;
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.Location = new System.Drawing.Point(84, 218);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(130, 36);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // iconType
            // 
            this.iconType.Controls.Add(this.warningRadioButton);
            this.iconType.Controls.Add(this.stopRadioButton);
            this.iconType.Controls.Add(this.questionRadioButton);
            this.iconType.Controls.Add(this.informationRadioButton);
            this.iconType.Controls.Add(this.handRadioButton);
            this.iconType.Controls.Add(this.exclamationRadioButton);
            this.iconType.Controls.Add(this.errorRadioButton);
            this.iconType.Controls.Add(this.asteriksRadioButton);
            this.iconType.Location = new System.Drawing.Point(268, 27);
            this.iconType.Name = "iconType";
            this.iconType.Size = new System.Drawing.Size(136, 207);
            this.iconType.TabIndex = 2;
            this.iconType.TabStop = false;
            this.iconType.Text = "Icon";
           
            // 
            // warningRadioButton
            // 
            this.warningRadioButton.AutoSize = true;
            this.warningRadioButton.Location = new System.Drawing.Point(7, 181);
            this.warningRadioButton.Name = "warningRadioButton";
            this.warningRadioButton.Size = new System.Drawing.Size(65, 17);
            this.warningRadioButton.TabIndex = 7;
            this.warningRadioButton.TabStop = true;
            this.warningRadioButton.Text = "Warning";
            this.warningRadioButton.UseVisualStyleBackColor = true;
            // 
            // stopRadioButton
            // 
            this.stopRadioButton.AutoSize = true;
            this.stopRadioButton.Location = new System.Drawing.Point(7, 158);
            this.stopRadioButton.Name = "stopRadioButton";
            this.stopRadioButton.Size = new System.Drawing.Size(47, 17);
            this.stopRadioButton.TabIndex = 6;
            this.stopRadioButton.TabStop = true;
            this.stopRadioButton.Text = "Stop";
            this.stopRadioButton.UseVisualStyleBackColor = true;
            // 
            // questionRadioButton
            // 
            this.questionRadioButton.AutoSize = true;
            this.questionRadioButton.Location = new System.Drawing.Point(7, 135);
            this.questionRadioButton.Name = "questionRadioButton";
            this.questionRadioButton.Size = new System.Drawing.Size(67, 17);
            this.questionRadioButton.TabIndex = 5;
            this.questionRadioButton.TabStop = true;
            this.questionRadioButton.Text = "Question";
            this.questionRadioButton.UseVisualStyleBackColor = true;
            // 
            // informationRadioButton
            // 
            this.informationRadioButton.AutoSize = true;
            this.informationRadioButton.Location = new System.Drawing.Point(7, 112);
            this.informationRadioButton.Name = "informationRadioButton";
            this.informationRadioButton.Size = new System.Drawing.Size(77, 17);
            this.informationRadioButton.TabIndex = 4;
            this.informationRadioButton.TabStop = true;
            this.informationRadioButton.Text = "Information";
            this.informationRadioButton.UseVisualStyleBackColor = true;
            // 
            // handRadioButton
            // 
            this.handRadioButton.AutoSize = true;
            this.handRadioButton.Location = new System.Drawing.Point(7, 89);
            this.handRadioButton.Name = "handRadioButton";
            this.handRadioButton.Size = new System.Drawing.Size(51, 17);
            this.handRadioButton.TabIndex = 3;
            this.handRadioButton.TabStop = true;
            this.handRadioButton.Text = "Hand";
            this.handRadioButton.UseVisualStyleBackColor = true;
            // 
            // exclamationRadioButton
            // 
            this.exclamationRadioButton.AutoSize = true;
            this.exclamationRadioButton.Location = new System.Drawing.Point(7, 66);
            this.exclamationRadioButton.Name = "exclamationRadioButton";
            this.exclamationRadioButton.Size = new System.Drawing.Size(82, 17);
            this.exclamationRadioButton.TabIndex = 2;
            this.exclamationRadioButton.TabStop = true;
            this.exclamationRadioButton.Text = "Exclamation";
            this.exclamationRadioButton.UseVisualStyleBackColor = true;
            // 
            // errorRadioButton
            // 
            this.errorRadioButton.AutoSize = true;
            this.errorRadioButton.Location = new System.Drawing.Point(7, 43);
            this.errorRadioButton.Name = "errorRadioButton";
            this.errorRadioButton.Size = new System.Drawing.Size(47, 17);
            this.errorRadioButton.TabIndex = 1;
            this.errorRadioButton.TabStop = true;
            this.errorRadioButton.Text = "Error";
            this.errorRadioButton.UseVisualStyleBackColor = true;
            // 
            // asteriksRadioButton
            // 
            this.asteriksRadioButton.AutoSize = true;
            this.asteriksRadioButton.Location = new System.Drawing.Point(7, 20);
            this.asteriksRadioButton.Name = "asteriksRadioButton";
            this.asteriksRadioButton.Size = new System.Drawing.Size(62, 17);
            this.asteriksRadioButton.TabIndex = 0;
            this.asteriksRadioButton.TabStop = true;
            this.asteriksRadioButton.Text = "Asteriks";
            this.asteriksRadioButton.UseVisualStyleBackColor = true;
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Location = new System.Drawing.Point(62, 268);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(406, 23);
            this.displayLabel.TabIndex = 3;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RadioButtonsTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 320);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.iconType);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.buttonType);
            this.Name = "RadioButtonsTest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RadioButtonsTest_Load);
            this.buttonType.ResumeLayout(false);
            this.buttonType.PerformLayout();
            this.iconType.ResumeLayout(false);
            this.iconType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox buttonType;
        private System.Windows.Forms.RadioButton RCradioButton;
        private System.Windows.Forms.RadioButton YNradioButton;
        private System.Windows.Forms.RadioButton YNCradioButton;
        private System.Windows.Forms.RadioButton ARIradioButton;
        private System.Windows.Forms.RadioButton OKCancelRadioButton;
        private System.Windows.Forms.RadioButton OKRadioButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.GroupBox iconType;
        private System.Windows.Forms.RadioButton warningRadioButton;
        private System.Windows.Forms.RadioButton stopRadioButton;
        private System.Windows.Forms.RadioButton questionRadioButton;
        private System.Windows.Forms.RadioButton informationRadioButton;
        private System.Windows.Forms.RadioButton handRadioButton;
        private System.Windows.Forms.RadioButton exclamationRadioButton;
        private System.Windows.Forms.RadioButton errorRadioButton;
        private System.Windows.Forms.RadioButton asteriksRadioButton;
        private System.Windows.Forms.Label displayLabel;
    }
}

