namespace graphics_editor
{
    partial class RectangularForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.цветПераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерПераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.highlight_checkBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.x_textBox = new System.Windows.Forms.TextBox();
            this.y_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветПераToolStripMenuItem,
            this.размерПераToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.сохранитьРисунокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // цветПераToolStripMenuItem
            // 
            this.цветПераToolStripMenuItem.Name = "цветПераToolStripMenuItem";
            this.цветПераToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.цветПераToolStripMenuItem.Text = "Цвет пера";
            this.цветПераToolStripMenuItem.Click += new System.EventHandler(this.цветПераToolStripMenuItem_Click);
            // 
            // размерПераToolStripMenuItem
            // 
            this.размерПераToolStripMenuItem.Name = "размерПераToolStripMenuItem";
            this.размерПераToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.размерПераToolStripMenuItem.Text = "Размер пера";
            this.размерПераToolStripMenuItem.Click += new System.EventHandler(this.размерПераToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // сохранитьРисунокToolStripMenuItem
            // 
            this.сохранитьРисунокToolStripMenuItem.Name = "сохранитьРисунокToolStripMenuItem";
            this.сохранитьРисунокToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.сохранитьРисунокToolStripMenuItem.Text = "Сохранить рисунок";
            this.сохранитьРисунокToolStripMenuItem.Click += new System.EventHandler(this.сохранитьРисунокToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 410);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(760, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Вставить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // highlight_checkBox
            // 
            this.highlight_checkBox.AutoSize = true;
            this.highlight_checkBox.Location = new System.Drawing.Point(675, 27);
            this.highlight_checkBox.Name = "highlight_checkBox";
            this.highlight_checkBox.Size = new System.Drawing.Size(178, 17);
            this.highlight_checkBox.TabIndex = 6;
            this.highlight_checkBox.Text = "Выделить часть изображения";
            this.highlight_checkBox.UseVisualStyleBackColor = true;
            // 
            // x_textBox
            // 
            this.x_textBox.Location = new System.Drawing.Point(698, 63);
            this.x_textBox.Name = "x_textBox";
            this.x_textBox.Size = new System.Drawing.Size(52, 20);
            this.x_textBox.TabIndex = 7;
            this.x_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_textBox_KeyPress);
            // 
            // y_textBox
            // 
            this.y_textBox.Location = new System.Drawing.Point(801, 63);
            this.y_textBox.Name = "y_textBox";
            this.y_textBox.Size = new System.Drawing.Size(52, 20);
            this.y_textBox.TabIndex = 8;
            this.y_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y_textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Координаты для вставки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "X=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(775, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Y=";
            // 
            // RectangularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.y_textBox);
            this.Controls.Add(this.x_textBox);
            this.Controls.Add(this.highlight_checkBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RectangularForm";
            this.Text = "Прямоугольный холст";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem цветПераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерПераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьРисунокToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox highlight_checkBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox x_textBox;
        private System.Windows.Forms.TextBox y_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}