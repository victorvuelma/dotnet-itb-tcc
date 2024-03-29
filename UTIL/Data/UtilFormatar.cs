﻿using Caelum.Stella.CSharp.Format;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitorrdgs.Util.Data
{
    public class UtilFormatar
    {
        private static String FORMAT_CEL = @"(00) 00000-0000";
        private static String FORMAT_TEL = @"(00) 0000-0000";

        private static CPFFormatter _cpfFormatter = new CPFFormatter();
        private static CNPJFormatter _cnpjFormatter = new CNPJFormatter();

        public static string retirarFormatacao(string texto)
        {
            if (UtilValidar.vazio(texto))
                return "";
            return new String(texto.Trim().Where(Char.IsNumber).ToArray());
        }

        public static String formatarValor(decimal valor)
        {
            return string.Format("{0:C}", valor);
        }

        public static String formatarCelular(String celular)
        {
            if (UtilValidar.vazio(celular))
                return null;
            return long.Parse(celular).ToString(FORMAT_CEL);
        }

        public static String formatarTelefone(String telefone)
        {
            if (UtilValidar.vazio(telefone))
                return "";
            return long.Parse(telefone).ToString(FORMAT_TEL);
        }

        public static String formatarCPF(String cpf)
        {
            return _cpfFormatter.Format(cpf);
        }

        public static String formatarCNPJ(String cnpj)
        {
            return _cnpjFormatter.Format(cnpj);
        }

        public static String formatarData(DateTime? data)
        {
            return ((data != null) ? formatarData((DateTime)data) : "");
        }

        public static String formatarData(DateTime data)
        {
            return data.ToString("dd/MM/yyyy");
        }

        public static String formatarHora(DateTime hora)
        {
            return hora.ToString("HH:mm");
        }

        public static String formatarDataHora(DateTime dataHora)
        {
            return dataHora.ToString("dd/MM/yyyy HH:mm");
        }

        public static String formatarDataHora(DateTime? dataHora)
        {
            if (dataHora != null)
            {
                return formatarDataHora((DateTime)dataHora);
            }
            return "";
        }

    }
}
