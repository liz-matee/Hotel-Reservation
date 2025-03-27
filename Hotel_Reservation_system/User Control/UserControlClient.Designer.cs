namespace Hotel_Reservation_system.User_Control
{
    partial class UserControlClient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabPageAddClient = new System.Windows.Forms.TabPage();
            this.textBoxPhoneClient = new System.Windows.Forms.TextBox();
            this.labelPhoneClient = new System.Windows.Forms.Label();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.textBoxLastnameClient = new System.Windows.Forms.TextBox();
            this.labelLastnameClient = new System.Windows.Forms.Label();
            this.textBoxFirstnameClient = new System.Windows.Forms.TextBox();
            this.labelFirstnameClient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchClient = new System.Windows.Forms.TabPage();
            this.dataGridViewSearchClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchClient = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelSearchclient = new System.Windows.Forms.Label();
            this.tabPageDeleteClient = new System.Windows.Forms.TabPage();
            this.textBoxPhoneClient1 = new System.Windows.Forms.TextBox();
            this.labelPhoneClient1 = new System.Windows.Forms.Label();
            this.textBoxLastnameClient1 = new System.Windows.Forms.TextBox();
            this.labelLastnameClient1 = new System.Windows.Forms.Label();
            this.textBoxFirstnameClient1 = new System.Windows.Forms.TextBox();
            this.labelFirstnameClient1 = new System.Windows.Forms.Label();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.labelDeleteclient = new System.Windows.Forms.Label();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.tabControlClient.SuspendLayout();
            this.tabPageAddClient.SuspendLayout();
            this.tabPageSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchClient)).BeginInit();
            this.tabPageDeleteClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlClient.Controls.Add(this.tabPageAddClient);
            this.tabControlClient.Controls.Add(this.tabPageSearchClient);
            this.tabControlClient.Controls.Add(this.tabPageDeleteClient);
            this.tabControlClient.Location = new System.Drawing.Point(26, 19);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(1053, 426);
            this.tabControlClient.TabIndex = 0;
            // 
            // tabPageAddClient
            // 
            this.tabPageAddClient.BackColor = System.Drawing.Color.White;
            this.tabPageAddClient.Controls.Add(this.textBoxPhoneClient);
            this.tabPageAddClient.Controls.Add(this.labelPhoneClient);
            this.tabPageAddClient.Controls.Add(this.buttonAddClient);
            this.tabPageAddClient.Controls.Add(this.textBoxLastnameClient);
            this.tabPageAddClient.Controls.Add(this.labelLastnameClient);
            this.tabPageAddClient.Controls.Add(this.textBoxFirstnameClient);
            this.tabPageAddClient.Controls.Add(this.labelFirstnameClient);
            this.tabPageAddClient.Controls.Add(this.label1);
            this.tabPageAddClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddClient.Name = "tabPageAddClient";
            this.tabPageAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddClient.Size = new System.Drawing.Size(1045, 394);
            this.tabPageAddClient.TabIndex = 0;
            this.tabPageAddClient.Text = "Add Client";
            this.tabPageAddClient.Click += new System.EventHandler(this.tabPageAddClient_Click);
            this.tabPageAddClient.Leave += new System.EventHandler(this.tabPageAddClient_Leave);
            // 
            // textBoxPhoneClient
            // 
            this.textBoxPhoneClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneClient.Location = new System.Drawing.Point(108, 216);
            this.textBoxPhoneClient.Name = "textBoxPhoneClient";
            this.textBoxPhoneClient.Size = new System.Drawing.Size(268, 27);
            this.textBoxPhoneClient.TabIndex = 13;
            // 
            // labelPhoneClient
            // 
            this.labelPhoneClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPhoneClient.AutoSize = true;
            this.labelPhoneClient.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneClient.ForeColor = System.Drawing.Color.Black;
            this.labelPhoneClient.Location = new System.Drawing.Point(105, 177);
            this.labelPhoneClient.Name = "labelPhoneClient";
            this.labelPhoneClient.Size = new System.Drawing.Size(99, 20);
            this.labelPhoneClient.TabIndex = 12;
            this.labelPhoneClient.Text = "Phone No :";
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddClient.BackColor = System.Drawing.Color.Plum;
            this.buttonAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddClient.ForeColor = System.Drawing.Color.White;
            this.buttonAddClient.Location = new System.Drawing.Point(104, 271);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(121, 33);
            this.buttonAddClient.TabIndex = 11;
            this.buttonAddClient.Text = "ADD";
            this.buttonAddClient.UseVisualStyleBackColor = false;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // textBoxLastnameClient
            // 
            this.textBoxLastnameClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastnameClient.Location = new System.Drawing.Point(581, 134);
            this.textBoxLastnameClient.Name = "textBoxLastnameClient";
            this.textBoxLastnameClient.Size = new System.Drawing.Size(268, 27);
            this.textBoxLastnameClient.TabIndex = 10;
            // 
            // labelLastnameClient
            // 
            this.labelLastnameClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLastnameClient.AutoSize = true;
            this.labelLastnameClient.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastnameClient.ForeColor = System.Drawing.Color.Black;
            this.labelLastnameClient.Location = new System.Drawing.Point(577, 95);
            this.labelLastnameClient.Name = "labelLastnameClient";
            this.labelLastnameClient.Size = new System.Drawing.Size(103, 20);
            this.labelLastnameClient.TabIndex = 9;
            this.labelLastnameClient.Text = "Last Name :";
            // 
            // textBoxFirstnameClient
            // 
            this.textBoxFirstnameClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstnameClient.Location = new System.Drawing.Point(104, 134);
            this.textBoxFirstnameClient.Name = "textBoxFirstnameClient";
            this.textBoxFirstnameClient.Size = new System.Drawing.Size(268, 27);
            this.textBoxFirstnameClient.TabIndex = 8;
            // 
            // labelFirstnameClient
            // 
            this.labelFirstnameClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFirstnameClient.AutoSize = true;
            this.labelFirstnameClient.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstnameClient.ForeColor = System.Drawing.Color.Black;
            this.labelFirstnameClient.Location = new System.Drawing.Point(100, 95);
            this.labelFirstnameClient.Name = "labelFirstnameClient";
            this.labelFirstnameClient.Size = new System.Drawing.Size(107, 20);
            this.labelFirstnameClient.TabIndex = 7;
            this.labelFirstnameClient.Text = "First Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Client :";
            // 
            // tabPageSearchClient
            // 
            this.tabPageSearchClient.BackColor = System.Drawing.Color.White;
            this.tabPageSearchClient.Controls.Add(this.dataGridViewSearchClient);
            this.tabPageSearchClient.Controls.Add(this.textBoxSearchClient);
            this.tabPageSearchClient.Controls.Add(this.labelUsername);
            this.tabPageSearchClient.Controls.Add(this.labelSearchclient);
            this.tabPageSearchClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchClient.Name = "tabPageSearchClient";
            this.tabPageSearchClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchClient.Size = new System.Drawing.Size(1045, 394);
            this.tabPageSearchClient.TabIndex = 1;
            this.tabPageSearchClient.Text = "Search Client";
            this.tabPageSearchClient.Click += new System.EventHandler(this.tabPageSearchClient_Click);
            this.tabPageSearchClient.Enter += new System.EventHandler(this.tabPageSearchClient_Enter);
            this.tabPageSearchClient.Leave += new System.EventHandler(this.tabPageSearchClient_Leave);
            // 
            // dataGridViewSearchClient
            // 
            this.dataGridViewSearchClient.AllowUserToAddRows = false;
            this.dataGridViewSearchClient.AllowUserToDeleteRows = false;
            this.dataGridViewSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewSearchClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSearchClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewSearchClient.Location = new System.Drawing.Point(374, 54);
            this.dataGridViewSearchClient.Name = "dataGridViewSearchClient";
            this.dataGridViewSearchClient.ReadOnly = true;
            this.dataGridViewSearchClient.RowHeadersWidth = 62;
            this.dataGridViewSearchClient.RowTemplate.Height = 28;
            this.dataGridViewSearchClient.Size = new System.Drawing.Size(650, 306);
            this.dataGridViewSearchClient.TabIndex = 13;
            this.dataGridViewSearchClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchClient_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Client_Firstname";
            this.Column1.HeaderText = "First Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Client_Lastname";
            this.Column2.HeaderText = "Last Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Client_Phone";
            this.Column3.HeaderText = "Phone No. ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // textBoxSearchClient
            // 
            this.textBoxSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchClient.Location = new System.Drawing.Point(57, 178);
            this.textBoxSearchClient.Name = "textBoxSearchClient";
            this.textBoxSearchClient.Size = new System.Drawing.Size(268, 27);
            this.textBoxSearchClient.TabIndex = 12;
            this.textBoxSearchClient.TextChanged += new System.EventHandler(this.textBoxSearchClient_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Black;
            this.labelUsername.Location = new System.Drawing.Point(53, 139);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(104, 20);
            this.labelUsername.TabIndex = 11;
            this.labelUsername.Text = "Phone No. :";
            // 
            // labelSearchclient
            // 
            this.labelSearchclient.AutoSize = true;
            this.labelSearchclient.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchclient.Location = new System.Drawing.Point(20, 19);
            this.labelSearchclient.Name = "labelSearchclient";
            this.labelSearchclient.Size = new System.Drawing.Size(157, 25);
            this.labelSearchclient.TabIndex = 10;
            this.labelSearchclient.Text = "Search Client :";
            // 
            // tabPageDeleteClient
            // 
            this.tabPageDeleteClient.BackColor = System.Drawing.Color.White;
            this.tabPageDeleteClient.Controls.Add(this.textBoxPhoneClient1);
            this.tabPageDeleteClient.Controls.Add(this.labelPhoneClient1);
            this.tabPageDeleteClient.Controls.Add(this.textBoxLastnameClient1);
            this.tabPageDeleteClient.Controls.Add(this.labelLastnameClient1);
            this.tabPageDeleteClient.Controls.Add(this.textBoxFirstnameClient1);
            this.tabPageDeleteClient.Controls.Add(this.labelFirstnameClient1);
            this.tabPageDeleteClient.Controls.Add(this.buttonDeleteClient);
            this.tabPageDeleteClient.Controls.Add(this.labelDeleteclient);
            this.tabPageDeleteClient.Controls.Add(this.buttonEditClient);
            this.tabPageDeleteClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageDeleteClient.Name = "tabPageDeleteClient";
            this.tabPageDeleteClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeleteClient.Size = new System.Drawing.Size(1045, 394);
            this.tabPageDeleteClient.TabIndex = 2;
            this.tabPageDeleteClient.Text = "Edit and Delete Client";
            this.tabPageDeleteClient.Leave += new System.EventHandler(this.tabPageDeleteClient_Leave);
            // 
            // textBoxPhoneClient1
            // 
            this.textBoxPhoneClient1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneClient1.Location = new System.Drawing.Point(133, 213);
            this.textBoxPhoneClient1.Name = "textBoxPhoneClient1";
            this.textBoxPhoneClient1.Size = new System.Drawing.Size(268, 27);
            this.textBoxPhoneClient1.TabIndex = 25;
            // 
            // labelPhoneClient1
            // 
            this.labelPhoneClient1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPhoneClient1.AutoSize = true;
            this.labelPhoneClient1.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneClient1.ForeColor = System.Drawing.Color.Black;
            this.labelPhoneClient1.Location = new System.Drawing.Point(130, 174);
            this.labelPhoneClient1.Name = "labelPhoneClient1";
            this.labelPhoneClient1.Size = new System.Drawing.Size(99, 20);
            this.labelPhoneClient1.TabIndex = 24;
            this.labelPhoneClient1.Text = "Phone No :";
            // 
            // textBoxLastnameClient1
            // 
            this.textBoxLastnameClient1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastnameClient1.Location = new System.Drawing.Point(606, 131);
            this.textBoxLastnameClient1.Name = "textBoxLastnameClient1";
            this.textBoxLastnameClient1.Size = new System.Drawing.Size(268, 27);
            this.textBoxLastnameClient1.TabIndex = 23;
            // 
            // labelLastnameClient1
            // 
            this.labelLastnameClient1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLastnameClient1.AutoSize = true;
            this.labelLastnameClient1.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastnameClient1.ForeColor = System.Drawing.Color.Black;
            this.labelLastnameClient1.Location = new System.Drawing.Point(602, 92);
            this.labelLastnameClient1.Name = "labelLastnameClient1";
            this.labelLastnameClient1.Size = new System.Drawing.Size(103, 20);
            this.labelLastnameClient1.TabIndex = 22;
            this.labelLastnameClient1.Text = "Last Name :";
            // 
            // textBoxFirstnameClient1
            // 
            this.textBoxFirstnameClient1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstnameClient1.Location = new System.Drawing.Point(129, 131);
            this.textBoxFirstnameClient1.Name = "textBoxFirstnameClient1";
            this.textBoxFirstnameClient1.Size = new System.Drawing.Size(268, 27);
            this.textBoxFirstnameClient1.TabIndex = 21;
            // 
            // labelFirstnameClient1
            // 
            this.labelFirstnameClient1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFirstnameClient1.AutoSize = true;
            this.labelFirstnameClient1.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstnameClient1.ForeColor = System.Drawing.Color.Black;
            this.labelFirstnameClient1.Location = new System.Drawing.Point(125, 92);
            this.labelFirstnameClient1.Name = "labelFirstnameClient1";
            this.labelFirstnameClient1.Size = new System.Drawing.Size(107, 20);
            this.labelFirstnameClient1.TabIndex = 20;
            this.labelFirstnameClient1.Text = "First Name :";
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteClient.BackColor = System.Drawing.Color.Plum;
            this.buttonDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteClient.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteClient.Location = new System.Drawing.Point(315, 278);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(121, 33);
            this.buttonDeleteClient.TabIndex = 19;
            this.buttonDeleteClient.Text = "DELETE";
            this.buttonDeleteClient.UseVisualStyleBackColor = false;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // labelDeleteclient
            // 
            this.labelDeleteclient.AutoSize = true;
            this.labelDeleteclient.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteclient.Location = new System.Drawing.Point(16, 15);
            this.labelDeleteclient.Name = "labelDeleteclient";
            this.labelDeleteclient.Size = new System.Drawing.Size(230, 25);
            this.labelDeleteclient.TabIndex = 18;
            this.labelDeleteclient.Text = "Edit and Delete Client";
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditClient.BackColor = System.Drawing.Color.Plum;
            this.buttonEditClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditClient.ForeColor = System.Drawing.Color.White;
            this.buttonEditClient.Location = new System.Drawing.Point(129, 278);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(121, 33);
            this.buttonEditClient.TabIndex = 17;
            this.buttonEditClient.Text = "EDIT";
            this.buttonEditClient.UseVisualStyleBackColor = false;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlClient);
            this.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlClient.ResumeLayout(false);
            this.tabPageAddClient.ResumeLayout(false);
            this.tabPageAddClient.PerformLayout();
            this.tabPageSearchClient.ResumeLayout(false);
            this.tabPageSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchClient)).EndInit();
            this.tabPageDeleteClient.ResumeLayout(false);
            this.tabPageDeleteClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabPageAddClient;
        private System.Windows.Forms.TabPage tabPageSearchClient;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.TextBox textBoxLastnameClient;
        private System.Windows.Forms.Label labelLastnameClient;
        private System.Windows.Forms.TextBox textBoxFirstnameClient;
        private System.Windows.Forms.Label labelFirstnameClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPhoneClient;
        private System.Windows.Forms.Label labelPhoneClient;
        private System.Windows.Forms.TabPage tabPageDeleteClient;
        private System.Windows.Forms.DataGridView dataGridViewSearchClient;
        private System.Windows.Forms.TextBox textBoxSearchClient;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelSearchclient;
        private System.Windows.Forms.TextBox textBoxPhoneClient1;
        private System.Windows.Forms.Label labelPhoneClient1;
        private System.Windows.Forms.TextBox textBoxLastnameClient1;
        private System.Windows.Forms.Label labelLastnameClient1;
        private System.Windows.Forms.TextBox textBoxFirstnameClient1;
        private System.Windows.Forms.Label labelFirstnameClient1;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Label labelDeleteclient;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
