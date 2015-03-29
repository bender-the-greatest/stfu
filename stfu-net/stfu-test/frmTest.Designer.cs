namespace stfu_tray
{
    partial class frmTest
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
            this.txtProp = new System.Windows.Forms.TextBox();
            this.lblProperty = new System.Windows.Forms.Label();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnLogWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProp
            // 
            this.txtProp.Location = new System.Drawing.Point(13, 32);
            this.txtProp.Name = "txtProp";
            this.txtProp.Size = new System.Drawing.Size(169, 20);
            this.txtProp.TabIndex = 0;
            // 
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Location = new System.Drawing.Point(13, 13);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(114, 13);
            this.lblProperty.TabIndex = 1;
            this.lblProperty.Text = "Push string as property";
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(13, 67);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 2;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnLogWindow
            // 
            this.btnLogWindow.Location = new System.Drawing.Point(12, 96);
            this.btnLogWindow.Name = "btnLogWindow";
            this.btnLogWindow.Size = new System.Drawing.Size(75, 23);
            this.btnLogWindow.TabIndex = 3;
            this.btnLogWindow.Text = "Error Window";
            this.btnLogWindow.UseVisualStyleBackColor = true;
            this.btnLogWindow.Click += new System.EventHandler(this.btnLogWindow_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 260);
            this.Controls.Add(this.btnLogWindow);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.lblProperty);
            this.Controls.Add(this.txtProp);
            this.MinimumSize = new System.Drawing.Size(217, 140);
            this.Name = "frmTest";
            this.Text = "Test Property";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProp;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnLogWindow;
    }
}

