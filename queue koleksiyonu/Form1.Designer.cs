namespace queue_koleksiyonu
{
    partial class Form1
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
            this.btnSiraAl = new System.Windows.Forms.Button();
            this.btnSiraCikart = new System.Windows.Forms.Button();
            this.lbSiralar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSiraAl
            // 
            this.btnSiraAl.Location = new System.Drawing.Point(52, 100);
            this.btnSiraAl.Name = "btnSiraAl";
            this.btnSiraAl.Size = new System.Drawing.Size(107, 86);
            this.btnSiraAl.TabIndex = 0;
            this.btnSiraAl.Text = "Sıra Al";
            this.btnSiraAl.UseVisualStyleBackColor = true;
            this.btnSiraAl.Click += new System.EventHandler(this.btnSiraAl_Click);
            // 
            // btnSiraCikart
            // 
            this.btnSiraCikart.Location = new System.Drawing.Point(338, 100);
            this.btnSiraCikart.Name = "btnSiraCikart";
            this.btnSiraCikart.Size = new System.Drawing.Size(107, 86);
            this.btnSiraCikart.TabIndex = 1;
            this.btnSiraCikart.Text = "Sıra Çıkart";
            this.btnSiraCikart.UseVisualStyleBackColor = true;
            this.btnSiraCikart.Click += new System.EventHandler(this.btnSiraCikart_Click);
            // 
            // lbSiralar
            // 
            this.lbSiralar.FormattingEnabled = true;
            this.lbSiralar.Location = new System.Drawing.Point(186, 63);
            this.lbSiralar.Name = "lbSiralar";
            this.lbSiralar.Size = new System.Drawing.Size(120, 160);
            this.lbSiralar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 286);
            this.Controls.Add(this.lbSiralar);
            this.Controls.Add(this.btnSiraCikart);
            this.Controls.Add(this.btnSiraAl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiraAl;
        private System.Windows.Forms.Button btnSiraCikart;
        private System.Windows.Forms.ListBox lbSiralar;
    }
}

