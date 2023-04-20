using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RememberPassword.LogicBase
{
    public class AutoCreatePass
    {
        private string pass;
        private int length;
        public string Pass { get => pass; set => pass = value; }
        public int Length { get => length; set => length = value; }
        public AutoCreatePass()
        {
            this.pass = null;
            this.length= 0;
        }
        public AutoCreatePass(int lenth)
        {
            this.length = lenth;
        }
        private bool  IsValidChar(char value)
        {
            return ((value >= 48 && value <= 57) || (value >= 64 && value <= 90) || (value >= 97 && value <= 122));
        }
        public string CreatePass()
        {
            if (length == 0)
                return null;
            for( int i = 0; i < length; i++)
            {
                bool flag = true;
                do
                {
                    Random randChar = new Random();
                    char temp = Convert.ToChar(randChar.Next(48, 122));
                    flag = IsValidChar(temp);
                    if (flag)
                    {
                        this.pass += temp;
                    }
                } while (!flag);
                if(this.pass.Contains("@") && i > length / 2)
                {
                    this.pass += "@";
                    length--;
                }
            }
            this.pass += "\0";
            return this.pass;
        }
    }
}
