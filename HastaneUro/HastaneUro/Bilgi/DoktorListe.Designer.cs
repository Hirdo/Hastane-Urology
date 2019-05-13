namespace HastaneUro.Bilgi
{
    partial class DoktorListe
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.txtDoktor1 = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.txtDoktor2 = new System.Windows.Forms.TextBox();
            this.txtDoktor3 = new System.Windows.Forms.TextBox();
            this.txtDoktor4 = new System.Windows.Forms.TextBox();
            this.txtDoktor5 = new System.Windows.Forms.TextBox();
            this.txtDoktor6 = new System.Windows.Forms.TextBox();
            this.btnAktarma = new System.Windows.Forms.Button();
            this.DoktorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoktorA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnAktarma);
            this.splitContainer1.Panel2.Controls.Add(this.txtDoktor6);
            this.splitContainer1.Panel2.Controls.Add(this.txtDoktor5);
            this.splitContainer1.Panel2.Controls.Add(this.txtDoktor4);
            this.splitContainer1.Panel2.Controls.Add(this.txtDoktor3);
            this.splitContainer1.Panel2.Controls.Add(this.txtDoktor2);
            this.splitContainer1.Panel2.Controls.Add(this.txtDoktor1);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 589;
            this.splitContainer1.TabIndex = 3;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoktorID,
            this.DoktorA});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(585, 446);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // txtDoktor1
            // 
            this.txtDoktor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoktor1.Location = new System.Drawing.Point(3, 46);
            this.txtDoktor1.Name = "txtDoktor1";
            this.txtDoktor1.Size = new System.Drawing.Size(190, 20);
            this.txtDoktor1.TabIndex = 3;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(0, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(203, 40);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtDoktor2
            // 
            this.txtDoktor2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoktor2.Location = new System.Drawing.Point(3, 72);
            this.txtDoktor2.Name = "txtDoktor2";
            this.txtDoktor2.Size = new System.Drawing.Size(190, 20);
            this.txtDoktor2.TabIndex = 3;
            // 
            // txtDoktor3
            // 
            this.txtDoktor3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoktor3.Location = new System.Drawing.Point(3, 98);
            this.txtDoktor3.Name = "txtDoktor3";
            this.txtDoktor3.Size = new System.Drawing.Size(190, 20);
            this.txtDoktor3.TabIndex = 3;
            // 
            // txtDoktor4
            // 
            this.txtDoktor4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoktor4.Location = new System.Drawing.Point(3, 124);
            this.txtDoktor4.Name = "txtDoktor4";
            this.txtDoktor4.Size = new System.Drawing.Size(190, 20);
            this.txtDoktor4.TabIndex = 3;
            // 
            // txtDoktor5
            // 
            this.txtDoktor5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoktor5.Location = new System.Drawing.Point(3, 150);
            this.txtDoktor5.Name = "txtDoktor5";
            this.txtDoktor5.Size = new System.Drawing.Size(190, 20);
            this.txtDoktor5.TabIndex = 3;
            // 
            // txtDoktor6
            // 
            this.txtDoktor6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoktor6.Location = new System.Drawing.Point(3, 176);
            this.txtDoktor6.Name = "txtDoktor6";
            this.txtDoktor6.Size = new System.Drawing.Size(190, 20);
            this.txtDoktor6.TabIndex = 3;
            // 
            // btnAktarma
            // 
            this.btnAktarma.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAktarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktarma.Location = new System.Drawing.Point(0, 407);
            this.btnAktarma.Name = "btnAktarma";
            this.btnAktarma.Size = new System.Drawing.Size(203, 39);
            this.btnAktarma.TabIndex = 4;
            this.btnAktarma.Text = "Aktarma";
            this.btnAktarma.UseVisualStyleBackColor = true;
            this.btnAktarma.Click += new System.EventHandler(this.btnAktarma_Click);
            // 
            // DoktorID
            // 
            this.DoktorID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DoktorID.HeaderText = "DoktorID";
            this.DoktorID.Name = "DoktorID";
            this.DoktorID.ReadOnly = true;
            this.DoktorID.Width = 75;
            // 
            // DoktorA
            // 
            this.DoktorA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoktorA.HeaderText = "Doktor Adı";
            this.DoktorA.Name = "DoktorA";
            this.DoktorA.ReadOnly = true;
            // 
            // DoktorListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DoktorListe";
            this.Text = "DoktorListe";
            this.Load += new System.EventHandler(this.DoktorListe_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.TextBox txtDoktor1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox txtDoktor6;
        private System.Windows.Forms.TextBox txtDoktor5;
        private System.Windows.Forms.TextBox txtDoktor4;
        private System.Windows.Forms.TextBox txtDoktor3;
        private System.Windows.Forms.TextBox txtDoktor2;
        private System.Windows.Forms.Button btnAktarma;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorA;
    }
}