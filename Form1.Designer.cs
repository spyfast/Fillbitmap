namespace FillBitmap
{
    partial class Form1
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.pictureBoxFilled = new System.Windows.Forms.PictureBox();
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.pictureBoxInputLib = new System.Windows.Forms.PictureBox();
            this.pictureBoxFilledLib = new System.Windows.Forms.PictureBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxFilled = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInputLib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilledLib)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(9, 77);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(459, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Открыть файл";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // pictureBoxFilled
            // 
            this.pictureBoxFilled.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxFilled.Location = new System.Drawing.Point(10, 26);
            this.pictureBoxFilled.Name = "pictureBoxFilled";
            this.pictureBoxFilled.Size = new System.Drawing.Size(125, 45);
            this.pictureBoxFilled.TabIndex = 1;
            this.pictureBoxFilled.TabStop = false;
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxInput.Location = new System.Drawing.Point(479, 21);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(125, 45);
            this.pictureBoxInput.TabIndex = 2;
            this.pictureBoxInput.TabStop = false;
            // 
            // pictureBoxInputLib
            // 
            this.pictureBoxInputLib.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxInputLib.Location = new System.Drawing.Point(610, 21);
            this.pictureBoxInputLib.Name = "pictureBoxInputLib";
            this.pictureBoxInputLib.Size = new System.Drawing.Size(125, 45);
            this.pictureBoxInputLib.TabIndex = 6;
            this.pictureBoxInputLib.TabStop = false;
            // 
            // pictureBoxFilledLib
            // 
            this.pictureBoxFilledLib.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxFilledLib.Location = new System.Drawing.Point(141, 26);
            this.pictureBoxFilledLib.Name = "pictureBoxFilledLib";
            this.pictureBoxFilledLib.Size = new System.Drawing.Size(125, 45);
            this.pictureBoxFilledLib.TabIndex = 5;
            this.pictureBoxFilledLib.TabStop = false;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(741, 21);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(197, 44);
            this.textBoxInput.TabIndex = 7;
            // 
            // textBoxFilled
            // 
            this.textBoxFilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilled.Location = new System.Drawing.Point(272, 27);
            this.textBoxFilled.Name = "textBoxFilled";
            this.textBoxFilled.Size = new System.Drawing.Size(197, 44);
            this.textBoxFilled.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(313, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Текст с картинки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 113);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFilled);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.pictureBoxInputLib);
            this.Controls.Add(this.pictureBoxFilledLib);
            this.Controls.Add(this.pictureBoxInput);
            this.Controls.Add(this.pictureBoxFilled);
            this.Controls.Add(this.buttonOpen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Распознавание капчи";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInputLib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilledLib)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.PictureBox pictureBoxFilled;
        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.PictureBox pictureBoxInputLib;
        private System.Windows.Forms.PictureBox pictureBoxFilledLib;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxFilled;
        private System.Windows.Forms.Label label5;
    }
}

