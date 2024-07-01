using Microsoft.AspNetCore.Mvc;
using webapi.models;
using webapi.datacontext;
using webapi.models.kitchen;
using webapi.models.form;
using webapi.models.files;

namespace webap.controllers
{


    public class FileController : MainController
    {

        private readonly DataContext _context;
        public FileController(DataContext context) {
            _context = context;
        }

         [HttpPost]
        [Route(nameof(UploadFile))]
        public async Task<IActionResult> UploadFile([FromForm] IFormFile[] files, [FromForm] string listId) {
            foreach (IFormFile file in files)
            {
                FileType fileType = new FileType();


                                
                var folderName = Path.Combine("Resources", new DateOnly().ToString().Replace("/", "-"));
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                var uniqueFileName = file.FileName;
                var dbPath = Path.Combine(folderName, uniqueFileName);

                using (var fileStream = new FileStream(Path.Combine(filePath, uniqueFileName), FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                fileType.name = file.Name;
                fileType.path = dbPath;
                fileType.listId = new Guid(listId);   
                
                _context.fileType.Add(fileType);
                await _context.SaveChangesAsync();
            }

            return Ok(files);
        }

    }
}
