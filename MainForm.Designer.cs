namespace Paquito_sPizzeria
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUsers = new ReaLTaiizor.Controls.RoyalButton();
            this.royalButton4 = new ReaLTaiizor.Controls.RoyalButton();
            this.btn = new ReaLTaiizor.Controls.RoyalButton();
            this.btnProd = new ReaLTaiizor.Controls.RoyalButton();
            this.btnDash = new ReaLTaiizor.Controls.RoyalButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.PanelMain);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 661);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1284, 106);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nunito ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(133)))), ((int)(((byte)(56)))));
            this.label5.Location = new System.Drawing.Point(101, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Panel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nunito ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Admin";
            // 
            // PanelMain
            // 
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelMain.Location = new System.Drawing.Point(189, 106);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1095, 555);
            this.PanelMain.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btnUsers);
            this.panel2.Controls.Add(this.royalButton4);
            this.panel2.Controls.Add(this.btn);
            this.panel2.Controls.Add(this.btnProd);
            this.panel2.Controls.Add(this.btnDash);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 661);
            this.panel2.TabIndex = 0;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUsers.BorderColor = System.Drawing.Color.Transparent;
            this.btnUsers.BorderThickness = 3;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.DrawBorder = true;
            this.btnUsers.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnUsers.Image = null;
            this.btnUsers.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.btnUsers.Location = new System.Drawing.Point(0, 265);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnUsers.PressedForeColor = System.Drawing.Color.White;
            this.btnUsers.Size = new System.Drawing.Size(189, 40);
            this.btnUsers.TabIndex = 22;
            this.btnUsers.Text = "Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // royalButton4
            // 
            this.royalButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.royalButton4.BorderColor = System.Drawing.Color.Transparent;
            this.royalButton4.BorderThickness = 3;
            this.royalButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.royalButton4.DrawBorder = true;
            this.royalButton4.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.royalButton4.ForeColor = System.Drawing.Color.White;
            this.royalButton4.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.royalButton4.Image = null;
            this.royalButton4.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.royalButton4.Location = new System.Drawing.Point(0, 225);
            this.royalButton4.Name = "royalButton4";
            this.royalButton4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.royalButton4.PressedForeColor = System.Drawing.Color.White;
            this.royalButton4.Size = new System.Drawing.Size(189, 40);
            this.royalButton4.TabIndex = 21;
            this.royalButton4.Text = "Products";
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn.BorderColor = System.Drawing.Color.Transparent;
            this.btn.BorderThickness = 3;
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.DrawBorder = true;
            this.btn.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn.Image = null;
            this.btn.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.btn.Location = new System.Drawing.Point(0, 186);
            this.btn.Name = "btn";
            this.btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn.PressedForeColor = System.Drawing.Color.White;
            this.btn.Size = new System.Drawing.Size(189, 40);
            this.btn.TabIndex = 20;
            this.btn.Text = "Products";
            // 
            // btnProd
            // 
            this.btnProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnProd.BorderColor = System.Drawing.Color.Transparent;
            this.btnProd.BorderThickness = 3;
            this.btnProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProd.DrawBorder = true;
            this.btnProd.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.ForeColor = System.Drawing.Color.White;
            this.btnProd.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnProd.Image = null;
            this.btnProd.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.btnProd.Location = new System.Drawing.Point(0, 146);
            this.btnProd.Name = "btnProd";
            this.btnProd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnProd.PressedForeColor = System.Drawing.Color.White;
            this.btnProd.Size = new System.Drawing.Size(189, 40);
            this.btnProd.TabIndex = 19;
            this.btnProd.Text = "Products";
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDash.BorderColor = System.Drawing.Color.Transparent;
            this.btnDash.BorderThickness = 3;
            this.btnDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDash.DrawBorder = true;
            this.btnDash.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnDash.Image = null;
            this.btnDash.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.btnDash.Location = new System.Drawing.Point(0, 106);
            this.btnDash.Name = "btnDash";
            this.btnDash.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnDash.PressedForeColor = System.Drawing.Color.White;
            this.btnDash.Size = new System.Drawing.Size(189, 40);
            this.btnDash.TabIndex = 0;
            this.btnDash.Text = "Dashboard";
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelMain;
        private ReaLTaiizor.Controls.RoyalButton btnDash;
        private ReaLTaiizor.Controls.RoyalButton btnProd;
        private ReaLTaiizor.Controls.RoyalButton btnUsers;
        private ReaLTaiizor.Controls.RoyalButton royalButton4;
        private ReaLTaiizor.Controls.RoyalButton btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}