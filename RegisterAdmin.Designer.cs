namespace Paquito_sPizzeria
{
    partial class RegisterAdmin
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
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPasswordTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.txtCustPrice = new ReaLTaiizor.Controls.HopeTextBox();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(280, 90);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(164, 20);
            this.nameTxt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(280, 126);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(164, 20);
            this.passwordTxt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter Password";
            // 
            // confirmPasswordTxt
            // 
            this.confirmPasswordTxt.Location = new System.Drawing.Point(280, 166);
            this.confirmPasswordTxt.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPasswordTxt.Name = "confirmPasswordTxt";
            this.confirmPasswordTxt.PasswordChar = '*';
            this.confirmPasswordTxt.Size = new System.Drawing.Size(164, 20);
            this.confirmPasswordTxt.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Confirm Password";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(308, 273);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(135, 38);
            this.registerBtn.TabIndex = 19;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Register Admin Account";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(159, 273);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(135, 38);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // txtCustPrice
            // 
            this.txtCustPrice.BackColor = System.Drawing.Color.White;
            this.txtCustPrice.BaseColor = System.Drawing.Color.White;
            this.txtCustPrice.BorderColorA = System.Drawing.Color.Black;
            this.txtCustPrice.BorderColorB = System.Drawing.Color.Black;
            this.txtCustPrice.Font = new System.Drawing.Font("Nunito", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustPrice.ForeColor = System.Drawing.Color.Black;
            this.txtCustPrice.Hint = "";
            this.txtCustPrice.Location = new System.Drawing.Point(178, 207);
            this.txtCustPrice.MaxLength = 32767;
            this.txtCustPrice.Multiline = false;
            this.txtCustPrice.Name = "txtCustPrice";
            this.txtCustPrice.PasswordChar = '\0';
            this.txtCustPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustPrice.SelectedText = "";
            this.txtCustPrice.SelectionLength = 0;
            this.txtCustPrice.SelectionStart = 0;
            this.txtCustPrice.Size = new System.Drawing.Size(251, 34);
            this.txtCustPrice.TabIndex = 22;
            this.txtCustPrice.TabStop = false;
            this.txtCustPrice.UseSystemPasswordChar = false;
            // 
            // RegisterAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtCustPrice);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmPasswordTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterAdmin";
            this.Text = "register_admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmPasswordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelBtn;
        private ReaLTaiizor.Controls.HopeTextBox txtCustPrice;
    }
}