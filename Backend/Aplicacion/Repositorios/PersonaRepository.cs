using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dominio;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repositorios;
    public class PersonaRepository : IPersona
    {
    
    private readonly ProFixContext _context;
    
    public PersonaRepository(ProFixContext context)
    {
        _context = context;
    }

    public virtual void Add(Persona entity)
    {
        _context.Set<Persona>().Add(entity);
    }

    public virtual void AddRange(IEnumerable<Persona> entities)
    {
        _context.Set<Persona>().AddRange(entities);
    }

    public virtual IEnumerable<Persona> Find(Expression<Func<Persona, bool>> expression)
    {
        return _context.Set<Persona>().Where(expression);
    }

    public virtual async Task<IEnumerable<Persona>> GetAllAsync()
    {
        return await _context.Set<Persona>().ToListAsync();
    }

    public virtual async Task<(int totalRegistros, IEnumerable<Persona> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var totalRegistros = await _context.Set<Persona>().CountAsync();
        var registros = await _context.Set<Persona>()
        .Skip((pageIndex - 1) * pageSize)
        .Take(pageSize)
        .ToListAsync();

        return (totalRegistros, registros);

    }

    public virtual async Task<Persona> GetByIdAsync(string id)
    {
        return await _context.Set<Persona>().FindAsync(id);
    }

    public virtual void Remove(Persona entity)
    {
        _context.Set<Persona>().Remove(entity);
    }

    public virtual void RemoveRange(IEnumerable<Persona> entities)
    {
        _context.Set<Persona>().RemoveRange(entities);
    }

    public virtual void Update(Persona entity)
    {
        _context.Set<Persona>().Update(entity);
    }
    }
