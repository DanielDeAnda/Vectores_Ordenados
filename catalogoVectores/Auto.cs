using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogoVectores
{
    class Auto
    {
        /// <summary>
        /// Parametros de la clase auto, lo que recibe o lo que sabe de ella;
        /// </summary>
        private string _placa;
        private string _año;
        private string _modelo;
        private string _marca;
        private string _telefono;

        /// <summary>
        /// Retorna los parametros de la clase;
        /// </summary>
        public string placa
        {
            get { return _placa; }
        }

        public string año
        {
            get { return _año; }
        }

        public string modelo
        {
            get { return modelo; }
        }

        public string marca
        {
            get { return _marca; }
        }

        public string telefono
        {
            get { return _telefono; }
        }

        public Auto(string placa, string año, string modelo, string marca, string telefono)
        {
            _placa = placa;
            _año = año;
            _modelo = modelo;
            _marca = marca;
            _telefono = telefono;
        }

        public override string ToString()
        {
            return "Placa: " + placa + Environment.NewLine
            + "Año: " + año + Environment.NewLine
            + "Modelo: " + modelo + Environment.NewLine
            + "Marca: " + marca + Environment.NewLine
            + "Telefono: " + telefono + Environment.NewLine;
        }
    }
}
