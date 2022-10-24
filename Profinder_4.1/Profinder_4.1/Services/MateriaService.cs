using Profinder_Domain.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Profinder_4._1.Services
{
    public class MateriaService :Service
{
        public async Task<IEnumerable<Materia>> GetMaterias(string word, string cidade, int numerodapagina = 1)
        {
         HttpResponseMessage response = await  _client.GetAsync($"{_BaseApiUrl})/api/Materias?word={word}&numerodapagina={numerodapagina}&cidade={cidade}");

            List<Materia> list = null;
            if (response.IsSuccessStatusCode)
            {
                list = await response.Content.ReadAsAsync<List<Materia>>();
            }
            return list;
        }

        public async Task<Materia> GetMateria(int id)
        {

            HttpResponseMessage response = await _client.GetAsync($"{_BaseApiUrl})/api/Materias/{id}");

            Materia materia = null;
            if (response.IsSuccessStatusCode)
            {
                materia = await response.Content.ReadAsAsync<Materia>();
            }
            return materia;
            

        }

        public async Task<Materia> AddMateria(Materia materia)
        {

            HttpResponseMessage response = await _client.PostAsJsonAsync($"{_BaseApiUrl}/api/Materias", materia);

            if (response.IsSuccessStatusCode)
            {
                materia = await response.Content.ReadAsAsync<Materia>();
            }
            else { materia = null; }
            return materia;

        }
}
}
