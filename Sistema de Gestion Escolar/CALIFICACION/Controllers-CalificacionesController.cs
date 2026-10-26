
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SGE.Models;

public class CalificacionesController : Controller
{
    private readonly SGEContext _context;

    public CalificacionesController(SGEContext context)
    {
        _context = context;
    }

    // GET: CALIFICACIONS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Calificacion.ToListAsync());
    }

    // GET: CALIFICACIONS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var calificacion = await _context.Calificacion
            .FirstOrDefaultAsync(m => m.Id == id);
        if (calificacion == null)
        {
            return NotFound();
        }

        return View(calificacion);
    }

    // GET: CALIFICACIONS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: CALIFICACIONS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Numero,Nota,Comentario")] Calificacion calificacion)
    {
        if (ModelState.IsValid)
        {
            _context.Add(calificacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(calificacion);
    }

    // GET: CALIFICACIONS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var calificacion = await _context.Calificacion.FindAsync(id);
        if (calificacion == null)
        {
            return NotFound();
        }
        return View(calificacion);
    }

    // POST: CALIFICACIONS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Numero,Nota,Comentario")] Calificacion calificacion)
    {
        if (id != calificacion.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(calificacion);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalificacionExists(calificacion.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(calificacion);
    }

    // GET: CALIFICACIONS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var calificacion = await _context.Calificacion
            .FirstOrDefaultAsync(m => m.Id == id);
        if (calificacion == null)
        {
            return NotFound();
        }

        return View(calificacion);
    }

    // POST: CALIFICACIONS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var calificacion = await _context.Calificacion.FindAsync(id);
        if (calificacion != null)
        {
            _context.Calificacion.Remove(calificacion);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool CalificacionExists(int? id)
    {
        return _context.Calificacion.Any(e => e.Id == id);
    }
}

