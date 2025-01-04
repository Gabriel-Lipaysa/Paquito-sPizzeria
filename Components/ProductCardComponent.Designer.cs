namespace Paquito_sPizzeria
{
    partial class ProductCardComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panelBg = new System.Windows.Forms.Panel();
            this.richTextName = new System.Windows.Forms.RichTextBox();
            this.richTxtDesc = new System.Windows.Forms.RichTextBox();
            this.btnDel = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Location = new System.Drawing.Point(415, 17);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(24, 13);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "qtty";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(292, 17);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            // 
            // panelBg
            // 
            this.panelBg.Controls.Add(this.richTextName);
            this.panelBg.Controls.Add(this.richTxtDesc);
            this.panelBg.Controls.Add(this.lblPrice);
            this.panelBg.Controls.Add(this.btnDel);
            this.panelBg.Controls.Add(this.btnEdit);
            this.panelBg.Controls.Add(this.picBox);
            this.panelBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBg.Location = new System.Drawing.Point(0, 0);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(1007, 115);
            this.panelBg.TabIndex = 9;
            this.panelBg.MouseLeave += new System.EventHandler(this.panelBg_MouseLeave);
            this.panelBg.MouseHover += new System.EventHandler(this.panelBg_MouseHover);
            // 
            // richTextName
            // 
            this.richTextName.BackColor = System.Drawing.Color.White;
            this.richTextName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextName.Location = new System.Drawing.Point(163, 18);
            this.richTextName.Name = "richTextName";
            this.richTextName.ReadOnly = true;
            this.richTextName.Size = new System.Drawing.Size(109, 79);
            this.richTextName.TabIndex = 8;
            this.richTextName.Text = "";
            // 
            // richTxtDesc
            // 
            this.richTxtDesc.BackColor = System.Drawing.Color.White;
            this.richTxtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtDesc.Location = new System.Drawing.Point(546, 17);
            this.richTxtDesc.Name = "richTxtDesc";
            this.richTxtDesc.ReadOnly = true;
            this.richTxtDesc.Size = new System.Drawing.Size(329, 79);
            this.richTxtDesc.TabIndex = 8;
            this.richTxtDesc.Text = "";
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Image = global::Paquito_sPizzeria.Properties.Resources.delete;
            this.btnDel.Location = new System.Drawing.Point(943, 30);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(34, 46);
            this.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDel.TabIndex = 2;
            this.btnDel.TabStop = false;
            this.btnDel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDel_MouseClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Image = global::Paquito_sPizzeria.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(899, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(38, 46);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 3;
            this.btnEdit.TabStop = false;
            this.btnEdit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEdit_MouseClick);
            // 
            // picBox
            // 
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox.Location = new System.Drawing.Point(35, 17);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(80, 80);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // ProductCardComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.panelBg);
            this.Name = "ProductCardComponent";
            this.Size = new System.Drawing.Size(1007, 115);
            this.Load += new System.EventHandler(this.ProductCardComponent_Load);
            this.panelBg.ResumeLayout(false);
            this.panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox btnDel;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Panel panelBg;
        private System.Windows.Forms.RichTextBox richTxtDesc;
        private System.Windows.Forms.RichTextBox richTextName;
    }
}
