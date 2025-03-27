namespace Hotel_Reservation_system.User_Control
{
    partial class UserControlRoom
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
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.tabPageAddRoom = new System.Windows.Forms.TabPage();
            this.labelFree = new System.Windows.Forms.Label();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.textBoxRoomPhone = new System.Windows.Forms.TextBox();
            this.labelRoomPhone = new System.Windows.Forms.Label();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelAddRoom = new System.Windows.Forms.Label();
            this.tabPageSearchRoom = new System.Windows.Forms.TabPage();
            this.dataGridViewSearchRoom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchRoom = new System.Windows.Forms.TextBox();
            this.labelRoomNo = new System.Windows.Forms.Label();
            this.labelSearchRoom = new System.Windows.Forms.Label();
            this.tabPageUpdateRoom = new System.Windows.Forms.TabPage();
            this.buttonDeleteRoom = new System.Windows.Forms.Button();
            this.buttonUpdateRoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRoomPhone1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRoomType1 = new System.Windows.Forms.TextBox();
            this.textBoxRoomFree1 = new System.Windows.Forms.TextBox();
            this.textBoxRoomType = new System.Windows.Forms.TextBox();
            this.textBoxRoomFree = new System.Windows.Forms.TextBox();
            this.tabControlRoom.SuspendLayout();
            this.tabPageAddRoom.SuspendLayout();
            this.tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchRoom)).BeginInit();
            this.tabPageUpdateRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlRoom.Controls.Add(this.tabPageAddRoom);
            this.tabControlRoom.Controls.Add(this.tabPageSearchRoom);
            this.tabControlRoom.Controls.Add(this.tabPageUpdateRoom);
            this.tabControlRoom.Location = new System.Drawing.Point(24, 18);
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(1053, 426);
            this.tabControlRoom.TabIndex = 0;
            // 
            // tabPageAddRoom
            // 
            this.tabPageAddRoom.BackColor = System.Drawing.Color.White;
            this.tabPageAddRoom.Controls.Add(this.textBoxRoomFree);
            this.tabPageAddRoom.Controls.Add(this.textBoxRoomType);
            this.tabPageAddRoom.Controls.Add(this.labelFree);
            this.tabPageAddRoom.Controls.Add(this.buttonAddRoom);
            this.tabPageAddRoom.Controls.Add(this.textBoxRoomPhone);
            this.tabPageAddRoom.Controls.Add(this.labelRoomPhone);
            this.tabPageAddRoom.Controls.Add(this.labelRoomType);
            this.tabPageAddRoom.Controls.Add(this.labelAddRoom);
            this.tabPageAddRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddRoom.Name = "tabPageAddRoom";
            this.tabPageAddRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRoom.Size = new System.Drawing.Size(1045, 394);
            this.tabPageAddRoom.TabIndex = 0;
            this.tabPageAddRoom.Text = "Add Room";
            // 
            // labelFree
            // 
            this.labelFree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFree.AutoSize = true;
            this.labelFree.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFree.ForeColor = System.Drawing.Color.Black;
            this.labelFree.Location = new System.Drawing.Point(111, 245);
            this.labelFree.Name = "labelFree";
            this.labelFree.Size = new System.Drawing.Size(58, 20);
            this.labelFree.TabIndex = 23;
            this.labelFree.Text = "Free ?";
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddRoom.BackColor = System.Drawing.Color.Plum;
            this.buttonAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddRoom.ForeColor = System.Drawing.Color.White;
            this.buttonAddRoom.Location = new System.Drawing.Point(140, 312);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(121, 33);
            this.buttonAddRoom.TabIndex = 19;
            this.buttonAddRoom.Text = "ADD";
            this.buttonAddRoom.UseVisualStyleBackColor = false;
            // 
            // textBoxRoomPhone
            // 
            this.textBoxRoomPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomPhone.Location = new System.Drawing.Point(580, 130);
            this.textBoxRoomPhone.Name = "textBoxRoomPhone";
            this.textBoxRoomPhone.Size = new System.Drawing.Size(268, 27);
            this.textBoxRoomPhone.TabIndex = 18;
            // 
            // labelRoomPhone
            // 
            this.labelRoomPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomPhone.AutoSize = true;
            this.labelRoomPhone.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomPhone.ForeColor = System.Drawing.Color.Black;
            this.labelRoomPhone.Location = new System.Drawing.Point(577, 91);
            this.labelRoomPhone.Name = "labelRoomPhone";
            this.labelRoomPhone.Size = new System.Drawing.Size(94, 20);
            this.labelRoomPhone.TabIndex = 17;
            this.labelRoomPhone.Text = "Phone No.";
            // 
            // labelRoomType
            // 
            this.labelRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomType.ForeColor = System.Drawing.Color.Black;
            this.labelRoomType.Location = new System.Drawing.Point(100, 91);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(110, 20);
            this.labelRoomType.TabIndex = 15;
            this.labelRoomType.Text = "Room Type :";
            // 
            // labelAddRoom
            // 
            this.labelAddRoom.AutoSize = true;
            this.labelAddRoom.BackColor = System.Drawing.Color.Transparent;
            this.labelAddRoom.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddRoom.ForeColor = System.Drawing.Color.Black;
            this.labelAddRoom.Location = new System.Drawing.Point(17, 15);
            this.labelAddRoom.Name = "labelAddRoom";
            this.labelAddRoom.Size = new System.Drawing.Size(127, 25);
            this.labelAddRoom.TabIndex = 14;
            this.labelAddRoom.Text = "Add Room :";
            // 
            // tabPageSearchRoom
            // 
            this.tabPageSearchRoom.BackColor = System.Drawing.Color.White;
            this.tabPageSearchRoom.Controls.Add(this.dataGridViewSearchRoom);
            this.tabPageSearchRoom.Controls.Add(this.textBoxSearchRoom);
            this.tabPageSearchRoom.Controls.Add(this.labelRoomNo);
            this.tabPageSearchRoom.Controls.Add(this.labelSearchRoom);
            this.tabPageSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRoom.Name = "tabPageSearchRoom";
            this.tabPageSearchRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRoom.Size = new System.Drawing.Size(1045, 394);
            this.tabPageSearchRoom.TabIndex = 1;
            this.tabPageSearchRoom.Text = "Search Room";
            this.tabPageSearchRoom.Click += new System.EventHandler(this.tabPageSearchRoom_Click);
            this.tabPageSearchRoom.Leave += new System.EventHandler(this.tabPageSearchRoom_Leave);
            // 
            // dataGridViewSearchRoom
            // 
            this.dataGridViewSearchRoom.AllowUserToAddRows = false;
            this.dataGridViewSearchRoom.AllowUserToDeleteRows = false;
            this.dataGridViewSearchRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewSearchRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSearchRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewSearchRoom.Location = new System.Drawing.Point(374, 62);
            this.dataGridViewSearchRoom.Name = "dataGridViewSearchRoom";
            this.dataGridViewSearchRoom.ReadOnly = true;
            this.dataGridViewSearchRoom.RowHeadersWidth = 62;
            this.dataGridViewSearchRoom.RowTemplate.Height = 28;
            this.dataGridViewSearchRoom.Size = new System.Drawing.Size(650, 306);
            this.dataGridViewSearchRoom.TabIndex = 17;
            this.dataGridViewSearchRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchRoom_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Room_Number";
            this.Column1.HeaderText = "RoomNo";
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
            this.Column3.DataPropertyName = "Room_Phone";
            this.Column3.HeaderText = "Phone";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Room_Free";
            this.Column4.HeaderText = "Available";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // textBoxSearchRoom
            // 
            this.textBoxSearchRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchRoom.Location = new System.Drawing.Point(57, 186);
            this.textBoxSearchRoom.Name = "textBoxSearchRoom";
            this.textBoxSearchRoom.Size = new System.Drawing.Size(268, 27);
            this.textBoxSearchRoom.TabIndex = 16;
            this.textBoxSearchRoom.TextChanged += new System.EventHandler(this.textBoxSearchRoom_TextChanged_1);
            // 
            // labelRoomNo
            // 
            this.labelRoomNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomNo.AutoSize = true;
            this.labelRoomNo.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNo.ForeColor = System.Drawing.Color.Black;
            this.labelRoomNo.Location = new System.Drawing.Point(53, 147);
            this.labelRoomNo.Name = "labelRoomNo";
            this.labelRoomNo.Size = new System.Drawing.Size(100, 20);
            this.labelRoomNo.TabIndex = 15;
            this.labelRoomNo.Text = "Room No. :";
            // 
            // labelSearchRoom
            // 
            this.labelSearchRoom.AutoSize = true;
            this.labelSearchRoom.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchRoom.Location = new System.Drawing.Point(20, 27);
            this.labelSearchRoom.Name = "labelSearchRoom";
            this.labelSearchRoom.Size = new System.Drawing.Size(153, 25);
            this.labelSearchRoom.TabIndex = 14;
            this.labelSearchRoom.Text = "Search Room :";
            // 
            // tabPageUpdateRoom
            // 
            this.tabPageUpdateRoom.BackColor = System.Drawing.Color.White;
            this.tabPageUpdateRoom.Controls.Add(this.textBoxRoomFree1);
            this.tabPageUpdateRoom.Controls.Add(this.textBoxRoomType1);
            this.tabPageUpdateRoom.Controls.Add(this.buttonDeleteRoom);
            this.tabPageUpdateRoom.Controls.Add(this.buttonUpdateRoom);
            this.tabPageUpdateRoom.Controls.Add(this.label1);
            this.tabPageUpdateRoom.Controls.Add(this.textBoxRoomPhone1);
            this.tabPageUpdateRoom.Controls.Add(this.label2);
            this.tabPageUpdateRoom.Controls.Add(this.label3);
            this.tabPageUpdateRoom.Controls.Add(this.label4);
            this.tabPageUpdateRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateRoom.Name = "tabPageUpdateRoom";
            this.tabPageUpdateRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateRoom.Size = new System.Drawing.Size(1045, 394);
            this.tabPageUpdateRoom.TabIndex = 2;
            this.tabPageUpdateRoom.Text = "Update and Delete Room";
            // 
            // buttonDeleteRoom
            // 
            this.buttonDeleteRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteRoom.BackColor = System.Drawing.Color.Plum;
            this.buttonDeleteRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteRoom.Location = new System.Drawing.Point(267, 312);
            this.buttonDeleteRoom.Name = "buttonDeleteRoom";
            this.buttonDeleteRoom.Size = new System.Drawing.Size(121, 33);
            this.buttonDeleteRoom.TabIndex = 35;
            this.buttonDeleteRoom.Text = "DELETE";
            this.buttonDeleteRoom.UseVisualStyleBackColor = false;
            this.buttonDeleteRoom.Click += new System.EventHandler(this.buttonDeleteRoom_Click);
            // 
            // buttonUpdateRoom
            // 
            this.buttonUpdateRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateRoom.BackColor = System.Drawing.Color.Plum;
            this.buttonUpdateRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateRoom.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateRoom.Location = new System.Drawing.Point(105, 312);
            this.buttonUpdateRoom.Name = "buttonUpdateRoom";
            this.buttonUpdateRoom.Size = new System.Drawing.Size(121, 33);
            this.buttonUpdateRoom.TabIndex = 34;
            this.buttonUpdateRoom.Text = "UPDATE";
            this.buttonUpdateRoom.UseVisualStyleBackColor = false;
            this.buttonUpdateRoom.Click += new System.EventHandler(this.buttonUpdateRoom_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(101, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Free ?";
            // 
            // textBoxRoomPhone1
            // 
            this.textBoxRoomPhone1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomPhone1.Location = new System.Drawing.Point(581, 135);
            this.textBoxRoomPhone1.Name = "textBoxRoomPhone1";
            this.textBoxRoomPhone1.Size = new System.Drawing.Size(268, 27);
            this.textBoxRoomPhone1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(578, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Phone No.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(101, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Room Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Update and Delete Room :";
            // 
            // textBoxRoomType1
            // 
            this.textBoxRoomType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomType1.Location = new System.Drawing.Point(105, 144);
            this.textBoxRoomType1.Name = "textBoxRoomType1";
            this.textBoxRoomType1.Size = new System.Drawing.Size(268, 27);
            this.textBoxRoomType1.TabIndex = 36;
            // 
            // textBoxRoomFree1
            // 
            this.textBoxRoomFree1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomFree1.Location = new System.Drawing.Point(191, 209);
            this.textBoxRoomFree1.Name = "textBoxRoomFree1";
            this.textBoxRoomFree1.Size = new System.Drawing.Size(182, 27);
            this.textBoxRoomFree1.TabIndex = 37;
            // 
            // textBoxRoomType
            // 
            this.textBoxRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomType.Location = new System.Drawing.Point(104, 130);
            this.textBoxRoomType.Name = "textBoxRoomType";
            this.textBoxRoomType.Size = new System.Drawing.Size(268, 27);
            this.textBoxRoomType.TabIndex = 30;
            // 
            // textBoxRoomFree
            // 
            this.textBoxRoomFree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomFree.Location = new System.Drawing.Point(224, 238);
            this.textBoxRoomFree.Name = "textBoxRoomFree";
            this.textBoxRoomFree.Size = new System.Drawing.Size(148, 27);
            this.textBoxRoomFree.TabIndex = 31;
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlRoom);
            this.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlRoom.ResumeLayout(false);
            this.tabPageAddRoom.ResumeLayout(false);
            this.tabPageAddRoom.PerformLayout();
            this.tabPageSearchRoom.ResumeLayout(false);
            this.tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchRoom)).EndInit();
            this.tabPageUpdateRoom.ResumeLayout(false);
            this.tabPageUpdateRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage tabPageAddRoom;
        private System.Windows.Forms.TabPage tabPageSearchRoom;
        private System.Windows.Forms.TabPage tabPageUpdateRoom;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.TextBox textBoxRoomPhone;
        private System.Windows.Forms.Label labelRoomPhone;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelAddRoom;
        private System.Windows.Forms.Label labelFree;
        private System.Windows.Forms.DataGridView dataGridViewSearchRoom;
        private System.Windows.Forms.TextBox textBoxSearchRoom;
        private System.Windows.Forms.Label labelRoomNo;
        private System.Windows.Forms.Label labelSearchRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRoomPhone1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDeleteRoom;
        private System.Windows.Forms.Button buttonUpdateRoom;
        private System.Windows.Forms.TextBox textBoxRoomFree;
        private System.Windows.Forms.TextBox textBoxRoomType;
        private System.Windows.Forms.TextBox textBoxRoomFree1;
        private System.Windows.Forms.TextBox textBoxRoomType1;
    }
}
