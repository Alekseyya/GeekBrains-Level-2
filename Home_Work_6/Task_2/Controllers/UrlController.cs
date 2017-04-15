using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2.Controllers
{
    

    public class UrlController
    {
        
        private WebRequest _request;
        Form1 form1;

        public UrlController(Form1 form1)
        {
            this.form1 = form1;
            form1.SetController(this);

        }

        public async void MakeRequest()
        {
            
            foreach(var i in this.form1.ListUrl)
            {
                System.Diagnostics.Stopwatch sw = new Stopwatch();
                sw.Start();
                var errorOrLength = ResponseResult(i.Name).GetAwaiter().GetResult();
                sw.Stop();
                i.ErrorOrLength = errorOrLength;
                i.StopWatch = (sw.ElapsedMilliseconds / 100.0).ToString();
            }

           
        }

        

        private void RequestSettings()
        {
            _request.Method = "GET";
            //_request.KeepAlive = false;
            _request.Timeout = 1000;
            _request.ContentType = "text/html";
        }

        private Task<string> ResponseResult(string url)
        {
            try
            {
                _request = WebRequest.CreateHttp(url);
                RequestSettings();
                WebResponse response = _request.GetResponse();


                return Task.Run(() =>
                {
                    string result = string.Empty;
                    using (var stream = response.GetResponseStream())
                    using (var sr = new StreamReader(stream))
                        result = sr.ReadToEnd();
                    return result.Length.ToString();
                });
            }
            catch (Exception ex )
            {
                return Task.Run(()=>
                {
                        return ex.Message;
                });
            }
            
        }

    }
}
