
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SGE.Models;

public class AlumnosController : Controller
{
    private readonly SGEContext _context;

    public AlumnosController(SGEContext context)
    {
        _context = context;
    }

    // GET: ALUMNOS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Alumno.ToListAsync());
    }

    // GET: ALUMNOS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var alumno = await _context.Alumno
            .FirstOrDefaultAsync(m => m.Id == id);
        if (alumno == null)
        {
            return NotFound();
        }

        return View(alumno);
    }

    // GET: ALUMNOS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: ALUMNOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Codigo,Nombre,Apellido")] Alumno alumno)
    {
        if (ModelState.IsValid)
        {
            _context.Add(alumno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(alumno);
    }

    // GET: ALUMNOS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var alumno = await _context.Alumno.FindAsync(id);
        if (alumno == null)
        {
            return NotFound();
        }
        return View(alumno);
    }

    // POST: ALUMNOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Codigo,Nombre,Apellido")] Alumno alumno)
    {
        if (id != alumno.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(alumno);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlumnoExists(alumno.Id))
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
        return View(alumno);
    }

    // GET: ALUMNOS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var alumno = await _context.Alumno
            .FirstOrDefaultAsync(m => m.Id == id);
        if (alumno == null)
        {
            return NotFound();
        }

        return View(alumno);
    }

    // POST: ALUMNOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var alumno = await _context.Alumno.FindAsync(id);
        if (alumno != null)
        {
            _context.Alumno.Remove(alumno);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool AlumnoExists(int? id)
    {
        return _context.Alumno.Any(e => e.Id == id);
    }
}

