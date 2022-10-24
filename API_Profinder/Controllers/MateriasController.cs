using API_Profinder.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Profinder_Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace API_Profinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        private int NumberOfRegistryByPage = 5;
        private ProfinderContext _data;
        public MateriasController(ProfinderContext data)
        {
            _data = data;
        }

        [HttpGet]
        public IEnumerable<Materia> GetMaterias(string word, string cidade, int numerodapagina = 1)
        {
            // tratar parametros de objetos NULL
            if (word == null)
                word = "";
            if (cidade == null)
                cidade = "";

            // PAGINAÇÃOOOOO( INFINITY SCROLL))))))))))))))))))))))



            return _data.Materias.Where(a =>
                a.Publicacao >= DateTime.Now.AddDays(-365) && //pesquisas limitadas a 1 ano
                a.Cidade.ToLower().Contains(cidade.ToLower()) &&
                (
                a.MateriaNome.ToLower().Contains(word) ||
                a.MateriaDescription.ToLower().Contains(word)

                )
                )
                .Skip(NumberOfRegistryByPage * (numerodapagina -1))
                .Take(NumberOfRegistryByPage)
                .ToList<Materia>();
        }

        [HttpGet("{id}")]

        public IActionResult GetMateria(int id)

        {
            Materia materiaDb = _data.Materias.Find(id);
            if (materiaDb == null)
            {
                return NotFound();
            }
            return new JsonResult(materiaDb);
        }

        public IActionResult AddMateria(Materia materia)
        {
            //VALIDACAO
            materia.Publicacao = DateTime.Now;
            _data.Materias.Add(materia);
            _data.SaveChanges();

            return CreatedAtAction("GetMateria", new {id = materia.Id}, materia);
        }

    }
}
