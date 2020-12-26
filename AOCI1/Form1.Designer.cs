namespace AOCI1
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
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonScale = new System.Windows.Forms.Button();
            this.buttonShift = new System.Windows.Forms.Button();
            this.textBoxShiftY = new System.Windows.Forms.TextBox();
            this.textBoxShiftX = new System.Windows.Forms.TextBox();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.buttonReflection = new System.Windows.Forms.Button();
            this.buttonHomo = new System.Windows.Forms.Button();
            this.textBoxQx = new System.Windows.Forms.TextBox();
            this.textBoxQy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(0, 0);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(500, 500);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Open image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(627, 0);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(500, 500);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(507, 42);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(33, 20);
            this.textBoxX.TabIndex = 4;
            this.textBoxX.Text = "0";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(546, 42);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(33, 20);
            this.textBoxY.TabIndex = 5;
            this.textBoxY.Text = "0";
            // 
            // buttonScale
            // 
            this.buttonScale.Location = new System.Drawing.Point(507, 69);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(114, 23);
            this.buttonScale.TabIndex = 6;
            this.buttonScale.Text = "Scale";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // buttonShift
            // 
            this.buttonShift.Location = new System.Drawing.Point(507, 125);
            this.buttonShift.Name = "buttonShift";
            this.buttonShift.Size = new System.Drawing.Size(114, 23);
            this.buttonShift.TabIndex = 9;
            this.buttonShift.Text = "Shift";
            this.buttonShift.UseVisualStyleBackColor = true;
            this.buttonShift.Click += new System.EventHandler(this.buttonShift_Click);
            // 
            // textBoxShiftY
            // 
            this.textBoxShiftY.Location = new System.Drawing.Point(546, 98);
            this.textBoxShiftY.Name = "textBoxShiftY";
            this.textBoxShiftY.Size = new System.Drawing.Size(33, 20);
            this.textBoxShiftY.TabIndex = 8;
            this.textBoxShiftY.Text = "0";
            // 
            // textBoxShiftX
            // 
            this.textBoxShiftX.Location = new System.Drawing.Point(507, 98);
            this.textBoxShiftX.Name = "textBoxShiftX";
            this.textBoxShiftX.Size = new System.Drawing.Size(33, 20);
            this.textBoxShiftX.TabIndex = 7;
            this.textBoxShiftX.Text = "0";
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(507, 154);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(33, 20);
            this.textBoxAngle.TabIndex = 10;
            this.textBoxAngle.Text = "0";
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(507, 180);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(114, 23);
            this.buttonRotate.TabIndex = 11;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // buttonReflection
            // 
            this.buttonReflection.Location = new System.Drawing.Point(507, 237);
            this.buttonReflection.Name = "buttonReflection";
            this.buttonReflection.Size = new System.Drawing.Size(114, 23);
            this.buttonReflection.TabIndex = 12;
            this.buttonReflection.Text = "Reflect";
            this.buttonReflection.UseVisualStyleBackColor = true;
            this.buttonReflection.Click += new System.EventHandler(this.buttonReflection_Click);
            // 
            // buttonHomo
            // 
            this.buttonHomo.Location = new System.Drawing.Point(506, 266);
            this.buttonHomo.Name = "buttonHomo";
            this.buttonHomo.Size = new System.Drawing.Size(114, 23);
            this.buttonHomo.TabIndex = 13;
            this.buttonHomo.Text = "Homography";
            this.buttonHomo.UseVisualStyleBackColor = true;
            this.buttonHomo.Click += new System.EventHandler(this.buttonHomo_Click);
            // 
            // textBoxQx
            // 
            this.textBoxQx.Location = new System.Drawing.Point(507, 209);
            this.textBoxQx.Name = "textBoxQx";
            this.textBoxQx.Size = new System.Drawing.Size(33, 20);
            this.textBoxQx.TabIndex = 14;
            this.textBoxQx.Text = "1";
            // 
            // textBoxQy
            // 
            this.textBoxQy.Location = new System.Drawing.Point(546, 209);
            this.textBoxQy.Name = "textBoxQy";
            this.textBoxQy.Size = new System.Drawing.Size(33, 20);
            this.textBoxQy.TabIndex = 15;
            this.textBoxQy.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 518);
            this.Controls.Add(this.textBoxQy);
            this.Controls.Add(this.textBoxQx);
            this.Controls.Add(this.buttonHomo);
            this.Controls.Add(this.buttonReflection);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.textBoxAngle);
            this.Controls.Add(this.buttonShift);
            this.Controls.Add(this.textBoxShiftY);
            this.Controls.Add(this.textBoxShiftX);
            this.Controls.Add(this.buttonScale);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.Button buttonShift;
        private System.Windows.Forms.TextBox textBoxShiftY;
        private System.Windows.Forms.TextBox textBoxShiftX;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Button buttonReflection;
        private System.Windows.Forms.Button buttonHomo;
        private System.Windows.Forms.TextBox textBoxQx;
        private System.Windows.Forms.TextBox textBoxQy;
    }
}

