using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUSABgui
{
    public class ImageListData
    {
        public Dictionary<string, ImageData> groups { get; set; }
    }

    public class ImageData
    {
        public IList<ImageData> images { get; set; }
        public Structure structure { get; set; }
        public ImageSize size { get; set; }
        public ImageEncryption encryption { get; set; }
    }

    public class ImageLabel
    {
        public string name { get; set; }
        public string id { get; set; }
    }

    public class ImageSize
    {
        public Nullable<int> pixmap { get; set; }
        public int data { get; set; }
    }

    public class ImageEncryption
    {
        public string salt { get; set; }
        public string hash { get; set; }
    }

    public class Structure
    {
        public IList<string> files { get; set; }
        public Dictionary<string, Structure> folders { get; set; }
    }
}
