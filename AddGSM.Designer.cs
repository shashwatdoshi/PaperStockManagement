namespace ProjectStockManagement
{
    partial class AddGSM
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
            this.btnCancleGSM = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAddGSM = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtAddGSM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblAddGSM = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnCancleGSM
            // 
            this.btnCancleGSM.AutoSize = true;
            this.btnCancleGSM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancleGSM.Depth = 0;
            this.btnCancleGSM.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancleGSM.Location = new System.Drawing.Point(171, 182);
            this.btnCancleGSM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancleGSM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancleGSM.Name = "btnCancleGSM";
            this.btnCancleGSM.Primary = false;
            this.btnCancleGSM.Size = new System.Drawing.Size(64, 36);
            this.btnCancleGSM.TabIndex = 7;
            this.btnCancleGSM.Text = "CANCLE";
            this.btnCancleGSM.UseVisualStyleBackColor = true;
            this.btnCancleGSM.Click += new System.EventHandler(this.btnCancleGSM_Click);
            // 
            // btnAddGSM
            // 
            this.btnAddGSM.AutoSize = true;
            this.btnAddGSM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddGSM.Depth = 0;
            this.btnAddGSM.Location = new System.Drawing.Point(73, 182);
            this.btnAddGSM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddGSM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddGSM.Name = "btnAddGSM";
            this.btnAddGSM.Primary = false;
            this.btnAddGSM.Size = new System.Drawing.Size(72, 36);
            this.btnAddGSM.TabIndex = 6;
            this.btnAddGSM.Text = "ADD GSM";
            this.btnAddGSM.UseVisualStyleBackColor = true;
            this.btnAddGSM.Click += new System.EventHandler(this.btnAddGSM_Click);
            // 
            // txtAddGSM
            // 
            this.txtAddGSM.Depth = 0;
            this.txtAddGSM.Hint = "Write GSM value";
            this.txtAddGSM.Location = new System.Drawing.Point(73, 111);
            this.txtAddGSM.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddGSM.Name = "txtAddGSM";
            this.txtAddGSM.PasswordChar = '\0';
            this.txtAddGSM.SelectedText = "";
            this.txtAddGSM.SelectionLength = 0;
            this.txtAddGSM.SelectionStart = 0;
            this.txtAddGSM.Size = new System.Drawing.Size(162, 23);
            this.txtAddGSM.TabIndex = 5;
            this.txtAddGSM.UseSystemPasswordChar = false;
            this.txtAddGSM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddGSM_KeyPress);
            // 
            // lblAddGSM
            // 
            this.lblAddGSM.AutoSize = true;
            this.lblAddGSM.Depth = 0;
            this.lblAddGSM.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddGSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddGSM.Location = new System.Drawing.Point(69, 63);
            this.lblAddGSM.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddGSM.Name = "lblAddGSM";
            this.lblAddGSM.Size = new System.Drawing.Size(71, 19);
            this.lblAddGSM.TabIndex = 4;
            this.lblAddGSM.Text = "Add GSM";
            // 
            // AddGSM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.btnCancleGSM);
            this.Controls.Add(this.btnAddGSM);
            this.Controls.Add(this.txtAddGSM);
            this.Controls.Add(this.lblAddGSM);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 320);
            this.Name = "AddGSM";
            this.Text = "AddGSM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnCancleGSM;
        private MaterialSkin.Controls.MaterialFlatButton btnAddGSM;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddGSM;
        private MaterialSkin.Controls.MaterialLabel lblAddGSM;
    }
}