using System.Windows.Forms;

namespace Mastermind
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.winText = new System.Windows.Forms.Label();
            this.winButton1 = new System.Windows.Forms.Button();
            this.winButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(243, 473);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(146, 53);
            this.resultLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(32, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 30);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(63, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 30);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(94, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 30);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(125, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 30);
            this.label4.TabIndex = 8;
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.info.Location = new System.Drawing.Point(198, 154);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(191, 297);
            this.info.TabIndex = 9;
            this.info.Text = resources.GetString("info.Text");
            // 
            // winText
            // 
            this.winText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.winText.Location = new System.Drawing.Point(198, 9);
            this.winText.Name = "winText";
            this.winText.Size = new System.Drawing.Size(167, 110);
            this.winText.TabIndex = 10;
            // 
            // winButton1
            // 
            this.winButton1.Location = new System.Drawing.Point(243, 122);
            this.winButton1.Name = "winButton1";
            this.winButton1.Size = new System.Drawing.Size(33, 29);
            this.winButton1.TabIndex = 11;
            this.winButton1.Text = "Ja";
            this.winButton1.UseVisualStyleBackColor = true;
            this.winButton1.Visible = false;
            this.winButton1.Click += new System.EventHandler(this.winButton1_Click);
            // 
            // winButton2
            // 
            this.winButton2.Location = new System.Drawing.Point(282, 122);
            this.winButton2.Name = "winButton2";
            this.winButton2.Size = new System.Drawing.Size(36, 29);
            this.winButton2.TabIndex = 12;
            this.winButton2.Text = "Nee";
            this.winButton2.UseVisualStyleBackColor = true;
            this.winButton2.Visible = false;
            this.winButton2.Click += new System.EventHandler(this.winButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(391, 535);
            this.Controls.Add(this.winButton2);
            this.Controls.Add(this.winButton1);
            this.Controls.Add(this.winText);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button winButton1;
        private System.Windows.Forms.Button winButton2;

        private System.Windows.Forms.Label winText;

        private System.Windows.Forms.Label info;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultLabel;

        #endregion
    }
}