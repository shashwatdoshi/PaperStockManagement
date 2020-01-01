namespace ProjectStockManagement
{
    partial class AddBF
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
            this.lblAddBF = new MaterialSkin.Controls.MaterialLabel();
            this.txtAddBF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddBF = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancleBF = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lblAddBF
            // 
            this.lblAddBF.AutoSize = true;
            this.lblAddBF.Depth = 0;
            this.lblAddBF.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddBF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddBF.Location = new System.Drawing.Point(69, 61);
            this.lblAddBF.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddBF.Name = "lblAddBF";
            this.lblAddBF.Size = new System.Drawing.Size(166, 19);
            this.lblAddBF.TabIndex = 0;
            this.lblAddBF.Text = "Add Breaking Force(BF)";
            // 
            // txtAddBF
            // 
            this.txtAddBF.Depth = 0;
            this.txtAddBF.Hint = "Write BF value";
            this.txtAddBF.Location = new System.Drawing.Point(73, 109);
            this.txtAddBF.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddBF.Name = "txtAddBF";
            this.txtAddBF.PasswordChar = '\0';
            this.txtAddBF.SelectedText = "";
            this.txtAddBF.SelectionLength = 0;
            this.txtAddBF.SelectionStart = 0;
            this.txtAddBF.Size = new System.Drawing.Size(162, 23);
            this.txtAddBF.TabIndex = 1;
            this.txtAddBF.UseSystemPasswordChar = false;
            // 
            // btnAddBF
            // 
            this.btnAddBF.AutoSize = true;
            this.btnAddBF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddBF.Depth = 0;
            this.btnAddBF.Location = new System.Drawing.Point(73, 180);
            this.btnAddBF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddBF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddBF.Name = "btnAddBF";
            this.btnAddBF.Primary = false;
            this.btnAddBF.Size = new System.Drawing.Size(59, 36);
            this.btnAddBF.TabIndex = 2;
            this.btnAddBF.Text = "ADD BF";
            this.btnAddBF.UseVisualStyleBackColor = true;
            // 
            // btnCancleBF
            // 
            this.btnCancleBF.AutoSize = true;
            this.btnCancleBF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancleBF.Depth = 0;
            this.btnCancleBF.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancleBF.Location = new System.Drawing.Point(171, 180);
            this.btnCancleBF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancleBF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancleBF.Name = "btnCancleBF";
            this.btnCancleBF.Primary = false;
            this.btnCancleBF.Size = new System.Drawing.Size(64, 36);
            this.btnCancleBF.TabIndex = 3;
            this.btnCancleBF.Text = "CANCLE";
            this.btnCancleBF.UseVisualStyleBackColor = true;
            // 
            // AddBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancleBF;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.btnCancleBF);
            this.Controls.Add(this.btnAddBF);
            this.Controls.Add(this.txtAddBF);
            this.Controls.Add(this.lblAddBF);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 320);
            this.Name = "AddBF";
            this.Text = "Add Breaking Force (BF)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblAddBF;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddBF;
        private MaterialSkin.Controls.MaterialFlatButton btnAddBF;
        private MaterialSkin.Controls.MaterialFlatButton btnCancleBF;
    }
}