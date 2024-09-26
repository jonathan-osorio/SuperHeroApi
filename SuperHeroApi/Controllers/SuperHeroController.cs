using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroApi.Data;
using SuperHeroApi.Dto;
using SuperHeroApi.Entities;

namespace SuperHeroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;
        public SuperHeroController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            var heroes = await _context.SuperHeroes.ToListAsync();

            return Ok(heroes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<SuperHero>>> GetHeroesById(int id)
        {
            var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero is null)
            {
                return NotFound("Hero Not Found");
            }

            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero([FromBody] SuperHeroDto hero) {


            var newHero = new SuperHero()
            {
                Name = hero.Name,
                Alias = hero.Alias,
                Birthday = hero.Birthday,
                Category = hero.Category,
                Faction = hero.Faction,
                Height = hero.Height,
                Individuality = hero.Individuality,
                IndividualityDescription = hero.IndividualityDescription,
                Likes = hero.Likes,
                ProfilePictureURL = hero.ProfilePictureURL
            };

            _context.Add(newHero);
            await _context.SaveChangesAsync();

            return Ok(newHero);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, [FromBody]SuperHeroDto hero)
        {
            var existingHero = await _context.SuperHeroes.FindAsync(id);

            if (existingHero is null) 
            {
                return NotFound($"Hero with id {id} not found");
            }

            existingHero.Name = hero.Name;
            existingHero.Alias = hero.Alias;
            existingHero.Birthday = hero.Birthday;
            existingHero.Category = hero.Category;
            existingHero.Faction = hero.Faction;
            existingHero.Height = hero.Height;
            existingHero.Individuality = hero.Individuality;
            existingHero.IndividualityDescription = hero.IndividualityDescription;
            existingHero.Likes = hero.Likes;
            existingHero.ProfilePictureURL = hero.ProfilePictureURL;

            await _context.SaveChangesAsync();

            return Ok(hero + "Data Updated");
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var existingHero = await _context.SuperHeroes.FindAsync(id);

            if (existingHero is null)
            {
                return NotFound($"Hero with id {id} not found");
            }

            _context.SuperHeroes.Remove(existingHero);
            await _context.SaveChangesAsync();

            return Ok("Hero Deleted: " + existingHero.Name);
        }

    }
 }

