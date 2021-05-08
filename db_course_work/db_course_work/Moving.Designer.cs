namespace db_course_work
{
    partial class Moving
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
            this.buttonEnterMoving = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaterialID = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStorageIDFrom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStorageIDTo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterialID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStorageIDFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStorageIDTo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEnterMoving
            // 
            this.buttonEnterMoving.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEnterMoving.Location = new System.Drawing.Point(103, 196);
            this.buttonEnterMoving.Name = "buttonEnterMoving";
            this.buttonEnterMoving.Size = new System.Drawing.Size(75, 29);
            this.buttonEnterMoving.TabIndex = 13;
            this.buttonEnterMoving.Text = "Готово";
            this.buttonEnterMoving.UseVisualStyleBackColor = true;
            this.buttonEnterMoving.Click += new System.EventHandler(this.buttonEnterMoving_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(86, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(86, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Материала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID склада отправки";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownAmount.Location = new System.Drawing.Point(90, 155);
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
            this.numericUpDownMaterialID.Location = new System.Drawing.Point(90, 98);
            this.numericUpDownMaterialID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaterialID.Name = "numericUpDownMaterialID";
            this.numericUpDownMaterialID.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownMaterialID.TabIndex = 8;
            this.numericUpDownMaterialID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownStorageIDFrom
            // 
            this.numericUpDownStorageIDFrom.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownStorageIDFrom.Location = new System.Drawing.Point(12, 38);
            this.numericUpDownStorageIDFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStorageIDFrom.Name = "numericUpDownStorageIDFrom";
            this.numericUpDownStorageIDFrom.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownStorageIDFrom.TabIndex = 7;
            this.numericUpDownStorageIDFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownStorageIDTo
            // 
            this.numericUpDownStorageIDTo.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownStorageIDTo.Location = new System.Drawing.Point(181, 38);
            this.numericUpDownStorageIDTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStorageIDTo.Name = "numericUpDownStorageIDTo";
            this.numericUpDownStorageIDTo.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownStorageIDTo.TabIndex = 14;
            this.numericUpDownStorageIDTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(177, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID склада приёма";
            // 
            // Moving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 234);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownStorageIDTo);
            this.Controls.Add(this.buttonEnterMoving);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.numericUpDownMaterialID);
            this.Controls.Add(this.numericUpDownStorageIDFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Moving";
            this.Text = "Перемещение";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterialID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStorageIDFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStorageIDTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnterMoving;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownMaterialID;
        private System.Windows.Forms.NumericUpDown numericUpDownStorageIDFrom;
        private System.Windows.Forms.NumericUpDown numericUpDownStorageIDTo;
        private System.Windows.Forms.Label label5;
    }
}