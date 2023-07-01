using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
	public static  class SimpleInterest
	{
		public static  float CalculateSimpleInterest(float rate, int principal, int time)
		{
			float SI;
			SI = principal * rate * time / 100;
			Console.WriteLine("Interest is : {0}", SI);
			return SI;
		}
	}
}
