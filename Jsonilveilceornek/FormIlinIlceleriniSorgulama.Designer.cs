
namespace Jsonilveilceornek
{
    partial class FormIlinIlceleriniSorgulama
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
            this.labelilsec = new System.Windows.Forms.Label();
            this.comboBoxILLER = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // labelilsec
            // 
            this.labelilsec.AutoSize = true;
            this.labelilsec.Location = new System.Drawing.Point(30, 43);
            this.labelilsec.Name = "labelilsec";
            this.labelilsec.Size = new System.Drawing.Size(49, 20);
            this.labelilsec.TabIndex = 0;
            this.labelilsec.Text = "İL SEÇ";
            // 
            // comboBoxILLER
            // 
            this.comboBoxILLER.FormattingEnabled = true;
            this.comboBoxILLER.Location = new System.Drawing.Point(141, 35);
            this.comboBoxILLER.Name = "comboBoxILLER";
            this.comboBoxILLER.Size = new System.Drawing.Size(295, 28);
            this.comboBoxILLER.TabIndex = 1;
            this.comboBoxILLER.SelectedIndexChanged += new System.EventHandler(this.comboBoxILLER_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(535, 284);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Belediye İsmi";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Telefon";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Eposta";
            // 
            // FormIlinIlceleriniSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBoxILLER);
            this.Controls.Add(this.labelilsec);
            this.Name = "FormIlinIlceleriniSorgulama";
            this.Text = "FormIlinIlceleriniSorgulama";
            this.Load += new System.EventHandler(this.FormIlinIlceleriniSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelilsec;
        private System.Windows.Forms.ComboBox comboBoxILLER;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}