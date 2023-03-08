namespace cubeSolo
{
    partial class ConnectSupprimer
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
            button2 = new Button();
            tbmdp = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(244, 267);
            button2.Name = "button2";
            button2.Size = new Size(130, 49);
            button2.TabIndex = 35;
            button2.Text = "Connexion";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tbmdp
            // 
            tbmdp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbmdp.Location = new Point(244, 205);
            tbmdp.Name = "tbmdp";
            tbmdp.Size = new Size(274, 30);
            tbmdp.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(244, 165);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 33;
            label2.Text = "Mot de passe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(170, 62);
            label1.Name = "label1";
            label1.Size = new Size(418, 39);
            label1.TabIndex = 32;
            label1.Text = "Connection Administrateur";
            // 
            // ConnectSupprimer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(tbmdp);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConnectSupprimer";
            Text = "ConnectSupprimer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox tbmdp;
        private Label label2;
        private Label label1;
    }
}