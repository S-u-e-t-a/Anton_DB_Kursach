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
            this.buttonDeleteData = new System.Windows.Forms.Button();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.groupBoxWatch = new System.Windows.Forms.GroupBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonUsing = new System.Windows.Forms.Button();
            this.buttonDoneGoods = new System.Windows.Forms.Button();
            this.groupBoxFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxWatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFunc
            // 
            this.groupBoxFunc.Controls.Add(this.buttonDoneGoods);
            this.groupBoxFunc.Controls.Add(this.buttonUsing);
            this.groupBoxFunc.Controls.Add(this.buttonManageFactory);
            this.groupBoxFunc.Controls.Add(this.buttonShake);
            this.groupBoxFunc.Controls.Add(this.buttonImport);
            this.groupBoxFunc.Controls.Add(this.ButtonAddPurchase);
            this.groupBoxFunc.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxFunc.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFunc.Name = "groupBoxFunc";
            this.groupBoxFunc.Size = new System.Drawing.Size(572, 155);
            this.groupBoxFunc.TabIndex = 0;
            this.groupBoxFunc.TabStop = false;
            this.groupBoxFunc.Text = "Функции";
            // 
            // buttonManageFactory
            // 
            this.buttonManageFactory.Location = new System.Drawing.Point(6, 89);
            this.buttonManageFactory.Name = "buttonManageFactory";
            this.buttonManageFactory.Size = new System.Drawing.Size(165, 55);
            this.buttonManageFactory.TabIndex = 8;
            this.buttonManageFactory.Text = "Управление РЦ";
            this.buttonManageFactory.UseVisualStyleBackColor = true;
            this.buttonManageFactory.Click += new System.EventHandler(this.buttonManageFactory_Click);
            // 
            // buttonShake
            // 
            this.buttonShake.Location = new System.Drawing.Point(376, 28);
            this.buttonShake.Name = "buttonShake";
            this.buttonShake.Size = new System.Drawing.Size(179, 55);
            this.buttonShake.TabIndex = 6;
            this.buttonShake.Text = "Заказ перемещения";
            this.buttonShake.UseVisualStyleBackColor = true;
            this.buttonShake.Click += new System.EventHandler(this.buttonShake_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(177, 28);
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
            this.buttonStore.Text = "Посмотреть таблицу \"Склады\"";
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // ButtonNomenclature
            // 
            this.ButtonNomenclature.Location = new System.Drawing.Point(177, 34);
            this.ButtonNomenclature.Name = "ButtonNomenclature";
            this.ButtonNomenclature.Size = new System.Drawing.Size(193, 55);
            this.ButtonNomenclature.TabIndex = 0;
            this.ButtonNomenclature.Text = "Посмотреть таблицу \"Номенклатура\"";
            this.ButtonNomenclature.UseVisualStyleBackColor = true;
            this.ButtonNomenclature.Click += new System.EventHandler(this.ButtonNomenclature_Click);
            // 
            // buttonFactory
            // 
            this.buttonFactory.Location = new System.Drawing.Point(6, 102);
            this.buttonFactory.Name = "buttonFactory";
            this.buttonFactory.Size = new System.Drawing.Size(165, 55);
            this.buttonFactory.TabIndex = 3;
            this.buttonFactory.Text = "Посмотреть таблицу \"Рабочие центры\"";
            this.buttonFactory.UseVisualStyleBackColor = true;
            this.buttonFactory.Click += new System.EventHandler(this.buttonFactory_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.Location = new System.Drawing.Point(177, 102);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(193, 55);
            this.buttonGroups.TabIndex = 4;
            this.buttonGroups.Text = "Посмотреть таблицу \"Группы заменимости\"";
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonCustoms
            // 
            this.buttonCustoms.Location = new System.Drawing.Point(6, 34);
            this.buttonCustoms.Name = "buttonCustoms";
            this.buttonCustoms.Size = new System.Drawing.Size(165, 55);
            this.buttonCustoms.TabIndex = 7;
            this.buttonCustoms.Text = "Посмотреть таблицу \"Заказы\"";
            this.buttonCustoms.UseVisualStyleBackColor = true;
            this.buttonCustoms.Click += new System.EventHandler(this.buttonCustoms_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(591, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(593, 235);
            this.dataGridView1.TabIndex = 1;
            // 
            // ButtonStocks
            // 
            this.ButtonStocks.Location = new System.Drawing.Point(376, 102);
            this.ButtonStocks.Name = "ButtonStocks";
            this.ButtonStocks.Size = new System.Drawing.Size(175, 55);
            this.ButtonStocks.TabIndex = 2;
            this.ButtonStocks.Text = "Посмотреть таблицу \"Запасы\"";
            this.ButtonStocks.UseVisualStyleBackColor = true;
            this.ButtonStocks.Click += new System.EventHandler(this.ButtonStocks_Click);
            // 
            // buttonDeleteData
            // 
            this.buttonDeleteData.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteData.Location = new System.Drawing.Point(838, 271);
            this.buttonDeleteData.Name = "buttonDeleteData";
            this.buttonDeleteData.Size = new System.Drawing.Size(165, 44);
            this.buttonDeleteData.TabIndex = 8;
            this.buttonDeleteData.Text = "Удалить кортеж";
            this.buttonDeleteData.UseVisualStyleBackColor = true;
            this.buttonDeleteData.Visible = false;
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSaveData.Location = new System.Drawing.Point(1009, 271);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(175, 44);
            this.buttonSaveData.TabIndex = 9;
            this.buttonSaveData.Text = "Сохранить изменения";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Visible = false;
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
            this.groupBoxWatch.Location = new System.Drawing.Point(12, 169);
            this.groupBoxWatch.Name = "groupBoxWatch";
            this.groupBoxWatch.Size = new System.Drawing.Size(572, 163);
            this.groupBoxWatch.TabIndex = 9;
            this.groupBoxWatch.TabStop = false;
            this.groupBoxWatch.Text = "Просмотр";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.buttonInfo.Location = new System.Drawing.Point(1179, 321);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(26, 30);
            this.buttonInfo.TabIndex = 10;
            this.buttonInfo.Text = "?";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonUsing
            // 
            this.buttonUsing.Location = new System.Drawing.Point(177, 89);
            this.buttonUsing.Name = "buttonUsing";
            this.buttonUsing.Size = new System.Drawing.Size(193, 55);
            this.buttonUsing.TabIndex = 9;
            this.buttonUsing.Text = "Журнал использования";
            this.buttonUsing.UseVisualStyleBackColor = true;
            // 
            // buttonDoneGoods
            // 
            this.buttonDoneGoods.Location = new System.Drawing.Point(376, 89);
            this.buttonDoneGoods.Name = "buttonDoneGoods";
            this.buttonDoneGoods.Size = new System.Drawing.Size(179, 55);
            this.buttonDoneGoods.TabIndex = 10;
            this.buttonDoneGoods.Text = "Журнал выхода\r\n";
            this.buttonDoneGoods.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 344);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.groupBoxWatch);
            this.Controls.Add(this.buttonDeleteData);
            this.Controls.Add(this.buttonSaveData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "База данных";
            this.groupBoxFunc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxWatch.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button buttonDeleteData;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.GroupBox groupBoxWatch;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonDoneGoods;
        private System.Windows.Forms.Button buttonUsing;
    }
}

