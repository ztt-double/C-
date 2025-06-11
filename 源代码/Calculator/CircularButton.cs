using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace jisuan
{
    public class CircularButton : Button
    {
        // 按钮状态常量
        private const int CS_DROPSHADOW = 0x20000;
        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_MOUSELEAVE = 0x02A3;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_LBUTTONUP = 0x0202;

        // 自定义属性
        private Color _hoverColor = Color.FromArgb(240, 240, 240);
        private Color _pressedColor = Color.FromArgb(220, 220, 220);
        private Color _borderColor = Color.FromArgb(150, 150, 150);
        private int _borderWidth = 1;
        private bool _isHovered = false;
        private bool _isPressed = false;
        private bool _isFocused = false;
        private bool _showBorder = true;
        private bool _showShadow = false;
        private bool _useGradient = true;

        public CircularButton()
        {
            // 初始化按钮基础属性
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(60, 60);
            ForeColor = Color.White;
            Margin = new Padding(5);
            DoubleBuffered = true; // 启用双缓冲减少闪烁
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        #region 自定义属性

        [Category("Appearance")]
        [Description("按钮悬停时的颜色")]
        public Color HoverColor
        {
            get { return _hoverColor; }
            set { _hoverColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("按钮按下时的颜色")]
        public Color PressedColor
        {
            get { return _pressedColor; }
            set { _pressedColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("按钮边框颜色")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("按钮边框宽度")]
        public int BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value > 0 ? value : 0; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("是否显示边框")]
        public bool ShowBorder
        {
            get { return _showBorder; }
            set { _showBorder = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("是否显示阴影")]
        public bool ShowShadow
        {
            get { return _showShadow; }
            set { _showShadow = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("是否使用渐变填充")]
        public bool UseGradient
        {
            get { return _useGradient; }
            set { _useGradient = value; Invalidate(); }
        }

        #endregion

        // 重写CreateParams添加阴影效果
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (_showShadow)
                    cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        // 重写OnPaint方法实现自定义绘制
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // 抗锯齿
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            int diameter = Math.Min(Width, Height) - (_showBorder ? _borderWidth * 2 : 0);
            int x = (_showBorder ? _borderWidth : 0);
            int y = (_showBorder ? _borderWidth : 0);

            // 创建圆形路径
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(x, y, diameter, diameter);
                Region = new Region(path);

                // 绘制背景
                Color fillColor = _isPressed ? _pressedColor : (_isHovered ? _hoverColor : BackColor);

                if (_useGradient && fillColor != Color.Transparent)
                {
                    // 创建渐变画刷
                    using (LinearGradientBrush gradientBrush = new LinearGradientBrush(
                        new Point(x, y),
                        new Point(x, y + diameter),
                        ControlPaint.Light(fillColor, 0.3f),
                        ControlPaint.Dark(fillColor, 0.2f)))
                    {
                        e.Graphics.FillEllipse(gradientBrush, x, y, diameter, diameter);
                    }
                }
                else
                {
                    using (SolidBrush solidBrush = new SolidBrush(fillColor))
                    {
                        e.Graphics.FillEllipse(solidBrush, x, y, diameter, diameter);
                    }
                }

                // 绘制边框
                if (_showBorder && _borderWidth > 0)
                {
                    using (Pen borderPen = new Pen(_borderColor, _borderWidth))
                    {
                        e.Graphics.DrawEllipse(borderPen, x, y, diameter, diameter);
                    }
                }

                // 绘制焦点框
                if (_isFocused && Focused)
                {
                    using (Pen focusPen = new Pen(Color.FromArgb(100, Color.Blue), 1))
                    {
                        focusPen.DashStyle = DashStyle.Dash;
                        e.Graphics.DrawEllipse(focusPen, x + 3, y + 3, diameter - 6, diameter - 6);
                    }
                }
            }

            // 绘制按钮文本
            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                new Rectangle(x, y, diameter, diameter),
                ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);
        }

        // 处理鼠标事件
        protected override void OnMouseEnter(EventArgs e)
        {
            _isHovered = true;
            Invalidate(); // 触发重绘
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _isHovered = false;
            _isPressed = false;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isPressed = true;
                Invalidate();
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _isPressed = false;
            Invalidate();
            base.OnMouseUp(e);
        }

        // 处理焦点事件
        protected override void OnGotFocus(EventArgs e)
        {
            _isFocused = true;
            Invalidate();
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            _isFocused = false;
            Invalidate();
            base.OnLostFocus(e);
        }

        // 处理尺寸变化
        protected override void OnSizeChanged(EventArgs e)
        {
            // 保持按钮为正方形
            if (Width != Height)
            {
                int size = Math.Min(Width, Height);
                Width = size;
                Height = size;
            }
            base.OnSizeChanged(e);
        }
    }
}