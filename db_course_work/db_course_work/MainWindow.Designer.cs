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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.ButtonAddPurchase = new System.Windows.Forms.Button();
            this.groupBoxStore = new System.Windows.Forms.GroupBox();
            this.ButtonNomenclature = new System.Windows.Forms.Button();
            this.groupBoxFactory = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBoxManager = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonStore = new System.Windows.Forms.Button();
            this.ButtonStocks = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxStore.SuspendLayout();
            this.groupBoxFactory.SuspendLayout();
            this.groupBoxManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxManager);
            this.groupBox1.Controls.Add(this.groupBoxFactory);
            this.groupBox1.Controls.Add(this.groupBoxStore);
            this.groupBox1.Controls.Add(this.groupBoxUser);
            this.groupBox1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функции";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.ButtonAddPurchase);
            this.groupBoxUser.Location = new System.Drawing.Point(7, 29);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(195, 403);
            this.groupBoxUser.TabIndex = 4;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Пользователь";
            // 
            // ButtonAddPurchase
            // 
            this.ButtonAddPurchase.Location = new System.Drawing.Point(6, 28);
            this.ButtonAddPurchase.Name = "ButtonAddPurchase";
            this.ButtonAddPurchase.Size = new System.Drawing.Size(179, 31);
            this.ButtonAddPurchase.TabIndex = 0;
            this.ButtonAddPurchase.Text = "Добавить заказ";
            this.ButtonAddPurchase.UseVisualStyleBackColor = true;
            this.ButtonAddPurchase.Click += new System.EventHandler(this.ButtonAddPurchase_Click);
            // 
            // groupBoxStore
            // 
            this.groupBoxStore.Controls.Add(this.ButtonStocks);
            this.groupBoxStore.Controls.Add(this.buttonStore);
            this.groupBoxStore.Controls.Add(this.ButtonNomenclature);
            this.groupBoxStore.Location = new System.Drawing.Point(224, 29);
            this.groupBoxStore.Name = "groupBoxStore";
            this.groupBoxStore.Size = new System.Drawing.Size(195, 404);
            this.groupBoxStore.TabIndex = 5;
            this.groupBoxStore.TabStop = false;
            this.groupBoxStore.Text = "Кладовщик";
            // 
            // ButtonNomenclature
            // 
            this.ButtonNomenclature.Location = new System.Drawing.Point(6, 28);
            this.ButtonNomenclature.Name = "ButtonNomenclature";
            this.ButtonNomenclature.Size = new System.Drawing.Size(179, 55);
            this.ButtonNomenclature.TabIndex = 0;
            this.ButtonNomenclature.Text = "Посмотреть таблицу \"Номенклатура\"";
            this.ButtonNomenclature.UseVisualStyleBackColor = true;
            // 
            // groupBoxFactory
            // 
            this.groupBoxFactory.Controls.Add(this.button6);
            this.groupBoxFactory.Location = new System.Drawing.Point(440, 29);
            this.groupBoxFactory.Name = "groupBoxFactory";
            this.groupBoxFactory.Size = new System.Drawing.Size(195, 404);
            this.groupBoxFactory.TabIndex = 6;
            this.groupBoxFactory.TabStop = false;
            this.groupBoxFactory.Text = "Начальник цехов";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 31);
            this.button6.TabIndex = 0;
            this.button6.Text = "Добавить заказ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBoxManager
            // 
            this.groupBoxManager.Controls.Add(this.button7);
            this.groupBoxManager.Location = new System.Drawing.Point(659, 28);
            this.groupBoxManager.Name = "groupBoxManager";
            this.groupBoxManager.Size = new System.Drawing.Size(195, 404);
            this.groupBoxManager.TabIndex = 7;
            this.groupBoxManager.TabStop = false;
            this.groupBoxManager.Text = "Менеджер";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 28);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(179, 31);
            this.button7.TabIndex = 0;
            this.button7.Text = "Добавить заказ";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // buttonStore
            // 
            this.buttonStore.Location = new System.Drawing.Point(6, 152);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(179, 55);
            this.buttonStore.TabIndex = 1;
            this.buttonStore.Text = "Посмотреть таблицу \"Склады\"";
            this.buttonStore.UseVisualStyleBackColor = true;
            // 
            // ButtonStocks
            // 
            this.ButtonStocks.Location = new System.Drawing.Point(6, 91);
            this.ButtonStocks.Name = "ButtonStocks";
            this.ButtonStocks.Size = new System.Drawing.Size(179, 55);
            this.ButtonStocks.TabIndex = 2;
            this.ButtonStocks.Text = "Посмотреть таблицу \"Запасы\"";
            this.ButtonStocks.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 463);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "База данных";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxStore.ResumeLayout(false);
            this.groupBoxFactory.ResumeLayout(false);
            this.groupBoxManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Button ButtonAddPurchase;
        private System.Windows.Forms.GroupBox groupBoxStore;
        private System.Windows.Forms.Button ButtonNomenclature;
        private System.Windows.Forms.GroupBox groupBoxManager;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBoxFactory;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.Button ButtonStocks;
    }
}

