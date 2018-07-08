using Caelum.Stella.CSharp.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUERSHACK_COMMON.UTIL
{
    public class clnUtilEndereco
    {

        private static ViaCEP ViaCEP = new ViaCEP();

        public static clnEndereco obterEndereco(String cep)
        {
            clnEndereco objEndereco = new clnEndereco
            {
                CEP = clnUtilFormatar.retirarFormatacao(cep)
            }.obterPorCep();
            if (objEndereco == null)
            {
                try
                {
                    return clnEndereco.Transform(ViaCEP.GetEndereco(cep));
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return objEndereco;
        }

    }
}
