
namespace Our_Perfect_Access
{
    partial class ChangeDbForm
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
            this.buttonBackToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackToMain
            // 
            this.buttonBackToMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToMain.Location = new System.Drawing.Point(12, 403);
            this.buttonBackToMain.Name = "buttonBackToMain";
            this.buttonBackToMain.Size = new System.Drawing.Size(117, 35);
            this.buttonBackToMain.TabIndex = 1;
            this.buttonBackToMain.Text = "Назад";
            this.buttonBackToMain.UseVisualStyleBackColor = true;
            this.buttonBackToMain.Click += new System.EventHandler(this.buttonBackToMain_Click);
            // 
            // ChangeDbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBackToMain);
            this.Name = "ChangeDbForm";
            this.Text = "ChangeDbForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeDbForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMain;
    }
}