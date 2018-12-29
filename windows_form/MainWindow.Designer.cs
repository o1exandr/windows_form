namespace windows_form
{
    partial class MainWindow
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
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.btnShowControls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(10, 10);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(150, 20);
            this.firstNameBox.TabIndex = 0;
            this.firstNameBox.Text = "Привіт";
            // 
            // btnShowControls
            // 
            this.btnShowControls.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowControls.Location = new System.Drawing.Point(10, 70);
            this.btnShowControls.Name = "btnShowControls";
            this.btnShowControls.Size = new System.Drawing.Size(90, 30);
            this.btnShowControls.TabIndex = 1;
            this.btnShowControls.Text = "Клацніть тут";
            this.btnShowControls.UseVisualStyleBackColor = false;
            this.btnShowControls.Click += new System.EventHandler(this.btnShowControls_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnShowControls);
            this.Controls.Add(this.firstNameBox);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прості елементи керування";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Button btnShowControls;
    }
}

