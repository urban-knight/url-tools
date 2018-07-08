using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace URL_Tools
{
    public partial class Form1 : Form
    {
        private BindingSource source = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        public static OuterResult getOuterResult(string url)
        {
            OuterResult result = new OuterResult();
            result.Redirects = new List<RequestResult>();

            if (string.IsNullOrWhiteSpace(url))
            {
                result.Endpoint = new RequestResult("", HttpStatusCode.BadGateway, "");
                return result;
            }

            int maxRedirCount = 4;
            string newUrl = url;
            bool redirected = false;
            HttpStatusCode status = HttpStatusCode.BadGateway;

            do
            {
                HttpWebRequest req = null;
                HttpWebResponse res = null;
                try
                {
                    req = (HttpWebRequest)HttpWebRequest.Create(url);
                    req.Method = "HEAD";
                    req.AllowAutoRedirect = false;
                    res = (HttpWebResponse)req.GetResponse();
                    switch (res.StatusCode)
                    {
                        case HttpStatusCode.OK:
                             result.Endpoint = new RequestResult(url, res.StatusCode, newUrl);
                             return result;
                        case HttpStatusCode.Redirect:
                        case HttpStatusCode.MovedPermanently:
                        case HttpStatusCode.RedirectKeepVerb:
                        case HttpStatusCode.RedirectMethod:
                             newUrl = res.Headers["Location"];
                             status = res.StatusCode;
                             redirected = true;
                             result.Redirects.Add(new RequestResult(url, res.StatusCode, newUrl));

                            if (newUrl.IndexOf("://", System.StringComparison.Ordinal) == -1)
                            {
                                Uri u = new Uri(new Uri(url), newUrl);
                                newUrl = u.ToString();
                            }
                            break;
                        default:
                            result.Endpoint = new RequestResult(url, res.StatusCode, newUrl);
                            return result;
                    }
                    url = newUrl;
                }
                catch (WebException e)
                {
                    if (e.Status == WebExceptionStatus.ProtocolError)
                    {
                        result.Endpoint = new RequestResult(url, ((HttpWebResponse)e.Response).StatusCode, newUrl);
                        return result;
                    }
                    else {
                        result.Endpoint = new RequestResult(url, HttpStatusCode.BadGateway, newUrl);
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    if (res != null)
                        res.Close();
                }
            } while (maxRedirCount-- > 0);
            result.Endpoint = new RequestResult(url, HttpStatusCode.BadGateway, newUrl);
            return result;
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in outerdataGridView.Rows)
            {
                if (row.Cells[outerdataGridView.Columns["entryPoint"].Index].Value != null) {
                    string _url = row.Cells[outerdataGridView.Columns["entryPoint"].Index].Value.ToString();
                    OuterResult res = getOuterResult(@_url);
                    row.Cells[outerdataGridView.Columns["endUrl"].Index].Value = (int)res.Endpoint.statusCode + ": " + res.Endpoint.endURL;
                    if (res.Redirects.Count > 0)
                        row.Cells[outerdataGridView.Columns["firstRedirect"].Index].Value = (int)res.Redirects[0].statusCode + ": " + res.Redirects[0].endURL;
                    if (res.Redirects.Count > 1)
                        row.Cells[outerdataGridView.Columns["secondRedirect"].Index].Value = (int)res.Redirects[1].statusCode + ": " + res.Redirects[1].endURL;
                    if (res.Redirects.Count > 2)
                        row.Cells[outerdataGridView.Columns["thirdRedirect"].Index].Value = (int)res.Redirects[2].statusCode + ": " + res.Redirects[2].endURL;
                }

            }
        }

        public static bool isValid(string url)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return result;
        }

        private void outerdataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == outerdataGridView.Columns["entryPoint"].Index)
            {
                outerdataGridView.Rows[e.RowIndex].ErrorText = "";
                if (outerdataGridView.Rows[e.RowIndex].IsNewRow) { return; }
                if (!isValid(e.FormattedValue.ToString()))
                {
                    e.Cancel = true;
                    outerdataGridView.Rows[e.RowIndex].ErrorText = "The URL has unsupported format. Please paste the valid URL.";
                }
            }
        }

        private void selectMap_button_Click(object sender, EventArgs e)
        {
            using (var selectFileDialog = new OpenFileDialog())
            {
                selectFileDialog.DefaultExt = ".json";
                selectFileDialog.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                selectFileDialog.Filter = "JSON file (*.json) | *.json";
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string _path = selectFileDialog.FileName;
                    selectMap_textBox.Text = _path;
                    if (_path != "" && _path != null)
                    {
                        List<Url> urls = loadURLsFromJSON(_path);
                        populateOuter(urls);
                    }
                }
            }
        }

        private void populateOuter(List<Url> urls)
        {
            foreach (Url url in urls){
                DataGridViewRow row = (DataGridViewRow)outerdataGridView.Rows[0].Clone();
                row.Cells[0].Value = url.Value;
                outerdataGridView.Rows.Add(row);
            }
        }

        private List<Url> loadURLsFromJSON(string _path)
        {
            List<Url> urls = new List<Url>();
            var jsonText = File.ReadAllText(_path);
            List<string> strUrls = JsonConvert.DeserializeObject<List<string>>(jsonText);
            foreach(string _url in strUrls)
            {
                if (isValid(_url))
                {
                    urls.Add(new Url(_url));
                }
            }

            return urls;
        }

        private void saveOuterMap(string _path)
        {
            var rows = outerdataGridView.Rows;
            List<string> urls = new List<string>();

            foreach (DataGridViewRow row in rows)
            {
                var val = row.Cells[outerdataGridView.Columns["entryPoint"].Index].Value;
                if (val != null) {
                    string _url = row.Cells[outerdataGridView.Columns["entryPoint"].Index].Value.ToString();
                    if (isValid(_url))
                    {
                        urls.Add(_url);
                    }
                }
            }
            string json = JsonConvert.SerializeObject(urls);
            System.IO.File.WriteAllText(_path, json);
        }

        private void outerdataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (outerdataGridView.Rows.Count != 0)
            {
                options_groupBox.Visible = true;
            }

        }

        private void outerdataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (outerdataGridView.Rows.Count <= 1)
            {
                options_groupBox.Visible = false;
            }
        }

        private void saveOuters_button_Click(object sender, EventArgs e)
        {
            string _path = selectMap_textBox.Text;
            if (_path != "" && _path != null)
            {
                saveOuterMap(_path);
            }
        }
    }
}
