using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace vrgoserver.Models 
{
    [Route("vrgoserver/exercise")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public ExerciseController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetExercise() 
        {
            Exercise exercise = new Exercise();
            return Ok(exercise);
        }
    }
}