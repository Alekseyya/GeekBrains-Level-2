using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class TesDelegate
    {
        public delegate void ShowMessage(String msg);
        //public ShowMessage showmess;
        public event ShowMessage showmessage;
        public event ShowMessage showmessage1;

        public TesDelegate()
        {
            
        }
        public void Message(String msg)
        {
            Console.WriteLine($"Выполнилось событие 1! {msg}");
        }

        public void Message1(String msg)
        {
            Console.WriteLine($"Выполнилось событие 2! {msg}");
        }

        public void Acces(int i)
        {
            if (i == 1)
            {
                showmessage("Hello");
            }else
            {
                showmessage1("World");
            }
        }
    }
}
