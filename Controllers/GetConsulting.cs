using Base_Backend.Model;
using Microsoft.AspNetCore.Mvc;

namespace Base_Backend.Controllers;

public abstract class GetConsulting
{
    [AcceptVerbs("GET")]
    [Route("Consulting")]
    public abstract ActionResult<ProductEntity> GetConsulting();
}