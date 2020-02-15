using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicXamarin.DependencyServices;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly:Dependency(typeof(BasicXamarin.iOS.PhotoPickerService))]
namespace BasicXamarin.iOS
{
    public class PhotoPickerService : IPhotoPickerServices
    {
        TaskCompletionSource<Stream> taskCompletionSource;
        UIImagePickerController imagePickerController;
        public Task<Stream> GetImageStreamAsync()
        {
            imagePickerController = new UIImagePickerController
            {
                SourceType = UIImagePickerControllerSourceType.PhotoLibrary,
                MediaTypes = UIImagePickerController.AvailableMediaTypes(UIImagePickerControllerSourceType.PhotoLibrary)
            };

            imagePickerController.FinishedPickingMedia += ImagePickerController_FinishedPickingMedia;
            imagePickerController.Canceled += ImagePickerController_Canceled;

            UIWindow window = UIApplication.SharedApplication.KeyWindow;
            var viewController = window.RootViewController;
            viewController.PresentModalViewController(imagePickerController, true);

            taskCompletionSource = new TaskCompletionSource<Stream>();
            return taskCompletionSource.Task;
        }

        private void ImagePickerController_FinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs e)
        {
            UIImage image = e.EditedImage ?? e.OriginalImage;
            if (image != null)
            {
                NSData data;
                if(e.ReferenceUrl.PathExtension.Equals("PNG") || e.ReferenceUrl.PathExtension.Equals("PNG"))
                {
                    data = image.AsPNG();
                }
                else
                {
                    data = image.AsJPEG(1);
                }
                Stream stream = data.AsStream();

                UnregisterEventHandlers();
                taskCompletionSource.SetResult(stream);
            }
            else
            {
                UnregisterEventHandlers();
                taskCompletionSource.SetResult(null);
            }
            imagePickerController.DismissModalViewController(true);
        }

        private void ImagePickerController_Canceled(object sender, EventArgs e)
        {
            UnregisterEventHandlers();
            taskCompletionSource.SetResult(null);
            imagePickerController.DismissModalViewController(true);
        }
        private void UnregisterEventHandlers()
        {
            imagePickerController.FinishedPickingMedia -= ImagePickerController_FinishedPickingMedia;
            imagePickerController.Canceled -= ImagePickerController_Canceled;
        }
    }
}