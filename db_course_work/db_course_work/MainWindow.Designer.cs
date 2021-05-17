namespace db_course_work
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxFunc = new System.Windows.Forms.GroupBox();
            this.ButtonLoadOut = new System.Windows.Forms.Button();
            this.buttonMakeOrder = new System.Windows.Forms.Button();
            this.buttonUsedMateials = new System.Windows.Forms.Button();
            this.buttonUsing = new System.Windows.Forms.Button();
            this.buttonManageFactory = new System.Windows.Forms.Button();
            this.buttonShake = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.ButtonAddPurchase = new System.Windows.Forms.Button();
            this.buttonStore = new System.Windows.Forms.Button();
            this.ButtonNomenclature = new System.Windows.Forms.Button();
            this.buttonFactory = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonCustoms = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonStocks = new System.Windows.Forms.Button();
            this.groupBoxWatch = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNameTable = new System.Windows.Forms.Label();
            this.groupBoxFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxWatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFunc
            // 
            this.groupBoxFunc.Controls.Add(this.ButtonLoadOut);
            this.groupBoxFunc.Controls.Add(this.buttonMakeOrder);
            this.groupBoxFunc.Controls.Add(this.buttonUsedMateials);
            this.groupBoxFunc.Controls.Add(this.buttonUsing);
            this.groupBoxFunc.Controls.Add(this.buttonManageFactory);
            this.groupBoxFunc.Controls.Add(this.buttonShake);
            this.groupBoxFunc.Controls.Add(this.buttonImport);
            this.groupBoxFunc.Controls.Add(this.ButtonAddPurchase);
            this.groupBoxFunc.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxFunc.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFunc.Name = "groupBoxFunc";
            this.groupBoxFunc.Size = new System.Drawing.Size(572, 227);
            this.groupBoxFunc.TabIndex = 0;
            this.groupBoxFunc.TabStop = false;
            this.groupBoxFunc.Text = "Функции";
            // 
            // ButtonLoadOut
            // 
            this.ButtonLoadOut.Location = new System.Drawing.Point(6, 150);
            this.ButtonLoadOut.Name = "ButtonLoadOut";
            this.ButtonLoadOut.Size = new System.Drawing.Size(165, 55);
            this.ButtonLoadOut.TabIndex = 12;
            this.ButtonLoadOut.Text = "Списать позиции";
            this.ButtonLoadOut.UseVisualStyleBackColor = true;
            this.ButtonLoadOut.Click += new System.EventHandler(this.ButtonLoadOut_Click);
            // 
            // buttonMakeOrder
            // 
            this.buttonMakeOrder.Location = new System.Drawing.Point(6, 89);
            this.buttonMakeOrder.Name = "buttonMakeOrder";
            this.buttonMakeOrder.Size = new System.Drawing.Size(165, 55);
            this.buttonMakeOrder.TabIndex = 11;
            this.buttonMakeOrder.Text = "Сделать заказ (пользователь)";
            this.buttonMakeOrder.UseVisualStyleBackColor = true;
            this.buttonMakeOrder.Click += new System.EventHandler(this.buttonMakeOrder_Click);
            // 
            // buttonUsedMateials
            // 
            this.buttonUsedMateials.Location = new System.Drawing.Point(376, 150);
            this.buttonUsedMateials.Name = "buttonUsedMateials";
            this.buttonUsedMateials.Size = new System.Drawing.Size(165, 55);
            this.buttonUsedMateials.TabIndex = 10;
            this.buttonUsedMateials.Text = "Журнал использования\r\n";
            this.buttonUsedMateials.UseVisualStyleBackColor = true;
            this.buttonUsedMateials.Click += new System.EventHandler(this.buttonUsedMateials_Click);
            // 
            // buttonUsing
            // 
            this.buttonUsing.Location = new System.Drawing.Point(376, 89);
            this.buttonUsing.Name = "buttonUsing";
            this.buttonUsing.Size = new System.Drawing.Size(165, 55);
            this.buttonUsing.TabIndex = 9;
            this.buttonUsing.Text = "Журнал выхода";
            this.buttonUsing.UseVisualStyleBackColor = true;
            this.buttonUsing.Click += new System.EventHandler(this.buttonUsing_Click);
            // 
            // buttonManageFactory
            // 
            this.buttonManageFactory.Location = new System.Drawing.Point(376, 28);
            this.buttonManageFactory.Name = "buttonManageFactory";
            this.buttonManageFactory.Size = new System.Drawing.Size(165, 55);
            this.buttonManageFactory.TabIndex = 8;
            this.buttonManageFactory.Text = "Управление РЦ";
            this.buttonManageFactory.UseVisualStyleBackColor = true;
            this.buttonManageFactory.Click += new System.EventHandler(this.buttonManageFactory_Click);
            // 
            // buttonShake
            // 
            this.buttonShake.Location = new System.Drawing.Point(177, 89);
            this.buttonShake.Name = "buttonShake";
            this.buttonShake.Size = new System.Drawing.Size(193, 55);
            this.buttonShake.TabIndex = 6;
            this.buttonShake.Text = "Заказ перемещения";
            this.buttonShake.UseVisualStyleBackColor = true;
            this.buttonShake.Click += new System.EventHandler(this.buttonShake_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(177, 29);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(193, 55);
            this.buttonImport.TabIndex = 5;
            this.buttonImport.Text = "Заказ закупок";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // ButtonAddPurchase
            // 
            this.ButtonAddPurchase.Location = new System.Drawing.Point(6, 28);
            this.ButtonAddPurchase.Name = "ButtonAddPurchase";
            this.ButtonAddPurchase.Size = new System.Drawing.Size(165, 55);
            this.ButtonAddPurchase.TabIndex = 0;
            this.ButtonAddPurchase.Text = "Производственный заказ";
            this.ButtonAddPurchase.UseVisualStyleBackColor = true;
            this.ButtonAddPurchase.Click += new System.EventHandler(this.ButtonAddPurchase_Click);
            // 
            // buttonStore
            // 
            this.buttonStore.Location = new System.Drawing.Point(376, 34);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(175, 55);
            this.buttonStore.TabIndex = 1;
            this.buttonStore.Text = "Таблица \"Склады\"";
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // ButtonNomenclature
            // 
            this.ButtonNomenclature.Location = new System.Drawing.Point(177, 34);
            this.ButtonNomenclature.Name = "ButtonNomenclature";
            this.ButtonNomenclature.Size = new System.Drawing.Size(193, 55);
            this.ButtonNomenclature.TabIndex = 0;
            this.ButtonNomenclature.Text = "Таблица \"Номенклатура\"";
            this.ButtonNomenclature.UseVisualStyleBackColor = true;
            this.ButtonNomenclature.Click += new System.EventHandler(this.ButtonNomenclature_Click);
            // 
            // buttonFactory
            // 
            this.buttonFactory.Location = new System.Drawing.Point(6, 102);
            this.buttonFactory.Name = "buttonFactory";
            this.buttonFactory.Size = new System.Drawing.Size(165, 55);
            this.buttonFactory.TabIndex = 3;
            this.buttonFactory.Text = "Таблица \"Рабочие центры\"";
            this.buttonFactory.UseVisualStyleBackColor = true;
            this.buttonFactory.Click += new System.EventHandler(this.buttonFactory_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.Location = new System.Drawing.Point(177, 102);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(193, 55);
            this.buttonGroups.TabIndex = 4;
            this.buttonGroups.Text = "Таблица \"Группы заменимости\"";
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonCustoms
            // 
            this.buttonCustoms.Location = new System.Drawing.Point(6, 34);
            this.buttonCustoms.Name = "buttonCustoms";
            this.buttonCustoms.Size = new System.Drawing.Size(165, 55);
            this.buttonCustoms.TabIndex = 7;
            this.buttonCustoms.Text = "Таблица \"Заказы\"";
            this.buttonCustoms.UseVisualStyleBackColor = true;
            this.buttonCustoms.Click += new System.EventHandler(this.buttonCustoms_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(594, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(593, 368);
            this.dataGridView1.TabIndex = 1;
            // 
            // ButtonStocks
            // 
            this.ButtonStocks.Location = new System.Drawing.Point(376, 102);
            this.ButtonStocks.Name = "ButtonStocks";
            this.ButtonStocks.Size = new System.Drawing.Size(175, 55);
            this.ButtonStocks.TabIndex = 2;
            this.ButtonStocks.Text = "Таблица \"Запасы\"";
            this.ButtonStocks.UseVisualStyleBackColor = true;
            this.ButtonStocks.Click += new System.EventHandler(this.ButtonStocks_Click);
            // 
            // groupBoxWatch
            // 
            this.groupBoxWatch.Controls.Add(this.buttonCustoms);
            this.groupBoxWatch.Controls.Add(this.ButtonStocks);
            this.groupBoxWatch.Controls.Add(this.buttonGroups);
            this.groupBoxWatch.Controls.Add(this.buttonFactory);
            this.groupBoxWatch.Controls.Add(this.ButtonNomenclature);
            this.groupBoxWatch.Controls.Add(this.buttonStore);
            this.groupBoxWatch.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxWatch.Location = new System.Drawing.Point(12, 245);
            this.groupBoxWatch.Name = "groupBoxWatch";
            this.groupBoxWatch.Size = new System.Drawing.Size(572, 163);
            this.groupBoxWatch.TabIndex = 9;
            this.groupBoxWatch.TabStop = false;
            this.groupBoxWatch.Text = "Просмотр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(590, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Таблица: ";
            // 
            // labelNameTable
            // 
            this.labelNameTable.AutoSize = true;
            this.labelNameTable.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.labelNameTable.Location = new System.Drawing.Point(662, 12);
            this.labelNameTable.Name = "labelNameTable";
            this.labelNameTable.Size = new System.Drawing.Size(46, 22);
            this.labelNameTable.TabIndex = 12;
            this.labelNameTable.Text = "None";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 438);
            this.Controls.Add(this.labelNameTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxWatch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "База данных";
            this.groupBoxFunc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxWatch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFunc;
        private System.Windows.Forms.Button ButtonAddPurchase;
        private System.Windows.Forms.Button ButtonNomenclature;
        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.Button buttonCustoms;
        private System.Windows.Forms.Button buttonShake;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonFactory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonStocks;
        private System.Windows.Forms.Button buttonManageFactory;
        private System.Windows.Forms.GroupBox groupBoxWatch;
        private System.Windows.Forms.Button buttonUsedMateials;
        private System.Windows.Forms.Button buttonUsing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNameTable;
        private System.Windows.Forms.Button buttonMakeOrder;
        private System.Windows.Forms.Button ButtonLoadOut;
    }
}

