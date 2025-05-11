using Microsoft.AspNetCore.Mvc;

namespace ApiExemplosEstruturaRepeticao.Controllers
{
    public class ExemploEstruturaRepeticao1Controller : Controller
    {
        [HttpPost("ExEstruturaRepeticaoTesteInicio")]
        public string ExEstruturaRepeticaoTesteInicio(int numeroUsuario)
        {
            string resultado = "";
            int contador = 0;
            while (numeroUsuario < 100)
            {
                resultado += $"Seja bem-vindo Usuario {numeroUsuario}\n\r";
                numeroUsuario++;
            }
            return resultado;

        }

        [HttpPost("ExEstruturaRepeticaoTesteFinal")]
        public string ExEstruturaRepeticaoTesteFinal(int numeroUsuario)
        {
            string resultado = "";

            do
            {
                resultado += $"Seja bem-vindo Usuario {numeroUsuario}\n\r";


            } while (numeroUsuario < 100);

            return resultado;


        }


        [HttpPost("ExemploSomaSerie")]

        public string ExemploSomaSerie()
        {
            string resultado = "";
            double soma, numerador, denominador;
            soma = 0;
            numerador = 1;
            denominador = 1;
            do
            {
                soma = soma + (numerador / denominador);
                numerador = numerador + 2;
                denominador = denominador + 1;

            } while (numerador <= 99);
            resultado = $"A soma da série é {soma}";
            return resultado;

            
            }
        [HttpPost("ExEstruturaComVariaveisDeControle")]

        public string ExEstruturaComVariaveisDeControle()
        {
            string resultado = "";
            for (int i = 0; i <= 10; i++)
            {
                resultado += "*";
            }
            return resultado;
        }
    } 
}

