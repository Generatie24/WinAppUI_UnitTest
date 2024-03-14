namespace WinAppUI
{
    partial class Form1
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
            this.btnCalculateAdd = new System.Windows.Forms.Button();
            this.txtFirstNr = new System.Windows.Forms.TextBox();
            this.txtSecondNr = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculateSub = new System.Windows.Forms.Button();
            this.btnCalculateDiv = new System.Windows.Forms.Button();
            this.btnCalculateMult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculateAdd
            // 
            this.btnCalculateAdd.Location = new System.Drawing.Point(142, 205);
            this.btnCalculateAdd.Name = "btnCalculateAdd";
            this.btnCalculateAdd.Size = new System.Drawing.Size(113, 23);
            this.btnCalculateAdd.TabIndex = 0;
            this.btnCalculateAdd.Text = "Calculate ADD";
            this.btnCalculateAdd.UseVisualStyleBackColor = true;
            this.btnCalculateAdd.Click += new System.EventHandler(this.btnCalculateAdd_Click);
            // 
            // txtFirstNr
            // 
            this.txtFirstNr.Location = new System.Drawing.Point(230, 133);
            this.txtFirstNr.Name = "txtFirstNr";
            this.txtFirstNr.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNr.TabIndex = 1;
            // 
            // txtSecondNr
            // 
            this.txtSecondNr.Location = new System.Drawing.Point(410, 133);
            this.txtSecondNr.Name = "txtSecondNr";
            this.txtSecondNr.Size = new System.Drawing.Size(100, 20);
            this.txtSecondNr.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(292, 295);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 3;
            // 
            // btnCalculateSub
            // 
            this.btnCalculateSub.Location = new System.Drawing.Point(275, 205);
            this.btnCalculateSub.Name = "btnCalculateSub";
            this.btnCalculateSub.Size = new System.Drawing.Size(113, 23);
            this.btnCalculateSub.TabIndex = 4;
            this.btnCalculateSub.Text = "Calculate Sub";
            this.btnCalculateSub.UseVisualStyleBackColor = true;
            this.btnCalculateSub.Click += new System.EventHandler(this.btnCalculateSub_Click);
            // 
            // btnCalculateDiv
            // 
            this.btnCalculateDiv.Location = new System.Drawing.Point(394, 205);
            this.btnCalculateDiv.Name = "btnCalculateDiv";
            this.btnCalculateDiv.Size = new System.Drawing.Size(113, 23);
            this.btnCalculateDiv.TabIndex = 5;
            this.btnCalculateDiv.Text = "Calculate Div";
            this.btnCalculateDiv.UseVisualStyleBackColor = true;
            this.btnCalculateDiv.Click += new System.EventHandler(this.btnCalculateDiv_Click);
            // 
            // btnCalculateMult
            // 
            this.btnCalculateMult.Location = new System.Drawing.Point(525, 205);
            this.btnCalculateMult.Name = "btnCalculateMult";
            this.btnCalculateMult.Size = new System.Drawing.Size(113, 23);
            this.btnCalculateMult.TabIndex = 6;
            this.btnCalculateMult.Text = "Calculate Mult";
            this.btnCalculateMult.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculateMult);
            this.Controls.Add(this.btnCalculateDiv);
            this.Controls.Add(this.btnCalculateSub);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtSecondNr);
            this.Controls.Add(this.txtFirstNr);
            this.Controls.Add(this.btnCalculateAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateAdd;
        private System.Windows.Forms.TextBox txtFirstNr;
        private System.Windows.Forms.TextBox txtSecondNr;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculateSub;
        private System.Windows.Forms.Button btnCalculateDiv;
        private System.Windows.Forms.Button btnCalculateMult;
    }
}

