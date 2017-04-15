using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public class Memo
        {
            public string Text { get; set; }
            public  DateTime Date { get; set; }

            public Memo()
            {
                Text = "aaaaaaaa";
                Date = DateTime.Now;

            }

        }

        public class MemoFile
        {
            List<Memo> list = new List<Memo>();

            public List<Memo> Memos
            {
                get { return list; }
                set { list = value; }
            }

            public DateTime[] GetDates
            {
                get
                {
                    //Использование LINQ
                    var res = from el in list select el.Date;
                    return res.ToArray();
                }
            }
        }



        BindingSource bindSrc = new BindingSource();
        Memo memo = new Memo();



        public Form1()
        {
            InitializeComponent();
            MemoFile memoFiles = new MemoFile();
            memoFiles.Memos.Add(new Memo());
            bindSrc.DataSource = memoFiles;
            bindSrc.DataMember = "Memos";

            
            //связывание с датой
            dtpMemo.DataBindings.Add("Value", bindSrc, "Date");
            //обновление
            dtpMemo.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            tbMemo.DataBindings.Add("Text", bindSrc, "Text");
            tbMemo.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show((bindSrc.DataSource as MemoFile).Memos[0].Date + " + " + (bindSrc.DataSource as MemoFile).Memos[0].Text);
        }
    }
}
