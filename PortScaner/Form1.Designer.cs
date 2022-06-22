
namespace PortScaner
{
    partial class main_win_form
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btn_scan = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tIPAddress = new System.Windows.Forms.TextBox();
            this.begin_port = new System.Windows.Forms.NumericUpDown();
            this.end_port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.begin_port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_port)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(32, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "IP адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Порт с";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(460, 31);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(19, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "по";
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(657, 24);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(131, 23);
            this.btn_scan.TabIndex = 3;
            this.btn_scan.Text = "Сканировать";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 59);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 473);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 552);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 23);
            this.progressBar.TabIndex = 5;
            // 
            // tIPAddress
            // 
            this.tIPAddress.Location = new System.Drawing.Point(101, 26);
            this.tIPAddress.Name = "tIPAddress";
            this.tIPAddress.Size = new System.Drawing.Size(145, 20);
            this.tIPAddress.TabIndex = 6;
            // 
            // begin_port
            // 
            this.begin_port.Location = new System.Drawing.Point(320, 26);
            this.begin_port.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.begin_port.Name = "begin_port";
            this.begin_port.Size = new System.Drawing.Size(134, 20);
            this.begin_port.TabIndex = 7;
            // 
            // end_port
            // 
            this.end_port.Location = new System.Drawing.Point(485, 26);
            this.end_port.Name = "end_port";
            this.end_port.Size = new System.Drawing.Size(137, 20);
            this.end_port.TabIndex = 8;
            // 
            // main_win_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.end_port);
            this.Controls.Add(this.begin_port);
            this.Controls.Add(this.tIPAddress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Name = "main_win_form";
            this.Text = "PortScanner";
            ((System.ComponentModel.ISupportInitialize)(this.begin_port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox tIPAddress;
        private System.Windows.Forms.NumericUpDown begin_port;
        private System.Windows.Forms.NumericUpDown end_port;
    }
}

