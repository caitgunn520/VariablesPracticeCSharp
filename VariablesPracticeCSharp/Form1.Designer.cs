namespace VariablesPracticeCSharp
{
    partial class MainForm
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
            this.wayneGretzky = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.circleArea = new System.Windows.Forms.Button();
            this.carpetButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wayneGretzky
            // 
            this.wayneGretzky.Location = new System.Drawing.Point(28, 22);
            this.wayneGretzky.Name = "wayneGretzky";
            this.wayneGretzky.Size = new System.Drawing.Size(75, 23);
            this.wayneGretzky.TabIndex = 0;
            this.wayneGretzky.Text = "Gretzky";
            this.wayneGretzky.UseVisualStyleBackColor = true;
            this.wayneGretzky.Click += new System.EventHandler(this.Button1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(188, 31);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(35, 13);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "label1";
            // 
            // circleArea
            // 
            this.circleArea.Location = new System.Drawing.Point(28, 68);
            this.circleArea.Name = "circleArea";
            this.circleArea.Size = new System.Drawing.Size(75, 23);
            this.circleArea.TabIndex = 2;
            this.circleArea.Text = "Area";
            this.circleArea.UseVisualStyleBackColor = true;
            this.circleArea.Click += new System.EventHandler(this.CircleArea_Click);
            // 
            // carpetButton
            // 
            this.carpetButton.Location = new System.Drawing.Point(28, 114);
            this.carpetButton.Name = "carpetButton";
            this.carpetButton.Size = new System.Drawing.Size(75, 23);
            this.carpetButton.TabIndex = 3;
            this.carpetButton.Text = "Carpet";
            this.carpetButton.UseVisualStyleBackColor = true;
            this.carpetButton.Click += new System.EventHandler(this.CarpetButton_Click);
            // 
            // billButton
            // 
            this.billButton.Location = new System.Drawing.Point(28, 160);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(75, 23);
            this.billButton.TabIndex = 4;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.BillButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.carpetButton);
            this.Controls.Add(this.circleArea);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.wayneGretzky);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wayneGretzky;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button circleArea;
        private System.Windows.Forms.Button carpetButton;
        private System.Windows.Forms.Button billButton;
    }
}

