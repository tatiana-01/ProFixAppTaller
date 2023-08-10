using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.Repositorios;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private PersonaRepository _personas;
    private readonly ProFixContext context;

    public UnitOfWork(ProFixContext _context)
    {
        context = _context;
    }

    public IPersona Personas
    {
        get
        {
            if (_personas == null)
            {
                _personas = new PersonaRepository(context);
            }
            return _personas;
        }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
