namespace db_course_work
{
    partial class Factory
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
            this.buttonEnterFactory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFactID = new System.Windows.Forms.NumericUpDown();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFactID)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEnterFactory
            // 
            this.buttonEnterFactory.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEnterFactory.Location = new System.Drawing.Point(53, 190);
            this.buttonEnterFactory.Name = "buttonEnterFactory";
            this.buttonEnterFactory.Size = new System.Drawing.Size(75, 29);
            this.buttonEnterFactory.TabIndex = 13;
            this.buttonEnterFactory.Text = "Готово";
            this.buttonEnterFactory.UseVisualStyleBackColor = true;
            this.buttonEnterFactory.Click += new System.EventHandler(this.buttonEnterFactory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(36, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Время работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Статус";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID РЦ";
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownTime.Location = new System.Drawing.Point(40, 149);
            this.numericUpDownTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownTime.TabIndex = 9;
            this.numericUpDownTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownFactID
            // 
            this.numericUpDownFactID.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownFactID.Location = new System.Drawing.Point(40, 35);
            this.numericUpDownFactID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFactID.Name = "numericUpDownFactID";
            this.numericUpDownFactID.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownFactID.TabIndex = 7;
            this.numericUpDownFactID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxStatus.Location = new System.Drawing.Point(40, 92);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(120, 29);
            this.textBoxStatus.TabIndex = 14;
            // 
            // Factory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 233);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonEnterFactory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownTime);
            this.Controls.Add(this.numericUpDownFactID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Factory";
            this.Text = "Управление РЦ";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFactID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnterFactory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.NumericUpDown numericUpDownFactID;
        private System.Windows.Forms.TextBox textBoxStatus;
    }
}