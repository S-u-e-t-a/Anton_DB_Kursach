namespace db_course_work
{
    partial class FactoryOrder
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
            this.FactoryOrderGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IDFactoryOrderNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonCloseOrder = new System.Windows.Forms.Button();
            this.ButtonStartProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FactoryOrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDFactoryOrderNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FactoryOrderGrid
            // 
            this.FactoryOrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FactoryOrderGrid.Location = new System.Drawing.Point(246, 49);
            this.FactoryOrderGrid.Name = "FactoryOrderGrid";
            this.FactoryOrderGrid.Size = new System.Drawing.Size(369, 222);
            this.FactoryOrderGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(252, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Каталог заказов, ожидающих обработки";
            // 
            // IDFactoryOrderNumericUpDown
            // 
            this.IDFactoryOrderNumericUpDown.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.IDFactoryOrderNumericUpDown.Location = new System.Drawing.Point(25, 107);
            this.IDFactoryOrderNumericUpDown.Name = "IDFactoryOrderNumericUpDown";
            this.IDFactoryOrderNumericUpDown.Size = new System.Drawing.Size(205, 29);
            this.IDFactoryOrderNumericUpDown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID заказа";
            // 
            // ButtonCloseOrder
            // 
            this.ButtonCloseOrder.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonCloseOrder.Location = new System.Drawing.Point(25, 187);
            this.ButtonCloseOrder.Name = "ButtonCloseOrder";
            this.ButtonCloseOrder.Size = new System.Drawing.Size(205, 34);
            this.ButtonCloseOrder.TabIndex = 4;
            this.ButtonCloseOrder.Text = "Закрыть заказ";
            this.ButtonCloseOrder.UseVisualStyleBackColor = true;
            this.ButtonCloseOrder.Click += new System.EventHandler(this.ButtonCloseOrder_Click);
            // 
            // ButtonStartProcess
            // 
            this.ButtonStartProcess.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonStartProcess.Location = new System.Drawing.Point(25, 147);
            this.ButtonStartProcess.Name = "ButtonStartProcess";
            this.ButtonStartProcess.Size = new System.Drawing.Size(205, 34);
            this.ButtonStartProcess.TabIndex = 5;
            this.ButtonStartProcess.Text = "Запустить производство";
            this.ButtonStartProcess.UseVisualStyleBackColor = true;
            this.ButtonStartProcess.Click += new System.EventHandler(this.ButtonStartProcess_Click);
            // 
            // FactoryOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 283);
            this.Controls.Add(this.ButtonStartProcess);
            this.Controls.Add(this.ButtonCloseOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDFactoryOrderNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FactoryOrderGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FactoryOrder";
            this.Text = "Размещение производственного заказа";
            this.Load += new System.EventHandler(this.FactoryOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FactoryOrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDFactoryOrderNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FactoryOrderGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDFactoryOrderNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonCloseOrder;
        private System.Windows.Forms.Button ButtonStartProcess;
    }
}