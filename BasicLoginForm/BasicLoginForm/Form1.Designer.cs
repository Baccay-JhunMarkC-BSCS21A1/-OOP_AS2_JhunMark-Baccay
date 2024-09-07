namespace BasicLoginForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Userbox = new TextBox();
            Passbox = new TextBox();
            button1 = new Button();
            UnameV = new Label();
            PwordV = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Userbox
            // 
            Userbox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Userbox.Location = new Point(247, 68);
            Userbox.Name = "Userbox";
            Userbox.Size = new Size(127, 31);
            Userbox.TabIndex = 0;
            Userbox.TextChanged += Userbox_TextChanged;
            // 
            // Passbox
            // 
            Passbox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Passbox.Location = new Point(247, 139);
            Passbox.Name = "Passbox";
            Passbox.Size = new Size(127, 31);
            Passbox.TabIndex = 1;
            Passbox.TextChanged += Passbox_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(179, 224);
            button1.Name = "button1";
            button1.Size = new Size(92, 35);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UnameV
            // 
            UnameV.AutoSize = true;
            UnameV.Location = new Point(247, 102);
            UnameV.Name = "UnameV";
            UnameV.Size = new Size(38, 15);
            UnameV.TabIndex = 3;
            UnameV.Text = "label1";
            // 
            // PwordV
            // 
            PwordV.AutoSize = true;
            PwordV.Location = new Point(247, 173);
            PwordV.Name = "PwordV";
            PwordV.Size = new Size(38, 15);
            PwordV.TabIndex = 4;
            PwordV.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 71);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 5;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(106, 142);
            label2.Name = "label2";
            label2.Size = new Size(100, 22);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 290);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PwordV);
            Controls.Add(UnameV);
            Controls.Add(button1);
            Controls.Add(Passbox);
            Controls.Add(Userbox);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Userbox;
        private TextBox Passbox;
        private Button button1;
        private Label UnameV;
        private Label PwordV;
        private Label label1;
        private Label label2;
    }
}
