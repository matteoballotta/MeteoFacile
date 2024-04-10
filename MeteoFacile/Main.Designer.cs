namespace MeteoFacile
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.CityInput = new System.Windows.Forms.TextBox();
            this.CitySearchButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CityInput
            // 
            this.CityInput.Location = new System.Drawing.Point(266, 44);
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(195, 20);
            this.CityInput.TabIndex = 2;
            // 
            // CitySearchButton
            // 
            this.CitySearchButton.Location = new System.Drawing.Point(266, 70);
            this.CitySearchButton.Name = "CitySearchButton";
            this.CitySearchButton.Size = new System.Drawing.Size(195, 23);
            this.CitySearchButton.TabIndex = 3;
            this.CitySearchButton.Text = "Cerca";
            this.CitySearchButton.UseVisualStyleBackColor = true;
            this.CitySearchButton.Click += new System.EventHandler(this.CitySearch_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleLabel.Location = new System.Drawing.Point(299, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(130, 25);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Cerca località";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 316);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CitySearchButton);
            this.Controls.Add(this.CityInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CityInput;
        private System.Windows.Forms.Button CitySearchButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}

