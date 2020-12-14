
namespace Our_Perfect_Access
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateDB = new System.Windows.Forms.Button();
            this.buttonChangeDB = new System.Windows.Forms.Button();
            this.buttonEntries = new System.Windows.Forms.Button();
            this.buttonQueries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateDB
            // 
            this.buttonCreateDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateDB.Location = new System.Drawing.Point(101, 71);
            this.buttonCreateDB.Name = "buttonCreateDB";
            this.buttonCreateDB.Size = new System.Drawing.Size(229, 43);
            this.buttonCreateDB.TabIndex = 2;
            this.buttonCreateDB.Text = "Создание базы данных";
            this.buttonCreateDB.UseVisualStyleBackColor = true;
            this.buttonCreateDB.Click += new System.EventHandler(this.buttonCreateDB_Click);
            // 
            // buttonChangeDB
            // 
            this.buttonChangeDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeDB.Location = new System.Drawing.Point(101, 119);
            this.buttonChangeDB.Name = "buttonChangeDB";
            this.buttonChangeDB.Size = new System.Drawing.Size(229, 43);
            this.buttonChangeDB.TabIndex = 3;
            this.buttonChangeDB.Text = "Редактирование схемы базы данных";
            this.buttonChangeDB.UseVisualStyleBackColor = true;
            this.buttonChangeDB.Click += new System.EventHandler(this.buttonChangeDB_Click);
            // 
            // buttonEntries
            // 
            this.buttonEntries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEntries.Location = new System.Drawing.Point(101, 168);
            this.buttonEntries.Name = "buttonEntries";
            this.buttonEntries.Size = new System.Drawing.Size(229, 43);
            this.buttonEntries.TabIndex = 4;
            this.buttonEntries.Text = "Работа с записями в бд";
            this.buttonEntries.UseVisualStyleBackColor = true;
            this.buttonEntries.Click += new System.EventHandler(this.buttonEntries_Click);
            // 
            // buttonQueries
            // 
            this.buttonQueries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQueries.Location = new System.Drawing.Point(101, 217);
            this.buttonQueries.Name = "buttonQueries";
            this.buttonQueries.Size = new System.Drawing.Size(229, 43);
            this.buttonQueries.TabIndex = 5;
            this.buttonQueries.Text = "Конструктор запросов";
            this.buttonQueries.UseVisualStyleBackColor = true;
            this.buttonQueries.Click += new System.EventHandler(this.buttonQueries_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 361);
            this.Controls.Add(this.buttonQueries);
            this.Controls.Add(this.buttonEntries);
            this.Controls.Add(this.buttonChangeDB);
            this.Controls.Add(this.buttonCreateDB);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(463, 400);
            this.MinimumSize = new System.Drawing.Size(463, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateDB;
        private System.Windows.Forms.Button buttonChangeDB;
        private System.Windows.Forms.Button buttonEntries;
        private System.Windows.Forms.Button buttonQueries;
    }
}

