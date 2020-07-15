using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste_webmotors.DbContex;
using teste_webmotors.Models;

namespace teste_webmotors.Services
{
    public class WebMotorService
    {

        private readonly WebMotorContext _dbWebMotorContext;
        public WebMotorService(WebMotorContext dbWebMotor)
        {
            _dbWebMotorContext = dbWebMotor;
        }

        public void InsertAnuncio(WebMotorsModel webMotors)
        {                          
           _dbWebMotorContext.tb_AnuncioWebmotors.Add(webMotors);             
           _dbWebMotorContext.SaveChanges();
        }

        public void updateAnuncio(WebMotorsModel webMotors)
        {
            var anuncio = _dbWebMotorContext.tb_AnuncioWebmotors.Find(webMotors.ID);
            if (anuncio.ID != 0)
            {
                anuncio.marca = webMotors.marca;
                anuncio.modelo = webMotors.modelo;
                anuncio.quilometragem = webMotors.quilometragem;
                anuncio.ano = webMotors.ano;
                anuncio.observacao = webMotors.observacao;
               _dbWebMotorContext.SaveChanges();
            }
        }

        public void deleteAnuncio(int id)
        {
            var anuncio = _dbWebMotorContext.tb_AnuncioWebmotors.FirstOrDefault(x => x.ID == id);
            if (anuncio.ID != 0)
            {
                _dbWebMotorContext.tb_AnuncioWebmotors.Remove(anuncio);
                _dbWebMotorContext.SaveChanges();
            }

        }

        public IEnumerable<WebMotorsModel> getAnunciosAll()
        {
            return _dbWebMotorContext.tb_AnuncioWebmotors.OrderBy(x => x.ID).ToList();
        }

        public WebMotorsModel getAnuncioId(int id)
        {
            return _dbWebMotorContext.tb_AnuncioWebmotors.Where(x => x.ID == id).FirstOrDefault();
        }
    }
}
