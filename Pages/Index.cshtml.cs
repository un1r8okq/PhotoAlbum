using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PhotoAlbum.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<string> ImgUrls;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            ImgUrls = new List<string>();
        }

        public void OnGet()
        {
            var imgPaths = Directory.GetFiles(Path.Combine("wwwroot", "img"));
            var imgNames = imgPaths.Select(path => Path.GetFileName(path));
            ImgUrls = imgNames.Select(imgName => "/img/" + imgName);
        }
    }
}