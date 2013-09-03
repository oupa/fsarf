using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Web;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace FSAircraftRepositoryFactory
{
    class Connector
    {
        public static string CheckVersion()
        {
            string args = "";
            string uri = "http://new.csav.cz/upload/fsarf/CheckVersion.php";
            try
            {
                string response = NetRequest(args, uri, "CheckVersion", true);
                return (ParseCheckVersion(response));
            }
            catch (Exception e)
            {
                Logger.Log("CheckVersion: Exception : " + e.ToString());
                return null;
            }
        }

        public static string ParseCheckVersion(string response)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(response);
            XmlElement node = (XmlElement)xml.GetElementsByTagName("fsarf")[0];
            string message = node.GetAttribute("message");
            if (message == "OK")
            {
                Logger.Log("Check Version response - OK");
                return node.GetAttribute("version");
            }
            else
            {
                Logger.Log("Check Version response - Error");
                Logger.Log(response);
                return null;
            }
        }

        public static string NetRequest(string post, string uri, string action, bool verbose)
        {
            try
            {
                StreamReader reader;
                Stream dataStream;
                WebResponse response;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.UserAgent = "CSAV/FSARF";
                request.Method = "POST";
                request.KeepAlive = false;
                request.ContentType = "application/x-www-form-urlencoded";
                string postData = post;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentLength = byteArray.Length;
                Logger.Log("NetRequest : action : " + action);
                if (action != "GetLogin")
                {
                    Logger.Log("NetRequest : postData : " + post);
                }
                dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                Cursor.Current = Cursors.WaitCursor;
                response = request.GetResponse();
                dataStream = response.GetResponseStream();
                reader = new StreamReader(dataStream);
                string s = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
                return s;
            }
            catch (Exception ex)
            {
                if (verbose)
                {
                    MessageBox.Show(ex.ToString(), "Web request error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Logger.Log("SemikRequest: Exception : " + ex.ToString());
                return "";
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

    }
}
