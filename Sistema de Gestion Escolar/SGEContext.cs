using Microsoft.EntityFrameworkCore;

public class SGEContext(DbContextOptions<SGEContext> options) : DbContext(options)
{
    public DbSet<SGE.Models.Aula> Aula { get; set; } = default!;
    public DbSet<SGE.Models.Maestro> Maestro { get; set; } = default!;
    public DbSet<SGE.Models.Alumno> Alumno { get; set; } = default!;
    public DbSet<SGE.Models.Calificacion> Calificacion { get; set; } = default!;
}
