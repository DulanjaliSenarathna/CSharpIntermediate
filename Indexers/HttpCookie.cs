using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers
{
    class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        //without indexer
        public void SetCookie(string key, string value)
        {

        }

        public string GetCookie(string key)
        {
            return key;
        }

        //with indexer
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value }
        }
    }
}
