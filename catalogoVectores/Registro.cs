using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catalogoVectores
{
    class Registro
    {
        private Auto[] _vecR;
        private short _autos = 0;
        //private string[] _auto;
        //private string _datos;
        //private int _contador;

        public Registro()
        {
            _vecR = new Auto[15];

        }

        public void Agregar(Auto carro)
        {
            bool rep = false;
            if (_autos > 0)
            {
                for (short i = 0; i < _autos; i++)
                {
                    if (carro.placa == _vecR[i].placa)
                    {
                        rep = true;
                    }
                }
            }
            if (rep == false)
            {
                Ordenado(carro);
                _autos++;
            }
            else
            {
                MessageBox.Show("Placa Existente");
            }
        }

        public void Ordenado(Auto carro)
        {
            short contador = 0;
            while (contador <= _autos)
            {
                if (_vecR[contador] != null)
                {
                    if (carro.placa.CompareTo(_vecR[contador].placa) < 0)
                    {
                        for (int s = _autos; s > contador; s--)
                        {
                            _vecR[s] = _vecR[s - 1];
                        }
                        _vecR[contador] = carro;
                        contador = _autos;
                    }
                }
                else
                {
                    _vecR[contador] = carro;
                }
                contador++;
            }
        }

        public void Buscar(string placa)
        {
            string Encontrado = "";
            for (int x = 0; x < _autos; x++)
            {
                if (_vecR[x].placa.ToString() == placa)
                {
                    Encontrado = _vecR[x].ToString();
                    MessageBox.Show("Encontrado: " + Encontrado);
                }
                else
                {
                    Encontrado = "No encontrado";
                    MessageBox.Show(Encontrado);
                }
            }
        }

        public void eliminar(int posicion)
        {
            if (_vecR[posicion - 1] != null)
            {
                for (int i = posicion - 1; i < posicion; i++)
                {
                    MessageBox.Show("Registro eliminado");
                }
                _autos--;
            }
        }

        public void insertar(int posicion, Auto objeto)
        {
            Auto temp;
            for (int i = posicion; i <= _vecR.Length; i++)
            {
                temp = _vecR[i];
                _vecR[i] = objeto;
                _vecR[i + 1] = temp;
            }
        }

        public string listar()
        {
                string lista = "";
                for (int x = 0; x < _autos; x++)
                {
                    lista += "Auto: " + x
                          + Environment.NewLine + _vecR[x]
                          + Environment.NewLine;
                }
                return lista;
        }
    }
}

