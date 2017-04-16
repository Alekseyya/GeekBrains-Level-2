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

        public async Task  MakeRequest()
        {
            await Task.Run(() =>
            {
                foreach (var i in this.form1.ListUrl)
                {
                    System.Diagnostics.Stopwatch sw = new Stopwatch();
                    sw.Start();
                    var errorOrLength = ResponseResult(i.Name).GetAwaiter().GetResult();
                    sw.Stop();
                    i.ErrorOrLength = errorOrLength;
                    i.StopWatch = (sw.ElapsedMilliseconds / 100.0).ToString();
                }

            });
            
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

        public async Task ReadFile()
        {
            
            await Task.Run(() =>
            {
                form1.ListUrl = new List<Model.Url>();
                var fileStream = new FileStream("Sites.txt", FileMode.Open, FileAccess.Read);
                using (StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        this.form1.ListUrl.Add(new Model.Url(line, "", ""));
                    }
                }
               
            });
        }

    }
}
