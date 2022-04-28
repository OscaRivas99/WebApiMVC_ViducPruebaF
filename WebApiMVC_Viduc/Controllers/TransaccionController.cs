using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApiMVC_Viduc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransaccionController : ControllerBase
    {
        private ModelContext _context;
        //Constructor para crear un contexto del controlador de usuario  
        public TransaccionController(ModelContext context)
        {
            _context = context;
        }


        //Metodo de tipo GET para listar los usuarios
        [HttpGet]
        public async Task<List<Transaccion>> Listar()
        {
            return await _context.Transaccions.ToListAsync();
        }
        //Metodo de tipo GET para buscar usuarios por id_user
        [HttpGet("{id}")]
        public async Task<ActionResult<Transaccion>> BuscarPorId(decimal id)
        {
            var retorno = await _context.Transaccions.FirstOrDefaultAsync(x => x.IdTrans == id);

            if (retorno != null)
                return retorno;
            else
                return NotFound();
        }

        //Metodo de tipo POST para añadir usuarios a la base de datos
        [HttpPost]
        public async Task<ActionResult<Transaccion>> Guardar(Transaccion t)
        {
            try
            {
                await _context.Transaccions.AddAsync(t);
                await _context.SaveChangesAsync();


                return t;
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, "Se encontró un error");
            }
        }
        //Metodo de tipo PUT para actualizar los usuarios
        [HttpPut]
        public async Task<ActionResult<Transaccion>> Actualizar(Transaccion t)
        {
            if (t == null || t.IdTrans == 0)
                return BadRequest("Faltan datos");

            Transaccion tr = await _context.Transaccions.FirstOrDefaultAsync(x => x.IdTrans == t.IdTrans);

            if (tr == null)
                return NotFound();

            try
            {
                tr.IdCuenta = t.IdCuenta;
                _context.Transaccions.Update(tr);
                await _context.SaveChangesAsync();

                return tr;
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
            Transaccion ts = await _context.Transaccions.SingleAsync(x => x.IdTrans == id);

            if (ts == null)
                return NotFound();

            try
            {
                _context.Transaccions.Remove(ts);
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
