namespace NotSimpleGame.Views
{
    partial class CharacterManagerView
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
            this.SelectCharackerCombobox = new System.Windows.Forms.ComboBox();
            this.SelectSkinCombobox = new System.Windows.Forms.ComboBox();
            this.SelectWeaponCombobox = new System.Windows.Forms.ComboBox();
            this.SelectCharackerLabel = new System.Windows.Forms.Label();
            this.SelectSkinLabel = new System.Windows.Forms.Label();
            this.SelectWeaponLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.MoneyValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectCharackerCombobox
            // 
            this.SelectCharackerCombobox.FormattingEnabled = true;
            this.SelectCharackerCombobox.Location = new System.Drawing.Point(145, 43);
            this.SelectCharackerCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectCharackerCombobox.Name = "SelectCharackerCombobox";
            this.SelectCharackerCombobox.Size = new System.Drawing.Size(169, 21);
            this.SelectCharackerCombobox.TabIndex = 0;
            // 
            // SelectSkinCombobox
            // 
            this.SelectSkinCombobox.FormattingEnabled = true;
            this.SelectSkinCombobox.Location = new System.Drawing.Point(145, 67);
            this.SelectSkinCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectSkinCombobox.Name = "SelectSkinCombobox";
            this.SelectSkinCombobox.Size = new System.Drawing.Size(169, 21);
            this.SelectSkinCombobox.TabIndex = 1;
            // 
            // SelectWeaponCombobox
            // 
            this.SelectWeaponCombobox.FormattingEnabled = true;
            this.SelectWeaponCombobox.Location = new System.Drawing.Point(145, 92);
            this.SelectWeaponCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectWeaponCombobox.Name = "SelectWeaponCombobox";
            this.SelectWeaponCombobox.Size = new System.Drawing.Size(169, 21);
            this.SelectWeaponCombobox.TabIndex = 2;
            // 
            // SelectCharackerLabel
            // 
            this.SelectCharackerLabel.AutoSize = true;
            this.SelectCharackerLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectCharackerLabel.Location = new System.Drawing.Point(8, 46);
            this.SelectCharackerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectCharackerLabel.Name = "SelectCharackerLabel";
            this.SelectCharackerLabel.Size = new System.Drawing.Size(137, 17);
            this.SelectCharackerLabel.TabIndex = 3;
            this.SelectCharackerLabel.Text = "Виберіть персонажа:";
            this.SelectCharackerLabel.Click += new System.EventHandler(this.SelectCharackerLabel_Click);
            // 
            // SelectSkinLabel
            // 
            this.SelectSkinLabel.AutoSize = true;
            this.SelectSkinLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectSkinLabel.Location = new System.Drawing.Point(8, 70);
            this.SelectSkinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectSkinLabel.Name = "SelectSkinLabel";
            this.SelectSkinLabel.Size = new System.Drawing.Size(99, 17);
            this.SelectSkinLabel.TabIndex = 4;
            this.SelectSkinLabel.Text = "Виберіть одяг:";
            // 
            // SelectWeaponLabel
            // 
            this.SelectWeaponLabel.AutoSize = true;
            this.SelectWeaponLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectWeaponLabel.Location = new System.Drawing.Point(8, 94);
            this.SelectWeaponLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectWeaponLabel.Name = "SelectWeaponLabel";
            this.SelectWeaponLabel.Size = new System.Drawing.Size(110, 17);
            this.SelectWeaponLabel.TabIndex = 5;
            this.SelectWeaponLabel.Text = "Виберіть зброю:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(248, 124);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(64, 28);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Вперед!";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyLabel.Location = new System.Drawing.Point(218, 15);
            this.MoneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(49, 16);
            this.MoneyLabel.TabIndex = 7;
            this.MoneyLabel.Text = "Кошти:";
            // 
            // MoneyValue
            // 
            this.MoneyValue.AutoSize = true;
            this.MoneyValue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyValue.Location = new System.Drawing.Point(268, 15);
            this.MoneyValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MoneyValue.Name = "MoneyValue";
            this.MoneyValue.Size = new System.Drawing.Size(0, 16);
            this.MoneyValue.TabIndex = 8;
            // 
            // CharacterManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 162);
            this.Controls.Add(this.MoneyValue);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SelectWeaponLabel);
            this.Controls.Add(this.SelectSkinLabel);
            this.Controls.Add(this.SelectCharackerLabel);
            this.Controls.Add(this.SelectWeaponCombobox);
            this.Controls.Add(this.SelectSkinCombobox);
            this.Controls.Add(this.SelectCharackerCombobox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CharacterManagerView";
            this.Text = "CharacterManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectCharackerCombobox;
        private System.Windows.Forms.ComboBox SelectSkinCombobox;
        private System.Windows.Forms.ComboBox SelectWeaponCombobox;
        private System.Windows.Forms.Label SelectCharackerLabel;
        private System.Windows.Forms.Label SelectSkinLabel;
        private System.Windows.Forms.Label SelectWeaponLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label MoneyValue;
    }
}

