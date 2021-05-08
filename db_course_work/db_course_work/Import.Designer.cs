namespace db_course_work
{
    partial class Import
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
            this.numericUpDownStorageID = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaterialID = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEnterImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStorageID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterialID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownStorageID
            // 
            this.numericUpDownStorageID.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownStorageID.Location = new System.Drawing.Point(34, 35);
            this.numericUpDownStorageID.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownStorageID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStorageID.Name = "numericUpDownStorageID";
            this.numericUpDownStorageID.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownStorageID.TabIndex = 0;
            this.numericUpDownStorageID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMaterialID
            // 
            this.numericUpDownMaterialID.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownMaterialID.Location = new System.Drawing.Point(34, 92);
            this.numericUpDownMaterialID.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numericUpDownMaterialID.Name = "numericUpDownMaterialID";
            this.numericUpDownMaterialID.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownMaterialID.TabIndex = 1;
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownAmount.Location = new System.Drawing.Point(34, 149);
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownAmount.TabIndex = 2;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID склада";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Материала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество";
            // 
            // buttonEnterImport
            // 
            this.buttonEnterImport.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEnterImport.Location = new System.Drawing.Point(47, 190);
            this.buttonEnterImport.Name = "buttonEnterImport";
            this.buttonEnterImport.Size = new System.Drawing.Size(75, 29);
            this.buttonEnterImport.TabIndex = 6;
            this.buttonEnterImport.Text = "Готово";
            this.buttonEnterImport.UseVisualStyleBackColor = true;
            this.buttonEnterImport.Click += new System.EventHandler(this.buttonEnterImport_Click);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 231);
            this.Controls.Add(this.buttonEnterImport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.numericUpDownMaterialID);
            this.Controls.Add(this.numericUpDownStorageID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Import";
            this.Text = "Заказ закупок";
            this.Load += new System.EventHandler(this.Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStorageID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterialID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownStorageID;
        private System.Windows.Forms.NumericUpDown numericUpDownMaterialID;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEnterImport;
    }
}