using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BasicXamarin.DependencyServices
{
    public interface IPhotoPickerServices
    {
        Task<Stream> GetImageStreamAsync();
    }
}
