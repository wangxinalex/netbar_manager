namespace Netbar_manager {
    partial class Server {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuisine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restaurant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirmed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Refugee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Helped = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Online_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.Cuisine,
            this.Number,
            this.Price,
            this.Restaurant,
            this.Confirmed});
            this.dataGridView1.Location = new System.Drawing.Point(20, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(641, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            // 
            // Cuisine
            // 
            this.Cuisine.HeaderText = "Cuisine";
            this.Cuisine.Name = "Cuisine";
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Restaurant
            // 
            this.Restaurant.HeaderText = "Restaurant";
            this.Restaurant.Name = "Restaurant";
            // 
            // Confirmed
            // 
            this.Confirmed.HeaderText = "Confirmed";
            this.Confirmed.Name = "Confirmed";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Refugee,
            this.Reason,
            this.Helped});
            this.dataGridView2.Location = new System.Drawing.Point(320, 196);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(341, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // Refugee
            // 
            this.Refugee.HeaderText = "Refugee";
            this.Refugee.Name = "Refugee";
            // 
            // Reason
            // 
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            // 
            // Helped
            // 
            this.Helped.HeaderText = "Helped";
            this.Helped.Name = "Helped";
            this.Helped.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Helped.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Online_Client,
            this.IP});
            this.dataGridView3.Location = new System.Drawing.Point(20, 196);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // Online_Client
            // 
            this.Online_Client.HeaderText = "Online_Client";
            this.Online_Client.Name = "Online_Client";
            this.Online_Client.ReadOnly = true;
            // 
            // IP
            // 
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 388);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuisine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restaurant;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Confirmed;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Refugee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Helped;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Online_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
    }
}

