using Entidades;
using Grpc.Core;
using GrpcService1;
using Controllers.Repositorios;

namespace GrpcService1.Services
{
    public class DentistaService : Dentista
    {
        private DentistaRep rep = new DentistaRep();

        public void Cadastrar(Dentista obj)
        {
            rep.Cadastrar(obj);
        }
        public Dentista Buscar(int id)
        {
            return rep.Buscar(id);
        }
        public List<Dentista> Listar()
        {
            return rep.Listar();
        }
        public void Deletar(int id)
        {
            rep.Deletar(id);
        }
        public void Editar(Dentista ObjNew)
        {
            rep.Editar(ObjNew);
        }

    }
}