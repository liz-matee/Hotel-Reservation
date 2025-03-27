namespace Hotel_Reservation_system.User_Control
{
    partial class UserControlReservation
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
            this.tabControlReservation = new System.Windows.Forms.TabControl();
            this.tabPageAddReservation = new System.Windows.Forms.TabPage();
            this.textBoxReserve = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRoomType = new System.Windows.Forms.TextBox();
            this.labelPhoneClient = new System.Windows.Forms.Label();
            this.buttonAddReservation = new System.Windows.Forms.Button();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.labelLastnameClient = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.labelFirstnameClient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchReservation = new System.Windows.Forms.TabPage();
            this.dataGridViewSearchReservation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchReservation = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelSearchclient = new System.Windows.Forms.Label();
            this.tabPageUpdateandDeleteReservation = new System.Windows.Forms.TabPage();
            this.buttonDeleteReservation = new System.Windows.Forms.Button();
            this.textBoxReserve1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRoomType1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdateReservation = new System.Windows.Forms.Button();
            this.textBoxRoomNumber1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxClientName1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControlReservation.SuspendLayout();
            this.tabPageAddReservation.SuspendLayout();
            this.tabPageSearchReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchReservation)).BeginInit();
            this.tabPageUpdateandDeleteReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlReservation
            // 
            this.tabControlReservation.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlReservation.Controls.Add(this.tabPageAddReservation);
            this.tabControlReservation.Controls.Add(this.tabPageSearchReservation);
            this.tabControlReservation.Controls.Add(this.tabPageUpdateandDeleteReservation);
            this.tabControlReservation.Location = new System.Drawing.Point(25, 22);
            this.tabControlReservation.Name = "tabControlReservation";
            this.tabControlReservation.SelectedIndex = 0;
            this.tabControlReservation.Size = new System.Drawing.Size(1045, 394);
            this.tabControlReservation.TabIndex = 0;
            this.tabControlReservation.Leave += new System.EventHandler(this.tabControlReservation_Leave);
            // 
            // tabPageAddReservation
            // 
            this.tabPageAddReservation.BackColor = System.Drawing.Color.White;
            this.tabPageAddReservation.Controls.Add(this.textBoxReserve);
            this.tabPageAddReservation.Controls.Add(this.label2);
            this.tabPageAddReservation.Controls.Add(this.textBoxRoomType);
            this.tabPageAddReservation.Controls.Add(this.labelPhoneClient);
            this.tabPageAddReservation.Controls.Add(this.buttonAddReservation);
            this.tabPageAddReservation.Controls.Add(this.textBoxRoomNumber);
            this.tabPageAddReservation.Controls.Add(this.labelLastnameClient);
            this.tabPageAddReservation.Controls.Add(this.textBoxClientName);
            this.tabPageAddReservation.Controls.Add(this.labelFirstnameClient);
            this.tabPageAddReservation.Controls.Add(this.label1);
            this.tabPageAddReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddReservation.Name = "tabPageAddReservation";
            this.tabPageAddReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddReservation.Size = new System.Drawing.Size(1037, 362);
            this.tabPageAddReservation.TabIndex = 0;
            this.tabPageAddReservation.Text = "Add Reservation";
            // 
            // textBoxReserve
            // 
            this.textBoxReserve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxReserve.Location = new System.Drawing.Point(579, 210);
            this.textBoxReserve.Name = "textBoxReserve";
            this.textBoxReserve.Size = new System.Drawing.Size(268, 27);
            this.textBoxReserve.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(576, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Reserve ?";
            // 
            // textBoxRoomType
            // 
            this.textBoxRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomType.Location = new System.Drawing.Point(107, 210);
            this.textBoxRoomType.Name = "textBoxRoomType";
            this.textBoxRoomType.Size = new System.Drawing.Size(268, 27);
            this.textBoxRoomType.TabIndex = 21;
            // 
            // labelPhoneClient
            // 
            this.labelPhoneClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPhoneClient.AutoSize = true;
            this.labelPhoneClient.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneClient.ForeColor = System.Drawing.Color.Black;
            this.labelPhoneClient.Location = new System.Drawing.Point(104, 171);
            this.labelPhoneClient.Name = "labelPhoneClient";
            this.labelPhoneClient.Size = new System.Drawing.Size(100, 20);
            this.labelPhoneClient.TabIndex = 20;
            this.labelPhoneClient.Text = "Room Type";
            // 
            // buttonAddReservation
            // 
            this.buttonAddReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddReservation.BackColor = System.Drawing.Color.Plum;
            this.buttonAddReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddReservation.ForeColor = System.Drawing.Color.White;
            this.buttonAddReservation.Location = new System.Drawing.Point(103, 265);
            this.buttonAddReservation.Name = "buttonAddReservation";
            this.buttonAddReservation.Size = new System.Drawing.Size(121, 33);
            this.buttonAddReservation.TabIndex = 19;
            this.buttonAddReservation.Text = "ADD";
            this.buttonAddReservation.UseVisualStyleBackColor = false;
            this.buttonAddReservation.Click += new System.EventHandler(this.buttonAddReservation_Click);
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomNumber.Location = new System.Drawing.Point(580, 128);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(268, 27);
            this.textBoxRoomNumber.TabIndex = 18;
            // 
            // labelLastnameClient
            // 
            this.labelLastnameClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLastnameClient.AutoSize = true;
            this.labelLastnameClient.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastnameClient.ForeColor = System.Drawing.Color.Black;
            this.labelLastnameClient.Location = new System.Drawing.Point(576, 89);
            this.labelLastnameClient.Name = "labelLastnameClient";
            this.labelLastnameClient.Size = new System.Drawing.Size(129, 20);
            this.labelLastnameClient.TabIndex = 17;
            this.labelLastnameClient.Text = "Room Number";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientName.Location = new System.Drawing.Point(103, 128);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(268, 27);
            this.textBoxClientName.TabIndex = 16;
            // 
            // labelFirstnameClient
            // 
            this.labelFirstnameClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFirstnameClient.AutoSize = true;
            this.labelFirstnameClient.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstnameClient.ForeColor = System.Drawing.Color.Black;
            this.labelFirstnameClient.Location = new System.Drawing.Point(99, 89);
            this.labelFirstnameClient.Name = "labelFirstnameClient";
            this.labelFirstnameClient.Size = new System.Drawing.Size(120, 20);
            this.labelFirstnameClient.TabIndex = 15;
            this.labelFirstnameClient.Text = "Client Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add Reservation:";
            // 
            // tabPageSearchReservation
            // 
            this.tabPageSearchReservation.BackColor = System.Drawing.Color.White;
            this.tabPageSearchReservation.Controls.Add(this.dataGridViewSearchReservation);
            this.tabPageSearchReservation.Controls.Add(this.textBoxSearchReservation);
            this.tabPageSearchReservation.Controls.Add(this.labelUsername);
            this.tabPageSearchReservation.Controls.Add(this.labelSearchclient);
            this.tabPageSearchReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchReservation.Name = "tabPageSearchReservation";
            this.tabPageSearchReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchReservation.Size = new System.Drawing.Size(1037, 362);
            this.tabPageSearchReservation.TabIndex = 1;
            this.tabPageSearchReservation.Text = "SearchReservation";
            this.tabPageSearchReservation.Click += new System.EventHandler(this.tabPageSearchReservation_Click);
            this.tabPageSearchReservation.Enter += new System.EventHandler(this.tabPageSearchReservation_Enter);
            this.tabPageSearchReservation.Leave += new System.EventHandler(this.tabPageSearchReservation_Leave);
            // 
            // dataGridViewSearchReservation
            // 
            this.dataGridViewSearchReservation.AllowUserToAddRows = false;
            this.dataGridViewSearchReservation.AllowUserToDeleteRows = false;
            this.dataGridViewSearchReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewSearchReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSearchReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewSearchReservation.Location = new System.Drawing.Point(327, 46);
            this.dataGridViewSearchReservation.Name = "dataGridViewSearchReservation";
            this.dataGridViewSearchReservation.ReadOnly = true;
            this.dataGridViewSearchReservation.RowHeadersWidth = 62;
            this.dataGridViewSearchReservation.RowTemplate.Height = 28;
            this.dataGridViewSearchReservation.Size = new System.Drawing.Size(693, 306);
            this.dataGridViewSearchReservation.TabIndex = 17;
            this.dataGridViewSearchReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchReservation_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Client_name";
            this.Column1.HeaderText = "Client Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Room_Type";
            this.Column2.HeaderText = "Room Type";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Reservation_";
            this.Column3.HeaderText = "Reservation";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Room Number";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // textBoxSearchReservation
            // 
            this.textBoxSearchReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchReservation.Location = new System.Drawing.Point(53, 170);
            this.textBoxSearchReservation.Name = "textBoxSearchReservation";
            this.textBoxSearchReservation.Size = new System.Drawing.Size(268, 27);
            this.textBoxSearchReservation.TabIndex = 16;
            this.textBoxSearchReservation.TextChanged += new System.EventHandler(this.textBoxSearchReservation_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Black;
            this.labelUsername.Location = new System.Drawing.Point(49, 131);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(115, 20);
            this.labelUsername.TabIndex = 15;
            this.labelUsername.Text = "Client Name:";
            // 
            // labelSearchclient
            // 
            this.labelSearchclient.AutoSize = true;
            this.labelSearchclient.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchclient.Location = new System.Drawing.Point(16, 11);
            this.labelSearchclient.Name = "labelSearchclient";
            this.labelSearchclient.Size = new System.Drawing.Size(213, 25);
            this.labelSearchclient.TabIndex = 14;
            this.labelSearchclient.Text = "Search Reservation :";
            // 
            // tabPageUpdateandDeleteReservation
            // 
            this.tabPageUpdateandDeleteReservation.BackColor = System.Drawing.Color.White;
            this.tabPageUpdateandDeleteReservation.Controls.Add(this.buttonDeleteReservation);
            this.tabPageUpdateandDeleteReservation.Controls.Add(this.textBoxReserve1);
            this.tabPageUpdateandDeleteReservation.Controls.Add(this.label3);
            this.tabPageUpdateandDeleteReservation.Controls.Add(this.textBoxRoomType1);
            this.tabPageUpdateandDeleteReservation.Controls.Add(this.label4);
            this.tabPageUpdateandDeleteReservation.Controls.Add(this.buttonUpdateReservation);
            this.tabPageUpdateandDeleteReservation.Controls.Add(this.textBoxRoomNumber1);
            this.tabPageUpdateandDeleteReservation.Controls.Add(this.label5);
            this.tabPageUpdateandDeleteReservation.Controls.Add(this.textBoxClientName1);
            this.tabPageUpdateandDeleteReservation.Controls.Add(this.label6);
            this.tabPageUpdateandDeleteReservation.Controls.Add(this.label7);
            this.tabPageUpdateandDeleteReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateandDeleteReservation.Name = "tabPageUpdateandDeleteReservation";
            this.tabPageUpdateandDeleteReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateandDeleteReservation.Size = new System.Drawing.Size(1037, 362);
            this.tabPageUpdateandDeleteReservation.TabIndex = 2;
            this.tabPageUpdateandDeleteReservation.Text = "Edit and Delete Reservation";
            // 
            // buttonDeleteReservation
            // 
            this.buttonDeleteReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteReservation.BackColor = System.Drawing.Color.Plum;
            this.buttonDeleteReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteReservation.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteReservation.Location = new System.Drawing.Point(346, 276);
            this.buttonDeleteReservation.Name = "buttonDeleteReservation";
            this.buttonDeleteReservation.Size = new System.Drawing.Size(121, 33);
            this.buttonDeleteReservation.TabIndex = 34;
            this.buttonDeleteReservation.Text = "DELETE";
            this.buttonDeleteReservation.UseVisualStyleBackColor = false;
            this.buttonDeleteReservation.Click += new System.EventHandler(this.buttonDeleteReservation_Click);
            // 
            // textBoxReserve1
            // 
            this.textBoxReserve1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxReserve1.Location = new System.Drawing.Point(579, 211);
            this.textBoxReserve1.Name = "textBoxReserve1";
            this.textBoxReserve1.Size = new System.Drawing.Size(268, 27);
            this.textBoxReserve1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(576, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Reserve ?";
            // 
            // textBoxRoomType1
            // 
            this.textBoxRoomType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomType1.Location = new System.Drawing.Point(107, 211);
            this.textBoxRoomType1.Name = "textBoxRoomType1";
            this.textBoxRoomType1.Size = new System.Drawing.Size(268, 27);
            this.textBoxRoomType1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(104, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Room Type";
            // 
            // buttonUpdateReservation
            // 
            this.buttonUpdateReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateReservation.BackColor = System.Drawing.Color.Plum;
            this.buttonUpdateReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateReservation.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateReservation.Location = new System.Drawing.Point(103, 276);
            this.buttonUpdateReservation.Name = "buttonUpdateReservation";
            this.buttonUpdateReservation.Size = new System.Drawing.Size(121, 33);
            this.buttonUpdateReservation.TabIndex = 29;
            this.buttonUpdateReservation.Text = "UPDATE";
            this.buttonUpdateReservation.UseVisualStyleBackColor = false;
            this.buttonUpdateReservation.Click += new System.EventHandler(this.buttonUpdateReservation_Click);
            // 
            // textBoxRoomNumber1
            // 
            this.textBoxRoomNumber1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomNumber1.Location = new System.Drawing.Point(580, 129);
            this.textBoxRoomNumber1.Name = "textBoxRoomNumber1";
            this.textBoxRoomNumber1.Size = new System.Drawing.Size(268, 27);
            this.textBoxRoomNumber1.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(576, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Room Number";
            // 
            // textBoxClientName1
            // 
            this.textBoxClientName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientName1.Location = new System.Drawing.Point(103, 129);
            this.textBoxClientName1.Name = "textBoxClientName1";
            this.textBoxClientName1.Size = new System.Drawing.Size(268, 27);
            this.textBoxClientName1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(99, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Client Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Update and Delete Reservation:";
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlReservation);
            this.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(1224, 439);
            this.tabControlReservation.ResumeLayout(false);
            this.tabPageAddReservation.ResumeLayout(false);
            this.tabPageAddReservation.PerformLayout();
            this.tabPageSearchReservation.ResumeLayout(false);
            this.tabPageSearchReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchReservation)).EndInit();
            this.tabPageUpdateandDeleteReservation.ResumeLayout(false);
            this.tabPageUpdateandDeleteReservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReservation;
        private System.Windows.Forms.TabPage tabPageAddReservation;
        private System.Windows.Forms.TabPage tabPageSearchReservation;
        private System.Windows.Forms.TabPage tabPageUpdateandDeleteReservation;
        private System.Windows.Forms.TextBox textBoxReserve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRoomType;
        private System.Windows.Forms.Label labelPhoneClient;
        private System.Windows.Forms.Button buttonAddReservation;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.Label labelLastnameClient;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label labelFirstnameClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSearchReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBoxSearchReservation;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelSearchclient;
        private System.Windows.Forms.Button buttonDeleteReservation;
        private System.Windows.Forms.TextBox textBoxReserve1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRoomType1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUpdateReservation;
        private System.Windows.Forms.TextBox textBoxRoomNumber1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxClientName1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
