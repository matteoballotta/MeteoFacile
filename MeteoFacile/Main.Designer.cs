namespace MeteoFacile
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cityInput = new System.Windows.Forms.TextBox();
            this.CitySearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(266, 44);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(195, 20);
            this.cityInput.TabIndex = 2;
            // 
            // CitySearch
            // 
            this.CitySearch.Location = new System.Drawing.Point(266, 70);
            this.CitySearch.Name = "CitySearch";
            this.CitySearch.Size = new System.Drawing.Size(195, 23);
            this.CitySearch.TabIndex = 3;
            this.CitySearch.Text = "Cerca";
            this.CitySearch.UseVisualStyleBackColor = true;
            this.CitySearch.Click += new System.EventHandler(this.CitySearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cerca località";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CitySearch);
            this.Controls.Add(this.cityInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Button CitySearch;
        private System.Windows.Forms.Label label1;
    }
}

