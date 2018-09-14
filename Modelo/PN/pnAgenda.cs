using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public static class pnAgenda
    {
        public static bool Inserir(Pessoa p)
        {
            try
            {
                AgendaEntities db = new AgendaEntities();

                db.Pessoas.Add(p);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Alterar(Pessoa p)
        {
            try
            {
                AgendaEntities db = new AgendaEntities();
                Pessoa pa = new Pessoa();

                // Para alterar o registro é necessário ler primeiro e depois fazer modificações
                pa = db.Pessoas.Find(p.Email);

                pa.Idade = p.Idade;
                pa.Nome = p.Nome;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Excluir(Pessoa p)
        {
            try
            {
                AgendaEntities db = new AgendaEntities();
                Pessoa pa = new Pessoa();

                // Para excluir o registro é necessário ler primeiro e depois fazer modificações
                pa = db.Pessoas.Find(p.Email);

                db.Pessoas.Remove(pa);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Pessoa Pesquisar(String email)
        {
            try
            {
                AgendaEntities db = new AgendaEntities();
                Pessoa pa = new Pessoa();

                // Para alterar o registro é necessário ler primeiro e depois fazer modificações
                pa = db.Pessoas.Find(email);              

                return pa;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Pessoa> Listar()
        {
            try
            {
                AgendaEntities db = new AgendaEntities();
                return (db.Pessoas.ToList());
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
