
namespace Метеостанция
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelKolDay = new System.Windows.Forms.Label();
            this.labelSred = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelHotDay = new System.Windows.Forms.Label();
            this.labelCold = new System.Windows.Forms.Label();
            this.labelMaxDay = new System.Windows.Forms.Label();
            this.labelMinDay = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelMonth = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(32, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Количество дней в месяце";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(32, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(293, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Средняя температура в месяце";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(32, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(358, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Самая высокая температура в месяце";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(32, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(344, 23);
            this.label12.TabIndex = 3;
            this.label12.Text = "Самая низкая температура в месяце";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(32, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(327, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "Количество жарких дней в месяце";
            this.toolTip1.SetToolTip(this.label13, "Температура выше 25 градусов");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.DarkBlue;
            this.label14.Location = new System.Drawing.Point(32, 449);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(345, 23);
            this.label14.TabIndex = 5;
            this.label14.Text = "Количество холодных дней в месяце";
            this.toolTip1.SetToolTip(this.label14, "Температура ниже -25 градусов");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.DarkBlue;
            this.label15.Location = new System.Drawing.Point(533, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 23);
            this.label15.TabIndex = 6;
            this.label15.Text = "дата";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.DarkBlue;
            this.label16.Location = new System.Drawing.Point(533, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 23);
            this.label16.TabIndex = 7;
            this.label16.Text = "дата";
            // 
            // labelKolDay
            // 
            this.labelKolDay.AutoSize = true;
            this.labelKolDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKolDay.ForeColor = System.Drawing.Color.Crimson;
            this.labelKolDay.Location = new System.Drawing.Point(434, 29);
            this.labelKolDay.Name = "labelKolDay";
            this.labelKolDay.Size = new System.Drawing.Size(20, 23);
            this.labelKolDay.TabIndex = 8;
            this.labelKolDay.Text = "0";
            // 
            // labelSred
            // 
            this.labelSred.AutoSize = true;
            this.labelSred.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSred.ForeColor = System.Drawing.Color.Crimson;
            this.labelSred.Location = new System.Drawing.Point(434, 114);
            this.labelSred.Name = "labelSred";
            this.labelSred.Size = new System.Drawing.Size(20, 23);
            this.labelSred.TabIndex = 9;
            this.labelSred.Text = "0";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMax.ForeColor = System.Drawing.Color.Crimson;
            this.labelMax.Location = new System.Drawing.Point(434, 195);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(20, 23);
            this.labelMax.TabIndex = 10;
            this.labelMax.Text = "0";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMin.ForeColor = System.Drawing.Color.Crimson;
            this.labelMin.Location = new System.Drawing.Point(434, 285);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(20, 23);
            this.labelMin.TabIndex = 11;
            this.labelMin.Text = "0";
            // 
            // labelHotDay
            // 
            this.labelHotDay.AutoSize = true;
            this.labelHotDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHotDay.ForeColor = System.Drawing.Color.Crimson;
            this.labelHotDay.Location = new System.Drawing.Point(434, 362);
            this.labelHotDay.Name = "labelHotDay";
            this.labelHotDay.Size = new System.Drawing.Size(20, 23);
            this.labelHotDay.TabIndex = 12;
            this.labelHotDay.Text = "0";
            // 
            // labelCold
            // 
            this.labelCold.AutoSize = true;
            this.labelCold.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCold.ForeColor = System.Drawing.Color.Crimson;
            this.labelCold.Location = new System.Drawing.Point(434, 449);
            this.labelCold.Name = "labelCold";
            this.labelCold.Size = new System.Drawing.Size(20, 23);
            this.labelCold.TabIndex = 13;
            this.labelCold.Text = "0";
            // 
            // labelMaxDay
            // 
            this.labelMaxDay.AutoSize = true;
            this.labelMaxDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxDay.ForeColor = System.Drawing.Color.Crimson;
            this.labelMaxDay.Location = new System.Drawing.Point(613, 195);
            this.labelMaxDay.Name = "labelMaxDay";
            this.labelMaxDay.Size = new System.Drawing.Size(20, 23);
            this.labelMaxDay.TabIndex = 14;
            this.labelMaxDay.Text = "0";
            // 
            // labelMinDay
            // 
            this.labelMinDay.AutoSize = true;
            this.labelMinDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinDay.ForeColor = System.Drawing.Color.Crimson;
            this.labelMinDay.Location = new System.Drawing.Point(613, 280);
            this.labelMinDay.Name = "labelMinDay";
            this.labelMinDay.Size = new System.Drawing.Size(20, 23);
            this.labelMinDay.TabIndex = 15;
            this.labelMinDay.Text = "0";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
            this.buttonOpen.Location = new System.Drawing.Point(36, 497);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(86, 86);
            this.buttonOpen.TabIndex = 16;
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(199, 497);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(86, 86);
            this.buttonClose.TabIndex = 17;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMonth.ForeColor = System.Drawing.Color.Crimson;
            this.labelMonth.Location = new System.Drawing.Point(456, 544);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(70, 23);
            this.labelMonth.TabIndex = 18;
            this.labelMonth.Text = "Месяц";
            this.labelMonth.Click += new System.EventHandler(this.label17_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Текстовый файл|*.txt";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(965, 608);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.labelMinDay);
            this.Controls.Add(this.labelMaxDay);
            this.Controls.Add(this.labelCold);
            this.Controls.Add(this.labelHotDay);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelSred);
            this.Controls.Add(this.labelKolDay);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "Form1";
            this.Text = "Метеостанция";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelKolDay;
        private System.Windows.Forms.Label labelSred;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelHotDay;
        private System.Windows.Forms.Label labelCold;
        private System.Windows.Forms.Label labelMaxDay;
        private System.Windows.Forms.Label labelMinDay;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

