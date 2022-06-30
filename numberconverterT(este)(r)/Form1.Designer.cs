
namespace numberconverterT_este__r_
{
    partial class Form
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hexbox = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.octbox = new System.Windows.Forms.TextBox();
            this.dezbox = new System.Windows.Forms.TextBox();
            this.binbox = new System.Windows.Forms.TextBox();
            this.HEX = new System.Windows.Forms.Label();
            this.OCT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // hexbox
            // 
            this.hexbox.Location = new System.Drawing.Point(498, 113);
            this.hexbox.Name = "hexbox";
            this.hexbox.ReadOnly = true;
            this.hexbox.Size = new System.Drawing.Size(191, 23);
            this.hexbox.TabIndex = 1;
            this.hexbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.Location = new System.Drawing.Point(235, 43);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(257, 33);
            this.description.TabIndex = 2;
            this.description.Text = "Zahlensystem Umrechner";
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(23, 157);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(235, 23);
            this.inputbox.TabIndex = 3;
            this.inputbox.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            this.inputbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inputbox_KeyDown);
            // 
            // octbox
            // 
            this.octbox.Location = new System.Drawing.Point(498, 154);
            this.octbox.Name = "octbox";
            this.octbox.ReadOnly = true;
            this.octbox.Size = new System.Drawing.Size(191, 23);
            this.octbox.TabIndex = 4;
            // 
            // dezbox
            // 
            this.dezbox.Location = new System.Drawing.Point(498, 193);
            this.dezbox.Name = "dezbox";
            this.dezbox.ReadOnly = true;
            this.dezbox.Size = new System.Drawing.Size(191, 23);
            this.dezbox.TabIndex = 5;
            // 
            // binbox
            // 
            this.binbox.Location = new System.Drawing.Point(498, 235);
            this.binbox.Name = "binbox";
            this.binbox.ReadOnly = true;
            this.binbox.Size = new System.Drawing.Size(191, 23);
            this.binbox.TabIndex = 6;
            // 
            // HEX
            // 
            this.HEX.AutoSize = true;
            this.HEX.Location = new System.Drawing.Point(464, 116);
            this.HEX.Name = "HEX";
            this.HEX.Size = new System.Drawing.Size(28, 15);
            this.HEX.TabIndex = 7;
            this.HEX.Text = "Hex";
            // 
            // OCT
            // 
            this.OCT.AutoSize = true;
            this.OCT.Location = new System.Drawing.Point(457, 157);
            this.OCT.Name = "OCT";
            this.OCT.Size = new System.Drawing.Size(35, 15);
            this.OCT.TabIndex = 8;
            this.OCT.Text = "Octal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Decimal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Binary";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 186);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 19);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hex";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.HexButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(75, 186);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 19);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Octal";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.OctalButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(134, 186);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 19);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Decimal";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.DecimalButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(208, 186);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 19);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Binary";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.BinaryButton_CheckedChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 320);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OCT);
            this.Controls.Add(this.HEX);
            this.Controls.Add(this.binbox);
            this.Controls.Add(this.dezbox);
            this.Controls.Add(this.octbox);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.description);
            this.Controls.Add(this.hexbox);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hexbox;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.TextBox octbox;
        private System.Windows.Forms.TextBox dezbox;
        private System.Windows.Forms.TextBox binbox;
        private System.Windows.Forms.Label HEX;
        private System.Windows.Forms.Label OCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

