﻿using System.Collections.Generic;
using LibraryManagerApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LibraryManagerApi.Controllers
{
    [Route("api/books")]
    public class BooksController : Controller
    {
        private LibraryRepository _libraryRepository;

        public BooksController(IConfiguration configuration)
        {
            _libraryRepository = new LibraryRepository(configuration);
        }

        [HttpGet]
        public IEnumerable<string> GetBooks()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
