using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
    public class DentistaRep
    {
        public void Cadastrar(Dentista obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Dentistas.Add(obj);
                ctx.SaveChanges();
            }
        }
        public Dentista Buscar(int id)
        {
            {
                Dentista obj = new Dentista();
                using (var ctx = new SistemaContext())
                {
                    obj = ctx.Dentistas.Find(id);
                }
                return obj;
            }
        }
        public List<Dentista> Listar()
        {
            using (var ctx = new SistemaContext())
            {
                var Dentistas = (from obj in ctx.Dentistas select obj).OrderBy(x => x.Nome).ToList();
                return Dentistas;
            }
        }

        public void Deletar(int id)
        {
            using(var ctx = new SistemaContext())
            {
                Dentista obj = ctx.Dentistas.Find(id);
                ctx.Dentistas.Remove(obj);
                ctx.SaveChanges();
            }
        }
        public void Editar(Dentista objNew)
        {
            using(var ctx = new SistemaContext())
            {
                Dentista objOld = ctx.Dentistas.Find(objNew.Id);
                objOld.Nome = objNew.Nome;
                objOld.Telefone = objNew.Telefone;
                objOld.Celular = objNew.Celular;
                objOld.Email = objNew.Email;
                objOld.CRO = objNew.CRO;
                ctx.SaveChanges();
            }
        }
    }
}
