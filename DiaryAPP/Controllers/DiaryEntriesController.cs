using DiaryAPP.Data;
using Microsoft.AspNetCore.Mvc;
using DiaryAPP.Models;

namespace DiaryAPP.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db) 
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList();
            return View(objDiaryEntryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            //List<DiaryEntry> objDiaryEntryList = _db.DiasryEntries.ToList();

            _db.DiaryEntries.Add(obj); //Add new diary entry to database
            _db.SaveChanges(); //saves change to db.
            return RedirectToAction("Index");
        }

        
    }
}
