﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{

    public abstract class clnUtilSelecionar
    {

        private clnUtilListar objListar;

        private int _quantidade = 1;

        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public clnUtilListar ObjListar { get => objListar; set => objListar = value; }

        public abstract object getSelecionado();

        public abstract bool setSelecionado(object obj);


    }

    public class clnUtilSelecionar<T> : clnUtilSelecionar
    {

        private T _selecionado;
        
        public T Selecionado { get => _selecionado; set => _selecionado = value; }

        public override object getSelecionado() => Selecionado;

        public override bool setSelecionado(object obj)
        {
            if (obj != null && obj is T val && !val.Equals(Selecionado))
            {
                Selecionado = val;
                return true;
            }
            return false;
        }

    }
}
