using Microsoft.AspNetCore.Mvc;
using webapi.models;
using webapi.datacontext;
using webapi.models.kitchen;
using webapi.models.form;
using webapi.models.types;

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
        public async Task<IActionResult> UploadFile(
            [FromForm] IFormFile file, 
            [FromForm] string listReferenceId, 
            [FromForm] string fileContainerTypeId,
            [FromForm] string label
        ) {
           
         
                
            var folderName = Path.Combine("Resources", new DateTime().ToString().Replace("/", "-"));
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

            List<FileType> fileTypes = _context.fileType.Where(file => file.filesContainerTypeId == new Guid(fileContainerTypeId)).ToList();
            FileType fileType;
            if (fileTypes.Any(file => file.label == label)) {
                fileType = fileTypes.Where(file => file.label == label).FirstOrDefault()!;
                fileType.name = file.Name;
                fileType.path = dbPath;
                fileType.listReferenceId = new Guid(listReferenceId);
                fileType.filesContainerTypeId = new Guid(fileContainerTypeId);
                fileType.label = label;
                
                _context.fileType.Update(fileType);
            } else {
                fileType = new FileType();
                fileType.name = file.Name;
                fileType.path = dbPath;
                fileType.listReferenceId = new Guid(listReferenceId);
                fileType.filesContainerTypeId = new Guid(fileContainerTypeId);
                fileType.label = label;
                
                _context.fileType.Add(fileType);
            }

            await _context.SaveChangesAsync();
            return Ok(fileType);

        }

 
        [HttpGet]
        [Route(nameof(GetFile))]
        public async Task<IActionResult> GetFile(string filePath) {
            // var filePath = _context.fileType.Where(list => list.listId == new Guid(listId)).First().path;
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), filePath);

            if (!System.IO.File.Exists(fullPath)) {
                return NotFound();
            }

            var fileBytes = System.IO.File.ReadAllBytes(fullPath);
            var contentType = "image/jpeg"; // Adjust this based on your file type

            return File(fileBytes, contentType);
            // return Ok(_context.fileType);
        }

        [HttpGet]
        [Route(nameof(GetAllFileTypeForList))]
        public async Task<IActionResult> GetAllFileTypeForList([FromQuery] string listReferenceTypeId) {
            return Ok(_context.fileType.Where(file => file.listReferenceId == new Guid(listReferenceTypeId)));
        }

        [HttpGet]
        [Route(nameof(GetAllFileTypeForAttribute))]
        public async Task<IActionResult> GetAllFileTypeForAttribute([FromQuery] string fileContainerTypeId) {
            return Ok(_context.fileType.Where(file => file.filesContainerTypeId == new Guid(fileContainerTypeId)));
        }

        

    }
}
