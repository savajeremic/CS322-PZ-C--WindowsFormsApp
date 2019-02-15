namespace CS322_PZ_Sava_Jeremic_2733
{
    partial class UserPanel
    {
        private int game_id;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.btnUserGames = new System.Windows.Forms.Button();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbGameToAdd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUserGames
            // 
            this.btnUserGames.Image = ((System.Drawing.Image)(resources.GetObject("btnUserGames.Image")));
            this.btnUserGames.Location = new System.Drawing.Point(35, 87);
            this.btnUserGames.Name = "btnUserGames";
            this.btnUserGames.Size = new System.Drawing.Size(72, 72);
            this.btnUserGames.TabIndex = 0;
            this.btnUserGames.UseVisualStyleBackColor = true;
            this.btnUserGames.Click += new System.EventHandler(this.btnUserGames_Click);
            // 
            // dgvGames
            // 
            this.dgvGames.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvGames.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Location = new System.Drawing.Point(35, 165);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.Size = new System.Drawing.Size(630, 258);
            this.dgvGames.TabIndex = 1;
            this.dgvGames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserGames_CellContentClick);
            // 
            // btnCart
            // 
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.Location = new System.Drawing.Point(593, 92);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(72, 72);
            this.btnCart.TabIndex = 2;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnStore
            // 
            this.btnStore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStore.BackgroundImage")));
            this.btnStore.Location = new System.Drawing.Point(319, 12);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(72, 72);
            this.btnStore.TabIndex = 3;
            this.btnStore.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to the Game Store";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Games";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Your Cart";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSearch.Location = new System.Drawing.Point(267, 139);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(183, 20);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "search";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(267, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(2, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 33);
            this.btnBack.TabIndex = 57;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbGameToAdd
            // 
            this.tbGameToAdd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbGameToAdd.Location = new System.Drawing.Point(62, 445);
            this.tbGameToAdd.Name = "tbGameToAdd";
            this.tbGameToAdd.Size = new System.Drawing.Size(183, 20);
            this.tbGameToAdd.TabIndex = 59;
            this.tbGameToAdd.TextChanged += new System.EventHandler(this.tbGameToAdd_TextChanged);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 477);
            this.Controls.Add(this.tbGameToAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.btnUserGames);
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserPanel_FormClosing);
            this.Load += new System.EventHandler(this.UserPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserGames;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbGameToAdd;
    }
}