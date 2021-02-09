namespace GameTitleScreen
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
            this.StartButton = new System.Windows.Forms.Button();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.Number3Label = new System.Windows.Forms.Label();
            this.Number2Label = new System.Windows.Forms.Label();
            this.Number1Label = new System.Windows.Forms.Label();
            this.BeginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.StartButton.Font = new System.Drawing.Font("Modern No. 20", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(305, 87);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(185, 71);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.BackColor = System.Drawing.Color.Thistle;
            this.LoadingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadingLabel.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLabel.Location = new System.Drawing.Point(313, 236);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(177, 35);
            this.LoadingLabel.TabIndex = 2;
            this.LoadingLabel.Text = "Loading...";
            // 
            // Number3Label
            // 
            this.Number3Label.AutoSize = true;
            this.Number3Label.BackColor = System.Drawing.Color.Plum;
            this.Number3Label.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number3Label.Location = new System.Drawing.Point(318, 300);
            this.Number3Label.Name = "Number3Label";
            this.Number3Label.Size = new System.Drawing.Size(28, 29);
            this.Number3Label.TabIndex = 3;
            this.Number3Label.Text = "3";
            // 
            // Number2Label
            // 
            this.Number2Label.AutoSize = true;
            this.Number2Label.BackColor = System.Drawing.Color.Violet;
            this.Number2Label.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number2Label.Location = new System.Drawing.Point(383, 326);
            this.Number2Label.Name = "Number2Label";
            this.Number2Label.Size = new System.Drawing.Size(28, 29);
            this.Number2Label.TabIndex = 4;
            this.Number2Label.Text = "2";
            // 
            // Number1Label
            // 
            this.Number1Label.AutoSize = true;
            this.Number1Label.BackColor = System.Drawing.Color.Purple;
            this.Number1Label.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number1Label.Location = new System.Drawing.Point(450, 345);
            this.Number1Label.Name = "Number1Label";
            this.Number1Label.Size = new System.Drawing.Size(28, 29);
            this.Number1Label.TabIndex = 5;
            this.Number1Label.Text = "1";
            // 
            // BeginLabel
            // 
            this.BeginLabel.AutoSize = true;
            this.BeginLabel.BackColor = System.Drawing.Color.Lavender;
            this.BeginLabel.Font = new System.Drawing.Font("Modern735 BT", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginLabel.Location = new System.Drawing.Point(339, 161);
            this.BeginLabel.Name = "BeginLabel";
            this.BeginLabel.Size = new System.Drawing.Size(126, 63);
            this.BeginLabel.TabIndex = 6;
            this.BeginLabel.Text = "Begin!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BeginLabel);
            this.Controls.Add(this.Number1Label);
            this.Controls.Add(this.Number2Label);
            this.Controls.Add(this.Number3Label);
            this.Controls.Add(this.LoadingLabel);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.Label Number3Label;
        private System.Windows.Forms.Label Number2Label;
        private System.Windows.Forms.Label Number1Label;
        private System.Windows.Forms.Label BeginLabel;
    }
}

