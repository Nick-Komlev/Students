namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudList = new System.Windows.Forms.ComboBox();
            this.DiscList = new System.Windows.Forms.ComboBox();
            this.ScoreList = new System.Windows.Forms.ListBox();
            this.StudAdd = new System.Windows.Forms.Button();
            this.StudDel = new System.Windows.Forms.Button();
            this.DiscAdd = new System.Windows.Forms.Button();
            this.DiscDel = new System.Windows.Forms.Button();
            this.ScoreAdd = new System.Windows.Forms.Button();
            this.ScoreDel = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.ShowLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudList
            // 
            this.StudList.FormattingEnabled = true;
            this.StudList.Location = new System.Drawing.Point(12, 29);
            this.StudList.Name = "StudList";
            this.StudList.Size = new System.Drawing.Size(121, 21);
            this.StudList.Sorted = true;
            this.StudList.TabIndex = 0;
            this.StudList.Text = "<Выберите строку>";
            // 
            // DiscList
            // 
            this.DiscList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.DiscList.FormattingEnabled = true;
            this.DiscList.Location = new System.Drawing.Point(188, 29);
            this.DiscList.Name = "DiscList";
            this.DiscList.Size = new System.Drawing.Size(121, 150);
            this.DiscList.Sorted = true;
            this.DiscList.TabIndex = 0;
            this.DiscList.Text = "<Выберите строку>";
            // 
            // ScoreList
            // 
            this.ScoreList.FormattingEnabled = true;
            this.ScoreList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ScoreList.Location = new System.Drawing.Point(360, 29);
            this.ScoreList.Name = "ScoreList";
            this.ScoreList.Size = new System.Drawing.Size(120, 95);
            this.ScoreList.Sorted = true;
            this.ScoreList.TabIndex = 1;
            // 
            // StudAdd
            // 
            this.StudAdd.Location = new System.Drawing.Point(139, 27);
            this.StudAdd.Name = "StudAdd";
            this.StudAdd.Size = new System.Drawing.Size(22, 23);
            this.StudAdd.TabIndex = 2;
            this.StudAdd.Text = "+";
            this.StudAdd.UseVisualStyleBackColor = true;
            this.StudAdd.Click += new System.EventHandler(this.StudAdd_Click);
            // 
            // StudDel
            // 
            this.StudDel.Location = new System.Drawing.Point(139, 56);
            this.StudDel.Name = "StudDel";
            this.StudDel.Size = new System.Drawing.Size(22, 23);
            this.StudDel.TabIndex = 2;
            this.StudDel.Text = "x";
            this.StudDel.UseVisualStyleBackColor = true;
            this.StudDel.Click += new System.EventHandler(this.StudDel_Click);
            // 
            // DiscAdd
            // 
            this.DiscAdd.Location = new System.Drawing.Point(315, 29);
            this.DiscAdd.Name = "DiscAdd";
            this.DiscAdd.Size = new System.Drawing.Size(22, 23);
            this.DiscAdd.TabIndex = 2;
            this.DiscAdd.Text = "+";
            this.DiscAdd.UseVisualStyleBackColor = true;
            this.DiscAdd.Click += new System.EventHandler(this.DiscAdd_Click);
            // 
            // DiscDel
            // 
            this.DiscDel.Location = new System.Drawing.Point(315, 56);
            this.DiscDel.Name = "DiscDel";
            this.DiscDel.Size = new System.Drawing.Size(22, 23);
            this.DiscDel.TabIndex = 2;
            this.DiscDel.Text = "x";
            this.DiscDel.UseVisualStyleBackColor = true;
            this.DiscDel.Click += new System.EventHandler(this.DiscDel_Click);
            // 
            // ScoreAdd
            // 
            this.ScoreAdd.Location = new System.Drawing.Point(486, 27);
            this.ScoreAdd.Name = "ScoreAdd";
            this.ScoreAdd.Size = new System.Drawing.Size(22, 23);
            this.ScoreAdd.TabIndex = 2;
            this.ScoreAdd.Text = "+";
            this.ScoreAdd.UseVisualStyleBackColor = true;
            this.ScoreAdd.Click += new System.EventHandler(this.ScoreAdd_Click);
            // 
            // ScoreDel
            // 
            this.ScoreDel.Location = new System.Drawing.Point(486, 54);
            this.ScoreDel.Name = "ScoreDel";
            this.ScoreDel.Size = new System.Drawing.Size(22, 23);
            this.ScoreDel.TabIndex = 2;
            this.ScoreDel.Text = "x";
            this.ScoreDel.UseVisualStyleBackColor = true;
            this.ScoreDel.Click += new System.EventHandler(this.ScoreDel_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(188, 196);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(121, 23);
            this.Show.TabIndex = 3;
            this.Show.Text = "Отобразить";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // AddBox
            // 
            this.AddBox.Location = new System.Drawing.Point(188, 267);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(164, 20);
            this.AddBox.TabIndex = 4;
            this.AddBox.Visible = false;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(188, 293);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 5;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Visible = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // ShowLbl
            // 
            this.ShowLbl.AutoSize = true;
            this.ShowLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowLbl.Location = new System.Drawing.Point(20, 237);
            this.ShowLbl.Name = "ShowLbl";
            this.ShowLbl.Size = new System.Drawing.Size(43, 13);
            this.ShowLbl.TabIndex = 6;
            this.ShowLbl.Text = "Вывод:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 328);
            this.Controls.Add(this.ShowLbl);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.ScoreDel);
            this.Controls.Add(this.DiscDel);
            this.Controls.Add(this.StudDel);
            this.Controls.Add(this.ScoreAdd);
            this.Controls.Add(this.DiscAdd);
            this.Controls.Add(this.StudAdd);
            this.Controls.Add(this.ScoreList);
            this.Controls.Add(this.DiscList);
            this.Controls.Add(this.StudList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StudList;
        private System.Windows.Forms.ComboBox DiscList;
        private System.Windows.Forms.ListBox ScoreList;
        private System.Windows.Forms.Button StudAdd;
        private System.Windows.Forms.Button StudDel;
        private System.Windows.Forms.Button DiscAdd;
        private System.Windows.Forms.Button DiscDel;
        private System.Windows.Forms.Button ScoreAdd;
        private System.Windows.Forms.Button ScoreDel;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label ShowLbl;
    }
}

