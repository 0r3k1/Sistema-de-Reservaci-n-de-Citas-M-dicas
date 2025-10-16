namespace CapaPresentacion {
    partial class FrmLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel1 = new Panel();
            label1 = new Label();
            btnLogin = new Sara_UI_Design.SaraControls.SaraUI_Button();
            txtContrasena = new Sara_UI_Design.SaraUI_TextBox();
            txtUsuario = new Sara_UI_Design.SaraUI_TextBox();
            sarauI_Line1 = new Sara_UI_Design.SaraControls.SaraUI_Line();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            sarauI_PictureBox2 = new Sara_UI_Design.SaraControls.SaraUI_PictureBox();
            sarauI_PictureBox1 = new Sara_UI_Design.SaraControls.SaraUI_PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sarauI_PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sarauI_PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(sarauI_Line1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 454);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(70, 155);
            label1.Name = "label1";
            label1.Size = new Size(241, 32);
            label1.TabIndex = 5;
            label1.Text = "Login Citas Médicas";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LimeGreen;
            btnLogin.BackgroundColor = Color.LimeGreen;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 20;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(98, 352);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(184, 55);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = SystemColors.Window;
            txtContrasena.BorderColor = Color.MidnightBlue;
            txtContrasena.BorderFocusColor = Color.HotPink;
            txtContrasena.BorderRadius = 0;
            txtContrasena.BorderSize = 2;
            txtContrasena.ErrorBorderColor = Color.Red;
            txtContrasena.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.ForeColor = Color.DimGray;
            txtContrasena.Location = new Point(24, 288);
            txtContrasena.Margin = new Padding(4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Padding = new Padding(7);
            txtContrasena.Placeholder = "Password";
            txtContrasena.PlaceholderColor = Color.Gray;
            txtContrasena.Size = new Size(332, 31);
            txtContrasena.TabIndex = 3;
            txtContrasena.Texts = "Password";
            txtContrasena.Type = Sara_UI_Design.SaraUI_TextBox.InputType.Password;
            txtContrasena.UnderlinedStyle = true;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.BorderColor = Color.MidnightBlue;
            txtUsuario.BorderFocusColor = Color.HotPink;
            txtUsuario.BorderRadius = 0;
            txtUsuario.BorderSize = 2;
            txtUsuario.ErrorBorderColor = Color.Red;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(24, 240);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(7);
            txtUsuario.Placeholder = "Nombre de Usuario";
            txtUsuario.PlaceholderColor = Color.Gray;
            txtUsuario.Size = new Size(332, 31);
            txtUsuario.TabIndex = 2;
            txtUsuario.Texts = "Nombre de Usuario";
            txtUsuario.Type = Sara_UI_Design.SaraUI_TextBox.InputType.Text;
            txtUsuario.UnderlinedStyle = true;
            // 
            // sarauI_Line1
            // 
            sarauI_Line1.LineColor = Color.Black;
            sarauI_Line1.LineWidth = 2;
            sarauI_Line1.Location = new Point(12, 200);
            sarauI_Line1.Name = "sarauI_Line1";
            sarauI_Line1.Size = new Size(357, 33);
            sarauI_Line1.TabIndex = 1;
            sarauI_Line1.Text = "sarauI_Line1";
            sarauI_Line1.X1 = 0;
            sarauI_Line1.X2 = 357;
            sarauI_Line1.Y1 = 0;
            sarauI_Line1.Y2 = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logi_icon;
            pictureBox2.Location = new Point(133, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(sarauI_PictureBox2);
            panel2.Controls.Add(sarauI_PictureBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(375, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 454);
            panel2.TabIndex = 1;
            // 
            // sarauI_PictureBox2
            // 
            sarauI_PictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            sarauI_PictureBox2.BorderColor = Color.RoyalBlue;
            sarauI_PictureBox2.BorderColor2 = Color.HotPink;
            sarauI_PictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            sarauI_PictureBox2.BorderSize = 0;
            sarauI_PictureBox2.GradientAngle = 50F;
            sarauI_PictureBox2.Image = Properties.Resources.minimizar;
            sarauI_PictureBox2.Location = new Point(503, 2);
            sarauI_PictureBox2.Name = "sarauI_PictureBox2";
            sarauI_PictureBox2.Size = new Size(27, 27);
            sarauI_PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            sarauI_PictureBox2.TabIndex = 7;
            sarauI_PictureBox2.TabStop = false;
            sarauI_PictureBox2.Click += sarauI_PictureBox2_Click;
            // 
            // sarauI_PictureBox1
            // 
            sarauI_PictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            sarauI_PictureBox1.BorderColor = Color.RoyalBlue;
            sarauI_PictureBox1.BorderColor2 = Color.HotPink;
            sarauI_PictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            sarauI_PictureBox1.BorderSize = 0;
            sarauI_PictureBox1.GradientAngle = 50F;
            sarauI_PictureBox1.Image = Properties.Resources.cerrar;
            sarauI_PictureBox1.Location = new Point(533, 2);
            sarauI_PictureBox1.Name = "sarauI_PictureBox1";
            sarauI_PictureBox1.Size = new Size(27, 27);
            sarauI_PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            sarauI_PictureBox1.TabIndex = 6;
            sarauI_PictureBox1.TabStop = false;
            sarauI_PictureBox1.Click += sarauI_PictureBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.login_background;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(566, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 454);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sarauI_PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)sarauI_PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Sara_UI_Design.SaraControls.SaraUI_Line sarauI_Line1;
        private PictureBox pictureBox2;
        private Sara_UI_Design.SaraControls.SaraUI_Button btnLogin;
        private Sara_UI_Design.SaraUI_TextBox txtContrasena;
        private Sara_UI_Design.SaraUI_TextBox txtUsuario;
        private Label label1;
        private Sara_UI_Design.SaraControls.SaraUI_PictureBox sarauI_PictureBox2;
        private Sara_UI_Design.SaraControls.SaraUI_PictureBox sarauI_PictureBox1;
    }
}