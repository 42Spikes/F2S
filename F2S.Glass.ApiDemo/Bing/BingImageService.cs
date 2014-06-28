using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using F2S.Glass.ApiDemo.Bing.Model;

namespace F2S.Glass.ApiDemo.Bing
{
    public class BingImageService
    {
        /*
        private IMvxMessenger _messenger;
        private IMvxFileStore _fileStore;
        private IDataService _dataService;
         * */

        public List<ImageModel> Images { get; private set; } 

        private readonly string _imageFeed = "http://www.bing.com/HPImageArchive.aspx?format=xml&idx={0}&n={1}&mkt=en-US";
        private readonly string _imageDownloadUrl = "http://www.bing.com{0}";

        private Dictionary<string, ImageModel> _images = new Dictionary<string, ImageModel>();
        private Dictionary<int, ImageModel> _favoritedImages = new Dictionary<int, ImageModel>();
        /*
        public BingImageService(IHttpClient httpClient, IMvxMessenger messenger, IMvxFileStore fileStore, IDataService dataService)
        {
            _httpClient = httpClient;
            _messenger = messenger;
            _fileStore = fileStore;
            _dataService = dataService;

            initialize();
        }
        */
        public BingImageService()
        {
            initialize();
            Load(0, 5);
        }

        public async void FavoriteImage(string imageURL)
        {
            /*
            ImageModel image = null;
            if (!_images.TryGetValue(imageURL, out image))
            {
                return;
            }

            var conn = new SQLiteConnection(_sqlPlatform, "bingimages.sql");
            conn.CreateTable<BingImageEntity>();
            var e = new BingImageEntity()
            {
                ImageURL = image.Image.URL,
                Description =  image.Image.Copyright
            };
            conn.Insert(e);
            conn.Close();

            if (image.Data == null)
            {
                await getImageDataAsync(image);
            }
            _fileStore.WriteFile(e.Id.ToString() + ".jpg", image.Data);

            _favoritedImages[e.Id] = image;

            _messenger.Publish(new AddedFavoriteImageMessage(this, image, _favoritedImages.Values.ToList()));
             * */
        }

        private string extractID(string filename)
        {
            var part1 = filename.Substring(0, filename.Length - 4);
            var index = part1.Length - 1;
            while (index > 0 && char.IsDigit(filename[index])) index--;
            var id = filename.Substring(index + 1, part1.Length - index - 1);
            return id;
        }

        private async void initialize()
        {
            /*
            _images.Clear();
            _favoritedImages.Clear();

            var favorited = _dataService.GetFavoritedImages();

            var deleted = new List<int>();
            var okd = new List<BingImageEntity>();

            foreach (var si in favorited)
            {
                var filename = si.Id.ToString() + ".jpg";
                if (!_fileStore.Exists(filename))
                {
                    deleted.Add(si.Id);
                    _dataService.Delete(si);
                }
                else okd.Add(si);
            }

            // any files with no database entry?  delete them
            var files = _fileStore.GetFilesIn(".");
            foreach (var file in files)
            {
                if (file.EndsWith(".jpg"))
                {
                    var id = int.Parse(extractID(file));
                    if (okd.All(si => si.Id != id) && deleted.All(di => di != id))
                    {
                        _fileStore.DeleteFile(file);
                    }
                }
                else
                {
                    _fileStore.DeleteFile(file);
                }
            }

            _favoritedImages.Clear();

            foreach (var si in okd)
            {
                byte[] imagedata = null;
                if (_fileStore.TryReadBinaryFile(si.Id.ToString() + ".jpg", out imagedata))
                {
                    var image = new ImageModel()
                    {
                        ID = si.Id,
                        URL = si.ImageURL,
                        Data = imagedata,
                        Description = si.Description
                    };
                    _favoritedImages[si.Id] = image;
                }
            }

            // let everyone know we loaded saved images
            if (_favoritedImages.Count > 0)
            {
                var lsim = new LoadedSavedImagesMessage(this, _favoritedImages.Values.ToList());
                _messenger.Publish(lsim);
            }
             * */
        }

        public bool Loading { get; private set; }
        public bool LoadingComplete { get; private set; }
        public Action OnLoadingComplete { get; set; }

        public async void Load(int start, int count)
        {
            Loading = true;
            LoadingComplete = false;

            // now load the stream xml from bing.com
            var query = string.Format(_imageFeed, start, count);
            var data = await getStringAsync(query);

            try
            {
                var xs = new XmlSerializer(typeof(ImageCollection));
                var images = xs.Deserialize(new StringReader(data)) as ImageCollection;

                var currentImages = new List<ImageModel>();

                foreach (var i in images.Images)
                {
                    var url = string.Format(_imageDownloadUrl, i.URL);
                    ImageModel image = null;
                    if (!_images.TryGetValue(url, out image))
                    {
                        image = new ImageModel()
                        {
                            Image = i,
                            URL = url,
                            Description = i.Copyright
                        };
                        _images[url] = image;

                    }
                    var saved = _favoritedImages.Values.FirstOrDefault(si => si.URL == url);
                    if (saved != null)
                    {
                        image.Data = saved.Data;
                    }
                    else getImageDataAsync(image);

                    currentImages.Add(image);
                }

                Images = currentImages;

                /*
                var msg = new AddedImageInfoMessage(this, start, count, currentImages);
                _messenger.Publish(msg);
                 * */
            }
            catch (Exception ex)
            {
            }

            Loading = false;
            LoadingComplete = true;
            if (OnLoadingComplete != null) OnLoadingComplete();
        }

        private async Task getImageDataAsync(ImageModel image)
        {
            var url = string.Format(_imageDownloadUrl, image.Image.URL);
            //var bytes = await _httpClient.GetByteArrayAsync(url);
            //image.Data = bytes;
            //var msg = new ImageDownloadCompletedMessage(this, image);
            //_messenger.Publish(msg);

            var wc = new WebClient();
            var tcs = new TaskCompletionSource<byte[]>();
            wc.DownloadDataCompleted += (sender, args) => tcs.SetResult(args.Result);
            wc.DownloadDataAsync(new Uri(url));
            var data = await tcs.Task;
            image.Data = data;
        }

        public ImageModel GetImageModel(string url)
        {
            return _images.Values.First(si => si.URL == url);
        }

        private async Task<string> getStringAsync(string url)
        {
            var wc = new WebClient();
            var tcs = new TaskCompletionSource<string>();
            wc.DownloadStringCompleted += (sender, args) => tcs.SetResult(args.Result);
            wc.DownloadStringAsync(new Uri(url));
            var data = await tcs.Task;
            return data;
        }
    }
}