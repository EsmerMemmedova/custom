using doorang.Business.Exteptions;
using doorang.Business.Services.Abstracts;
using doorang.Core.Models;
using doorang.Core.RepostoryAbstracts;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doorang.Business.Services.Concretes;

public class ExploreService : IExploreService
{
    private readonly IExploreRepostory _exploreRepostory;
    private readonly   IWebHostEnvironment _webHostEnvironment;


    public ExploreService(IExploreRepostory exploreRepostory, IWebHostEnvironment webHostEnvironment)
    {
        _exploreRepostory = exploreRepostory;
        _webHostEnvironment = webHostEnvironment;
    }

    public void AddExplore(Explore explore)
    {

        if (explore == null) throw new NullReferenceException("Explore ola bilmez");
        if (explore.ImgFile == null) throw new NullReferenceException("File ola bilmez");
        if (!explore.ImgFile.ContentType.Contains("image/")) throw new FileNotFoundException("File ola bilmez");

        string path = _webHostEnvironment.WebRootPath + @"\Upload\Explores\" + explore.ImgFile.FileName;
        using (FileStream stream = new FileStream(path, FileMode.Create))
        {
            explore.ImgFile.CopyTo(stream);
        };
        
        explore.ImgUrl = explore.ImgFile.FileName;
        _exploreRepostory.Add(explore);
        _exploreRepostory.Commit();
    }

    public List<Explore> GetAllExplore(Func<Explore, bool>? func = null)
    {
       return _exploreRepostory.GetAll(func);
    }

    public Explore GetExplore(Func<Explore, bool>? func = null)
    {
        return _exploreRepostory.Get(func);
    }

    public void RemoveExplore(int id)
    {
        var existExplore=_exploreRepostory.Get(x=> x.Id == id);
        if(existExplore==null) throw new NullReferenceException("explore tapilmadi");
        _exploreRepostory.Remove(existExplore);
        _exploreRepostory.Commit(); 
    }
   

    public void UpdateExplore(int id, Explore newexplore)
    {
        var existExplore = _exploreRepostory.Get(x => x.Id == id);
        if (existExplore == null) throw new NullReferenceException("explore tapilmadi");
        if (!_exploreRepostory.GetAll().Any(x => x.Name == newexplore.Name))
        {
            existExplore.Id= newexplore.Id;
        }
        else
        {
            throw new DublicateExploreExteptions("Explore adlari eynin ola bilmez");

        }

    }
}
