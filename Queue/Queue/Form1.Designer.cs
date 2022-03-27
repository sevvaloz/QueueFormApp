namespace Queue
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.brn_sil = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.sayi = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(76, 211);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(157, 54);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "Kuyruğa Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // brn_sil
            // 
            this.brn_sil.Location = new System.Drawing.Point(259, 211);
            this.brn_sil.Name = "brn_sil";
            this.brn_sil.Size = new System.Drawing.Size(157, 54);
            this.brn_sil.TabIndex = 1;
            this.brn_sil.Text = "Kuyruktan Sil";
            this.brn_sil.UseVisualStyleBackColor = true;
            this.brn_sil.Click += new System.EventHandler(this.brn_sil_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(100, 126);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 16);
            this.label.TabIndex = 2;
            this.label.Text = "Sayi Giriniz:";
            // 
            // sayi
            // 
            this.sayi.Location = new System.Drawing.Point(182, 120);
            this.sayi.Name = "sayi";
            this.sayi.Size = new System.Drawing.Size(199, 22);
            this.sayi.TabIndex = 3;
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(76, 305);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(340, 180);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 549);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.sayi);
            this.Controls.Add(this.label);
            this.Controls.Add(this.brn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Name = "Form1";
            this.Text = "Kuyruk Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button brn_sil;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox sayi;
        private System.Windows.Forms.ListView listView;
    }
}

