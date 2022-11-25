using Microsoft.AspNetCore.Mvc;
using NordicDoor.DataAccess.Repository.IRepository;
using NordicDoor.Models;
using NordicDoorWeb.DataAccess;

namespace NordicDoorWeb.Areas.Admin.Controllers;
[Area("Admin")]

public class SuggestionController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public SuggestionController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        IEnumerable<Suggestion> objSuggestionList = _unitOfWork.Suggestion.GetAll();
        return View(objSuggestionList);
    }

    //GET
    public IActionResult Create()
    {
        return View();
    }

    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Suggestion obj)
    {

        if (ModelState.IsValid)
        {
            _unitOfWork.Suggestion.Add(obj);
            _unitOfWork.Save();
            TempData["success"] = "Suggestion Created Successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }
    //GET
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        //var suggestionFromDb = _db.Suggestions.Find(id);
        var suggestionFromDbFirst = _unitOfWork.Suggestion.GetFirstOrDefault(u => u.Id == id);
        //var suggestionFromDbSingle = _db.Suggestions.SingleOrDefault(u => u.Id == id);

        if (suggestionFromDbFirst == null)
        {
            return NotFound();
        }

        return View(suggestionFromDbFirst);
    }

    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Suggestion obj)
    {

        if (ModelState.IsValid)
        {
            _unitOfWork.Suggestion.Update(obj);
            _unitOfWork.Save();
            TempData["success"] = "Suggestion Updated Successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        //var suggestionFromDb = _db.Suggestions.Find(id);
        var suggestionFromDbFirst = _unitOfWork.Suggestion.GetFirstOrDefault(u => u.Id == id);
        //var suggestionFromDbSingle = _db.Suggestions.SingleOrDefault(u => u.Id == id);

        if (suggestionFromDbFirst == null)
        {
            return NotFound();
        }

        return View(suggestionFromDbFirst);
    }

    //POST
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePOST(int? id)
    {
        var obj = _unitOfWork.Suggestion.GetFirstOrDefault(u => u.Id == id);
        if (obj == null)
        {
            return NotFound();
        }
        _unitOfWork.Suggestion.Remove(obj);
        _unitOfWork.Save();
        TempData["success"] = "Suggestion Deleted Successfully";
        return RedirectToAction("Index");


    }
}

