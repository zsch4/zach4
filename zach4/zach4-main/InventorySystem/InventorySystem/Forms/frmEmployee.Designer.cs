namespace InventorySystem.Forms
{
    partial class frmEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtFramequantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbFrametype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrameprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFramename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FramesetTable = new System.Windows.Forms.DataGridView();
            this.dgframeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFramename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFrametype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFrameprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFramequantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FramesetTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1753, 78);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.txtFramequantity);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.cmbFrametype);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtFrameprice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFramename);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.FramesetTable);
            this.panel2.Location = new System.Drawing.Point(1, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1756, 598);
            this.panel2.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(815, 192);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 42);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtFramequantity
            // 
            this.txtFramequantity.Location = new System.Drawing.Point(666, 125);
            this.txtFramequantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFramequantity.Name = "txtFramequantity";
            this.txtFramequantity.Size = new System.Drawing.Size(72, 26);
            this.txtFramequantity.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantity";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(502, 192);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 42);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(658, 192);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 42);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(347, 192);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbFrametype
            // 
            this.cmbFrametype.FormattingEnabled = true;
            this.cmbFrametype.Items.AddRange(new object[] {
            "Road bike",
            "Fixie",
            "Mountain bike"});
            this.cmbFrametype.Location = new System.Drawing.Point(1006, 75);
            this.cmbFrametype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFrametype.Name = "cmbFrametype";
            this.cmbFrametype.Size = new System.Drawing.Size(202, 28);
            this.cmbFrametype.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(885, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Frame type:";
            // 
            // txtFrameprice
            // 
            this.txtFrameprice.Location = new System.Drawing.Point(457, 122);
            this.txtFrameprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFrameprice.Name = "txtFrameprice";
            this.txtFrameprice.Size = new System.Drawing.Size(72, 26);
            this.txtFrameprice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // txtFramename
            // 
            this.txtFramename.Location = new System.Drawing.Point(457, 75);
            this.txtFramename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFramename.Name = "txtFramename";
            this.txtFramename.Size = new System.Drawing.Size(385, 26);
            this.txtFramename.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frame name:";
            // 
            // FramesetTable
            // 
            this.FramesetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FramesetTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgframeId,
            this.dgFramename,
            this.dgFrametype,
            this.dgFrameprice,
            this.dgFramequantity});
            this.FramesetTable.Location = new System.Drawing.Point(331, 256);
            this.FramesetTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FramesetTable.Name = "FramesetTable";
            this.FramesetTable.RowHeadersWidth = 62;
            this.FramesetTable.RowTemplate.Height = 28;
            this.FramesetTable.Size = new System.Drawing.Size(1148, 331);
            this.FramesetTable.TabIndex = 0;
            this.FramesetTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FramesetTable_CellContentClick);
            // 
            // dgframeId
            // 
            this.dgframeId.DataPropertyName = "frameId";
            this.dgframeId.HeaderText = "Frameset Id";
            this.dgframeId.MinimumWidth = 8;
            this.dgframeId.Name = "dgframeId";
            this.dgframeId.Visible = false;
            this.dgframeId.Width = 150;
            // 
            // dgFramename
            // 
            this.dgFramename.DataPropertyName = "frameName";
            this.dgFramename.HeaderText = "Frame Name";
            this.dgFramename.MinimumWidth = 8;
            this.dgFramename.Name = "dgFramename";
            this.dgFramename.Visible = false;
            this.dgFramename.Width = 150;
            // 
            // dgFrametype
            // 
            this.dgFrametype.DataPropertyName = "frameType";
            this.dgFrametype.HeaderText = "Frame Type";
            this.dgFrametype.MinimumWidth = 8;
            this.dgFrametype.Name = "dgFrametype";
            this.dgFrametype.Visible = false;
            this.dgFrametype.Width = 150;
            // 
            // dgFrameprice
            // 
            this.dgFrameprice.DataPropertyName = "framePrice";
            this.dgFrameprice.HeaderText = "Frame Price";
            this.dgFrameprice.MinimumWidth = 8;
            this.dgFrameprice.Name = "dgFrameprice";
            this.dgFrameprice.Visible = false;
            this.dgFrameprice.Width = 150;
            // 
            // dgFramequantity
            // 
            this.dgFramequantity.DataPropertyName = "frameQuantity";
            this.dgFramequantity.HeaderText = "Frame Quantity";
            this.dgFramequantity.MinimumWidth = 8;
            this.dgFramequantity.Name = "dgFramequantity";
            this.dgFramequantity.Visible = false;
            this.dgFramequantity.Width = 150;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Plum;
            this.panel3.Location = new System.Drawing.Point(1, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 595);
            this.panel3.TabIndex = 15;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1754, 676);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEmployee";
            this.Text = "Dashboard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FramesetTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView FramesetTable;
        private System.Windows.Forms.TextBox txtFrameprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFramename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFrametype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFramequantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgframeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFramename;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFrametype;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFrameprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFramequantity;
    }
}