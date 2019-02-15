namespace CS322_PZ_Sava_Jeremic_2733
{
    partial class UserGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserGames));
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.btnCheckout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(-1, 1);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 33);
            this.btnBack.TabIndex = 57;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(232, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.TabIndex = 59;
            this.label1.Text = "Games Library";
            // 
            // dgvGames
            // 
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Location = new System.Drawing.Point(77, 65);
            this.dgvGames.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.Size = new System.Drawing.Size(539, 362);
            this.dgvGames.TabIndex = 58;
            this.dgvGames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGames_CellContentClick);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Snow;
            this.btnCheckout.FlatAppearance.BorderSize = 3;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(250, 445);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(183, 36);
            this.btnCheckout.TabIndex = 61;
            this.btnCheckout.Text = "Refresh :)";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // UserGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 493);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.btnBack);
            this.Name = "UserGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserGames";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserGames_FormClosing);
            this.Load += new System.EventHandler(this.UserGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.Button btnCheckout;
    }
}