using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public string PrimeNumber(int value) {
		if (value <= 3 && value > 0) {
			return string.Format("{0} is a prime number", value);
		}
		if (value <= 0) {
			return "Has to be greater than 0";
		}
		for (int i = 2; i < value; i++) {
			if (value % i == 0 ) {
				return string.Format("{0} is not a prime number", value);
            }
		}
		return string.Format("{0} is a prime number", value);
    }
    public int SumOfDigits(int value) {
		int sum = 0;
		foreach (char i in value.ToString().ToArray<char>()) {
			sum += int.Parse(i.ToString());
		}
		return sum;
	}
	public string ReverseString(string value) {
		char[] valueArray = value.ToArray<char>();
		Array.Reverse(valueArray);
		string ret = "";
		for(int i = 0; i < valueArray.Length; i++) {
			ret += valueArray[i].ToString();
		}
		return ret;
	}
	public string PrintTags(string value, string tags) {
		return "<" + tags + ">" + value + "<" + "/" + tags + ">";
	}
	public string SortArray(int[] value, bool by) {
		Array.Sort(value);
		if (by) Array.Reverse(value);
		string ret = "";
		foreach(int i in value) {
			ret += i.ToString() + " ";
		}
		return ret;
	}
    public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
