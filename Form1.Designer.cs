namespace DeltaPoprawa
{
    partial class aInput
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.A = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.Oblicz = new System.Windows.Forms.Button();
            this.aInputBox = new System.Windows.Forms.TextBox();
            this.bInput = new System.Windows.Forms.TextBox();
            this.cInput = new System.Windows.Forms.TextBox();
            this.Tittle = new System.Windows.Forms.Label();
            this.ans1 = new System.Windows.Forms.Label();
            this.ans2 = new System.Windows.Forms.Label();
            this.ans3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.A.Location = new System.Drawing.Point(301, 76);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(14, 15);
            this.A.TabIndex = 0;
            this.A.Text = "A";
            this.A.Click += new System.EventHandler(this.label1_Click);
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.B.Location = new System.Drawing.Point(301, 103);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(15, 15);
            this.B.TabIndex = 1;
            this.B.Text = "B";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.C.Location = new System.Drawing.Point(301, 132);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(15, 15);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            // 
            // Oblicz
            // 
            this.Oblicz.Location = new System.Drawing.Point(301, 159);
            this.Oblicz.Name = "Oblicz";
            this.Oblicz.Size = new System.Drawing.Size(173, 23);
            this.Oblicz.TabIndex = 3;
            this.Oblicz.Text = "Oblicz";
            this.Oblicz.UseVisualStyleBackColor = true;
            this.Oblicz.Click += new System.EventHandler(this.Oblicz_Click);
            // 
            // aInputBox
            // 
            this.aInputBox.Location = new System.Drawing.Point(321, 73);
            this.aInputBox.Name = "aInputBox";
            this.aInputBox.Size = new System.Drawing.Size(153, 20);
            this.aInputBox.TabIndex = 4;
            // 
            // bInput
            // 
            this.bInput.Location = new System.Drawing.Point(321, 103);
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(153, 20);
            this.bInput.TabIndex = 5;
            // 
            // cInput
            // 
            this.cInput.Location = new System.Drawing.Point(321, 133);
            this.cInput.Name = "cInput";
            this.cInput.Size = new System.Drawing.Size(152, 20);
            this.cInput.TabIndex = 6;
            // 
            // Tittle
            // 
            this.Tittle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Tittle.Location = new System.Drawing.Point(305, 9);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(157, 39);
            this.Tittle.TabIndex = 7;
            this.Tittle.Text = "Oblicz se";
            this.Tittle.Click += new System.EventHandler(this.Tittle_Click);
            // 
            // ans1
            // 
            this.ans1.AutoSize = true;
            this.ans1.Location = new System.Drawing.Point(318, 288);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(35, 13);
            this.ans1.TabIndex = 8;
            this.ans1.Text = "label1";
            // 
            // ans2
            // 
            this.ans2.AutoSize = true;
            this.ans2.Location = new System.Drawing.Point(439, 288);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(35, 13);
            this.ans2.TabIndex = 9;
            this.ans2.Text = "label1";
            // 
            // ans3
            // 
            this.ans3.AutoSize = true;
            this.ans3.Location = new System.Drawing.Point(377, 288);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(35, 13);
            this.ans3.TabIndex = 10;
            this.ans3.Text = "label2";
            this.ans3.Click += new System.EventHandler(this.label2_Click);
            // 
            // aInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.cInput);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.aInputBox);
            this.Controls.Add(this.Oblicz);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Name = "aInput";
            this.Text = "        ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Button Oblicz;
        private System.Windows.Forms.TextBox aInputBox;
        private System.Windows.Forms.TextBox bInput;
        private System.Windows.Forms.TextBox cInput;
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Label ans1;
        private System.Windows.Forms.Label ans2;
        private System.Windows.Forms.Label ans3;
    }
}

