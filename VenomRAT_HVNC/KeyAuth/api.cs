using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KeyAuth
{
    public class api
    {
        public api(string name, string ownerid, string secret, string version)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
            {
                MessageBox.Show("Application not setup correctly. Please watch video link found in Login.cs");
                Environment.Exit(0);
            }
            this.name = name;
            this.ownerid = ownerid;
            this.secret = secret;
            this.version = version;
        }

        public void init()
        {
            this.enckey = encryption.sha256(encryption.iv_key());
            string text = encryption.sha256(encryption.iv_key());
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
            nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
            nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
            nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
            nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
            nameValueCollection["init_iv"] = text;
            NameValueCollection post_data = nameValueCollection;
            string text2 = api.req(post_data);
            if (text2 == "KeyAuth_Invalid")
            {
                MessageBox.Show("Application not found.");
                Environment.Exit(0);
            }
            text2 = encryption.decrypt(text2, this.secret, text);
            api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
            if (response_structure.success)
            {
                this.sessionid = response_structure.sessionid;
                this.initzalized = true;
                return;
            }
            if (response_structure.message == "invalidver")
            {
                Process.Start(response_structure.download);
                Environment.Exit(0);
                return;
            }
            MessageBox.Show(response_structure.message);
            Environment.Exit(0);
        }

        public bool register(string username, string pass, string key)
        {
            if (!this.initzalized)
            {
                MessageBox.Show("Please initzalize first");
                return false;
            }
            string value = WindowsIdentity.GetCurrent().User.Value;
            string text = encryption.sha256(encryption.iv_key());
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
            nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
            nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
            nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
            nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
            nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
            nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
            nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
            nameValueCollection["init_iv"] = text;
            NameValueCollection post_data = nameValueCollection;
            string text2 = api.req(post_data);
            text2 = encryption.decrypt(text2, this.enckey, text);
            api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
            if (!response_structure.success)
            {
                MessageBox.Show(response_structure.message);
                return false;
            }
            this.load_user_data(response_structure.info);
            return true;
        }

        public bool login(string username, string pass)
        {
            if (!this.initzalized)
            {
                MessageBox.Show("Please initzalize first");
                return false;
            }
            string value = WindowsIdentity.GetCurrent().User.Value;
            string text = encryption.sha256(encryption.iv_key());
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
            nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
            nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
            nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
            nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
            nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
            nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
            nameValueCollection["init_iv"] = text;
            NameValueCollection post_data = nameValueCollection;
            string text2 = api.req(post_data);
            text2 = encryption.decrypt(text2, this.enckey, text);
            api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
            if (!response_structure.success)
            {
                MessageBox.Show(response_structure.message);
                return false;
            }
            this.load_user_data(response_structure.info);
            return true;
        }

        public void upgrade(string username, string key)
        {
            if (!this.initzalized)
            {
                MessageBox.Show("Please initzalize first");
                return;
            }
            string value = WindowsIdentity.GetCurrent().User.Value;
            string text = encryption.sha256(encryption.iv_key());
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
            nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
            nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
            nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
            nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
            nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
            nameValueCollection["init_iv"] = text;
            NameValueCollection post_data = nameValueCollection;
            string text2 = api.req(post_data);
            text2 = encryption.decrypt(text2, this.enckey, text);
            api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
            if (!response_structure.success)
            {
                MessageBox.Show(response_structure.message);
                Environment.Exit(0);
                return;
            }
            MessageBox.Show(response_structure.message);
        }

        public bool license(string key)
        {
            if (!this.initzalized)
            {
                MessageBox.Show("Please initzalize first");
                return false;
            }
            string value = WindowsIdentity.GetCurrent().User.Value;
            string text = encryption.sha256(encryption.iv_key());
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
            nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
            nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
            nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
            nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
            nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
            nameValueCollection["init_iv"] = text;
            NameValueCollection post_data = nameValueCollection;
            string text2 = api.req(post_data);
            text2 = encryption.decrypt(text2, this.enckey, text);
            api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
            if (!response_structure.success)
            {
                MessageBox.Show(response_structure.message);
                Environment.Exit(0);
                return false;
            }
            this.load_user_data(response_structure.info);
            return true;
        }

        public void ban()
        {
            if (!this.initzalized)
            {
                MessageBox.Show("Please initzalize first");
                return;
            }
            string text = encryption.sha256(encryption.iv_key());
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
            nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
            nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
            nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
            nameValueCollection["init_iv"] = text;
            NameValueCollection post_data = nameValueCollection;
            string text2 = api.req(post_data);
            text2 = encryption.decrypt(text2, this.enckey, text);
            api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
            if (!response_structure.success)
            {
                MessageBox.Show(response_structure.message);
                Environment.Exit(0);
            }
        }

        public string var(string varid)
        {
            if (!this.initzalized)
            {
                MessageBox.Show("Please initzalize first");
                return "";
            }
            string value = WindowsIdentity.GetCurrent().User.Value;
            string text = encryption.sha256(encryption.iv_key());
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
            nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
            nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
            nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
            nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
            nameValueCollection["init_iv"] = text;
            NameValueCollection post_data = nameValueCollection;
            string text2 = api.req(post_data);
            text2 = encryption.decrypt(text2, this.enckey, text);
            api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
            if (!response_structure.success)
            {
                MessageBox.Show(response_structure.message);
                return "";
            }
            return response_structure.message;
        }

        public void webhook(string webid, string param)
        {
            if (!this.initzalized)
            {
                MessageBox.Show("Please initzalize first");
                return;
            }
            string value = WindowsIdentity.GetCurrent().User.Value;
            string text = encryption.sha256(encryption.iv_key());
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
            nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
            nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
            nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
            nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
            nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
            nameValueCollection["init_iv"] = text;
            NameValueCollection post_data = nameValueCollection;
            string text2 = api.req(post_data);
            text2 = encryption.decrypt(text2, this.enckey, text);
            api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
            if (!response_structure.success)
            {
                MessageBox.Show(response_structure.message);
            }
        }

        public byte[] download(string fileid)
        {
            if (!this.initzalized)
            {
                MessageBox.Show("Please initzalize first");
                return new byte[0];
            }
            string text = encryption.sha256(encryption.iv_key());
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
            nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
            nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
            nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
            nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
            nameValueCollection["init_iv"] = text;
            NameValueCollection post_data = nameValueCollection;
            string text2 = api.req(post_data);
            text2 = encryption.decrypt(text2, this.enckey, text);
            api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
            if (!response_structure.success)
            {
                MessageBox.Show(response_structure.message);
            }
            return encryption.str_to_byte_arr(response_structure.contents);
        }

        public void log(string message)
        {
            if (!this.initzalized)
            {
                MessageBox.Show("Please initzalize first");
                return;
            }
            string text = encryption.sha256(encryption.iv_key());
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
            nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
            nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
            nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
            nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
            nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
            nameValueCollection["init_iv"] = text;
            NameValueCollection post_data = nameValueCollection;
            api.req(post_data);
        }

        private static string req(NameValueCollection post_data)
        {
            string result;
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] bytes = webClient.UploadValues("http://auth.codeme.cloud/api/1.0/", post_data);
                    result = Encoding.Default.GetString(bytes);
                }
            }
            catch
            {
                MessageBox.Show("Connection failure. Please try again, or contact us for help.");
                Thread.Sleep(3500);
                Environment.Exit(0);
                result = "nothing";
            }
            return result;
        }

        private void load_user_data(api.user_data_structure data)
        {
            this.user_data.username = data.username;
            this.user_data.ip = data.ip;
            this.user_data.subscriptions = data.subscriptions;
        }

        public string name;
        public string ownerid;
        public string secret;
        public string version;
        private string sessionid;
        private string enckey;
        private bool initzalized;
        public api.user_data_class user_data = new api.user_data_class();
        private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

        [DataContract]
        private class response_structure
        {
            [DataMember]
            public bool success { get; set; }

            [DataMember]
            public string sessionid { get; set; }

            [DataMember]
            public string contents { get; set; }

            [DataMember]
            public string response { get; set; }

            [DataMember]
            public string message { get; set; }

            [DataMember]
            public string download { get; set; }

            [DataMember(IsRequired = false, EmitDefaultValue = false)]
            public api.user_data_structure info { get; set; }
        }

        [DataContract]
        private class user_data_structure
        {
            [DataMember]
            public string username { get; set; }

            [DataMember]
            public List<api.Data> subscriptions { get; set; }

            [DataMember]
            public string ip { get; set; }
        }

        public class user_data_class
        {
            public string username { get; set; }
            public List<api.Data> subscriptions { get; set; }
            public string ip { get; set; }
        }

        public class Data
        {
            public string subscription { get; set; }
            public string expiry { get; set; }
        }
    }
}