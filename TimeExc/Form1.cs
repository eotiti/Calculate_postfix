using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TimeExc
{
    public partial class Form1 : Form
    {
        string[] arr;
        public Form1()
        {
            InitializeComponent();
        }
        public static bool IsOperand(string str)
        {
            return Regex.Match(str, @"^\d+$|^([a-z]|[A-Z])$").Success;
        }
        public float EvaluatePostfix(string hauto)
        {
            Stack<float> stack = new Stack<float>();
            hauto = hauto.Trim();

            IEnumerable<string> enumer = hauto.Split(' ');

            foreach (string kytu in enumer)
            {
                //  xét phần tử tiếp theo nếu ko là toán tử thì push vào stack
                if (IsOperand(kytu))
                {
                    stack.Push(float.Parse(kytu));
                    
                }
                else
                {
                    // nếu là toán tử lôi 2 thằng vừa push ra ròi tính theo switch ... case
                    float s1 = stack.Pop();
                    float s2 = stack.Pop();
                    
                    
                    switch (kytu)
                    {
                        case "+":
                            s2 = s2 + s1;
                            break;
                        case "-":
                            s2 = s2 - s1;
                            break;
                        case "*":
                            s2 = s2 * s1;
                            break;
                        case "/":
                            s2 = s2 / s1;
                            break;
                        case "%":
                            s2 = s2 % s1;
                            break;
                    }
                    stack.Push(s2);// tính xong push kq vào lại
                }
            }
            return stack.Pop();// kết quả cuối cùng
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            string str = txt_input.Text.ToString();// gán dữ liệu
            float kq = EvaluatePostfix(str);// xuất kết quả
            txt_output.Text = kq.ToString();//in kết quả
                
        }
    }
}
