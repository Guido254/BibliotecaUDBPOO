namespace Log_In
{
    partial class LogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.BtnCloseProgram = new System.Windows.Forms.Button();
            this.BtnRegistration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRecoverPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserCode = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.TimerLogInBackground = new System.Windows.Forms.Timer(this.components);
            this.PicBox_LogIn = new System.Windows.Forms.PictureBox();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_LogIn)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.PanelLogin.Controls.Add(this.BtnCloseProgram);
            this.PanelLogin.Controls.Add(this.BtnRegistration);
            this.PanelLogin.Controls.Add(this.label4);
            this.PanelLogin.Controls.Add(this.BtnLogIn);
            this.PanelLogin.Controls.Add(this.label3);
            this.PanelLogin.Controls.Add(this.BtnRecoverPass);
            this.PanelLogin.Controls.Add(this.label1);
            this.PanelLogin.Controls.Add(this.TxtPassword);
            this.PanelLogin.Controls.Add(this.TxtUserCode);
            this.PanelLogin.Controls.Add(this.Title);
            this.PanelLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelLogin.Location = new System.Drawing.Point(589, 0);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(421, 625);
            this.PanelLogin.TabIndex = 0;
            // 
            // BtnCloseProgram
            // 
            this.BtnCloseProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseProgram.FlatAppearance.BorderSize = 0;
            this.BtnCloseProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseProgram.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCloseProgram.Location = new System.Drawing.Point(382, 3);
            this.BtnCloseProgram.Name = "BtnCloseProgram";
            this.BtnCloseProgram.Size = new System.Drawing.Size(36, 23);
            this.BtnCloseProgram.TabIndex = 9;
            this.BtnCloseProgram.Text = "X";
            this.BtnCloseProgram.UseVisualStyleBackColor = true;
            this.BtnCloseProgram.Click += new System.EventHandler(this.BtnCloseProgram_Click);
            // 
            // BtnRegistration
            // 
            this.BtnRegistration.AutoSize = true;
            this.BtnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistration.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRegistration.Location = new System.Drawing.Point(235, 580);
            this.BtnRegistration.Name = "BtnRegistration";
            this.BtnRegistration.Size = new System.Drawing.Size(91, 22);
            this.BtnRegistration.TabIndex = 8;
            this.BtnRegistration.Text = "Registrate aqui";
            this.BtnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(97, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "¿Aún no te has registrado?";
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogIn.FlatAppearance.BorderSize = 0;
            this.BtnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogIn.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLogIn.Location = new System.Drawing.Point(56, 384);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(311, 30);
            this.BtnLogIn.TabIndex = 6;
            this.BtnLogIn.Text = "Iniciar sesión";
            this.BtnLogIn.UseVisualStyleBackColor = false;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(62, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // BtnRecoverPass
            // 
            this.BtnRecoverPass.AutoSize = true;
            this.BtnRecoverPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRecoverPass.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecoverPass.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtnRecoverPass.Location = new System.Drawing.Point(214, 306);
            this.BtnRecoverPass.Name = "BtnRecoverPass";
            this.BtnRecoverPass.Size = new System.Drawing.Size(153, 21);
            this.BtnRecoverPass.TabIndex = 4;
            this.BtnRecoverPass.Text = "¿Has olvidado tu contraseña?";
            this.BtnRecoverPass.Click += new System.EventHandler(this.BtnRecoverPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(62, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TxtPassword.Location = new System.Drawing.Point(56, 329);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(311, 25);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.TabStop = false;
            this.TxtPassword.Text = "Ingrese su contraseña";
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // TxtUserCode
            // 
            this.TxtUserCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.TxtUserCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUserCode.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserCode.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TxtUserCode.Location = new System.Drawing.Point(56, 262);
            this.TxtUserCode.Multiline = true;
            this.TxtUserCode.Name = "TxtUserCode";
            this.TxtUserCode.Size = new System.Drawing.Size(311, 25);
            this.TxtUserCode.TabIndex = 1;
            this.TxtUserCode.TabStop = false;
            this.TxtUserCode.Text = "Ingrese su codigo de usuario";
            this.TxtUserCode.Enter += new System.EventHandler(this.TxtUserCode_Enter);
            this.TxtUserCode.Leave += new System.EventHandler(this.TxtUserCode_Leave);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Dubai", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(49, 178);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(132, 42);
            this.Title.TabIndex = 0;
            this.Title.Text = "Bienvenido";
            // 
            // TimerLogInBackground
            // 
            this.TimerLogInBackground.Interval = 13000;
            this.TimerLogInBackground.Tick += new System.EventHandler(this.TimerLogInBackground_Tick);
            // 
            // PicBox_LogIn
            // 
            this.PicBox_LogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PicBox_LogIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.PicBox_LogIn.Image = global::Log_In.Properties.Resources.LogIn_1;
            this.PicBox_LogIn.Location = new System.Drawing.Point(0, 0);
            this.PicBox_LogIn.Name = "PicBox_LogIn";
            this.PicBox_LogIn.Size = new System.Drawing.Size(589, 625);
            this.PicBox_LogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_LogIn.TabIndex = 1;
            this.PicBox_LogIn.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1010, 625);
            this.Controls.Add(this.PicBox_LogIn);
            this.Controls.Add(this.PanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_LogIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.TextBox TxtUserCode;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BtnRecoverPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.Label BtnRegistration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PicBox_LogIn;
        private System.Windows.Forms.Button BtnCloseProgram;
        private System.Windows.Forms.Timer TimerLogInBackground;
    }
}

