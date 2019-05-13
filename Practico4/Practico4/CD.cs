using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico4
{

	class CD
	{
		//Atributos
		private string titulo;
		private string interprete;
		private int duracion;

		//Constructor
		public CD(string titulo, string interprete, int duracion)
		{
			this.titulo = titulo;
			this.interprete = interprete;
			this.duracion = duracion;
		}

		//Gets y Sets
		public string Titulo
		{
			get { return titulo; }
			set { Titulo = value; }
		}

		public string Interprete
		{
			get { return interprete; }
			set { Interprete = value; }
		}

		public int Duracion
		{
			get { return duracion; }
			set { Duracion = value; }
		}
	


        
    }
}
