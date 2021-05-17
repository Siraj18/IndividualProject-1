namespace IndividualProject
{
	partial class LoginFm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.loginPanel = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelResult = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.buReg = new System.Windows.Forms.Button();
			this.buLogin = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.loginPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// loginPanel
			// 
			this.loginPanel.BackColor = System.Drawing.Color.White;
			this.loginPanel.Controls.Add(this.label5);
			this.loginPanel.Controls.Add(this.label4);
			this.loginPanel.Controls.Add(this.labelResult);
			this.loginPanel.Controls.Add(this.label2);
			this.loginPanel.Controls.Add(this.textBoxPass);
			this.loginPanel.Controls.Add(this.textBoxLogin);
			this.loginPanel.Controls.Add(this.buReg);
			this.loginPanel.Controls.Add(this.buLogin);
			this.loginPanel.Controls.Add(this.pictureBox2);
			this.loginPanel.Controls.Add(this.pictureBox1);
			this.loginPanel.Controls.Add(this.label1);
			this.loginPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.loginPanel.Location = new System.Drawing.Point(468, 0);
			this.loginPanel.Name = "loginPanel";
			this.loginPanel.Size = new System.Drawing.Size(598, 644);
			this.loginPanel.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Intro Cond Light Free", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(29, 331);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 29);
			this.label5.TabIndex = 9;
			this.label5.Text = "Пароль";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Intro Cond Light Free", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(43, 256);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 29);
			this.label4.TabIndex = 8;
			this.label4.Text = "Логин";
			// 
			// labelResult
			// 
			this.labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelResult.Font = new System.Drawing.Font("Intro Cond Light Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResult.ForeColor = System.Drawing.Color.Red;
			this.labelResult.Location = new System.Drawing.Point(144, 520);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(314, 115);
			this.labelResult.TabIndex = 7;
			this.labelResult.Text = "...";
			this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Intro Cond Light Free", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(109, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(379, 46);
			this.label2.TabIndex = 6;
			this.label2.Text = "Добро пожаловать";
			// 
			// textBoxPass
			// 
			this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPass.Font = new System.Drawing.Font("BravoRG", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPass.ForeColor = System.Drawing.Color.Black;
			this.textBoxPass.Location = new System.Drawing.Point(172, 333);
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.Size = new System.Drawing.Size(274, 27);
			this.textBoxPass.TabIndex = 5;
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxLogin.Font = new System.Drawing.Font("BravoRG", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxLogin.ForeColor = System.Drawing.Color.Black;
			this.textBoxLogin.Location = new System.Drawing.Point(172, 256);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBoxLogin.Size = new System.Drawing.Size(274, 27);
			this.textBoxLogin.TabIndex = 4;
			// 
			// buReg
			// 
			this.buReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(127)))), ((int)(((byte)(154)))));
			this.buReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buReg.Font = new System.Drawing.Font("Intro Cond Light Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buReg.ForeColor = System.Drawing.Color.White;
			this.buReg.Location = new System.Drawing.Point(144, 455);
			this.buReg.Name = "buReg";
			this.buReg.Size = new System.Drawing.Size(314, 62);
			this.buReg.TabIndex = 3;
			this.buReg.Text = "Регистрация";
			this.buReg.UseVisualStyleBackColor = false;
			// 
			// buLogin
			// 
			this.buLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(127)))), ((int)(((byte)(154)))));
			this.buLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buLogin.Font = new System.Drawing.Font("Intro Cond Light Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buLogin.ForeColor = System.Drawing.Color.White;
			this.buLogin.Location = new System.Drawing.Point(144, 387);
			this.buLogin.Name = "buLogin";
			this.buLogin.Size = new System.Drawing.Size(314, 62);
			this.buLogin.TabIndex = 3;
			this.buLogin.Text = "Войти";
			this.buLogin.UseVisualStyleBackColor = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::IndividualProject.Properties.Resources.input;
			this.pictureBox2.Location = new System.Drawing.Point(144, 319);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(314, 50);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::IndividualProject.Properties.Resources.input;
			this.pictureBox1.Location = new System.Drawing.Point(144, 244);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(314, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Intro Cond Light Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(257, 191);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Вход";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Intro Cond Light Free", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(154, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(237, 46);
			this.label3.TabIndex = 7;
			this.label3.Text = "Библиотека";
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.White;
			this.pictureBox5.Image = global::IndividualProject.Properties.Resources.icon;
			this.pictureBox5.Location = new System.Drawing.Point(12, 12);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(136, 73);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 7;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::IndividualProject.Properties.Resources.Ресурс_1;
			this.pictureBox4.Location = new System.Drawing.Point(55, 319);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(306, 260);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 6;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox3.Image = global::IndividualProject.Properties.Resources.path8271;
			this.pictureBox3.Location = new System.Drawing.Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(468, 318);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			// 
			// LoginFm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(127)))), ((int)(((byte)(154)))));
			this.ClientSize = new System.Drawing.Size(1066, 644);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.loginPanel);
			this.Name = "LoginFm";
			this.Text = "Авторизация";
			this.loginPanel.ResumeLayout(false);
			this.loginPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel loginPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button buLogin;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.TextBox textBoxPass;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label3;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.Button buReg;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
	}
}

