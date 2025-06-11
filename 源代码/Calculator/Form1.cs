using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jisuan
{
    public partial class Form1 : Form
    {
        private string currentInput = "0";      // 当前输入数字
        private double result = 0;             // 计算结果
        private string pendingOperation = "";  // 待执行的运算符
        private bool isNewCalculation = true;  // 是否开始新计算
        private bool hasError = false;         // 是否处于错误状态
        private double firstOperand = 0;       // 第一个操作数
        private string inputDisplay = "";      // 用于显示用户输入的字符串

        public Form1()
        {
            InitializeComponent();
            InitializeCalculator();
        }

        private void InitializeCalculator()
        {
            currentInput = "0";
            result = 0;
            pendingOperation = "";
            isNewCalculation = true;
            hasError = false;
            firstOperand = 0;
            inputDisplay = "";
            expression.Clear();  // 确保初始化时清空表达式
            UpdateDisplay();
        }
        

        private void UpdateDisplay()
        {
            if (hasError)
            {
                resultLabel.Text = currentInput; // 错误信息直接显示
            }
            else
            {
                // 若输入为空（初始状态），显示"0"
                resultLabel.Text = string.IsNullOrEmpty(inputDisplay) ? "0" : inputDisplay;
            }
        }


        private void HandleNumberInput(string digit)
        {
            try
            {
                if (hasError)
                {
                    InitializeCalculator();
                    return;
                }

                // 如果是新计算或计算已完成，开始新输入
                if (isNewCalculation)
                {
                    currentInput = digit;
                    isNewCalculation = false;
                    if (inputDisplay.EndsWith("+") || inputDisplay.EndsWith("-") || inputDisplay.EndsWith("*") || inputDisplay.EndsWith("÷"))
                    {
                        inputDisplay += digit;
                    }
                    else
                    {
                        inputDisplay = digit;
                    }
                }
                else
                {
                    if (currentInput == "0")
                        currentInput = digit;
                    else
                        currentInput += digit;
                    inputDisplay += digit;
                }

                UpdateDisplay();
            }
            catch (Exception ex)
            {
                HandleError($"{ex.Message}");
            }
        }





        private void circularButton18_Click(object sender, EventArgs e)
        {
            HandleNumberInput("0");
        }

        private void num1Button_Click(object sender, EventArgs e)
        {
            HandleNumberInput("1");
        }

        private void num2Button_Click(object sender, EventArgs e)
        {
            HandleNumberInput("2");
        }

        private void num3Button_Click(object sender, EventArgs e)
        {
            HandleNumberInput("3");
        }

        private void num4Button_Click(object sender, EventArgs e)
        {
            HandleNumberInput("4");
        }

        private void num5Button_Click(object sender, EventArgs e)
        {
            HandleNumberInput("5");
        }

        private void num6Button_Click(object sender, EventArgs e)
        {
            HandleNumberInput("6");
        }

        private void num7Button_Click(object sender, EventArgs e)
        {
            HandleNumberInput("7");
        }

        private void num8Button_Click(object sender, EventArgs e)
        {
            HandleNumberInput("8");
        }

        private void num9Button_Click(object sender, EventArgs e)
        {
            HandleNumberInput("9");
        }


        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (hasError)
            {
                InitializeCalculator();
            }

            // 如果是新计算，初始化小数点输入
            if (isNewCalculation)
            {
                currentInput = "0.";
                isNewCalculation = false;
                if (inputDisplay.EndsWith("+") || inputDisplay.EndsWith("-") || inputDisplay.EndsWith("*") || inputDisplay.EndsWith("÷"))
                {
                    inputDisplay += "0.";
                }
                else
                {
                    inputDisplay = "0.";
                }
            }
            else if (!currentInput.Contains("."))
            {
                currentInput += ".";
                inputDisplay += ".";
            }

            UpdateDisplay();
        }


        private void divideButton_Click(object sender, EventArgs e)
        {
            HandleOperatorInput("÷");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            HandleOperatorInput("*");
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            HandleOperatorInput("-");
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            HandleOperatorInput("+");
        }

        // 处理运算符输入
        private void HandleOperatorInput(string op)
        {
            // 添加：重置错误状态
            if (hasError)
            {
                hasError = false;  // 重置错误状态
                InitializeCalculator();
                return;
            }

            

            // 处理负数输入（如-3）
            if (isNewCalculation && string.IsNullOrEmpty(pendingOperation) && op == "-")
            {
                currentInput = "-";
                isNewCalculation = false;
                inputDisplay = "-";
                UpdateDisplay();
                return;
            }

            //输入运算符时立即添加操作数和运算符到表达式
            if (!string.IsNullOrEmpty(currentInput))
            {
                expression.Add(currentInput);  // 添加当前操作数
            }
            if (!string.IsNullOrEmpty(op))
            {
                expression.Add(op);  // 添加运算符
            }

            pendingOperation = op;
            isNewCalculation = true;
            inputDisplay += op;
            currentInput = "";  // 重置当前输入，准备下一个操作数
            UpdateDisplay();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            // 重置错误状态
            if (hasError)
            {
                hasError = false;
                InitializeCalculator();
                return;
            }

            if (hasError || pendingOperation == "" || isNewCalculation)
                return;

            if (!string.IsNullOrEmpty(currentInput))
            {
                expression.Add(currentInput);
            }

            // 验证表达式完整性
            if (expression.Count < 3)
            {
                HandleError("表达式不完整");
                return;
            }

            Calculate();

            if (!hasError)
            {
                currentInput = FormatResult(result);
                pendingOperation = "";
                isNewCalculation = true;
                inputDisplay = currentInput;
                expression.Clear();  // 清空表达式
            }

            UpdateDisplay();
        }

        // 清除按钮点击事件
        private void acButton_Click(object sender, EventArgs e)
        {
            InitializeCalculator();
        }

        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            if (hasError) return;

            if (currentInput != "0")
            {
                if (double.TryParse(currentInput, out double value))
                {
                    currentInput = FormatResult(-value);
                    if (inputDisplay.EndsWith(currentInput.Substring(1)))
                    {
                        inputDisplay = inputDisplay.Substring(0, inputDisplay.Length - currentInput.Substring(1).Length) + currentInput;
                    }
                    UpdateDisplay();
                }
            }
        }
        //格式化输出
        private string FormatResult(double value)
        {
            if (value == Math.Truncate(value))
                return value.ToString("F0");

            string formatted = value.ToString("G8");
            if (formatted.Contains('E'))
                formatted = value.ToString("F10").TrimEnd('0').TrimEnd('.');

            if (formatted.Contains('.'))
            {
                formatted = formatted.TrimEnd('0').TrimEnd('.');
            }

            return formatted;
        }

        // 错误处理
        private void HandleError(string message)
        {
            currentInput = message;
            hasError = true;
            expression.Clear();
            UpdateDisplay();
        }

        private List<string> expression = new List<string>();


        private void Calculate()
        {
            // 重置错误状态
            hasError = false;
            try
            {
                // 先处理乘除
                ProcessOperations("*÷");
                // 再处理加减
                ProcessOperations("+-");

                // 验证计算结果
                if (expression.Count == 1)
                {
                    result = double.Parse(expression[0]);
                    currentInput = FormatResult(result);
                }
                else
                {
                    HandleError("表达式计算错误");
                }
            }
            catch (DivideByZeroException)
            {
                HandleError("除数不能为零");
            }
            catch (Exception ex)
            {
                HandleError($"{ex.Message}");
            }
        }


        private void ProcessOperations(string operators)
        {
            int index = 0;
            while (index <= expression.Count - 3)  
            {
                string op = expression[index + 1];
                if (operators.Contains(op))
                {
                    double left = double.Parse(expression[index]);
                    double right = double.Parse(expression[index + 2]);
                    double result = PerformOperation(left, op, right);

                    // 用计算结果替换三个元素
                    expression[index] = result.ToString();
                    expression.RemoveAt(index + 1);
                    expression.RemoveAt(index + 1);
                    // 不增加index
                }
                else
                {
                    index++;
                }
            }
        }

        private double PerformOperation(double left, string op, double right)
        {
            switch (op)
            {
                case "+": return left + right;
                case "-": return left - right;
                case "*": return left * right;
                case "÷":
                    if (right == 0) throw new DivideByZeroException();
                    return left / right;
                default: throw new ArgumentException("无效运算符");
            }
        }



        // 百分号按钮点击事件
        private void percentButton_Click(object sender, EventArgs e)
        {
            if (hasError)
            {
                InitializeCalculator();
                return;
            }

            if (double.TryParse(currentInput, out double value))
            {
                double percentValue = value / 100;
                currentInput = FormatResult(percentValue);
                // 显示为百分比形式
                inputDisplay = value + "%"; 
                isNewCalculation = true;
                UpdateDisplay();
            }
            else
            {
                HandleError("转换错误");
            }
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void more_Click(object sender, EventArgs e)
        {
            using (MoreOptionsDialog dialog = new MoreOptionsDialog())
            {
                dialog.Owner = this;
                dialog.ShowDialog();

                if (dialog.DialogResult == DialogResult.OK)
                {
                    // 选择返回
                    this.Show();
                }
                else if (dialog.DialogResult == DialogResult.Yes)
                {
                    // 选择跳转到科学计算器
                    this.Hide();
                    using (ScienceCalculator calc = new ScienceCalculator())
                    {
                        calc.Owner = this;
                        calc.ShowDialog();
                        this.Show();
                    }
                }
            }
        }
    }
}
