
namespace PonomarevLab2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.oprogramme = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.info = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.созданиеСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вНачалоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вКонецToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вПроизвольнуюТочкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вНачалеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вКонцеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вПроизвольнойТочкеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.разрушениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.exit = new System.Windows.Forms.Button();
            this.exitDA = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.oprogramme);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "О программе";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // oprogramme
            // 
            this.oprogramme.AutoSize = true;
            this.oprogramme.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oprogramme.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.oprogramme.Location = new System.Drawing.Point(48, 0);
            this.oprogramme.Name = "oprogramme";
            this.oprogramme.Size = new System.Drawing.Size(695, 264);
            this.oprogramme.TabIndex = 0;
            this.oprogramme.Text = resources.GetString("oprogramme.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.info);
            this.tabPage2.Controls.Add(this.menuStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(187, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(418, 276);
            this.listBox1.TabIndex = 2;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.ForeColor = System.Drawing.SystemColors.Info;
            this.info.Location = new System.Drawing.Point(26, 133);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 32);
            this.info.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеСпискаToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.обработкаСпискаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // созданиеСпискаToolStripMenuItem
            // 
            this.созданиеСпискаToolStripMenuItem.Name = "созданиеСпискаToolStripMenuItem";
            this.созданиеСпискаToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.созданиеСпискаToolStripMenuItem.Text = " Создание списка";
            this.созданиеСпискаToolStripMenuItem.Click += new System.EventHandler(this.созданиеСпискаToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеToolStripMenuItem1,
            this.удалениеToolStripMenuItem1,
            this.разрушениеToolStripMenuItem1});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.редактированиеToolStripMenuItem.Text = "Редактирование списка";
            // 
            // добавлениеToolStripMenuItem1
            // 
            this.добавлениеToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вНачалоToolStripMenuItem1,
            this.вКонецToolStripMenuItem1,
            this.вПроизвольнуюТочкуToolStripMenuItem1});
            this.добавлениеToolStripMenuItem1.Name = "добавлениеToolStripMenuItem1";
            this.добавлениеToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.добавлениеToolStripMenuItem1.Text = "Добавление";
            // 
            // вНачалоToolStripMenuItem1
            // 
            this.вНачалоToolStripMenuItem1.Name = "вНачалоToolStripMenuItem1";
            this.вНачалоToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.вНачалоToolStripMenuItem1.Text = "В начало";
            this.вНачалоToolStripMenuItem1.Click += new System.EventHandler(this.вНачалоToolStripMenuItem1_Click);
            // 
            // вКонецToolStripMenuItem1
            // 
            this.вКонецToolStripMenuItem1.Name = "вКонецToolStripMenuItem1";
            this.вКонецToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.вКонецToolStripMenuItem1.Text = "В конец";
            this.вКонецToolStripMenuItem1.Click += new System.EventHandler(this.вКонецToolStripMenuItem1_Click);
            // 
            // вПроизвольнуюТочкуToolStripMenuItem1
            // 
            this.вПроизвольнуюТочкуToolStripMenuItem1.Name = "вПроизвольнуюТочкуToolStripMenuItem1";
            this.вПроизвольнуюТочкуToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.вПроизвольнуюТочкуToolStripMenuItem1.Text = "В произвольную точку";
            this.вПроизвольнуюТочкуToolStripMenuItem1.Click += new System.EventHandler(this.вПроизвольнуюТочкуToolStripMenuItem1_Click);
            // 
            // удалениеToolStripMenuItem1
            // 
            this.удалениеToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вНачалеToolStripMenuItem1,
            this.вКонцеToolStripMenuItem1,
            this.вПроизвольнойТочкеToolStripMenuItem1});
            this.удалениеToolStripMenuItem1.Name = "удалениеToolStripMenuItem1";
            this.удалениеToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.удалениеToolStripMenuItem1.Text = "Удаление";
            // 
            // вНачалеToolStripMenuItem1
            // 
            this.вНачалеToolStripMenuItem1.Name = "вНачалеToolStripMenuItem1";
            this.вНачалеToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.вНачалеToolStripMenuItem1.Text = "В начале";
            this.вНачалеToolStripMenuItem1.Click += new System.EventHandler(this.вНачалеToolStripMenuItem1_Click);
            // 
            // вКонцеToolStripMenuItem1
            // 
            this.вКонцеToolStripMenuItem1.Name = "вКонцеToolStripMenuItem1";
            this.вКонцеToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.вКонцеToolStripMenuItem1.Text = "В конце";
            this.вКонцеToolStripMenuItem1.Click += new System.EventHandler(this.вКонцеToolStripMenuItem1_Click);
            // 
            // вПроизвольнойТочкеToolStripMenuItem1
            // 
            this.вПроизвольнойТочкеToolStripMenuItem1.Name = "вПроизвольнойТочкеToolStripMenuItem1";
            this.вПроизвольнойТочкеToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.вПроизвольнойТочкеToolStripMenuItem1.Text = "В произвольной точке";
            this.вПроизвольнойТочкеToolStripMenuItem1.Click += new System.EventHandler(this.вПроизвольнойТочкеToolStripMenuItem1_Click);
            // 
            // разрушениеToolStripMenuItem1
            // 
            this.разрушениеToolStripMenuItem1.Name = "разрушениеToolStripMenuItem1";
            this.разрушениеToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.разрушениеToolStripMenuItem1.Text = "Разрушение";
            this.разрушениеToolStripMenuItem1.Click += new System.EventHandler(this.разрушениеToolStripMenuItem1_Click);
            // 
            // обработкаСпискаToolStripMenuItem
            // 
            this.обработкаСпискаToolStripMenuItem.Name = "обработкаСпискаToolStripMenuItem";
            this.обработкаСпискаToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.обработкаСпискаToolStripMenuItem.Text = "Обработка списка";
            this.обработкаСпискаToolStripMenuItem.Click += new System.EventHandler(this.обработкаСпискаToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.exit);
            this.tabPage3.Controls.Add(this.exitDA);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(793, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Выход";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(343, 177);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(103, 36);
            this.exit.TabIndex = 1;
            this.exit.Text = "Да";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // exitDA
            // 
            this.exitDA.AutoSize = true;
            this.exitDA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitDA.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitDA.Location = new System.Drawing.Point(223, 96);
            this.exitDA.Name = "exitDA";
            this.exitDA.Size = new System.Drawing.Size(360, 26);
            this.exitDA.TabIndex = 0;
            this.exitDA.Text = "Вы уверены, что хотите выйти?";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Lab2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label oprogramme;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem созданиеСпискаToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label exitDA;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вНачалоToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вКонецToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вПроизвольнуюТочкуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалениеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вНачалеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вКонцеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вПроизвольнойТочкеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem разрушениеToolStripMenuItem1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.ToolStripMenuItem обработкаСпискаToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}

