using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace JsonViewer
{
    public partial class JsonView : Form
    {
        public Exception exception = null;
        public string filePath = "C:\\Users\\IDO\\Documents\\GitHub\\JsonViewer\\example2.json";
        public bool loadedSuccessfully = false;

        public JsonView(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;

            try
            {
                StreamReader stream = new StreamReader(filePath);
                string fileText = stream.ReadToEnd();

                object obj = JsonConvert.DeserializeObject(fileText);
                foreach(TreeNode redNode in JsonRedirect(obj))
                {
                    TreeView.Nodes.Add(redNode);
                }
                this.loadedSuccessfully = true;
                stream.Close();
            }
            catch(Exception e)
            {
                this.Close();
                this.exception = e;
            }
        }

        public static TreeNodeCollection JsonRedirect(object obj)
        {
            if (obj is string || obj is Int64 || obj is bool || obj is Double)
            {
                return TreeNodeString(obj.ToString());
            }
            else if(obj is null)
            {
                return TreeNodeString("");
            }
            else if(obj is JValue)
            {
                return JsonRedirect(((JValue)obj).Value);
            }
            else if(obj is JArray)
            {
                return TreeNodeJArray((JArray)obj);
            }
            else if(obj is JObject)
            {
                return TreeNodeJObject((JObject)obj, "").Nodes;
            }

            throw new NotImplementedException(obj.GetType().ToString());
        }

        public static TreeNodeCollection TreeNodeJArray(JArray arr)
        {
            TreeNode tree = new TreeNode();
            int count = 0;
            foreach(JToken jtoken in arr)
            {
                TreeNode arrNode = new TreeNode(string.Format("[{0}]", count++));
                foreach(TreeNode node in JsonRedirect(jtoken))
                {
                    arrNode.Nodes.Add(node);
                }
                tree.Nodes.Add(arrNode);
            }
            return tree.Nodes;
        }

        public static TreeNode TreeNodeJObject(JObject json, string name)
        {
            TreeNode tree = new TreeNode(name);

            foreach(JProperty prop in json.Properties())
            {
                object propValue = prop.Value;
                TreeNode node = new TreeNode(prop.Name);
                foreach(TreeNode redNode in JsonRedirect(propValue))
                {
                    node.Nodes.Add(redNode);
                }
                tree.Nodes.Add(node);
            }
            return tree;
        }

        public static TreeNodeCollection TreeNodeString(string value)
        {
            TreeNode node = new TreeNode();
            node.Nodes.Add(value);
            return node.Nodes;
        }
    }
}