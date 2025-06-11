namespace jisuan
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.equalButton = new jisuan.CircularButton();
            this.decimalButton = new jisuan.CircularButton();
            this.num0Button = new jisuan.CircularButton();
            this.more = new jisuan.CircularButton();
            this.plusButton = new jisuan.CircularButton();
            this.num3Button = new jisuan.CircularButton();
            this.num2Button = new jisuan.CircularButton();
            this.num1Button = new jisuan.CircularButton();
            this.minusButton = new jisuan.CircularButton();
            this.num6Button = new jisuan.CircularButton();
            this.num5Button = new jisuan.CircularButton();
            this.num4Button = new jisuan.CircularButton();
            this.multiplyButton = new jisuan.CircularButton();
            this.num9Button = new jisuan.CircularButton();
            this.num8Button = new jisuan.CircularButton();
            this.num7Button = new jisuan.CircularButton();
            this.divideButton = new jisuan.CircularButton();
            this.percentButton = new jisuan.CircularButton();
            this.plusMinusButton = new jisuan.CircularButton();
            this.acButton = new jisuan.CircularButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.equalButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.decimalButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.num0Button, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.more, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.plusButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.num3Button, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.num2Button, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.num1Button, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.minusButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.num6Button, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.num5Button, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.num4Button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.multiplyButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.num9Button, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.num8Button, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.num7Button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.divideButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.percentButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.plusMinusButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.acButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 233);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.81081F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.18919F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultLabel.Location = new System.Drawing.Point(25, 154);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(59, 64);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "0";
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::jisuan.Properties.Resources.abb8da13a94e403581514c36349c7306;
            this.pictureBox1.Image = global::jisuan.Properties.Resources.abb8da13a94e403581514c36349c7306;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // equalButton
            // 
            this.equalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.equalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.equalButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.equalButton.BorderWidth = 1;
            this.equalButton.FlatAppearance.BorderSize = 0;
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.equalButton.ForeColor = System.Drawing.Color.White;
            this.equalButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.equalButton.Location = new System.Drawing.Point(354, 298);
            this.equalButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.equalButton.Name = "equalButton";
            this.equalButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.equalButton.ShowBorder = true;
            this.equalButton.ShowShadow = false;
            this.equalButton.Size = new System.Drawing.Size(68, 68);
            this.equalButton.TabIndex = 20;
            this.equalButton.Text = "=";
            this.equalButton.UseGradient = true;
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.decimalButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.decimalButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.decimalButton.BorderWidth = 1;
            this.decimalButton.FlatAppearance.BorderSize = 0;
            this.decimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decimalButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.decimalButton.ForeColor = System.Drawing.Color.White;
            this.decimalButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.decimalButton.Location = new System.Drawing.Point(244, 298);
            this.decimalButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.decimalButton.ShowBorder = true;
            this.decimalButton.ShowShadow = false;
            this.decimalButton.Size = new System.Drawing.Size(68, 68);
            this.decimalButton.TabIndex = 19;
            this.decimalButton.Text = ".";
            this.decimalButton.UseGradient = true;
            this.decimalButton.UseVisualStyleBackColor = false;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // num0Button
            // 
            this.num0Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num0Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num0Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.num0Button.BorderWidth = 1;
            this.num0Button.FlatAppearance.BorderSize = 0;
            this.num0Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num0Button.ForeColor = System.Drawing.Color.White;
            this.num0Button.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.num0Button.Location = new System.Drawing.Point(134, 298);
            this.num0Button.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.num0Button.Name = "num0Button";
            this.num0Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.num0Button.ShowBorder = true;
            this.num0Button.ShowShadow = false;
            this.num0Button.Size = new System.Drawing.Size(68, 68);
            this.num0Button.TabIndex = 18;
            this.num0Button.Text = "0";
            this.num0Button.UseGradient = true;
            this.num0Button.UseVisualStyleBackColor = false;
            this.num0Button.Click += new System.EventHandler(this.circularButton18_Click);
            // 
            // more
            // 
            this.more.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.more.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.more.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.more.BorderWidth = 1;
            this.more.FlatAppearance.BorderSize = 0;
            this.more.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.more.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.more.ForeColor = System.Drawing.Color.White;
            this.more.HoverColor = System.Drawing.Color.Aqua;
            this.more.Location = new System.Drawing.Point(24, 298);
            this.more.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.more.Name = "more";
            this.more.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.more.ShowBorder = true;
            this.more.ShowShadow = false;
            this.more.Size = new System.Drawing.Size(68, 68);
            this.more.TabIndex = 17;
            this.more.Text = "More";
            this.more.UseGradient = true;
            this.more.UseVisualStyleBackColor = false;
            this.more.Click += new System.EventHandler(this.more_Click);
            // 
            // plusButton
            // 
            this.plusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.plusButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.plusButton.BorderWidth = 1;
            this.plusButton.FlatAppearance.BorderSize = 0;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plusButton.ForeColor = System.Drawing.Color.White;
            this.plusButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.plusButton.Location = new System.Drawing.Point(354, 224);
            this.plusButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.plusButton.Name = "plusButton";
            this.plusButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.plusButton.ShowBorder = true;
            this.plusButton.ShowShadow = false;
            this.plusButton.Size = new System.Drawing.Size(68, 68);
            this.plusButton.TabIndex = 16;
            this.plusButton.Text = "+";
            this.plusButton.UseGradient = true;
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // num3Button
            // 
            this.num3Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num3Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num3Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.num3Button.BorderWidth = 1;
            this.num3Button.FlatAppearance.BorderSize = 0;
            this.num3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num3Button.ForeColor = System.Drawing.Color.White;
            this.num3Button.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.num3Button.Location = new System.Drawing.Point(244, 224);
            this.num3Button.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.num3Button.Name = "num3Button";
            this.num3Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.num3Button.ShowBorder = true;
            this.num3Button.ShowShadow = false;
            this.num3Button.Size = new System.Drawing.Size(68, 68);
            this.num3Button.TabIndex = 15;
            this.num3Button.Text = "3";
            this.num3Button.UseGradient = true;
            this.num3Button.UseVisualStyleBackColor = false;
            this.num3Button.Click += new System.EventHandler(this.num3Button_Click);
            // 
            // num2Button
            // 
            this.num2Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num2Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num2Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.num2Button.BorderWidth = 1;
            this.num2Button.FlatAppearance.BorderSize = 0;
            this.num2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num2Button.ForeColor = System.Drawing.Color.White;
            this.num2Button.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.num2Button.Location = new System.Drawing.Point(134, 224);
            this.num2Button.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.num2Button.Name = "num2Button";
            this.num2Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.num2Button.ShowBorder = true;
            this.num2Button.ShowShadow = false;
            this.num2Button.Size = new System.Drawing.Size(68, 68);
            this.num2Button.TabIndex = 14;
            this.num2Button.Text = "2";
            this.num2Button.UseGradient = true;
            this.num2Button.UseVisualStyleBackColor = false;
            this.num2Button.Click += new System.EventHandler(this.num2Button_Click);
            // 
            // num1Button
            // 
            this.num1Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num1Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num1Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.num1Button.BorderWidth = 1;
            this.num1Button.FlatAppearance.BorderSize = 0;
            this.num1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num1Button.ForeColor = System.Drawing.Color.White;
            this.num1Button.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.num1Button.Location = new System.Drawing.Point(24, 224);
            this.num1Button.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.num1Button.Name = "num1Button";
            this.num1Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.num1Button.ShowBorder = true;
            this.num1Button.ShowShadow = false;
            this.num1Button.Size = new System.Drawing.Size(68, 68);
            this.num1Button.TabIndex = 13;
            this.num1Button.Text = "1";
            this.num1Button.UseGradient = true;
            this.num1Button.UseVisualStyleBackColor = false;
            this.num1Button.Click += new System.EventHandler(this.num1Button_Click);
            // 
            // minusButton
            // 
            this.minusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minusButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.minusButton.BorderWidth = 1;
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minusButton.ForeColor = System.Drawing.Color.White;
            this.minusButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.minusButton.Location = new System.Drawing.Point(354, 150);
            this.minusButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.minusButton.Name = "minusButton";
            this.minusButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.minusButton.ShowBorder = true;
            this.minusButton.ShowShadow = false;
            this.minusButton.Size = new System.Drawing.Size(68, 68);
            this.minusButton.TabIndex = 12;
            this.minusButton.Text = "−";
            this.minusButton.UseGradient = true;
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // num6Button
            // 
            this.num6Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num6Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num6Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.num6Button.BorderWidth = 1;
            this.num6Button.FlatAppearance.BorderSize = 0;
            this.num6Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num6Button.ForeColor = System.Drawing.Color.White;
            this.num6Button.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.num6Button.Location = new System.Drawing.Point(244, 150);
            this.num6Button.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.num6Button.Name = "num6Button";
            this.num6Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.num6Button.ShowBorder = true;
            this.num6Button.ShowShadow = false;
            this.num6Button.Size = new System.Drawing.Size(68, 68);
            this.num6Button.TabIndex = 11;
            this.num6Button.Text = "6";
            this.num6Button.UseGradient = true;
            this.num6Button.UseVisualStyleBackColor = false;
            this.num6Button.Click += new System.EventHandler(this.num6Button_Click);
            // 
            // num5Button
            // 
            this.num5Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num5Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num5Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.num5Button.BorderWidth = 1;
            this.num5Button.FlatAppearance.BorderSize = 0;
            this.num5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num5Button.ForeColor = System.Drawing.Color.White;
            this.num5Button.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.num5Button.Location = new System.Drawing.Point(134, 150);
            this.num5Button.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.num5Button.Name = "num5Button";
            this.num5Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.num5Button.ShowBorder = true;
            this.num5Button.ShowShadow = false;
            this.num5Button.Size = new System.Drawing.Size(68, 68);
            this.num5Button.TabIndex = 10;
            this.num5Button.Text = "5";
            this.num5Button.UseGradient = true;
            this.num5Button.UseVisualStyleBackColor = false;
            this.num5Button.Click += new System.EventHandler(this.num5Button_Click);
            // 
            // num4Button
            // 
            this.num4Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num4Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num4Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.num4Button.BorderWidth = 1;
            this.num4Button.FlatAppearance.BorderSize = 0;
            this.num4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num4Button.ForeColor = System.Drawing.Color.White;
            this.num4Button.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.num4Button.Location = new System.Drawing.Point(24, 150);
            this.num4Button.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.num4Button.Name = "num4Button";
            this.num4Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.num4Button.ShowBorder = true;
            this.num4Button.ShowShadow = false;
            this.num4Button.Size = new System.Drawing.Size(68, 68);
            this.num4Button.TabIndex = 9;
            this.num4Button.Text = "4";
            this.num4Button.UseGradient = true;
            this.num4Button.UseVisualStyleBackColor = false;
            this.num4Button.Click += new System.EventHandler(this.num4Button_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multiplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.multiplyButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.multiplyButton.BorderWidth = 1;
            this.multiplyButton.FlatAppearance.BorderSize = 0;
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.multiplyButton.ForeColor = System.Drawing.Color.White;
            this.multiplyButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.multiplyButton.Location = new System.Drawing.Point(356, 79);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.multiplyButton.ShowBorder = true;
            this.multiplyButton.ShowShadow = false;
            this.multiplyButton.Size = new System.Drawing.Size(65, 65);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.Text = "×";
            this.multiplyButton.UseGradient = true;
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // num9Button
            // 
            this.num9Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num9Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num9Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.num9Button.BorderWidth = 1;
            this.num9Button.FlatAppearance.BorderSize = 0;
            this.num9Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num9Button.ForeColor = System.Drawing.Color.White;
            this.num9Button.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.num9Button.Location = new System.Drawing.Point(246, 79);
            this.num9Button.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.num9Button.Name = "num9Button";
            this.num9Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.num9Button.ShowBorder = true;
            this.num9Button.ShowShadow = false;
            this.num9Button.Size = new System.Drawing.Size(65, 65);
            this.num9Button.TabIndex = 7;
            this.num9Button.Text = "9";
            this.num9Button.UseGradient = true;
            this.num9Button.UseVisualStyleBackColor = false;
            this.num9Button.Click += new System.EventHandler(this.num9Button_Click);
            // 
            // num8Button
            // 
            this.num8Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num8Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num8Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.num8Button.BorderWidth = 1;
            this.num8Button.FlatAppearance.BorderSize = 0;
            this.num8Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num8Button.ForeColor = System.Drawing.Color.White;
            this.num8Button.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.num8Button.Location = new System.Drawing.Point(136, 79);
            this.num8Button.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.num8Button.Name = "num8Button";
            this.num8Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.num8Button.ShowBorder = true;
            this.num8Button.ShowShadow = false;
            this.num8Button.Size = new System.Drawing.Size(65, 65);
            this.num8Button.TabIndex = 6;
            this.num8Button.Text = "8";
            this.num8Button.UseGradient = true;
            this.num8Button.UseVisualStyleBackColor = false;
            this.num8Button.Click += new System.EventHandler(this.num8Button_Click);
            // 
            // num7Button
            // 
            this.num7Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num7Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num7Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.num7Button.BorderWidth = 1;
            this.num7Button.FlatAppearance.BorderSize = 0;
            this.num7Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num7Button.ForeColor = System.Drawing.Color.White;
            this.num7Button.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.num7Button.Location = new System.Drawing.Point(26, 79);
            this.num7Button.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.num7Button.Name = "num7Button";
            this.num7Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.num7Button.ShowBorder = true;
            this.num7Button.ShowShadow = false;
            this.num7Button.Size = new System.Drawing.Size(65, 65);
            this.num7Button.TabIndex = 5;
            this.num7Button.Text = "7";
            this.num7Button.UseGradient = true;
            this.num7Button.UseVisualStyleBackColor = false;
            this.num7Button.Click += new System.EventHandler(this.num7Button_Click);
            // 
            // divideButton
            // 
            this.divideButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.divideButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.divideButton.BorderWidth = 1;
            this.divideButton.FlatAppearance.BorderSize = 0;
            this.divideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divideButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.divideButton.ForeColor = System.Drawing.Color.White;
            this.divideButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.divideButton.Location = new System.Drawing.Point(354, 4);
            this.divideButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.divideButton.Name = "divideButton";
            this.divideButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.divideButton.ShowBorder = true;
            this.divideButton.ShowShadow = true;
            this.divideButton.Size = new System.Drawing.Size(68, 68);
            this.divideButton.TabIndex = 4;
            this.divideButton.Text = "÷";
            this.divideButton.UseGradient = true;
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // percentButton
            // 
            this.percentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.percentButton.BackColor = System.Drawing.Color.Gold;
            this.percentButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.percentButton.BorderWidth = 1;
            this.percentButton.FlatAppearance.BorderSize = 0;
            this.percentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.percentButton.ForeColor = System.Drawing.Color.White;
            this.percentButton.HoverColor = System.Drawing.Color.Yellow;
            this.percentButton.Location = new System.Drawing.Point(244, 4);
            this.percentButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.percentButton.Name = "percentButton";
            this.percentButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.percentButton.ShowBorder = true;
            this.percentButton.ShowShadow = false;
            this.percentButton.Size = new System.Drawing.Size(68, 68);
            this.percentButton.TabIndex = 3;
            this.percentButton.Text = "%";
            this.percentButton.UseGradient = true;
            this.percentButton.UseVisualStyleBackColor = false;
            this.percentButton.Click += new System.EventHandler(this.percentButton_Click);
            // 
            // plusMinusButton
            // 
            this.plusMinusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusMinusButton.BackColor = System.Drawing.Color.Gold;
            this.plusMinusButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.plusMinusButton.BorderWidth = 1;
            this.plusMinusButton.FlatAppearance.BorderSize = 0;
            this.plusMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusMinusButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plusMinusButton.ForeColor = System.Drawing.Color.White;
            this.plusMinusButton.HoverColor = System.Drawing.Color.Yellow;
            this.plusMinusButton.Location = new System.Drawing.Point(134, 4);
            this.plusMinusButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.plusMinusButton.Name = "plusMinusButton";
            this.plusMinusButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.plusMinusButton.ShowBorder = true;
            this.plusMinusButton.ShowShadow = false;
            this.plusMinusButton.Size = new System.Drawing.Size(68, 68);
            this.plusMinusButton.TabIndex = 2;
            this.plusMinusButton.Text = "+/-";
            this.plusMinusButton.UseGradient = true;
            this.plusMinusButton.UseVisualStyleBackColor = false;
            this.plusMinusButton.Click += new System.EventHandler(this.plusMinusButton_Click);
            // 
            // acButton
            // 
            this.acButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acButton.BackColor = System.Drawing.Color.IndianRed;
            this.acButton.BorderColor = System.Drawing.Color.Red;
            this.acButton.BorderWidth = 1;
            this.acButton.FlatAppearance.BorderSize = 0;
            this.acButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.acButton.ForeColor = System.Drawing.Color.White;
            this.acButton.HoverColor = System.Drawing.Color.OrangeRed;
            this.acButton.Location = new System.Drawing.Point(24, 4);
            this.acButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.acButton.Name = "acButton";
            this.acButton.PressedColor = System.Drawing.Color.Red;
            this.acButton.ShowBorder = true;
            this.acButton.ShowShadow = false;
            this.acButton.Size = new System.Drawing.Size(68, 68);
            this.acButton.TabIndex = 1;
            this.acButton.Text = "AC";
            this.acButton.UseGradient = true;
            this.acButton.UseVisualStyleBackColor = false;
            this.acButton.Click += new System.EventHandler(this.acButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 603);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "计算器";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CircularButton plusMinusButton;
        private CircularButton acButton;
        private CircularButton equalButton;
        private CircularButton decimalButton;
        private CircularButton num0Button;
        private CircularButton more;
        private CircularButton plusButton;
        private CircularButton num3Button;
        private CircularButton num2Button;
        private CircularButton num1Button;
        private CircularButton minusButton;
        private CircularButton num6Button;
        private CircularButton num5Button;
        private CircularButton num4Button;
        private CircularButton multiplyButton;
        private CircularButton num9Button;
        private CircularButton num8Button;
        private CircularButton num7Button;
        private CircularButton divideButton;
        private CircularButton percentButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

