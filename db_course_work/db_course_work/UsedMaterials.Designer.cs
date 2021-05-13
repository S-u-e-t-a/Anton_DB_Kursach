namespace db_course_work
{
    partial class UsedMaterials
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
            this.label4 = new System.Windows.Forms.Label();
            this.StatUsingGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownOrderID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.StatUsingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrderID)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "Журнал использования";
            // 
            // StatUsingGrid
            // 
            this.StatUsingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatUsingGrid.Location = new System.Drawing.Point(15, 262);
            this.StatUsingGrid.Name = "StatUsingGrid";
            this.StatUsingGrid.RowHeadersVisible = false;
            this.StatUsingGrid.Size = new System.Drawing.Size(789, 345);
            this.StatUsingGrid.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Таблица заказов";
            // 
            // OrderGrid
            // 
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Location = new System.Drawing.Point(15, 115);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.RowHeadersVisible = false;
            this.OrderGrid.Size = new System.Drawing.Size(789, 119);
            this.OrderGrid.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Выберите номер заказа, отчёт по которому Вы хотите получить:";
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.buttonShow.Location = new System.Drawing.Point(141, 56);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(120, 30);
            this.buttonShow.TabIndex = 24;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID Заказа";
            // 
            // numericUpDownOrderID
            // 
            this.numericUpDownOrderID.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownOrderID.Location = new System.Drawing.Point(15, 58);
            this.numericUpDownOrderID.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numericUpDownOrderID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOrderID.Name = "numericUpDownOrderID";
            this.numericUpDownOrderID.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownOrderID.TabIndex = 22;
            this.numericUpDownOrderID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UsedMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 626);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StatUsingGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownOrderID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UsedMaterials";
            this.Text = "Журнал использования";
            this.Load += new System.EventHandler(this.UsedMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatUsingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrderID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView StatUsingGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView OrderGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownOrderID;
    }
}