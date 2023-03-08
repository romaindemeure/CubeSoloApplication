namespace cubeSolo
{
    partial class Connexion
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
            label1 = new Label();
            label2 = new Label();
            tbmdp = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(177, 28);
            label1.Name = "label1";
            label1.Size = new Size(418, 39);
            label1.TabIndex = 26;
            label1.Text = "Connection Administrateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(251, 131);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 27;
            label2.Text = "Mot de passe";
            label2.Click += label2_Click;
            // 
            // tbmdp
            // 
            tbmdp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbmdp.Location = new Point(251, 171);
            tbmdp.Name = "tbmdp";
            tbmdp.Size = new Size(274, 30);
            tbmdp.TabIndex = 30;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(251, 233);
            button2.Name = "button2";
            button2.Size = new Size(130, 49);
            button2.TabIndex = 31;
            button2.Text = "Connexion";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(tbmdp);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Connexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox tbmdp;
        private Button button2;
    }
}