using System.Collections;

namespace Alipay.AopSdk.Core.Util
{
	public class StringUtil
	{
		public static string ToString(object obj)
		{
			if (obj == null)
				return "null";

			var type = obj.GetType();
			if (string.Equals("System", type.Namespace))
				return "\"" + obj + "\"";

			// class
			var result = "{";

			var pis = type.GetProperties();
			for (var i = 0; i < pis.Length; i++)
			{
				var pi = pis[i];
				var pType = pi.PropertyType;

				var getMethod = pi.GetGetMethod();
				var value = getMethod.Invoke(obj, null);
				if (value == null)
					continue;

				var valueString = "";

				if (string.Equals("System", pType.Namespace))
					valueString = "\"" + value + "\"";
				else if (string.Equals("System.Collections.Generic", pType.Namespace))
					valueString = List2String(value);
				else
					valueString = ToString(value);

				if (i != 0)
					result += ",";
				result += "\"" + pi.Name + "\":" + valueString + "";
			}
			result += "}";

			return result;
		}

		public static string List2String(object listObjects)
		{
			if (listObjects == null)
				return "[]";

			var result = "[";

			var list = (IList) listObjects;
			for (var i = 0; i < list.Count; i++)
			{
				if (i != 0)
					result += ",";
				result += ToString(list[i]);
			}
			result += "]";
			return result;
		}
	}
}