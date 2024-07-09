using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOpp2AhmedNasr
{
    internal class Car
    {
		#region atrributes
		private int id;
		private string? model;
		private double speed;

		#endregion

		#region properties
		public double Speed
		{
			get { return speed; }
			set { speed = value; }
		}
		public string? Model
		{
			get { return model; }
			set { model = value; }
		}
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

        #endregion

        public Car()
        {
            
        }
        public Car(int _id,string _model , double _speed)
        {          
            id = _id;
			model = _model;
			speed = _speed;
            Console.WriteLine("Ctor01");
        }
        public Car(int _id, string _model):this(_id,_model, 180)
        {
            //id = _id;
            //model = _model;
            //speed = 180;
            Console.WriteLine("Ctor02");
        }
        public Car(int _id)
        {
            Console.WriteLine("Ctor03");
            id = _id;
            model = "Hyndai Elentra 2023";
            speed = 200;

        }

        public override string ToString()
        {
            return $"Car Id:{id} \nModel:{model} \nSpeed: {speed}";

		}
    }
}
