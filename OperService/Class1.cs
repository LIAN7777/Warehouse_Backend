using System;
using System.IO;

namespace OperService
{
    public class Class1
    {
        public void Print(string content)
        {
            using (StreamWriter sw = new StreamWriter("Oper.text"))
            {
                sw.WriteLine(content);
            }
        }
    }
}
