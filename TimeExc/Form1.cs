using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeExc
{
    public partial class Form1 : Form
    {
        string[] arr;
        public Form1()
        {
            InitializeComponent();
        }
        
            
        private void btn_start_Click(object sender, EventArgs e)
        {
            string str= txt_input.Text.Trim();
            arr = str.Split(' ');
            
            {
                
                for (int i=0;i<arr.Length;i++)
                {
                    txt_output.AppendText(arr[i]+" ");
                    
                }
            }   
                
        }
        
        private void btn_calc_Click(object sender, EventArgs e)
        {
            txt_output.Text = string.Empty;
            if (arr != null && arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for(int j=i+1;j< arr.Length;j++)
                    {
                        if (arr[j] == "+" || arr[j] == "-" || arr[j] == "*" || arr[j] == "/")
                        {
                            string temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                    }
                    txt_output.AppendText(arr[i] + " ");
                }  
            }
              

        }
    }
}
