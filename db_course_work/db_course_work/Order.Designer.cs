namespace db_course_work
{
    partial class Order
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
            this.buttonEnterImport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaterialID = new System.Windows.Forms.NumericUpDown();
            this.MaterialGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterialID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEnterImport
            // 
            this.buttonEnterImport.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEnterImport.Location = new System.Drawing.Point(25, 139);
            this.buttonEnterImport.Name = "buttonEnterImport";
            this.buttonEnterImport.Size = new System.Drawing.Size(75, 29);
            this.buttonEnterImport.TabIndex = 13;
            this.buttonEnterImport.Text = "Готово";
            this.buttonEnterImport.UseVisualStyleBackColor = true;
            this.buttonEnterImport.Click += new System.EventHandler(this.buttonEnterImport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Материала";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownAmount.Location = new System.Drawing.Point(12, 98);
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownAmount.TabIndex = 9;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMaterialID
            // 
            this.numericUpDownMaterialID.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownMaterialID.Location = new System.Drawing.Point(12, 41);
            this.numericUpDownMaterialID.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numericUpDownMaterialID.Name = "numericUpDownMaterialID";
            this.numericUpDownMaterialID.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownMaterialID.TabIndex = 8;
            // 
            // MaterialGrid
            // 
            this.MaterialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialGrid.Location = new System.Drawing.Point(144, 18);
            this.MaterialGrid.Name = "MaterialGrid";
            this.MaterialGrid.RowHeadersVisible = false;
            this.MaterialGrid.Size = new System.Drawing.Size(240, 150);
            this.MaterialGrid.TabIndex = 14;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 193);
            this.Controls.Add(this.MaterialGrid);
            this.Controls.Add(this.buttonEnterImport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.numericUpDownMaterialID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Order";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterialID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnterImport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownMaterialID;
        private System.Windows.Forms.DataGridView MaterialGrid;
    }
}