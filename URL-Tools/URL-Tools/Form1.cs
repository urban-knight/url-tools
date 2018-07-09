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
        static DeviceList devices = new DeviceList();

        public Form1()
        {
            InitializeComponent();
            DataGridViewComboBoxColumn deviceColumn = new DataGridViewComboBoxColumn();
            deviceColumn.Items.AddRange(devices.GetDevices());
            deviceColumn.Name = "deviceColumn";
            deviceColumn.HeaderText = "Device";
            deviceColumn.Width = 150;
            deviceColumn.AutoComplete = true;
            outerdataGridView.Columns.Insert(0, deviceColumn);
        }

        public static OuterResult getOuterResult(string url, string userAgent)
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
                    req.UserAgent = userAgent;
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

        public static HttpWebResponse getInnerResult(string url)
        {
            if (string.IsNullOrWhiteSpace(url)) { return null; }

                HttpWebRequest req = null;
                HttpWebResponse res = null;
                try
                {
                    req = (HttpWebRequest)HttpWebRequest.Create(url);
                    req.Method = "HEAD";
                    req.AllowAutoRedirect = false;
                    res = (HttpWebResponse)req.GetResponse();
                    return res;
                }
                catch (WebException e)
                {
                    if (e.Status == WebExceptionStatus.ProtocolError)
                    {
                        return (HttpWebResponse)e.Response;
                    }
                    else { return null; }
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
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in outerdataGridView.Rows)
            {
                if (row.Cells[outerdataGridView.Columns["entryPoint"].Index].Value != null) {
                    string _url = row.Cells[outerdataGridView.Columns["entryPoint"].Index].Value.ToString();
                    string userAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/525.19 (KHTML, like Gecko) Chrome/1.0.154.53 Safari/525.19";
                    if (row.Cells[outerdataGridView.Columns["deviceColumn"].Index].Value != null)
                    {
                        string deviceName = row.Cells[outerdataGridView.Columns["deviceColumn"].Index].Value.ToString();
                        Device d = devices.FindByName(deviceName);
                        userAgent = d.Value;
                    }
                    row.Cells[outerdataGridView.Columns["endUrl"].Index].Value = "";
                    row.Cells[outerdataGridView.Columns["firstRedirect"].Index].Value = "";
                    row.Cells[outerdataGridView.Columns["secondRedirect"].Index].Value = "";
                    row.Cells[outerdataGridView.Columns["thirdRedirect"].Index].Value = "";

                    OuterResult res = getOuterResult(@_url, @userAgent);
                    row.Cells[outerdataGridView.Columns["endUrl"].Index].Value = (int)res.Endpoint.statusCode + ": " + res.Endpoint.endURL;
                    if (res.Redirects.Count > 0)
                        row.Cells[outerdataGridView.Columns["firstRedirect"].Index].Value = (int)res.Redirects[0].statusCode + ": " + res.Redirects[0].endURL;
                    if (res.Redirects.Count > 1)
                        row.Cells[outerdataGridView.Columns["secondRedirect"].Index].Value = (int)res.Redirects[1].statusCode + ": " + res.Redirects[1].endURL;
                    if (res.Redirects.Count > 2)
                        row.Cells[outerdataGridView.Columns["thirdRedirect"].Index].Value = (int)res.Redirects[2].statusCode + ": " + res.Redirects[2].endURL;
                }

            }
            if (!string.IsNullOrEmpty((string)baseURL_comboBox.Text))
            {
                string _baseUrl = baseURL_comboBox.Text;
                foreach (DataGridViewRow row in innerdataGridView.Rows)
                {
                    if (row.Cells[innerdataGridView.Columns["urlPath"].Index].Value != null)
                    {
                        row.Cells[innerdataGridView.Columns["resCode"].Index].Value = "";
                        row.Cells[innerdataGridView.Columns["resLocation"].Index].Value = "";
                        row.Cells[innerdataGridView.Columns["resContentType"].Index].Value = "";
                        row.Cells[innerdataGridView.Columns["resKeepAlive"].Index].Value = "";
                        row.Cells[innerdataGridView.Columns["resServer"].Index].Value = "";
                        row.Cells[innerdataGridView.Columns["resPoweredBy"].Index].Value = "";
                        string _path = row.Cells[innerdataGridView.Columns["urlPath"].Index].Value.ToString();
                        Uri url = new Uri(new Uri(_baseUrl), _path);
                        HttpWebResponse res = getInnerResult(url.AbsoluteUri);
                        if (res != null)
                        {
                            row.Cells[innerdataGridView.Columns["resCode"].Index].Value = (int)res.StatusCode + ":" + res.StatusCode;
                            row.Cells[innerdataGridView.Columns["resLocation"].Index].Value = res.Headers["Location"];
                            row.Cells[innerdataGridView.Columns["resContentType"].Index].Value = res.Headers["Content-Type"];
                            row.Cells[innerdataGridView.Columns["resKeepAlive"].Index].Value = res.Headers["Keep-Alive"];
                            row.Cells[innerdataGridView.Columns["resServer"].Index].Value = res.Headers["Server"];
                            row.Cells[innerdataGridView.Columns["resPoweredBy"].Index].Value = res.Headers["X-Powered-By"];
                        }
                    }
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
                        Map map = loadMapFromJSON(_path);

                        if (map.outer != null && map.outer.Count > 0)
                        {
                            populateOuter(map.outer);
                        }

                        if (map.inner != null && map.inner.Count > 0)
                        {
                            populateInner(map.inner);
                        }
                    }
                }
            }
        }

        private void populateOuter(List<string> urls)
        {
            DataGridViewComboBoxColumn deviceCol = (DataGridViewComboBoxColumn)outerdataGridView.Columns["deviceColumn"];
            foreach (string url in urls){
                DataGridViewRow row = (DataGridViewRow)outerdataGridView.Rows[0].Clone();
                row.Cells[outerdataGridView.Columns["deviceColumn"].Index].Value = deviceCol.Items[0];
                row.Cells[outerdataGridView.Columns["entryPoint"].Index].Value = url;
                outerdataGridView.Rows.Add(row);
                baseURL_comboBox.Items.Add(url);
            }
        }

        private void populateInner(List<string> urls)
        {
            foreach (string url in urls)
            {
                DataGridViewRow row = (DataGridViewRow)innerdataGridView.Rows[0].Clone();
                row.Cells[innerdataGridView.Columns["urlPath"].Index].Value = url;
                innerdataGridView.Rows.Add(row);
            }
        }

        private Map loadMapFromJSON(string _path)
        {
            var jsonText = File.ReadAllText(_path);
            Map map = JsonConvert.DeserializeObject<Map>(jsonText);


            foreach(string _url in map.outer)
            {
                if (!isValid(_url)) map.outer.Remove(_url);
            }

            return map;
        }

        private void saveMap(string _path)
        {
            var outerRows = outerdataGridView.Rows;
            var innerRows = innerdataGridView.Rows;
            Map map = new Map();

            foreach (DataGridViewRow row in outerRows)
            {
                var val = row.Cells[outerdataGridView.Columns["entryPoint"].Index].Value;
                if (val != null) {
                    string _url = row.Cells[outerdataGridView.Columns["entryPoint"].Index].Value.ToString();
                    if (isValid(_url))
                    {
                        map.outer.Add(_url);
                    }
                }
            }

            foreach (DataGridViewRow row in innerRows)
            {
                var val = row.Cells[innerdataGridView.Columns["urlPath"].Index].Value;
                if (val != null)
                {
                    string _url = row.Cells[innerdataGridView.Columns["urlPath"].Index].Value.ToString();
                    map.inner.Add(_url);
                }
            }

            string json = JsonConvert.SerializeObject(map);
            System.IO.File.WriteAllText(_path, json);
        }

        private void saveMap_button_Click(object sender, EventArgs e)
        {
            string _path = selectMap_textBox.Text;
            if (_path != "" && _path != null)
            {
                saveMap(_path);
            }
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

            baseURL_comboBox.Items.RemoveAt(e.RowIndex);
        }

        private void outerdataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (outerdataGridView.Rows[e.RowIndex].IsNewRow) { return; }
            string url = outerdataGridView.Rows[e.RowIndex].Cells[outerdataGridView.Columns["entryPoint"].Index].Value.ToString();
            int index = baseURL_comboBox.Items.IndexOf(url);
            if (index == -1)
            {
                if (baseURL_comboBox.Items.Count == e.RowIndex)
                {
                    baseURL_comboBox.Items.Add(url);
                } else
                {
                    baseURL_comboBox.Items[e.RowIndex] = url;
                }
            }
        }
    }
}
