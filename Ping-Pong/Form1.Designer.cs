namespace Ping_Pong
{
    partial class pingPong
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
            this.pictureLeft = new System.Windows.Forms.PictureBox();
            this.pictureCircle = new System.Windows.Forms.PictureBox();
            this.pictureRight = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLeft
            // 
            this.pictureLeft.Image = global::Ping_Pong.Properties.Resources.Rectangle;
            this.pictureLeft.Location = new System.Drawing.Point(12, 26);
            this.pictureLeft.Name = "pictureLeft";
            this.pictureLeft.Size = new System.Drawing.Size(21, 197);
            this.pictureLeft.TabIndex = 1;
            this.pictureLeft.TabStop = false;
            // 
            // pictureCircle
            // 
            this.pictureCircle.Image = global::Ping_Pong.Properties.Resources.Circle;
            this.pictureCircle.Location = new System.Drawing.Point(603, 255);
            this.pictureCircle.Name = "pictureCircle";
            this.pictureCircle.Size = new System.Drawing.Size(37, 40);
            this.pictureCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureCircle.TabIndex = 0;
            this.pictureCircle.TabStop = false;
            // 
            // pictureRight
            // 
            this.pictureRight.Image = global::Ping_Pong.Properties.Resources.Rectangle;
            this.pictureRight.Location = new System.Drawing.Point(1245, 26);
            this.pictureRight.Name = "pictureRight";
            this.pictureRight.Size = new System.Drawing.Size(21, 197);
            this.pictureRight.TabIndex = 2;
            this.pictureRight.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(618, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(662, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "0";
            // 
            // pingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 804);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureRight);
            this.Controls.Add(this.pictureLeft);
            this.Controls.Add(this.pictureCircle);
            this.Name = "pingPong";
            this.Text = "Ping-Pong";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCircle;
        private System.Windows.Forms.PictureBox pictureLeft;
        private System.Windows.Forms.PictureBox pictureRight;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

