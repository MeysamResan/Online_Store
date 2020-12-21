
namespace OnlineStore
{
    partial class ShoppingCartF
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CheckoutBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.BackToMainMenuBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(301, 218);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // CheckoutBTN
            // 
            this.CheckoutBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CheckoutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckoutBTN.Location = new System.Drawing.Point(12, 236);
            this.CheckoutBTN.Name = "CheckoutBTN";
            this.CheckoutBTN.Size = new System.Drawing.Size(301, 23);
            this.CheckoutBTN.TabIndex = 1;
            this.CheckoutBTN.Text = "Оформить заказ";
            this.CheckoutBTN.UseVisualStyleBackColor = false;
            this.CheckoutBTN.Click += new System.EventHandler(this.CheckoutBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 262);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBTN.Location = new System.Drawing.Point(242, 262);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(71, 23);
            this.DeleteBTN.TabIndex = 3;
            this.DeleteBTN.Text = "Удалить";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // BackToMainMenuBTN
            // 
            this.BackToMainMenuBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackToMainMenuBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackToMainMenuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMainMenuBTN.Location = new System.Drawing.Point(12, 290);
            this.BackToMainMenuBTN.Name = "BackToMainMenuBTN";
            this.BackToMainMenuBTN.Size = new System.Drawing.Size(301, 23);
            this.BackToMainMenuBTN.TabIndex = 4;
            this.BackToMainMenuBTN.Text = "Вернуться в главное меню";
            this.BackToMainMenuBTN.UseVisualStyleBackColor = false;
            this.BackToMainMenuBTN.Click += new System.EventHandler(this.BackToMainMenuBTN_Click);
            // 
            // ShoppingCartF
            // 
            this.AcceptButton = this.CheckoutBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.BackToMainMenuBTN;
            this.ClientSize = new System.Drawing.Size(327, 325);
            this.Controls.Add(this.BackToMainMenuBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CheckoutBTN);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShoppingCartF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.ShoppingCartF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button CheckoutBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button BackToMainMenuBTN;
    }
}