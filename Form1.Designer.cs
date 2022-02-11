
namespace Inex_1
{
    partial class Main_form
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
            this.expens = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.income = new System.Windows.Forms.Button();
            this.tools = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // expens
            // 
            this.expens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expens.Location = new System.Drawing.Point(47, 48);
            this.expens.Name = "expens";
            this.expens.Size = new System.Drawing.Size(244, 36);
            this.expens.TabIndex = 0;
            this.expens.Text = "Expense(-)";
            this.expens.UseVisualStyleBackColor = true;
            this.expens.Click += new System.EventHandler(this.expens_Click);
            // 
            // reports
            // 
            this.reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reports.Location = new System.Drawing.Point(194, 143);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(244, 36);
            this.reports.TabIndex = 1;
            this.reports.Text = "Reports (+/-)";
            this.reports.UseVisualStyleBackColor = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // income
            // 
            this.income.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.income.Location = new System.Drawing.Point(388, 243);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(244, 36);
            this.income.TabIndex = 2;
            this.income.Text = "Income(+)";
            this.income.UseVisualStyleBackColor = true;
            this.income.Click += new System.EventHandler(this.income_Click);
            // 
            // tools
            // 
            this.tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tools.Location = new System.Drawing.Point(572, 48);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(60, 44);
            this.tools.TabIndex = 3;
            this.tools.Text = "Tools";
            this.tools.UseVisualStyleBackColor = true;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 369);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.income);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.expens);
            this.Name = "Main_form";
            this.Text = "Main form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button expens;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button income;
        private System.Windows.Forms.Button tools;
    }
}

