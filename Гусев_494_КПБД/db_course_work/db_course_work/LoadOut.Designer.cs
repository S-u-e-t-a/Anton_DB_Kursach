namespace db_course_work
{
    partial class LoadOut
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
            this.buttonMakeLoadOut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaterialID = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStorageID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterialID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStorageID)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMakeLoadOut
            // 
            this.buttonMakeLoadOut.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.buttonMakeLoadOut.Location = new System.Drawing.Point(88, 152);
            this.buttonMakeLoadOut.Name = "buttonMakeLoadOut";
            this.buttonMakeLoadOut.Size = new System.Drawing.Size(75, 29);
            this.buttonMakeLoadOut.TabIndex = 19;
            this.buttonMakeLoadOut.Text = "Готово";
            this.buttonMakeLoadOut.UseVisualStyleBackColor = true;
            this.buttonMakeLoadOut.Click += new System.EventHandler(this.buttonMakeLoadOut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(71, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID Продукта";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownAmount.Location = new System.Drawing.Point(75, 111);
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownAmount.TabIndex = 16;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMaterialID
            // 
            this.numericUpDownMaterialID.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownMaterialID.Location = new System.Drawing.Point(12, 46);
            this.numericUpDownMaterialID.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numericUpDownMaterialID.Name = "numericUpDownMaterialID";
            this.numericUpDownMaterialID.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownMaterialID.TabIndex = 15;
            // 
            // numericUpDownStorageID
            // 
            this.numericUpDownStorageID.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownStorageID.Location = new System.Drawing.Point(152, 46);
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
            this.numericUpDownStorageID.TabIndex = 20;
            this.numericUpDownStorageID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(148, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID Склада";
            // 
            // LoadOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 205);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownStorageID);
            this.Controls.Add(this.buttonMakeLoadOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.numericUpDownMaterialID);
            this.Name = "LoadOut";
            this.Text = "Списание";
            this.Load += new System.EventHandler(this.LoadOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterialID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStorageID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMakeLoadOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownMaterialID;
        private System.Windows.Forms.NumericUpDown numericUpDownStorageID;
        private System.Windows.Forms.Label label1;
    }
}