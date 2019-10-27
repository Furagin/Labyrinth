namespace Labirint
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
			this.createMapButton = new System.Windows.Forms.Button();
			this.loadMapButton = new System.Windows.Forms.Button();
			this.saveMapButton = new System.Windows.Forms.Button();
			this.solveLabirintButton = new System.Windows.Forms.Button();
			this.robotsCountTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.fileNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.fieldX = new System.Windows.Forms.TextBox();
			this.fieldY = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.InfoRowTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.startX = new System.Windows.Forms.TextBox();
			this.startY = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.infoButton = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// createMapButton
			// 
			this.createMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.createMapButton.Location = new System.Drawing.Point(590, 102);
			this.createMapButton.Margin = new System.Windows.Forms.Padding(2);
			this.createMapButton.Name = "createMapButton";
			this.createMapButton.Size = new System.Drawing.Size(104, 19);
			this.createMapButton.TabIndex = 0;
			this.createMapButton.Text = "Создать карту";
			this.createMapButton.UseVisualStyleBackColor = true;
			this.createMapButton.Click += new System.EventHandler(this.createMapButton_Click);
			// 
			// loadMapButton
			// 
			this.loadMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.loadMapButton.Location = new System.Drawing.Point(590, 122);
			this.loadMapButton.Margin = new System.Windows.Forms.Padding(2);
			this.loadMapButton.Name = "loadMapButton";
			this.loadMapButton.Size = new System.Drawing.Size(104, 19);
			this.loadMapButton.TabIndex = 1;
			this.loadMapButton.Text = "Загрузить карту";
			this.loadMapButton.UseVisualStyleBackColor = true;
			this.loadMapButton.Click += new System.EventHandler(this.loadMapButton_Click);
			// 
			// saveMapButton
			// 
			this.saveMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.saveMapButton.Location = new System.Drawing.Point(590, 142);
			this.saveMapButton.Margin = new System.Windows.Forms.Padding(2);
			this.saveMapButton.Name = "saveMapButton";
			this.saveMapButton.Size = new System.Drawing.Size(104, 19);
			this.saveMapButton.TabIndex = 2;
			this.saveMapButton.Text = "Сохранить карту";
			this.saveMapButton.UseVisualStyleBackColor = true;
			this.saveMapButton.Click += new System.EventHandler(this.saveMapButton_Click);
			// 
			// solveLabirintButton
			// 
			this.solveLabirintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.solveLabirintButton.Location = new System.Drawing.Point(590, 417);
			this.solveLabirintButton.Margin = new System.Windows.Forms.Padding(2);
			this.solveLabirintButton.Name = "solveLabirintButton";
			this.solveLabirintButton.Size = new System.Drawing.Size(104, 37);
			this.solveLabirintButton.TabIndex = 3;
			this.solveLabirintButton.Text = "Пройти лабиринт";
			this.solveLabirintButton.UseVisualStyleBackColor = true;
			this.solveLabirintButton.Click += new System.EventHandler(this.solveLabirintButton_Click);
			// 
			// robotsCountTextBox
			// 
			this.robotsCountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.robotsCountTextBox.Location = new System.Drawing.Point(590, 219);
			this.robotsCountTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.robotsCountTextBox.Name = "robotsCountTextBox";
			this.robotsCountTextBox.Size = new System.Drawing.Size(105, 20);
			this.robotsCountTextBox.TabIndex = 5;
			this.robotsCountTextBox.Text = "1";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(587, 202);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Количество роботов";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(590, 67);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Имя файла";
			// 
			// fileNameTextBox
			// 
			this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.fileNameTextBox.Location = new System.Drawing.Point(590, 83);
			this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.fileNameTextBox.Name = "fileNameTextBox";
			this.fileNameTextBox.Size = new System.Drawing.Size(105, 20);
			this.fileNameTextBox.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(590, 7);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Размерность поля";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(590, 30);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "X";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(590, 50);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(14, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Y";
			// 
			// fieldX
			// 
			this.fieldX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.fieldX.Location = new System.Drawing.Point(607, 28);
			this.fieldX.Margin = new System.Windows.Forms.Padding(2);
			this.fieldX.Name = "fieldX";
			this.fieldX.Size = new System.Drawing.Size(88, 20);
			this.fieldX.TabIndex = 12;
			// 
			// fieldY
			// 
			this.fieldY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.fieldY.Location = new System.Drawing.Point(607, 48);
			this.fieldY.Margin = new System.Windows.Forms.Padding(2);
			this.fieldY.Name = "fieldY";
			this.fieldY.Size = new System.Drawing.Size(88, 20);
			this.fieldY.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(590, 165);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Строка состояния";
			// 
			// InfoRowTextBox
			// 
			this.InfoRowTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.InfoRowTextBox.Location = new System.Drawing.Point(590, 183);
			this.InfoRowTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.InfoRowTextBox.Name = "InfoRowTextBox";
			this.InfoRowTextBox.Size = new System.Drawing.Size(104, 20);
			this.InfoRowTextBox.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(590, 239);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(107, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Координаты начала";
			// 
			// startX
			// 
			this.startX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.startX.Location = new System.Drawing.Point(619, 258);
			this.startX.Margin = new System.Windows.Forms.Padding(2);
			this.startX.Name = "startX";
			this.startX.Size = new System.Drawing.Size(76, 20);
			this.startX.TabIndex = 17;
			this.startX.Text = "0";
			// 
			// startY
			// 
			this.startY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.startY.Location = new System.Drawing.Point(619, 279);
			this.startY.Margin = new System.Windows.Forms.Padding(2);
			this.startY.Name = "startY";
			this.startY.Size = new System.Drawing.Size(76, 20);
			this.startY.TabIndex = 18;
			this.startY.Text = "0";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(590, 259);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(12, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "x";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(590, 275);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(12, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "y";
			// 
			// textBox8
			// 
			this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox8.Location = new System.Drawing.Point(10, 7);
			this.textBox8.Margin = new System.Windows.Forms.Padding(2);
			this.textBox8.Multiline = true;
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(574, 447);
			this.textBox8.TabIndex = 21;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Location = new System.Drawing.Point(10, 7);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(573, 446);
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// infoButton
			// 
			this.infoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.infoButton.Location = new System.Drawing.Point(590, 393);
			this.infoButton.Margin = new System.Windows.Forms.Padding(2);
			this.infoButton.Name = "infoButton";
			this.infoButton.Size = new System.Drawing.Size(104, 19);
			this.infoButton.TabIndex = 23;
			this.infoButton.Text = "Инфо";
			this.infoButton.UseVisualStyleBackColor = true;
			this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Location = new System.Drawing.Point(590, 322);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(104, 67);
			this.pictureBox2.TabIndex = 24;
			this.pictureBox2.TabStop = false;
			// 
			// textBox9
			// 
			this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox9.Location = new System.Drawing.Point(590, 322);
			this.textBox9.Margin = new System.Windows.Forms.Padding(2);
			this.textBox9.Multiline = true;
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(105, 67);
			this.textBox9.TabIndex = 25;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(703, 463);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.infoButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.startY);
			this.Controls.Add(this.startX);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.InfoRowTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.fieldY);
			this.Controls.Add(this.fieldX);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.fileNameTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.robotsCountTextBox);
			this.Controls.Add(this.solveLabirintButton);
			this.Controls.Add(this.saveMapButton);
			this.Controls.Add(this.loadMapButton);
			this.Controls.Add(this.createMapButton);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Лабиринт. КРМО-01-17 Шелагин И.С.";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createMapButton;
        private System.Windows.Forms.Button loadMapButton;
        private System.Windows.Forms.Button saveMapButton;
        private System.Windows.Forms.Button solveLabirintButton;
        private System.Windows.Forms.TextBox robotsCountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fieldX;
        private System.Windows.Forms.TextBox fieldY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InfoRowTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox startX;
        private System.Windows.Forms.TextBox startY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox textBox9;
    }
}

