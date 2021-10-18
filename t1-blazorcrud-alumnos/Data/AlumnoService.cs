using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace t1_blazorcrud_alumnos.Data
{
    public class AlumnoService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public AlumnoService(AppDBContext appDBContext) => _appDBContext = appDBContext;
        #endregion

        #region Obtener todos los alumnos
        public List<Alumno> GetAllAlumnos() => _appDBContext.Alumnos.ToList();
        #endregion

        #region Obtener un solo alumno
        public Alumno GetAlumno(int Id)
        {
            Alumno alumno = _appDBContext.Alumnos.FirstOrDefault(c => c.Id.Equals(Id));
            return alumno;
        }
        #endregion

        #region Insertar alumno
        public bool InsertAlumno(Alumno alumno)
        {
            _appDBContext.Alumnos.Add(alumno);
            _appDBContext.SaveChanges();
            return true;
        }
        #endregion

        #region Actualizar un alumno
        public bool UpdateAlumno(Alumno alumno)
        {
            _appDBContext.Alumnos.Update(alumno);
            _appDBContext.SaveChanges();
            return true;
        }
        #endregion

        #region Borrar un alumno
        public bool DeleteAlumno(Alumno alumno)
        {
            _appDBContext.Remove(alumno);
            _appDBContext.SaveChanges();
            return true;
        }
        #endregion
    }
}