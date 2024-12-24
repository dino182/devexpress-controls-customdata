using BlazorApp.Client;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    [HttpGet]
    public LoadResult GetItems(DataSourceLoadOptions loadOptions)
    {
        return DataSourceLoader.Load(
            new List<Item>
            {
                new Item{Text = "Item 1", Value = 1},
                new Item{Text = "Item 2", Value = 2},
                new Item{Text = "Item 3", Value = 3},
            }
            , loadOptions);
    }
}
