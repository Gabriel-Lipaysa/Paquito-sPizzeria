namespace Paquito_sPizzeria
{
    partial class Products
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
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new ReaLTaiizor.Controls.HopeButton();
            this.btnEdit = new ReaLTaiizor.Controls.HopeButton();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(53, 73);
            this.productGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowHeadersWidth = 51;
            this.productGridView.RowTemplate.Height = 24;
            this.productGridView.Size = new System.Drawing.Size(849, 242);
            this.productGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(254, 334);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(117, 50);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "delete ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(543, 49);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(320, 22);
            this.searchTxt.TabIndex = 5;
            this.searchTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnAdd.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.HoverTextColor = System.Drawing.Color.White;
            this.btnAdd.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnAdd.Location = new System.Drawing.Point(53, 335);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.btnAdd.Size = new System.Drawing.Size(155, 49);
            this.btnAdd.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderColor = System.Drawing.Color.Transparent;
            this.btnEdit.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnEdit.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEdit.HoverTextColor = System.Drawing.Color.White;
            this.btnEdit.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnEdit.Location = new System.Drawing.Point(421, 334);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.btnEdit.Size = new System.Drawing.Size(155, 49);
            this.btnEdit.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.HopeButton btnAdd;
        private ReaLTaiizor.Controls.HopeButton btnEdit;
    }
}