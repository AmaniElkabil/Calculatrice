namespace Calculatrice
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
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.egal = new System.Windows.Forms.Button();
            this.virgule = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.moins = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.divise = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.Calcul = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.labelresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.num1.FlatAppearance.BorderSize = 0;
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(11, 223);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 42);
            this.num1.TabIndex = 1;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.num2.FlatAppearance.BorderSize = 0;
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(92, 223);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 42);
            this.num2.TabIndex = 2;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.num3.FlatAppearance.BorderSize = 0;
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(173, 223);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 42);
            this.num3.TabIndex = 3;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.num0.FlatAppearance.BorderSize = 0;
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num0.Location = new System.Drawing.Point(11, 271);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(156, 42);
            this.num0.TabIndex = 4;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // egal
            // 
            this.egal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.egal.FlatAppearance.BorderSize = 0;
            this.egal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.egal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.egal.Location = new System.Drawing.Point(254, 271);
            this.egal.Name = "egal";
            this.egal.Size = new System.Drawing.Size(75, 42);
            this.egal.TabIndex = 5;
            this.egal.Text = "=";
            this.egal.UseVisualStyleBackColor = false;
            this.egal.Click += new System.EventHandler(this.egal_Click);
            // 
            // virgule
            // 
            this.virgule.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.virgule.FlatAppearance.BorderSize = 0;
            this.virgule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.virgule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virgule.Location = new System.Drawing.Point(173, 271);
            this.virgule.Name = "virgule";
            this.virgule.Size = new System.Drawing.Size(75, 42);
            this.virgule.TabIndex = 6;
            this.virgule.Text = ",";
            this.virgule.UseVisualStyleBackColor = false;
            this.virgule.Click += new System.EventHandler(this.virgule_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(254, 223);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 42);
            this.plus.TabIndex = 7;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.num4.FlatAppearance.BorderSize = 0;
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(11, 175);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(75, 42);
            this.num4.TabIndex = 8;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.num5.FlatAppearance.BorderSize = 0;
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(92, 175);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(75, 42);
            this.num5.TabIndex = 9;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.num6.FlatAppearance.BorderSize = 0;
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(173, 175);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(75, 42);
            this.num6.TabIndex = 10;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // moins
            // 
            this.moins.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.moins.FlatAppearance.BorderSize = 0;
            this.moins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moins.Location = new System.Drawing.Point(254, 175);
            this.moins.Name = "moins";
            this.moins.Size = new System.Drawing.Size(75, 42);
            this.moins.TabIndex = 11;
            this.moins.Text = "-";
            this.moins.UseVisualStyleBackColor = false;
            this.moins.Click += new System.EventHandler(this.moins_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.num7.FlatAppearance.BorderSize = 0;
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(11, 127);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(75, 42);
            this.num7.TabIndex = 12;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.num8.FlatAppearance.BorderSize = 0;
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(92, 127);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(75, 42);
            this.num8.TabIndex = 13;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.num9.FlatAppearance.BorderSize = 0;
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(173, 127);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(75, 42);
            this.num9.TabIndex = 14;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // multiple
            // 
            this.multiple.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.multiple.FlatAppearance.BorderSize = 0;
            this.multiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiple.Location = new System.Drawing.Point(254, 128);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(75, 42);
            this.multiple.TabIndex = 16;
            this.multiple.Text = "×";
            this.multiple.UseVisualStyleBackColor = false;
            this.multiple.Click += new System.EventHandler(this.multiple_Click);
            // 
            // divise
            // 
            this.divise.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.divise.FlatAppearance.BorderSize = 0;
            this.divise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divise.Location = new System.Drawing.Point(254, 80);
            this.divise.Name = "divise";
            this.divise.Size = new System.Drawing.Size(75, 42);
            this.divise.TabIndex = 17;
            this.divise.Text = " ÷";
            this.divise.UseVisualStyleBackColor = false;
            this.divise.Click += new System.EventHandler(this.divise_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(11, 79);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(235, 42);
            this.clear.TabIndex = 18;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Calcul
            // 
            this.Calcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcul.Location = new System.Drawing.Point(12, 9);
            this.Calcul.Name = "Calcul";
            this.Calcul.Size = new System.Drawing.Size(317, 67);
            this.Calcul.TabIndex = 19;
            this.Calcul.Text = "0";
            this.Calcul.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Calcul.Click += new System.EventHandler(this.Calcul_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(32, 19);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 13);
            this.label_result.TabIndex = 20;
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelresult.Location = new System.Drawing.Point(30, 20);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(35, 13);
            this.labelresult.TabIndex = 21;
            this.labelresult.Text = "label1";
            this.labelresult.Click += new System.EventHandler(this.labelresult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(370, 377);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.Calcul);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.divise);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.moins);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.virgule);
            this.Controls.Add(this.egal);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button egal;
        private System.Windows.Forms.Button virgule;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button moins;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button divise;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label Calcul;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label labelresult;
    }
}

