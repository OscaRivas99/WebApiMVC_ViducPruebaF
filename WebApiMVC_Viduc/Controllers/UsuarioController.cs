using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApiMVC_Viduc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private ModelContext _context;
        //Constructor para crear un contexto del controlador de usuario  
        public UsuarioController(ModelContext context)
        {
            _context = context;
        }


        //Metodo de tipo GET para listar los usuarios
        [HttpGet]
        public async Task<List<Usuario>> Listar()
        {
            return await _context.Usuarios.ToListAsync();
        }
        //Metodo de tipo GET para buscar usuarios por id_user
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> BuscarPorId(decimal id)
        {
            var retorno = await _context.Usuarios.FirstOrDefaultAsync(x => x.IdUser == id);

            if (retorno != null)
                return retorno;
            else
                return NotFound();
        }

        //Metodo de tipo POST para añadir usuarios a la base de datos
        [HttpPost]
        public async Task<ActionResult<Usuario>> Guardar(Usuario u)
        {
            try
            {
                await _context.Usuarios.AddAsync(u);
                await _context.SaveChangesAsync();


                return u;
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, "Se encontró un error");
            }
        }
        //Metodo de tipo PUT para actualizar los usuarios
        [HttpPut]
        public async Task<ActionResult<Usuario>> Actualizar(Usuario u)
        {
            if (u == null || u.IdUser == 0)
                return BadRequest("Faltan datos");

            Usuario us = await _context.Usuarios.FirstOrDefaultAsync(x => x.IdUser == u.IdUser);

            if (us == null)
                return NotFound();

            try
            {
                us.Nombre = u.Nombre;
                _context.Usuarios.Update(us);
                await _context.SaveChangesAsync();

                return us;
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, "Se encontró un error");
            }
        }
        //Metodo de tipo DELETE para eliminar el usuario por su id_user

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Eliminar(decimal id)
        {
            Usuario us = await _context.Usuarios.SingleAsync(x => x.IdUser == id);

            if (us == null)
                return NotFound();

            try
            {
                _context.Usuarios.Remove(us);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, "Se encontró un error");
            }
        }
    }
}
