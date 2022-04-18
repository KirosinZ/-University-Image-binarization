
namespace KG1
{
    partial class MainForm
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
            this.OriginalPicBox = new System.Windows.Forms.PictureBox();
            this.ImitatedPicBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.DepthBox = new System.Windows.Forms.NumericUpDown();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImitatedPicBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginalPicBox
            // 
            this.OriginalPicBox.Location = new System.Drawing.Point(10, 65);
            this.OriginalPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.OriginalPicBox.Name = "OriginalPicBox";
            this.OriginalPicBox.Size = new System.Drawing.Size(400, 400);
            this.OriginalPicBox.TabIndex = 0;
            this.OriginalPicBox.TabStop = false;
            // 
            // ImitatedPicBox
            // 
            this.ImitatedPicBox.Location = new System.Drawing.Point(10, 470);
            this.ImitatedPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.ImitatedPicBox.Name = "ImitatedPicBox";
            this.ImitatedPicBox.Size = new System.Drawing.Size(400, 400);
            this.ImitatedPicBox.TabIndex = 0;
            this.ImitatedPicBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(422, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileMenuStrip});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenFileMenuStrip
            // 
            this.OpenFileMenuStrip.Name = "OpenFileMenuStrip";
            this.OpenFileMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFileMenuStrip.Size = new System.Drawing.Size(212, 26);
            this.OpenFileMenuStrip.Text = "Открыть...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Глубина возбуждения:";
            // 
            // DepthBox
            // 
            this.DepthBox.Location = new System.Drawing.Point(170, 40);
            this.DepthBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DepthBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DepthBox.Size = new System.Drawing.Size(140, 20);
            this.DepthBox.TabIndex = 3;
            this.DepthBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 873);
            this.Controls.Add(this.DepthBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImitatedPicBox);
            this.Controls.Add(this.OriginalPicBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Метод упорядоченного возбуждения";
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImitatedPicBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OriginalPicBox;
        private System.Windows.Forms.PictureBox ImitatedPicBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DepthBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}

