using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PhotoOrg.Models;

namespace PhotoOrg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController
    {
        private readonly Context _context;

        public PhotosController(Context context)
        {
            _context = context;

            if (_context.PhotoFiles.Count() == 0)
            {
                _context.PhotoFiles.Add(new PhotoFile { Name = "Img001", FileExtension = "jpg" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<PhotoFile>> GetAll()
        {
            return _context.PhotoFiles.ToList();
        }
    }
}