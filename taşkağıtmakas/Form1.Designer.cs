namespace taşkağıtmakas
{
    partial class taşkağıtmakas
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
            label1 = new Label();
            label2 = new Label();
            bilgisayartaş = new Button();
            insantaş = new Button();
            bilgisayarkağıt = new Button();
            insankağıt = new Button();
            bilgisayarmakas = new Button();
            insanmakas = new Button();
            sonuç = new Label();
            label4 = new Label();
            insanskor = new Label();
            bilgisayarskor = new Label();
            reseetbuton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(403, 66);
            label1.Name = "label1";
            label1.Size = new Size(126, 43);
            label1.TabIndex = 0;
            label1.Text = "BEN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(24, 59);
            label2.Name = "label2";
            label2.Size = new Size(164, 57);
            label2.TabIndex = 1;
            label2.Text = "BİLGİSAYAR";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseWaitCursor = true;
            // 
            // bilgisayartaş
            // 
            bilgisayartaş.Font = new Font("Segoe UI", 24F);
            bilgisayartaş.Location = new Point(33, 136);
            bilgisayartaş.Name = "bilgisayartaş";
            bilgisayartaş.Size = new Size(150, 70);
            bilgisayartaş.TabIndex = 2;
            bilgisayartaş.Text = "TAŞ";
            bilgisayartaş.UseVisualStyleBackColor = true;
            bilgisayartaş.UseWaitCursor = true;
            // 
            // insantaş
            // 
            insantaş.Font = new Font("Segoe UI", 24F);
            insantaş.Location = new Point(379, 136);
            insantaş.Name = "insantaş";
            insantaş.Size = new Size(150, 70);
            insantaş.TabIndex = 3;
            insantaş.Text = "TAŞ";
            insantaş.UseVisualStyleBackColor = true;
            insantaş.UseWaitCursor = true;
            insantaş.Click += insantaş_Click;
            // 
            // bilgisayarkağıt
            // 
            bilgisayarkağıt.Font = new Font("Segoe UI", 24F);
            bilgisayarkağıt.Location = new Point(38, 246);
            bilgisayarkağıt.Name = "bilgisayarkağıt";
            bilgisayarkağıt.Size = new Size(150, 70);
            bilgisayarkağıt.TabIndex = 4;
            bilgisayarkağıt.Text = "KAĞIT";
            bilgisayarkağıt.UseVisualStyleBackColor = true;
            bilgisayarkağıt.UseWaitCursor = true;
            // 
            // insankağıt
            // 
            insankağıt.Font = new Font("Segoe UI", 24F);
            insankağıt.Location = new Point(379, 246);
            insankağıt.Name = "insankağıt";
            insankağıt.Size = new Size(150, 70);
            insankağıt.TabIndex = 5;
            insankağıt.Text = "KAĞIT";
            insankağıt.UseVisualStyleBackColor = true;
            insankağıt.UseWaitCursor = true;
            insankağıt.Click += insankağıt_Click;
            // 
            // bilgisayarmakas
            // 
            bilgisayarmakas.Font = new Font("Segoe UI", 24F);
            bilgisayarmakas.Location = new Point(38, 364);
            bilgisayarmakas.Name = "bilgisayarmakas";
            bilgisayarmakas.Size = new Size(150, 70);
            bilgisayarmakas.TabIndex = 6;
            bilgisayarmakas.Text = "MAKAS";
            bilgisayarmakas.UseVisualStyleBackColor = true;
            bilgisayarmakas.UseWaitCursor = true;
            // 
            // insanmakas
            // 
            insanmakas.Font = new Font("Segoe UI", 24F);
            insanmakas.Location = new Point(379, 364);
            insanmakas.Name = "insanmakas";
            insanmakas.Size = new Size(150, 70);
            insanmakas.TabIndex = 7;
            insanmakas.Text = "MAKAS";
            insanmakas.UseVisualStyleBackColor = true;
            insanmakas.UseWaitCursor = true;
            insanmakas.Click += button6_Click;
            // 
            // sonuç
            // 
            sonuç.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            sonuç.ForeColor = Color.Red;
            sonuç.Location = new Point(143, 461);
            sonuç.Name = "sonuç";
            sonuç.Size = new Size(268, 73);
            sonuç.TabIndex = 8;
            sonuç.Text = "KAYBETTİNİZ";
            sonuç.TextAlign = ContentAlignment.MiddleCenter;
            sonuç.UseWaitCursor = true;
            sonuç.Visible = false;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(219, 41);
            label4.Name = "label4";
            label4.Size = new Size(135, 33);
            label4.TabIndex = 9;
            label4.Text = "SKOR";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseWaitCursor = true;
            // 
            // insanskor
            // 
            insanskor.AutoSize = true;
            insanskor.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            insanskor.Location = new Point(335, 84);
            insanskor.Name = "insanskor";
            insanskor.Size = new Size(26, 30);
            insanskor.TabIndex = 10;
            insanskor.Text = "0";
            insanskor.UseWaitCursor = true;
            // 
            // bilgisayarskor
            // 
            bilgisayarskor.AutoSize = true;
            bilgisayarskor.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            bilgisayarskor.Location = new Point(219, 84);
            bilgisayarskor.Name = "bilgisayarskor";
            bilgisayarskor.Size = new Size(26, 30);
            bilgisayarskor.TabIndex = 11;
            bilgisayarskor.Text = "0";
            bilgisayarskor.UseWaitCursor = true;
            // 
            // reseetbuton
            // 
            reseetbuton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            reseetbuton.ForeColor = Color.Green;
            reseetbuton.Location = new Point(251, 255);
            reseetbuton.Name = "reseetbuton";
            reseetbuton.Size = new Size(64, 52);
            reseetbuton.TabIndex = 12;
            reseetbuton.Text = "RESET";
            reseetbuton.UseVisualStyleBackColor = true;
            reseetbuton.UseWaitCursor = true;
            reseetbuton.Click += reseetbuton_Click;
            // 
            // taşkağıtmakas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(reseetbuton);
            Controls.Add(bilgisayarskor);
            Controls.Add(insanskor);
            Controls.Add(label4);
            Controls.Add(sonuç);
            Controls.Add(insanmakas);
            Controls.Add(bilgisayarmakas);
            Controls.Add(insankağıt);
            Controls.Add(bilgisayarkağıt);
            Controls.Add(insantaş);
            Controls.Add(bilgisayartaş);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "taşkağıtmakas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TAŞ KAĞIT MAKAS";
            UseWaitCursor = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button bilgisayartaş;
        private Button insantaş;
        private Button bilgisayarkağıt;
        private Button insankağıt;
        private Button bilgisayarmakas;
        private Button insanmakas;
        private Label sonuç;
        private Label label4;
        private Label insanskor;
        private Label bilgisayarskor;
        private Button reseetbuton;
    }
}
