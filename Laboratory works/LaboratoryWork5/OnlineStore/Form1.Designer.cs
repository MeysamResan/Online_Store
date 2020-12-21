
namespace OnlineStore
{
    partial class MainMenuF
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
            this.ShoppingCartBTN = new System.Windows.Forms.Button();
            this.CatalogBTN = new System.Windows.Forms.Button();
            this.SearchTXTBX = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShoppingCartBTN
            // 
            this.ShoppingCartBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShoppingCartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShoppingCartBTN.Location = new System.Drawing.Point(158, 12);
            this.ShoppingCartBTN.Name = "ShoppingCartBTN";
            this.ShoppingCartBTN.Size = new System.Drawing.Size(75, 23);
            this.ShoppingCartBTN.TabIndex = 0;
            this.ShoppingCartBTN.Text = "Kорзина";
            this.ShoppingCartBTN.UseVisualStyleBackColor = false;
            this.ShoppingCartBTN.Click += new System.EventHandler(this.ShoppingCartBTN_Click);
            // 
            // CatalogBTN
            // 
            this.CatalogBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CatalogBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatalogBTN.Location = new System.Drawing.Point(158, 38);
            this.CatalogBTN.Name = "CatalogBTN";
            this.CatalogBTN.Size = new System.Drawing.Size(75, 23);
            this.CatalogBTN.TabIndex = 1;
            this.CatalogBTN.Text = "Каталог товаров";
            this.CatalogBTN.UseVisualStyleBackColor = false;
            this.CatalogBTN.Click += new System.EventHandler(this.CatalogBTN_Click);
            // 
            // SearchTXTBX
            // 
            this.SearchTXTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTXTBX.Location = new System.Drawing.Point(12, 12);
            this.SearchTXTBX.Multiline = true;
            this.SearchTXTBX.Name = "SearchTXTBX";
            this.SearchTXTBX.Size = new System.Drawing.Size(140, 23);
            this.SearchTXTBX.TabIndex = 2;
            this.SearchTXTBX.TextChanged += new System.EventHandler(this.SearchTXTBX_TextChanged);
            // 
            // SearchBTN
            // 
            this.SearchBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBTN.Location = new System.Drawing.Point(12, 38);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(140, 23);
            this.SearchBTN.TabIndex = 3;
            this.SearchBTN.Text = "Поиск";
            this.SearchBTN.UseVisualStyleBackColor = false;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Designed by Angelina and Meysam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuF
            // 
            this.AcceptButton = this.SearchBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(247, 88);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.SearchTXTBX);
            this.Controls.Add(this.CatalogBTN);
            this.Controls.Add(this.ShoppingCartBTN);
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(263, 127);
            this.MinimumSize = new System.Drawing.Size(263, 127);
            this.Name = "MainMenuF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShoppingCartBTN;
        public System.Windows.Forms.Button CatalogBTN;
        private System.Windows.Forms.TextBox SearchTXTBX;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Label label1;
    }
}

