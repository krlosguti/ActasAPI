using System.Collections.Generic;
using ActasAPI.Models;
using System;

namespace ActasAPI.Data
{
    public class MockActaAPIRepository : IActaAPIRepository
    {
        public void Create(Acta item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Acta item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Acta> Get()
        {
            var items = new List<Acta>
            {
                new Acta
                {
                    ActaId=1,
                    Fecha=DateTime.Today,
                    Temas="temas de uno",
                    ResumenReunion="resumen uno",
                    estadoActa = EstadoActa.Abierta
                },
                new Acta
                {
                    ActaId=2,
                    Fecha=DateTime.Today,
                    Temas="temas de dos",
                    ResumenReunion="resumen dos",
                    estadoActa = EstadoActa.Abierta
                },
                new Acta
                {
                    ActaId=3,
                    Fecha=DateTime.Today,
                    Temas="temas de tres",
                    ResumenReunion="resumen tres",
                    estadoActa = EstadoActa.Abierta
                },
                new Acta
                {
                    ActaId=4,
                    Fecha=DateTime.Today,
                    Temas="temas de four",
                    ResumenReunion="resumen four",
                    estadoActa = EstadoActa.Abierta
                }
            };
            return items;
        }

        public Acta Get(int id)
        {
            return new Acta
                {
                    ActaId=1,
                    Fecha=DateTime.Today,
                    Temas="temas de hoy",
                    ResumenReunion="resumen hoy",
                    estadoActa = EstadoActa.Abierta
                };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Acta item)
        {
            throw new System.NotImplementedException();
        }
    }
}