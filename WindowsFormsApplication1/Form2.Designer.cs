namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.textBoxNameCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCheckTheWeather = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNameCity
            // 
            this.textBoxNameCity.Location = new System.Drawing.Point(49, 51);
            this.textBoxNameCity.Name = "textBoxNameCity";
            this.textBoxNameCity.Size = new System.Drawing.Size(178, 20);
            this.textBoxNameCity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Miasto:";
            // 
            // buttonCheckTheWeather
            // 
            this.buttonCheckTheWeather.Location = new System.Drawing.Point(49, 99);
            this.buttonCheckTheWeather.Name = "buttonCheckTheWeather";
            this.buttonCheckTheWeather.Size = new System.Drawing.Size(178, 39);
            this.buttonCheckTheWeather.TabIndex = 2;
            this.buttonCheckTheWeather.Text = "Jaka jest pogoda?";
            this.buttonCheckTheWeather.UseVisualStyleBackColor = true;
            this.buttonCheckTheWeather.Click += new System.EventHandler(this.buttonCheckTheWeather_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(49, 170);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(178, 114);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(49, 302);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(178, 62);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 431);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.buttonCheckTheWeather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameCity);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCheckTheWeather;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}