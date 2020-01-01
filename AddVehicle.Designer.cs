namespace ProjectStockManagement
{
    partial class AddVehicle
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
            this.btnCancleVehicle = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAddVehicle = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtAddVehicle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblAddVehicle = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnCancleVehicle
            // 
            this.btnCancleVehicle.AutoSize = true;
            this.btnCancleVehicle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancleVehicle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancleVehicle.Depth = 0;
            this.btnCancleVehicle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancleVehicle.Location = new System.Drawing.Point(171, 182);
            this.btnCancleVehicle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancleVehicle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancleVehicle.Name = "btnCancleVehicle";
            this.btnCancleVehicle.Primary = false;
            this.btnCancleVehicle.Size = new System.Drawing.Size(64, 36);
            this.btnCancleVehicle.TabIndex = 7;
            this.btnCancleVehicle.Text = "CANCLE";
            this.btnCancleVehicle.UseVisualStyleBackColor = true;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.AutoSize = true;
            this.btnAddVehicle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddVehicle.Depth = 0;
            this.btnAddVehicle.Location = new System.Drawing.Point(73, 182);
            this.btnAddVehicle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddVehicle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Primary = false;
            this.btnAddVehicle.Size = new System.Drawing.Size(97, 36);
            this.btnAddVehicle.TabIndex = 6;
            this.btnAddVehicle.Text = "ADD Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            // 
            // txtAddVehicle
            // 
            this.txtAddVehicle.Depth = 0;
            this.txtAddVehicle.Hint = "Add Vehicle Number";
            this.txtAddVehicle.Location = new System.Drawing.Point(73, 111);
            this.txtAddVehicle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddVehicle.Name = "txtAddVehicle";
            this.txtAddVehicle.PasswordChar = '\0';
            this.txtAddVehicle.SelectedText = "";
            this.txtAddVehicle.SelectionLength = 0;
            this.txtAddVehicle.SelectionStart = 0;
            this.txtAddVehicle.Size = new System.Drawing.Size(162, 23);
            this.txtAddVehicle.TabIndex = 5;
            this.txtAddVehicle.UseSystemPasswordChar = false;
            // 
            // lblAddVehicle
            // 
            this.lblAddVehicle.AutoSize = true;
            this.lblAddVehicle.Depth = 0;
            this.lblAddVehicle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddVehicle.Location = new System.Drawing.Point(69, 63);
            this.lblAddVehicle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddVehicle.Name = "lblAddVehicle";
            this.lblAddVehicle.Size = new System.Drawing.Size(140, 19);
            this.lblAddVehicle.TabIndex = 4;
            this.lblAddVehicle.Text = "Add Vehicle Details";
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.btnCancleVehicle);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.txtAddVehicle);
            this.Controls.Add(this.lblAddVehicle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 320);
            this.Name = "AddVehicle";
            this.Text = "Add Vehicle Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnCancleVehicle;
        private MaterialSkin.Controls.MaterialFlatButton btnAddVehicle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddVehicle;
        private MaterialSkin.Controls.MaterialLabel lblAddVehicle;
    }
}